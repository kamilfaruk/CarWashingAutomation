/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Models;
using CarWashingAutomation.Components;
using CarWashingAutomation.Connections;
using CarWashingAutomation.Forms;

namespace CarWashingAutomation.Controls
{
    public partial class MachineTracking : UserControl
    {
        Machine Main_Machine;
        Timer Refresh_Timer;
        int RefreshPeriodMs = 1000;
        public MachineTracking(int _machineId)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    Main_Machine = _dbManager.GetMachine(_machineId);
                    if (Main_Machine != null)
                    {
                        InitializeComponent();
                        if (Refresh_Timer == null)
                        {
                            Refresh_Timer = new Timer();
                            Refresh_Timer.Interval = RefreshPeriodMs;
                            Refresh_Timer.Enabled = true;
                            Refresh_Timer.Tick += Refresh_Timer_Tick;
                            Refresh_Timer.Start();
                        }
                        else
                        {
                            Refresh_Timer.Enabled = true;
                            Refresh_Timer.Start();
                        }
                    }
                    else
                    {
                        this.BackColor = Color.FromArgb(147, 80, 83);
                        Label _infoLbl = new Label();
                        _infoLbl.Dock = DockStyle.Fill;
                        _infoLbl.BackColor = Color.Transparent;
                        _infoLbl.Name = "_infoLbl";
                        _infoLbl.Text = "CİHAZ BULUNAMADI";
                        _infoLbl.TextAlign = ContentAlignment.MiddleCenter;
                        _infoLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                        _infoLbl.ForeColor = Color.FromArgb(192, 192, 192);
                        this.Controls.Add(_infoLbl);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineDetails.MachineDetails -> ", _ex);
            }
        }
        private void MachineDetails_Disposed(object sender, EventArgs e)
        {
            Refresh_Timer.Enabled = false;
            Refresh_Timer.Stop();
        }
        private void Refresh_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Main_Machine != null)
                {
                    Alias_Lbl.Text = Main_Machine.Alias;
                    Version_Lbl.Text = "V." + Main_Machine.Version.ToString();
                    if (Main_Machine.DeviceStatus == 1)
                    {
                        //DeviceStatus_TglBtn.Checked = true;
                    }
                    if (Main_Machine.MoneyHopperState == 1)
                    {
                        //MoneyHopperState_TglBtn.Checked = true;
                    }
                    if (Main_Machine.P10Usage == 1)
                    {
                        //P10Usage_TglBtn.Checked = true;
                    }
                    if (Main_Machine.FlowAlarmIsActive == 1)
                    {
                        //FlowAlarmIsActive_TglBtn.Checked = true;
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineDetails.Refresh_Timer_Tick -> ", _ex);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                //TODO: Burayada makine durumuna göre renklendirme ekle
                base.OnPaint(e);
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
                Pen pen = new Pen(Color.FromArgb(16, 154, 208), 1);
                g.DrawRectangle(pen, rect);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineDetails.OnPaint -> ", _ex);
            }
        }
        private void MachineDetails_Load(object sender, EventArgs e)
        {
            try
            {
                Alias_Lbl.Text = Main_Machine.Alias;
                Version_Lbl.Text = "V." + Main_Machine.Version.ToString();
                if (Main_Machine.DeviceStatus == 1)
                {
                    DeviceStatus_TglBtn.Checked = true;
                }
                if (Main_Machine.MoneyHopperState == 1)
                {
                    MoneyHopperState_TglBtn.Checked = true;
                }
                if (Main_Machine.P10Usage == 1)
                {
                    P10Usage_TglBtn.Checked = true;
                }
                if (Main_Machine.FlowAlarmIsActive == 1)
                {
                    FlowAlarmIsActive_TglBtn.Checked = true;
                }
                this.DeviceStatus_TglBtn.CheckedChanged += DeviceStatus_TglBtn_CheckedChanged;
                this.MoneyHopperState_TglBtn.CheckedChanged += MoneyHopperState_TglBtn_CheckedChanged;
                this.P10Usage_TglBtn.CheckedChanged += P10Usage_TglBtn_CheckedChanged;
                this.FlowAlarmIsActive_TglBtn.CheckedChanged += FlowAlarmIsActive_TglBtn_CheckedChanged;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineDetails.MachineDetails_Load -> ", _ex);
            }
        }
        private void DeviceStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is MainForm)
            {
                MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                using (WaitForm _waitForm = new WaitForm(SetDeviceStatus, "Cihaz durumu değiştiriliyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                {
                    _mainForm.TopMost = false;
                    _waitForm.TopMost = true;
                    _waitForm.ShowDialog();
                    _mainForm.RefreshSystemStatusPanel();
                    _mainForm.TopMost = true;

                }
            }
        }
        private void SetDeviceStatus()
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is MainForm)
            {
                MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                _mainForm.SecondReadingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                _mainForm.SecondsReadingTimerEnabled = false;
                System.Threading.Thread.Sleep(1100);
                try
                {
                    Constants.Main_ModbusConnection.SlaveId = (byte)Main_Machine.CommunicationAddress;
                    if (Constants.Main_ModbusConnection.SetDeviceStatus(DeviceStatus_TglBtn.Checked))
                    {
                        using (NotificationManager _notificationManager = new NotificationManager())
                        {
                            string _notificationText = "Cihaz durumu değiştirildi.";
                            _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                        }
                    }
                    else
                    {
                        using (NotificationManager _notificationManager = new NotificationManager())
                        {
                            string _notificationText = "Cihaz durumu değiştirilemedi.";
                            _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                        }
                        DeviceStatus_TglBtn.Checked = !DeviceStatus_TglBtn.Checked;
                    }
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                }
                catch (Exception _ex)
                {
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Logger.WriteLog("MachineDetails.SetDeviceStatus -> ", _ex);
                }
            }
        }
        private void MoneyHopperState_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is MainForm)
            {
                MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                using (WaitForm _waitForm = new WaitForm(SetMoneyHopperState, "Para haznesi durumu değiştiriliyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                {
                    _mainForm.TopMost = false;
                    _waitForm.TopMost = true;
                    _waitForm.ShowDialog();
                    _mainForm.TopMost = true;

                }
            }
        }
        private void SetMoneyHopperState()
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is Forms.MainForm)
            {
                MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                _mainForm.SecondReadingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                _mainForm.SecondsReadingTimerEnabled = false;
                System.Threading.Thread.Sleep(1100);
                try
                {
                    Constants.Main_ModbusConnection.SlaveId = (byte)Main_Machine.CommunicationAddress;
                    if (Constants.Main_ModbusConnection.SetMoneyHopperState(MoneyHopperState_TglBtn.Checked))
                    {
                        using (NotificationManager _notificationManager = new NotificationManager())
                        {
                            string _notificationText = "Para haznesi durumu değiştirildi.";
                            _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                        }
                    }
                    else
                    {
                        using (NotificationManager _notificationManager = new NotificationManager())
                        {
                            string _notificationText = "Para haznesi durumu değiştirilemedi.";
                            _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                        }
                        MoneyHopperState_TglBtn.Checked = !MoneyHopperState_TglBtn.Checked;
                    }
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                }
                catch (Exception _ex)
                {
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Logger.WriteLog("MachineDetails.MoneyHopperState_TglBtn_CheckedChanged -> ", _ex);
                }
            }
        }
        private void P10Usage_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is MainForm)
            {
                MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                using (WaitForm _waitForm = new WaitForm(SetP10Usage, "Led ekran durumu değiştiriliyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                {
                    _mainForm.TopMost = false;
                    _waitForm.TopMost = true;
                    _waitForm.ShowDialog();
                    _mainForm.TopMost = true;

                }
            }
        }
        private void SetP10Usage()
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is Forms.MainForm)
            {
                MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                _mainForm.SecondReadingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                _mainForm.SecondsReadingTimerEnabled = false;
                System.Threading.Thread.Sleep(1100);
                try
                {
                    Constants.Main_ModbusConnection.SlaveId = (byte)Main_Machine.CommunicationAddress;
                    if (Constants.Main_ModbusConnection.SetP10Usage(P10Usage_TglBtn.Checked))
                    {
                        using (NotificationManager _notificationManager = new NotificationManager())
                        {
                            string _notificationText = "Led ekran durumu değiştirildi.";
                            _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                        }
                    }
                    else
                    {
                        using (NotificationManager _notificationManager = new NotificationManager())
                        {
                            string _notificationText = "Led ekran durumu değiştirilemedi.";
                            _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                        }
                        P10Usage_TglBtn.Checked = !P10Usage_TglBtn.Checked;
                    }
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                }
                catch (Exception _ex)
                {
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Logger.WriteLog("MachineDetails.P10Usage_TglBtn_CheckedChanged -> ", _ex);
                }
            }
        }
        private void FlowAlarmIsActive_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is MainForm)
            {
                MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                using (WaitForm _waitForm = new WaitForm(SetFlowAlarmIsActive, "Basınç sensörü durumu değiştiriliyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                {
                    _mainForm.TopMost = false;
                    _waitForm.TopMost = true;
                    _waitForm.ShowDialog();
                    _mainForm.TopMost = true;

                }
            }
        }
        private void SetFlowAlarmIsActive()
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is Forms.MainForm)
            {
                MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                _mainForm.SecondReadingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                _mainForm.SecondsReadingTimerEnabled = false;
                System.Threading.Thread.Sleep(1100);
                try
                {
                    Constants.Main_ModbusConnection.SlaveId = (byte)Main_Machine.CommunicationAddress;
                    if (Constants.Main_ModbusConnection.SetFlowAlarmIsActive(FlowAlarmIsActive_TglBtn.Checked))
                    {
                        using (NotificationManager _notificationManager = new NotificationManager())
                        {
                            string _notificationText = "Basınç sensörü durumu değiştirildi.";
                            _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                        }
                    }
                    else
                    {
                        using (NotificationManager _notificationManager = new NotificationManager())
                        {
                            string _notificationText = "Basınç sensörü durumu değiştirildi.";
                            _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                        }
                        FlowAlarmIsActive_TglBtn.Checked = !FlowAlarmIsActive_TglBtn.Checked;
                    }
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                }
                catch (Exception _ex)
                {
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Logger.WriteLog("MachineDetails.P10Usage_TglBtn_CheckedChanged -> ", _ex);
                }
            }
        }
        private void ControlDoubleClick(object sender, EventArgs e)

        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Seçili makinenin detay ayarlarını değiştirmek istediğinize emin misiniz?";
                    string _header = "MAKİNE DETAY AYARLARI";
                    DialogResult _ans = _msgBox.Show(_message, _header, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        if (this.Parent.Parent.Parent.Parent.Parent.Parent.Parent is MainForm)
                        {
                            MainForm _mainForm = (MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                            _mainForm.TopMost = false;
                            DeviceTrackingSubForm _deviceTrackingSubForm = new DeviceTrackingSubForm(Main_Machine.Id);
                            _deviceTrackingSubForm.TopMost = true;
                            _deviceTrackingSubForm.StartPosition = FormStartPosition.Manual;
                            _deviceTrackingSubForm.Location = new Point(_mainForm.Location.X + ((_mainForm.Width - _deviceTrackingSubForm.Width) / 2), _mainForm.Location.Y + ((_mainForm.Height - _deviceTrackingSubForm.Height) / 2));
                            _deviceTrackingSubForm.Tag = _mainForm;
                            _deviceTrackingSubForm.ShowDialog();
                            if (_deviceTrackingSubForm.isDelete)
                            {
                                this.BackColor = Color.FromArgb(147, 80, 83);
                                this.Controls.Clear();
                                Label _infoLbl = new Label();
                                _infoLbl.Dock = DockStyle.Fill;
                                _infoLbl.BackColor = Color.Transparent;
                                _infoLbl.Name = "_infoLbl";
                                _infoLbl.Text = "CİHAZ SİLİNDİ";
                                _infoLbl.TextAlign = ContentAlignment.MiddleCenter;
                                _infoLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                                _infoLbl.ForeColor = Color.FromArgb(192, 192, 192);
                                this.Controls.Add(_infoLbl);
                            }
                            _mainForm.TopMost = true;
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineDetails.ControlDoubleClick -> ", _ex);
            }
        }
    }
}
