/* Coder by KFY */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CarWashingAutomation.Components;
using CarWashingAutomation.Connections;
using CarWashingAutomation.Models;

namespace CarWashingAutomation.Controls
{
    public partial class MachineCreater : UserControl
    {
        private Color SelectedPbxBtnBackColor = Color.FromArgb(64, 69, 76);
        public MachineCreater()
        {
            try
            {
                InitializeComponent();
                SetBackColorAllPbx();
                Machine_Pbx.BackColor = SelectedPbxBtnBackColor;
                Main_Pnl.Controls.Add(Machine_Table);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.MachineCreater -> ", _ex);
            }
        }
        private void SetBackColorAllPbx()
        {
            try
            {
                Machine_Pbx.BackColor = Color.Transparent;
                Foam_Pbx.BackColor = Color.Transparent;
                Wash_Pbx.BackColor = Color.Transparent;
                Foam_Pbx.BackColor = Color.Transparent;
                Air_Pbx.BackColor = Color.Transparent;
                Vacuum_Pbx.BackColor = Color.Transparent;
                Varnish_Pbx.BackColor = Color.Transparent;
                if (FoamStatus_TglBtn.Checked)
                {
                    Foam_Pbx.BackColor = Color.FromArgb(43, 77, 64);
                }
                if (WashStatus_TglBtn.Checked)
                {
                    Wash_Pbx.BackColor = Color.FromArgb(43, 77, 64);
                }
                if (FoamStatus_TglBtn.Checked)
                {
                    Foam_Pbx.BackColor = Color.FromArgb(43, 77, 64);
                }
                if (AirStatus_TglBtn.Checked)
                {
                    Air_Pbx.BackColor = Color.FromArgb(43, 77, 64);
                }
                if (VacuumStatus_TglBtn.Checked)
                {
                    Vacuum_Pbx.BackColor = Color.FromArgb(43, 77, 64);
                }
                if (VarnishStatus_TglBtn.Checked)
                {
                    Varnish_Pbx.BackColor = Color.FromArgb(43, 77, 64);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.SetBackColorAllPbx -> ", _ex);
            }
        }
        private void FetchDate_Btn_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent is Forms.MainForm)
            {
                Forms.MainForm _mainForm = (Forms.MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent;
                try
                {
                    _mainForm.SecondReadingTimer.Change(Timeout.Infinite, Timeout.Infinite);
                    _mainForm.SecondsReadingTimerEnabled = false;
                    System.Threading.Thread.Sleep(1100);
                    int _unitIdentifier = Convert.ToInt32(CommunicationAddress_Num.Value);
                    if (Constants.Main_ModbusConnection == null)
                    {
                        Constants.Main_ModbusConnection = new ModbusConnection(_unitIdentifier);
                    }
                    if (Constants.Main_ModbusConnection.Connected)
                    {
                        Constants.Main_ModbusConnection.SlaveId = (byte)_unitIdentifier;
                        Constants.Main_ModbusConnection.InputRegisters = Constants.Main_ModbusConnection.Main_ModbusClient.ReadInputRegisters(1, 8);
                        Constants.Main_ModbusConnection.HoldingRegisters = Constants.Main_ModbusConnection.Main_ModbusClient.ReadHoldingRegisters(1, 57);
                        this.P10Usage_TglBtn.Checked = Constants.Main_ModbusConnection.GetP10Usage();
                        this.TemperatureAlarmIsActive_TglBtn.Checked = Constants.Main_ModbusConnection.GetTemperatureAlarmIsActive();
                        this.LowTemperatureAlarm_Num.Value = Constants.Main_ModbusConnection.GetLowTemperatureAlarm();
                        this.HighTemperatureAlarm_Num.Value = Constants.Main_ModbusConnection.GetHighTemperatureAlarm();
                        this.FlowInitialCalibrationLimit_Num.Value = Constants.Main_ModbusConnection.GetFlowInitialCalibrationLimit();
                        this.HighFlowAlarmCount_Num.Value = Constants.Main_ModbusConnection.GetHighFlowAlarmCount();
                        this.LowFlowAlarmCount_Num.Value = Constants.Main_ModbusConnection.GetLowFlowAlarmCount();
                        this.FoamStatus_TglBtn.Checked = Constants.Main_ModbusConnection.GetFoamStatus();
                        this.FoamPrice_Num.Value = Constants.Main_ModbusConnection.GetFoamPrice();
                        this.FoamTime_Num.Value = Constants.Main_ModbusConnection.GetFoamTime();
                        this.WashStatus_TglBtn.Checked = Constants.Main_ModbusConnection.GetWashingStatus();
                        this.WashPrice_Num.Value = Constants.Main_ModbusConnection.GetWashingPrice();
                        this.WashTime_Num.Value = Constants.Main_ModbusConnection.GetWashingTime();
                        this.FoamStatus_TglBtn.Checked = Constants.Main_ModbusConnection.GetFoamStatus();
                        this.FoamPrice_Num.Value = Constants.Main_ModbusConnection.GetFoamPrice();
                        this.FoamTime_Num.Value = Constants.Main_ModbusConnection.GetFoamTime();
                        this.AirStatus_TglBtn.Checked = Constants.Main_ModbusConnection.GetAirmaticStatus();
                        this.AirPrice_Num.Value = Constants.Main_ModbusConnection.GetAirmaticPrice();
                        this.AirTime_Num.Value = Constants.Main_ModbusConnection.GetAirmaticTime();
                        this.VacuumStatus_TglBtn.Checked = Constants.Main_ModbusConnection.GetVacuummaticStatus();
                        this.VacuumPrice_Num.Value = Constants.Main_ModbusConnection.GetVacuummaticPrice();
                        this.VacuumTime_Num.Value = Constants.Main_ModbusConnection.GetVacuummaticTime();
                        this.VarnishStatus_TglBtn.Checked = Constants.Main_ModbusConnection.GetVarnishStatus();
                        this.VarnishPrice_Num.Value = Constants.Main_ModbusConnection.GetVarnishPrice();
                        this.VarnishTime_Num.Value = Constants.Main_ModbusConnection.GetVarnishTime();
                    }
                    else
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Ne yazık ki girmiş olduğunuz haberleşme adresi ile bağlantı kurulamadı.";
                            string _title = "BAĞLANTI HATASI";
                            _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                        }
                    }
                    SetBackColorAllPbx();
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                }
                catch (Exception _ex)
                {
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Logger.WriteLog("MachineCreater.FetchDate_Btn_Click -> ", _ex);
                }
            }
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetTotalModCount() < 4)
                {
                    if (this.Parent.Parent.Parent.Parent.Parent.Parent is Forms.MainForm)
                    {
                        Forms.MainForm _mainForm = (Forms.MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent;
                        int _communicationAddress = Convert.ToInt32(CommunicationAddress_Num.Value);
                        if (_communicationAddress > 0)
                        {
                            using (DBManager _dbManager = new DBManager())
                            {
                                List<Machine> _machineList = _dbManager.GetMachineList();
                                if (_machineList != null)
                                {
                                    Machine _machine = _machineList.Find(_m => _m.CommunicationAddress == _communicationAddress);
                                    if (_machine == null)
                                    {
                                        using (WaitForm _waitForm = new WaitForm(WriteParametersByModbus, "Yeni Cihaz Ekleniyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                                        {
                                            _mainForm.TopMost = false;
                                            _waitForm.TopMost = true;
                                            _waitForm.ShowDialog();
                                            _mainForm.TopMost = true;
                                            _mainForm.RefreshSystemStatusPanel();
                                        }
                                    }
                                    else
                                    {
                                        using (MsgBox _msgBox = new MsgBox())
                                        {
                                            string _message = "Girmiş olduğunuz haberleşme adresi ile tanımlı bir makine sistemde zaten ekli. Lütfen haberleşme adresinizi kontrol ediniz.";
                                            string _title = "ADRES UYUŞMAZLIĞI";
                                            _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                                        }
                                    }
                                }
                                else
                                {
                                    using (WaitForm _waitForm = new WaitForm(WriteParametersByModbus, "Ayarlar Makineye İletiliyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                                    {
                                        _mainForm.TopMost = false;
                                        _waitForm.TopMost = true;
                                        _waitForm.ShowDialog();
                                        _mainForm.TopMost = true;
                                        _mainForm.RefreshSystemStatusPanel();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Makine haberleşme adresi 0dan büyük bir değer olmalıdır. Lütfen girmiş olduğunuz haberleşme adresinizi gözden geçiriniz.";
                            string _title = "HABERLEŞME ADRESİ HATASI";
                            _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                        }
                    }
                }
                else
                {
                    using (MsgBox _msgBox = new MsgBox())
                    {
                        string _message = "Bir makine en fazla 3 adet modu aktif olarak kullanabilir. Lütfen makine kurgunuzu gözden geçiriniz.";
                        string _title = "FAZLA AKTİF MOD";
                        _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.Save_Btn_Click -> ", _ex);
            }
        }

        private int GetTotalModCount()
        {
            try
            {
                int _totalActiveModCount = 0;
                if (FoamStatus_TglBtn.Checked)
                {
                    _totalActiveModCount++;
                }
                if (WashStatus_TglBtn.Checked)
                {
                    _totalActiveModCount++;
                }
                if (FoamStatus_TglBtn.Checked)
                {
                    _totalActiveModCount++;
                }
                if (AirStatus_TglBtn.Checked)
                {
                    _totalActiveModCount++;
                }
                if (VacuumStatus_TglBtn.Checked)
                {
                    _totalActiveModCount++;
                }
                if (VarnishStatus_TglBtn.Checked)
                {
                    _totalActiveModCount++;
                }
                return _totalActiveModCount;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.GetTotalModCount -> ", _ex);
                return 0;
            }
        }

        private void WriteParametersByDatabase()
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent is Forms.MainForm)
            {
                Forms.MainForm _mainForm = (Forms.MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent;
                _mainForm.SecondReadingTimer.Change(Timeout.Infinite, Timeout.Infinite);
                _mainForm.SecondsReadingTimerEnabled = false;
                System.Threading.Thread.Sleep(1100);
                try
                {
                    Machine _machine = new Machine();
                    _machine.Alias = Alias_Txt.Texts;
                    _machine.PeriodicMaintenanceHour = Convert.ToInt32(PeriodicMaintenanceHour_Num.Value);
                    _machine.CommunicationAddress = Convert.ToInt32(CommunicationAddress_Num.Value);

                    Constants.Main_ModbusConnection.SlaveId = (byte)_machine.CommunicationAddress;
                    if (Constants.Main_ModbusConnection.Connected)
                    {
                        Constants.Main_ModbusConnection.InputRegisters = Constants.Main_ModbusConnection.Main_ModbusClient.ReadInputRegisters(1, 8);
                        Constants.Main_ModbusConnection.HoldingRegisters = Constants.Main_ModbusConnection.Main_ModbusClient.ReadHoldingRegisters(1, 57);
                        _machine.DeviceStatus = Convert.ToInt32(Constants.Main_ModbusConnection.GetDeviceStatus());
                        _machine.MoneyHopperState = Convert.ToInt32(Constants.Main_ModbusConnection.GetMoneyHopperState());
                        _machine.Version = Constants.Main_ModbusConnection.GetVersion();
                        _machine.StatusesOfOutputs = Constants.Main_ModbusConnection.GetStatusesOfOutputs();
                        _machine.P10Usage = Convert.ToInt32(Constants.Main_ModbusConnection.GetP10Usage());
                        _machine.RestoreFactorySettings = 0;
                        _machine.DeleteDeviceTotals = 0;
                        _machine.CurrentMoney = Constants.Main_ModbusConnection.GetCurrentMoney();
                        _machine.TotalMoney = Constants.Main_ModbusConnection.GetTotalMoney();
                        _machine.AlarmStates = Constants.Main_ModbusConnection.GetAlarmStates();
                        _machine.CurrentTemperature = Constants.Main_ModbusConnection.GetCurrentTemperature();
                        _machine.LowTemperatureAlarm = Constants.Main_ModbusConnection.GetLowTemperatureAlarm();
                        _machine.HighTemperatureAlarm = Constants.Main_ModbusConnection.GetHighTemperatureAlarm();
                        _machine.TemperatureAlarmIsActive = Convert.ToInt32(Constants.Main_ModbusConnection.GetTemperatureAlarmIsActive());
                        _machine.CurrentModeStates = Constants.Main_ModbusConnection.GetCurrentModeStates();
                        _machine.FlowAlarmIsActive = Convert.ToInt32(Constants.Main_ModbusConnection.GetFlowAlarmIsActive());
                        _machine.FlowInitialCalibrationLimit = Constants.Main_ModbusConnection.GetFlowInitialCalibrationLimit();
                        _machine.HighFlowAlarmCount = Constants.Main_ModbusConnection.GetHighFlowAlarmCount();
                        _machine.LowFlowAlarmCount = Constants.Main_ModbusConnection.GetLowFlowAlarmCount();
                        _machine.WashingPrice = Constants.Main_ModbusConnection.GetWashingPrice();
                        _machine.WashingStatus = Convert.ToInt32(Constants.Main_ModbusConnection.GetWashingStatus());
                        _machine.WashingTime = Constants.Main_ModbusConnection.GetWashingTime();
                        _machine.WashingTotalMoney = Constants.Main_ModbusConnection.GetWashingTotalMoney();
                        _machine.WashingTotalTime = Constants.Main_ModbusConnection.GetWashingTotalTime();
                        _machine.FoamPrice = Constants.Main_ModbusConnection.GetFoamPrice();
                        _machine.FoamStatus = Convert.ToInt32(Constants.Main_ModbusConnection.GetFoamStatus());
                        _machine.FoamTime = Constants.Main_ModbusConnection.GetFoamTime();
                        _machine.FoamTotalMoney = Constants.Main_ModbusConnection.GetFoamTotalMoney();
                        _machine.FoamTotalTime = Constants.Main_ModbusConnection.GetFoamTotalTime();
                        _machine.MopPrice = Constants.Main_ModbusConnection.GetMopPrice();
                        _machine.MopStatus = Convert.ToInt32(Constants.Main_ModbusConnection.GetMopStatus());
                        _machine.MopTime = Constants.Main_ModbusConnection.GetMopTime();
                        _machine.MopTotalMoney = Constants.Main_ModbusConnection.GetMopTotalMoney();
                        _machine.MopTotalTime = Constants.Main_ModbusConnection.GetMopTotalTime();
                        _machine.AirmaticPrice = Constants.Main_ModbusConnection.GetAirmaticPrice();
                        _machine.AirmaticStatus = Convert.ToInt32(Constants.Main_ModbusConnection.GetAirmaticStatus());
                        _machine.AirmaticTime = Constants.Main_ModbusConnection.GetAirmaticTime();
                        _machine.AirmaticTotalMoney = Constants.Main_ModbusConnection.GetAirmaticTotalMoney();
                        _machine.AirmaticTotalTime = Constants.Main_ModbusConnection.GetAirmaticTotalTime();
                        _machine.VacuummaticPrice = Constants.Main_ModbusConnection.GetVacuummaticPrice();
                        _machine.VacuummaticStatus = Convert.ToInt32(Constants.Main_ModbusConnection.GetVacuummaticStatus());
                        _machine.VacuummaticTime = Constants.Main_ModbusConnection.GetVacuummaticTime();
                        _machine.VacuummaticTotalMoney = Constants.Main_ModbusConnection.GetVacuummaticTotalMoney();
                        _machine.VacuummaticTotalTime = Constants.Main_ModbusConnection.GetVacuummaticTotalTime();
                        _machine.VarnishPrice = Constants.Main_ModbusConnection.GetVarnishPrice();
                        _machine.VarnishStatus = Convert.ToInt32(Constants.Main_ModbusConnection.GetVarnishStatus());
                        _machine.VarnishTime = Constants.Main_ModbusConnection.GetVarnishTime();
                        _machine.VarnishTotalMoney = Constants.Main_ModbusConnection.GetVarnishTotalMoney();
                        _machine.VarnishTotalTime = Constants.Main_ModbusConnection.GetVarnishTotalTime();
                        _mainForm.SecondReadingTimer.Change(1000, 1000);
                        _mainForm.SecondsReadingTimerEnabled = true;
                        using (DBManager _dbManager = new DBManager())
                        {

                            if (_dbManager.AddMachine(_machine))
                            {
                                List<Machine> _machineList = _dbManager.GetMachineList();
                                if (_machineList != null)
                                {
                                    int _communicationAddress = Convert.ToInt32(CommunicationAddress_Num.Value);
                                    Machine _savedMachine = _machineList.Find(_m => _m.CommunicationAddress == _communicationAddress);
                                    if (_savedMachine != null)
                                    {
                                        Save_Btn.BackColor = Color.FromArgb(25, 160, 60);
                                    }
                                    else
                                    {
                                        Save_Btn.BackColor = Color.FromArgb(230, 90, 90);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception _ex)
                {
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Logger.WriteLog("MachineCreater.WriteParametersByDatabase -> ", _ex);
                }
            }
        }
        private void WriteParametersByModbus()
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent is Forms.MainForm)
            {
                Forms.MainForm _mainForm = (Forms.MainForm)this.Parent.Parent.Parent.Parent.Parent.Parent;
                _mainForm.SecondReadingTimer.Change(Timeout.Infinite, Timeout.Infinite);
                _mainForm.SecondsReadingTimerEnabled = false;
                System.Threading.Thread.Sleep(1100);
                try
                {
                    int _unitIdentifier = Convert.ToInt32(CommunicationAddress_Num.Value);
                    Constants.Main_ModbusConnection.SlaveId = (byte)_unitIdentifier;
                    Constants.Main_ModbusConnection.SetP10Usage(this.P10Usage_TglBtn.Checked);
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
                    WriteParametersByDatabase();
                }
                catch (Exception _ex)
                {
                    _mainForm.SecondReadingTimer.Change(1000, 1000);
                    _mainForm.SecondsReadingTimerEnabled = true;
                    Logger.WriteLog("MachineCreater.WriteParametersByModbus -> ", _ex);
                }
            }
        }
        private void Varnish_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "Varnish_Table")
                {
                    SetBackColorAllPbx();
                    Varnish_Pbx.BackColor = SelectedPbxBtnBackColor;
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(Varnish_Table);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.Varnish_Pbx_Click -> ", _ex);
            }
        }
        private void VarnishStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (VarnishStatus_TglBtn.Checked)
                {
                    VarnishPrice_Num.Enabled = true;
                    VarnishTime_Num.Enabled = true;
                }
                else
                {
                    VarnishPrice_Num.Enabled = false;
                    VarnishTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.VarnishStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void Vacuum_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "Vacuum_Table")
                {
                    SetBackColorAllPbx();
                    Vacuum_Pbx.BackColor = SelectedPbxBtnBackColor;
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(Vacuum_Table);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.Vacuum_Pbx_Click -> ", _ex);
            }
        }
        private void VacuumStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (VacuumStatus_TglBtn.Checked)
                {
                    VacuumPrice_Num.Enabled = true;
                    VacuumTime_Num.Enabled = true;
                }
                else
                {
                    VacuumPrice_Num.Enabled = false;
                    VacuumTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.VacuumStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void Air_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "Air_Table")
                {
                    SetBackColorAllPbx();
                    Air_Pbx.BackColor = SelectedPbxBtnBackColor;
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(Air_Table);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.Air_Pbx_Click -> ", _ex);
            }
        }
        private void AirStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (AirStatus_TglBtn.Checked)
                {
                    AirPrice_Num.Enabled = true;
                    AirTime_Num.Enabled = true;
                }
                else
                {
                    AirPrice_Num.Enabled = false;
                    AirTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.AirStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void Foam_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "Foam_Table")
                {
                    SetBackColorAllPbx();
                    Foam_Pbx.BackColor = SelectedPbxBtnBackColor;
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(Foam_Table);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.Foam_Pbx_Click -> ", _ex);
            }
        }
        private void FoamStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (FoamStatus_TglBtn.Checked)
                {
                    FoamPrice_Num.Enabled = true;
                    FoamTime_Num.Enabled = true;
                }
                else
                {
                    FoamPrice_Num.Enabled = false;
                    FoamTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.FoamStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void Wash_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "Wash_Table")
                {
                    SetBackColorAllPbx();
                    Wash_Pbx.BackColor = SelectedPbxBtnBackColor;
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(Wash_Table);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.Wash_Pbx_Click -> ", _ex);
            }
        }
        private void WashStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (WashStatus_TglBtn.Checked)
                {
                    WashPrice_Num.Enabled = true;
                    WashTime_Num.Enabled = true;
                }
                else
                {
                    WashPrice_Num.Enabled = false;
                    WashTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.WashStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void Mop_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "Mop_Table")
                {
                    SetBackColorAllPbx();
                    Mop_Pbx.BackColor = SelectedPbxBtnBackColor;
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(Mop_Table);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.Mop_Pbx_Click -> ", _ex);
            }
        }
        private void MopStatus_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (MopStatus_TglBtn.Checked)
                {
                    MopPrice_Num.Enabled = true;
                    MopTime_Num.Enabled = true;
                }
                else
                {
                    MopPrice_Num.Enabled = false;
                    MopTime_Num.Enabled = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.MopStatus_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void Machine_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "Machine_Table")
                {
                    SetBackColorAllPbx();
                    Machine_Pbx.BackColor = SelectedPbxBtnBackColor;
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(Machine_Table);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.Machine_Pbx_Click -> ", _ex);
            }
        }
    }
}
