/* Coder by KFY */
using System;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Collections.Generic;
using CarWashingAutomation.Models;
using CarWashingAutomation.Controls;
using System.Runtime.InteropServices;
using CarWashingAutomation.Components;
using CarWashingAutomation.Connections;
using CarWashingAutomation.Tools;
using System.Security.Principal;
using System.Security.AccessControl;

namespace CarWashingAutomation.Forms
{
    public partial class MainForm : Form
    {
        //https://coolors.co/1d2227-2f343a-40454c-345b6d-109ad0-935053-e65a5a-2d7344-19a03c      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public System.Threading.Timer SecondReadingTimer;
        public bool SecondsReadingTimerEnabled = true;
        private bool RestartRequest = false;
        public List<int> CommunicationErrorList = new List<int>();

        public MainForm()
        {
            try
            {
                InitializeComponent();
                SetStartup();
                LoginForm _loginForm = new LoginForm();
                _loginForm.ShowDialog();
                if (_loginForm.Logined)
                {
                    GetUserMenu();
                    using (DBManager _dbManager = new DBManager())
                    {
                        List<Machine> _machineList = _dbManager.GetMachineList();
                        if (_machineList.Count > 0)
                        {
                            Constants.Main_ModbusConnection = new ModbusConnection(_machineList[0].CommunicationAddress);
                        }
                    }
                    SecondReadingTimer = new System.Threading.Timer(new System.Threading.TimerCallback(SecondsReadingTimer_Tick), null, 1000, 1000);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.MainForm -> ", _ex);
            }
        }
        private void SetStartup()
        {
            try
            {
                using (var _registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree))
                {

                    if (_registryKey.GetValue("CarWashingAutomation") != null)
                    {
                        _registryKey.DeleteValue("CarWashingAutomation");
                    }
                    /*
                    if (_registryKey.GetValue("CarWashingAutomation") == null)
                    {
                        _registryKey.SetValue("CarWashingAutomation", Application.ExecutablePath.ToString());
                    }
                    SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
                    NTAccount account = sid.Translate(typeof(NTAccount)) as NTAccount;
                    RegistrySecurity rs = _registryKey.GetAccessControl();
                    var rar = new RegistryAccessRule(
                        account.ToString(),
                        RegistryRights.FullControl,
                        InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                        PropagationFlags.None,
                        AccessControlType.Allow);
                    rs.AddAccessRule(rar);
                    _registryKey.SetAccessControl(rs);
                    */
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.SetStartup -> ", _ex);
            }
        }
        private void GetUserMenu()
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    User _user = _dbManager.GetUser(Constants.CurrentUserId);
                    Logout_Btn.Text = _user.Name + " " + _user.Surname;
                    this.Menu_Pnl.Controls.Clear();
                    this.Menu_Pnl.Controls.Add(this.Shift_Table);
                    this.Menu_Pnl.Controls.Add(this.Logout_Btn);
                    this.Menu_Pnl.Controls.Add(this.SlideMenu_Btn);
                    if (_user.Authority == "KULLANICI")
                    {
                        this.Overview_Pbx.Location = new Point(0, 98);
                        this.Overview_Btn.Location = new Point(0, 98);
                        this.TechnicalSupport_Pbx.Location = new Point(0, 155);
                        this.TechnicalSupport_Btn.Location = new Point(0, 155);
                        //
                        this.Menu_Pnl.Controls.Add(this.Overview_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Overview_Btn);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Pbx);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Btn);
                    }
                    else if (_user.Authority == "YÖNETİCİ")
                    {
                        this.Overview_Pbx.Location = new Point(0, 98);
                        this.Overview_Btn.Location = new Point(0, 98);
                        this.Reports_Pbx.Location = new Point(0, 155);
                        this.Reports_Btn.Location = new Point(0, 155);
                        this.TechnicalSupport_Pbx.Location = new Point(0, 212);
                        this.TechnicalSupport_Btn.Location = new Point(0, 212);
                        //
                        this.Menu_Pnl.Controls.Add(this.Overview_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Overview_Btn);
                        this.Menu_Pnl.Controls.Add(this.Reports_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Reports_Btn);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Pbx);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Btn);
                    }
                    else if (_user.Authority == "MÜDÜR")
                    {
                        this.Overview_Pbx.Location = new Point(0, 98);
                        this.Overview_Btn.Location = new Point(0, 98);
                        this.DeviceTracking_Pbx.Location = new Point(0, 155);
                        this.DeviceTracking_Btn.Location = new Point(0, 155);
                        this.Reports_Pbx.Location = new Point(0, 212);
                        this.Reports_Btn.Location = new Point(0, 212);
                        this.Settings_Pbx.Location = new Point(0, 268);
                        this.Settings_Btn.Location = new Point(0, 268);
                        this.TechnicalSupport_Pbx.Location = new Point(0, 325);
                        this.TechnicalSupport_Btn.Location = new Point(0, 325);
                        //
                        this.Menu_Pnl.Controls.Add(this.Overview_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Overview_Btn);
                        this.Menu_Pnl.Controls.Add(this.DeviceTracking_Pbx);
                        this.Menu_Pnl.Controls.Add(this.DeviceTracking_Btn);
                        this.Menu_Pnl.Controls.Add(this.Reports_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Reports_Btn);
                        this.Menu_Pnl.Controls.Add(this.Settings_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Settings_Btn);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Pbx);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Btn);
                    }
                    else
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Ne yazıkki girmiş olduğunuz kullanıcı adı veya şifre ile eşleşen bir kullanıcı bulunamadı.";
                            string _title = "KULLANICI BULUNAMADI";
                            _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                            Environment.Exit(0);
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.GetUserMenu -> ", _ex);
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!RestartRequest)
                {
                    using (MsgBox _msgBox = new MsgBox())
                    {
                        string _message = "Kullanmakta olduğunuz program araç yıkama otomasyonunun temelini oluşturmaktadır. Lütfen bu programı veya ana makineyi kapatmayınız.";
                        string _header = "LÜTFEN KAPATMAYINIZ";
                        _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Info);
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.MainForm_FormClosing -> ", _ex);
            }
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    ShowIcon = false;
                    Main_NotifiyIcon.Visible = true;
                    Main_NotifiyIcon.ShowBalloonTip(500);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.MainForm_Resize -> ", _ex);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                OpenFormInPanel(new LogoForm());
                Main_NotifiyIcon.BalloonTipText = "Uygulama Arka Plana Alındı";
                Main_NotifiyIcon.BalloonTipTitle = "W@shWiz";
                RefreshSystemStatusPanel();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.MainForm_Load -> ", _ex);
            }
        }
        public void RefreshSystemStatusPanel()
        {
            try
            {
                CommunicationErrorList.Clear();
                RefreshAllMachineByDb();
                SystemStatus_Pnl.Controls.Clear();
                SystemStatus_Pnl.Controls.Add(GetMachineStatusTable());
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.RefreshSystemStatusPanel -> ", _ex);
            }
        }
        private Control GetMachineStatusTable()
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    List<Machine> _machineList = _dbManager.GetMachineList();
                    if (_machineList != null)
                    {
                        TableLayoutPanel _machineTable = new TableLayoutPanel();
                        _machineTable.ColumnCount = _machineList.Count;
                        _machineTable.RowCount = 1;
                        _machineTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                        _machineTable.Height = SystemStatus_Pnl.Height;
                        _machineTable.Width = _machineList.Count * SystemStatus_Pnl.Height;
                        int _columnNo = 0;
                        foreach (Machine _machine in _machineList)
                        {
                            int _machineId = _machine.Id;
                            _machineTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                            MachineStatus _machineOverview = new MachineStatus(_machineId);
                            _machineOverview.Dock = DockStyle.Fill;
                            _machineTable.Controls.Add(_machineOverview, _columnNo, 0);
                            _columnNo++;
                        }
                        return _machineTable;
                    }
                }
                return null;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.GetMachineStatusTable -> ", _ex);
                return null;
            }
        }
        private void Main_NotifiyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Main_NotifiyIcon.Visible = false;
                WindowState = FormWindowState.Normal;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Main_NotifiyIcon_MouseDoubleClick -> ", _ex);
            }
        }

        #region Title Buttons
        private void Title_Pnl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Title_Pnl_MouseDown -> ", _ex);
            }
        }
        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Minimize_Btn_Click -> ", _ex);
            }
        }
        private void Restart_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Mevcut uygulamayı yeniden başlatmak istediğinize emin misiniz?";
                    string _title = "RESET ONAYI";
                    DialogResult _ans = _msgBox.Show(_message, _title, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        RestartRequest = true;
                        Application.Restart();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Restart_Btn_Click -> ", _ex);
            }
        }
        private void Information_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                InformationForm _informationForm = new InformationForm();
                _informationForm.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_informationForm);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Information_Btn_Click -> ", _ex);
            }
        }
        #endregion

        #region Menu Buttons
        private void SlideMenu_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Menu_Pnl.Width == 172)
                {
                    this.CollapseMenu_Tmr.Start();
                }
                else if (Menu_Pnl.Width == 55)
                {
                    this.ExpandMenu_Tmr.Start();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.SlideMenu_Btn_Click -> ", _ex);
            }
        }
        private void Overview_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                Overview_Btn.BackColor = Color.FromArgb(47, 52, 58);
                OverviewForm _form = new OverviewForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Overview_Btn_Click -> ", _ex);
            }
        }
        private void ButtonsBackColorTransparent()
        {
            try
            {
                Overview_Btn.BackColor = Color.Transparent;
                DeviceTracking_Btn.BackColor = Color.Transparent;
                Reports_Btn.BackColor = Color.Transparent;
                Settings_Btn.BackColor = Color.Transparent;
                TechnicalSupport_Btn.BackColor = Color.Transparent;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.ButtonsBackColorTransparent -> ", _ex);
            }
        }
        private void DeviceTracking_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                DeviceTracking_Btn.BackColor = Color.FromArgb(47, 52, 58);
                DeviceTrackingForm _form = new DeviceTrackingForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.DeviceTracking_Btn_Click -> ", _ex);
            }
        }
        private void Reports_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                Reports_Btn.BackColor = Color.FromArgb(47, 52, 58);
                ReportsForm _form = new ReportsForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Reports_Btn_Click -> ", _ex);
            }
        }
        private void Settings_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                Settings_Btn.BackColor = Color.FromArgb(47, 52, 58);
                SettingsForm _form = new SettingsForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Settings_Btn_Click -> ", _ex);
            }
        }
        private void TechnicalSupport_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                TechnicalSupport_Btn.BackColor = Color.FromArgb(47, 52, 58);
                TechnicalSupportForm _form = new TechnicalSupportForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.TechnicalSupport_Btn_Click -> ", _ex);
            }
        }
        private void Shift_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Shift_TglBtn.Checked == false)
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Mevcut vardiyayı sonlandırdığınız takdirde tüm makineleriniz kapanacaktır. Yinede vardiyayı sonlandırmak istediğinize emin misiniz?";
                    string _title = "VARDİYA BİTİRME ONAYI";
                    DialogResult _ans = _msgBox.Show(_message, _title, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        EndShift();
                    }
                    else
                    {
                        Shift_TglBtn.Checked = true;
                    }
                }
            }
            else
            {
                StartShift();
            }
        }
        private void Logout_Btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Hide();
                Constants.CurrentUserId = 0;
                LoginForm _loginForm = new LoginForm();
                _loginForm.ShowDialog();
                _loginForm.TopMost = true;
                if (_loginForm.Logined)
                {
                    this.Show();
                    GetUserMenu();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Logout_Pbx_Click -> ", _ex);
            }
        }
        private void OpenFormInPanel(object _form)
        {
            try
            {
                if (this.FormContainer_Pnl.Controls.Count > 0)
                    this.FormContainer_Pnl.Controls.RemoveAt(0);
                Form _currentForm = _form as Form;
                _currentForm.TopLevel = false;
                _currentForm.FormBorderStyle = FormBorderStyle.None;
                _currentForm.Dock = DockStyle.Fill;
                this.FormContainer_Pnl.Controls.Add(_currentForm);
                this.FormContainer_Pnl.Tag = _currentForm;
                _currentForm.Show();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.OpenFormInPanel -> ", _ex);
            }
        }
        private void ShowLogoFormWhenClosingForms(object sender, FormClosedEventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                OpenFormInPanel(new LogoForm());
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.ShowLogoFormWhenClosingForms -> ", _ex);
            }
        }
        #endregion

        #region Shift Control
        private void ShiftControl(int _hour, int _minute)
        {
            try
            {
                int _startHour = Convert.ToInt32(Constants.ShiftStartTime.Split(':')[0]);
                int _startMinute = Convert.ToInt32(Constants.ShiftStartTime.Split(':')[1]);
                if (_hour == _startHour && _minute == _startMinute)
                {
                    StartShift();
                }
                int _endHour = Convert.ToInt32(Constants.ShiftEndTime.Split(':')[0]);
                int _endMinute = Convert.ToInt32(Constants.ShiftEndTime.Split(':')[1]);
                if (_hour == _endHour && _minute == _endMinute)
                {
                    EndShift();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.ShiftControl -> ", _ex);
            }
        }
        private void EndShift()
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    List<Machine> _machineList = _dbManager.GetMachineList();
                    if (_machineList != null)
                    {
                        foreach (Machine _machine in _machineList)
                        {
                            SecondReadingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                            SecondsReadingTimerEnabled = false;
                            System.Threading.Thread.Sleep(1100);
                            Constants.Main_ModbusConnection.SlaveId = (byte)_machine.CommunicationAddress;
                            if (Constants.Main_ModbusConnection.SetDeviceStatus(false))
                            {
                                using (NotificationManager _notificationManager = new NotificationManager())
                                {
                                    string _notificationText = _machine.ToString() + "-BAŞARILI";
                                    _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                                }
                            }
                            else
                            {
                                using (NotificationManager _notificationManager = new NotificationManager())
                                {
                                    string _notificationText = _machine.ToString() + "-BAŞARISIZ";
                                    _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                                }
                            }
                            SecondReadingTimer.Change(1000, 1000);
                            SecondsReadingTimerEnabled = true;
                        }
                        User _user = _dbManager.GetUser(Constants.CurrentUserId);
                        PdfReport _pdfReport = new PdfReport();
                        if (_pdfReport.GenerateAndSaveReport("Vardiya Sonu (" + _user.ToString() + ")"))
                        {
                            using (NotificationManager _notificationManager = new NotificationManager())
                            {
                                string _notificationText = "Vardiya Raporu Oluşturuldu";
                                _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                            }
                        }
                        else
                        {
                            using (NotificationManager _notificationManager = new NotificationManager())
                            {
                                string _notificationText = "Vardiya Raporu Oluşturulamadı";
                                _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                            }
                            using (MsgBox _msgBox = new MsgBox())
                            {
                                string _message = "Ne yazıkki vardiya sonundaki güncel sistem durumunu içeren rapor dosyası oluşturulamadı. Lütfen sistem yetkililerinizden manuel olarak rapor oluşturmasını talep ediniz!";
                                string _title = "RAPOR OLUŞTURULAMADI";
                                _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                SecondReadingTimer.Change(1000, 1000);
                SecondsReadingTimerEnabled = true;
                Logger.WriteLog("MainForm.StartShift -> ", _ex);
            }
        }
        private void StartShift()
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    List<Machine> _machineList = _dbManager.GetMachineList();
                    if (_machineList != null)
                    {
                        foreach (Machine _machine in _machineList)
                        {
                            SecondReadingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                            SecondsReadingTimerEnabled = false;
                            System.Threading.Thread.Sleep(1100);
                            Constants.Main_ModbusConnection.SlaveId = (byte)_machine.CommunicationAddress;
                            if (Constants.Main_ModbusConnection.SetDeviceStatus(true))
                            {
                                using (NotificationManager _notificationManager = new NotificationManager())
                                {
                                    string _notificationText = _machine.ToString() + "-BAŞARILI";
                                    _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                                }
                            }
                            else
                            {
                                using (NotificationManager _notificationManager = new NotificationManager())
                                {
                                    string _notificationText = _machine.ToString() + "-BAŞARISIZ";
                                    _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                                }
                            }
                            SecondReadingTimer.Change(1000, 1000);
                            SecondsReadingTimerEnabled = true;
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                SecondReadingTimer.Change(1000, 1000);
                SecondsReadingTimerEnabled = true;
                Logger.WriteLog("MainForm.StartShift -> ", _ex);
            }
        }
        #endregion

        #region Timer Ticks
        private void DateTime_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                Date_Lbl.Text = DateTime.Now.ToLongDateString();
                Hour_Lbl.Text = DateTime.Now.ToString("HH:mm:ss");
                ShiftControl(DateTime.Now.Hour, DateTime.Now.Minute);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.DateTime_Tmr_Tick -> ", _ex);
            }
        }
        private void ExpandMenu_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Menu_Pnl.Width >= 172)
                {
                    this.ExpandMenu_Tmr.Stop();
                }
                else
                {
                    Menu_Pnl.Width = Menu_Pnl.Width + 9;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.ExpandMenu_Tmr_Tick -> ", _ex);
            }
        }
        private void CollapseMenu_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Menu_Pnl.Width <= 55)
                {
                    this.CollapseMenu_Tmr.Stop();
                }
                else
                {
                    Menu_Pnl.Width = Menu_Pnl.Width - 9;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.CollapseMenu_Tmr_Tick -> ", _ex);
            }
        }
        bool ModbusBeausy = false;
        private void SecondsReadingTimer_Tick(object state)
        {
            try
            {
                if (SecondsReadingTimerEnabled)
                {
                    RefreshAllMachineByDb();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.SecondsReadingTimer_Tick -> ", _ex);
            }
        }
        private void RefreshAllMachineByDb()
        {
            try
            {
                if (!ModbusBeausy)
                {
                    ModbusBeausy = true;
                    using (DBManager _dbManager = new DBManager())
                    {
                        List<Machine> _machineList = _dbManager.GetMachineList();
                        foreach (Machine _machine in _machineList)
                        {
                            Constants.Main_ModbusConnection.SlaveId = (byte)_machine.CommunicationAddress;
                            if (Constants.Main_ModbusConnection.CommunicationControl(_machine.CommunicationAddress))
                            {
                                if (Constants.Main_ModbusConnection.RefreshMachine(_machine.Id))
                                {
                                    if (CommunicationErrorList.Contains(_machine.Id))
                                    {
                                        CommunicationErrorList.Remove(_machine.Id);
                                        SystemStatus_Pnl.Controls.Clear();
                                        SystemStatus_Pnl.Controls.Add(GetMachineStatusTable());
                                    }
                                }
                                else
                                {
                                    CommunicationErrorList.Add(_machine.Id);
                                }
                            }
                            else
                            {
                                CommunicationErrorList.Add(_machine.Id);
                            }
                        }
                    }
                    ModbusBeausy = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.SecondsReadingTimer_Tick -> ", _ex);
                ModbusBeausy = false;
            }
        }
        #endregion
    }
}
