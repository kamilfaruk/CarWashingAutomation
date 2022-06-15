/* Coder by KFY */
using CarWashingAutomation.Components;
using System;
using System.Windows.Forms;
using CarWashingAutomation.Models;
using System.Drawing;
using System.Threading;

namespace CarWashingAutomation.Forms
{
    public partial class DeviceTrackingSubForm : Form
    {
        Machine Main_Machine;
        int ActiveModCount = 0;
        public bool isDelete = false;
        public DeviceTrackingSubForm(int _machineId)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    Main_Machine = _dbManager.GetMachine(_machineId);
                    if (Main_Machine != null)
                    {
                        InitializeComponent();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.DeviceTrackingSubForm -> ", _ex);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int _rectFrame = 2;
            Rectangle _rect = new Rectangle(new Point(_rectFrame, _rectFrame), new Size(this.Width - 2 * _rectFrame, this.Height - 2 * _rectFrame));
            Pen _pen = new Pen(Color.FromArgb(16, 154, 208), _rectFrame);
            g.DrawRectangle(_pen, _rect);
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.Close_Btn_Click -> ", _ex);
            }
        }
        private void DeviceTrackingSubForm_Load(object sender, EventArgs e)
        {
            try
            {
                Alias_Txt.Texts = Main_Machine.Alias;
                PeriodicMaintenanceHour_Num.Value = Main_Machine.PeriodicMaintenanceHour;
                CommunicationAddress_Num.Value = Main_Machine.CommunicationAddress;
                if (Main_Machine.TemperatureAlarmIsActive == 1)
                {
                    TemperatureAlarmIsActive_TglBtn.Checked = true;
                }
                LowTemperatureAlarm_Num.Value = Main_Machine.LowTemperatureAlarm;
                HighTemperatureAlarm_Num.Value = Main_Machine.HighTemperatureAlarm;
                FlowInitialCalibrationLimit_Num.Value = Main_Machine.FlowInitialCalibrationLimit;
                HighFlowAlarmCount_Num.Value = Main_Machine.HighFlowAlarmCount;
                LowFlowAlarmCount_Num.Value = Main_Machine.LowFlowAlarmCount;
                //Mop
                if (Main_Machine.MopStatus == 1)
                {
                    MopStatus_TglBtn.Checked = true;
                }
                MopPrice_Num.Value = Main_Machine.MopPrice;
                MopTime_Num.Value = Main_Machine.MopTime;
                //Wash
                if (Main_Machine.WashingStatus == 1)
                {
                    WashStatus_TglBtn.Checked = true;
                }
                WashPrice_Num.Value = Main_Machine.WashingPrice;
                WashTime_Num.Value = Main_Machine.WashingTime;
                //Foam
                if (Main_Machine.FoamStatus == 1)
                {
                    FoamStatus_TglBtn.Checked = true;
                }
                FoamPrice_Num.Value = Main_Machine.FoamPrice;
                FoamTime_Num.Value = Main_Machine.FoamTime;
                //Air
                if (Main_Machine.AirmaticStatus == 1)
                {
                    AirStatus_TglBtn.Checked = true;
                }
                AirPrice_Num.Value = Main_Machine.AirmaticPrice;
                AirTime_Num.Value = Main_Machine.AirmaticTime;
                //Vacuum
                if (Main_Machine.VacuummaticStatus == 1)
                {
                    VacuumStatus_TglBtn.Checked = true;
                }
                VacuumPrice_Num.Value = Main_Machine.VacuummaticPrice;
                VacuumTime_Num.Value = Main_Machine.VacuummaticTime;
                //Varnish
                if (Main_Machine.VarnishStatus == 1)
                {
                    VarnishStatus_TglBtn.Checked = true;
                }
                VarnishPrice_Num.Value = Main_Machine.VarnishPrice;
                VarnishTime_Num.Value = Main_Machine.VarnishTime;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.DeviceTrackingForm_Load -> ", _ex);
            }
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (WaitForm _waitForm = new WaitForm(WriteParametersByModbus, "Ayarlar Makineye İletiliyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                {
                    this.TopMost = false;
                    _waitForm.TopMost = true;
                    _waitForm.ShowDialog();
                    this.TopMost = true;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.Save_Btn_Click -> ", _ex);
            }
        }
        private void FactoryReset_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (WaitForm _waitForm = new WaitForm(FactoryReset, "Fabrika ayarlarına dönülüyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                {
                    this.TopMost = false;
                    _waitForm.TopMost = true;
                    _waitForm.ShowDialog();
                    this.TopMost = true;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.FactoryReset_Btn_Click -> ", _ex);
            }
        }
        private void FactoryReset()
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    DialogResult _ans = _msgBox.Show(Main_Machine.Alias + " adlı makineye fabrika ayarlarını yüklemek istediğinize emin misiniz? Bu işlem bir kere gerçekleştikten sonra mevcut makine üzerindeki tüm ayarlarınız kalıcı olarak silinecektir.", "FABRİKA AYARLARINA DÖNME ONAYI", MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        if (this.Tag is MainForm)
                        {
                            MainForm _mainForm = (MainForm)this.Tag;
                            _mainForm.SecondReadingTimer.Change(Timeout.Infinite, Timeout.Infinite);
                            _mainForm.SecondsReadingTimerEnabled = false;
                            Thread.Sleep(1100);
                            try
                            {
                                int _unitIdentifier = Convert.ToInt32(CommunicationAddress_Num.Value);
                                Constants.Main_ModbusConnection.SlaveId = (byte)_unitIdentifier;
                                if (Constants.Main_ModbusConnection.SetRestoreFactorySettings())
                                {
                                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                                    _mainForm.SecondsReadingTimerEnabled = true;
                                }
                            }
                            catch (Exception _ex)
                            {
                                _mainForm.SecondReadingTimer.Change(1000, 1000);
                                _mainForm.SecondsReadingTimerEnabled = true;
                                Logger.WriteLog("DeviceTrackingSubForm.FactoryReset -> ", _ex);
                            }
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.FactoryReset -> ", _ex);
            }
        }
        private void DeleteMachine_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    DialogResult _ans = _msgBox.Show(Main_Machine.Alias + " adlı makineye silmek istediğinize emin misiniz?", "SİLME ONAYI", MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        using (DBManager _dbManager = new DBManager())
                        {
                            Machine _machine = _dbManager.GetMachine(Main_Machine.Id);
                            if (_machine != null)
                            {
                                if (_dbManager.DeleteMachine(_machine))
                                {
                                    using (NotificationManager _notificationManager = new NotificationManager())
                                    {
                                        string _notificationText = "Cihaz silindi.";
                                        _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                                    }
                                    if (this.Tag is MainForm)
                                    {
                                        MainForm _mainForm = (MainForm)this.Tag;
                                        _mainForm.RefreshSystemStatusPanel();
                                        isDelete = true;
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    using (NotificationManager _notificationManager = new NotificationManager())
                                    {
                                        string _notificationText = "Cihaz silinemedi.";
                                        _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                                    }
                                }
                            }
                            else
                            {
                                using (NotificationManager _notificationManager = new NotificationManager())
                                {
                                    string _notificationText = "Cihaz silinemedi.";
                                    _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.DeleteMachine_Btn_Click -> ", _ex);
                using (NotificationManager _notificationManager = new NotificationManager())
                {
                    string _notificationText = "Cihaz silinemedi.";
                    _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                }
            }
        }
        private void WriteParametersByModbus()
        {
            if (this.Tag is MainForm)
            {
                MainForm _mainForm = (MainForm)this.Tag;
                _mainForm.SecondReadingTimer.Change(Timeout.Infinite, Timeout.Infinite);
                _mainForm.SecondsReadingTimerEnabled = false;
                System.Threading.Thread.Sleep(1100);
                try
                {
                    int _unitIdentifier = Convert.ToInt32(CommunicationAddress_Num.Value);
                    Constants.Main_ModbusConnection.SlaveId = (byte)_unitIdentifier;
                    Constants.Main_ModbusConnection.SetTemperatureAlarmIsActive(this.TemperatureAlarmIsActive_TglBtn.Checked);
                    Constants.Main_ModbusConnection.SetLowTemperatureAlarm(Convert.ToInt32(this.LowTemperatureAlarm_Num.Value));
                    Constants.Main_ModbusConnection.SetHighTemperatureAlarm(Convert.ToInt32(this.HighTemperatureAlarm_Num.Value));
                    Constants.Main_ModbusConnection.SetFlowInitialCalibrationLimit(Convert.ToInt32(this.FlowInitialCalibrationLimit_Num.Value));
                    Constants.Main_ModbusConnection.SetHighFlowAlarmCount(Convert.ToInt32(this.HighFlowAlarmCount_Num.Value));
                    Constants.Main_ModbusConnection.SetLowFlowAlarmCount(Convert.ToInt32(this.LowFlowAlarmCount_Num.Value));

                    Constants.Main_ModbusConnection.SetMopStatus(this.MopStatus_TglBtn.Checked);
                    Constants.Main_ModbusConnection.SetMopPrice(Convert.ToInt32(this.MopPrice_Num.Value));
                    Constants.Main_ModbusConnection.SetMopTime(Convert.ToInt32(this.MopTime_Num.Value));

                    Constants.Main_ModbusConnection.SetWashingStatus(this.WashStatus_TglBtn.Checked);
                    Constants.Main_ModbusConnection.SetWashingPrice(Convert.ToInt32(this.WashPrice_Num.Value));
                    Constants.Main_ModbusConnection.SetWashingTime(Convert.ToInt32(this.WashTime_Num.Value));

                    Constants.Main_ModbusConnection.SetFoamStatus(this.FoamStatus_TglBtn.Checked);
                    Constants.Main_ModbusConnection.SetFoamPrice(Convert.ToInt32(this.FoamPrice_Num.Value));
                    Constants.Main_ModbusConnection.SetFoamTime(Convert.ToInt32(this.FoamTime_Num.Value));

                    Constants.Main_ModbusConnection.SetAirmaticStatus(this.AirStatus_TglBtn.Checked);
                    Constants.Main_ModbusConnection.SetAirmaticPrice(Convert.ToInt32(this.AirPrice_Num.Value));
                    Constants.Main_ModbusConnection.SetAirmaticTime(Convert.ToInt32(this.AirTime_Num.Value));

                    Constants.Main_ModbusConnection.SetVacuummaticStatus(this.VacuumStatus_TglBtn.Checked);
                    Constants.Main_ModbusConnection.SetVacuummaticPrice(Convert.ToInt32(this.VacuumPrice_Num.Value));
                    Constants.Main_ModbusConnection.SetVacuummaticTime(Convert.ToInt32(this.VacuumTime_Num.Value));

                    Constants.Main_ModbusConnection.SetVarnishStatus(this.VarnishStatus_TglBtn.Checked);
                    Constants.Main_ModbusConnection.SetVarnishPrice(Convert.ToInt32(this.VarnishPrice_Num.Value));
                    Constants.Main_ModbusConnection.SetVarnishTime(Convert.ToInt32(this.VarnishTime_Num.Value));
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Save_Btn.BackColor = Color.FromArgb(25, 160, 60);
                }
                catch (Exception _ex)
                {
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Logger.WriteLog("DeviceTrackingSubForm.WriteParametersByModbus -> ", _ex);
                    Save_Btn.BackColor = Color.FromArgb(230, 90, 90);
                }
            }
        }


        #region ToogleButtons
        private void VarnishStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (VarnishStatus_TglBtn.Checked)
                {
                    if (ActiveModCount++ < 4)
                    {
                        VarnishPrice_Num.Enabled = true;
                        VarnishTime_Num.Enabled = true;
                    }
                }
                else
                {
                    ActiveModCount--;
                    VarnishPrice_Num.Enabled = false;
                    VarnishTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.VarnishStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void VacuumStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (VacuumStatus_TglBtn.Checked)
                {
                    if (ActiveModCount++ < 4)
                    {
                        VacuumPrice_Num.Enabled = true;
                        VacuumTime_Num.Enabled = true;
                    }
                }
                else
                {
                    ActiveModCount--;
                    VacuumPrice_Num.Enabled = false;
                    VacuumTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.VacuumStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void AirStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (AirStatus_TglBtn.Checked)
                {
                    if (ActiveModCount++ < 4)
                    {
                        AirPrice_Num.Enabled = true;
                        AirTime_Num.Enabled = true;
                    }
                }
                else
                {
                    ActiveModCount--;
                    AirPrice_Num.Enabled = false;
                    AirTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.AirStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void FoamStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (FoamStatus_TglBtn.Checked)
                {
                    if (ActiveModCount++ < 4)
                    {
                        FoamPrice_Num.Enabled = true;
                        FoamTime_Num.Enabled = true;
                    }
                }
                else
                {
                    ActiveModCount--;
                    FoamPrice_Num.Enabled = false;
                    FoamTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.FoamStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void WashStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (WashStatus_TglBtn.Checked)
                {
                    if (ActiveModCount++ < 4)
                    {
                        WashPrice_Num.Enabled = true;
                        WashTime_Num.Enabled = true;
                    }
                }
                else
                {
                    ActiveModCount--;
                    WashPrice_Num.Enabled = false;
                    WashTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.WashStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void MopStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (MopStatus_TglBtn.Checked)
                {
                    if (ActiveModCount++ < 4)
                    {
                        MopPrice_Num.Enabled = true;
                        MopTime_Num.Enabled = true;
                    }
                }
                else
                {
                    ActiveModCount--;
                    MopPrice_Num.Enabled = false;
                    MopTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingSubForm.MopStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        #endregion
    }
}
