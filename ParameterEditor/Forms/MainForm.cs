/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using ParameterEditor.Components;
using ParameterEditor.Connections;

namespace ParameterEditor.Forms
{
    public partial class MainForm : Form
    {
        private Color SelectedPbxBtnBackColor = Color.FromArgb(64, 69, 76);
        private ModbusConnection Main_ModbusConnection;
        public MainForm()
        {
            try
            {
                InitializeComponent();
                SetAllPbxBackColor();
                Machine_Pbx.BackColor = SelectedPbxBtnBackColor;
                Main_Pnl.Controls.Add(Machine_Table);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.MachineCreater -> ", _ex);
            }
        }
        private void SetAllPbxBackColor()
        {
            try
            {
                Machine_Pbx.BackColor = Color.Transparent;
                Mop_Pbx.BackColor = Color.Transparent;
                Wash_Pbx.BackColor = Color.Transparent;
                Foam_Pbx.BackColor = Color.Transparent;
                Air_Pbx.BackColor = Color.Transparent;
                Vacuum_Pbx.BackColor = Color.Transparent;
                Varnish_Pbx.BackColor = Color.Transparent;
                if (MopStatus_TglBtn.Checked)
                {
                    Mop_Pbx.BackColor = Color.FromArgb(43, 77, 64);
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
                Logger.WriteLog("MachineCreater.SetAllPbxBackColor -> ", _ex);
            }
        }
        int CommunicationAddress;
        private void FetchDate_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                CommunicationAddress = Convert.ToInt32(CommunicationAddress_Num.Value);
                if (Main_ModbusConnection == null)
                {
                    Main_ModbusConnection = new ModbusConnection(CommunicationAddress);
                }
                else
                {
                    Main_ModbusConnection.SlaveId = (byte)CommunicationAddress;
                    Main_ModbusConnection.ReadParameter();
                }
                if (Main_ModbusConnection.Connected)
                {
                    this.P10Usage_TglBtn.Checked = Main_ModbusConnection.GetP10Usage();
                    this.FlowAlarmIsActive_TglBtn.Checked = Main_ModbusConnection.GetFlowAlarmIsActive();
                    this.TemperatureAlarmIsActive_TglBtn.Checked = Main_ModbusConnection.GetTemperatureAlarmIsActive();
                    this.P10Address_Lbl.Text = Main_ModbusConnection.GetP10Address().ToString();
                    this.EmbeddedVersion_Lbl.Text = Main_ModbusConnection.GetVersion().ToString();
                    this.FlowInitialCalibrationLimit_Num.Value = Main_ModbusConnection.GetFlowInitialCalibrationLimit();
                    this.HighFlowAlarmCount_Num.Value = Main_ModbusConnection.GetHighFlowAlarmCount();
                    this.LowFlowAlarmCount_Num.Value = Main_ModbusConnection.GetLowFlowAlarmCount();

                    this.MopStatus_TglBtn.Checked = Main_ModbusConnection.GetMopStatus();
                    this.MopPrice_Num.Value = Main_ModbusConnection.GetMopPrice();
                    this.MopTime_Num.Value = Main_ModbusConnection.GetMopTime();

                    this.WashStatus_TglBtn.Checked = Main_ModbusConnection.GetWashingStatus();
                    this.WashPrice_Num.Value = Main_ModbusConnection.GetWashingPrice();
                    this.WashTime_Num.Value = Main_ModbusConnection.GetWashingTime();

                    this.FoamStatus_TglBtn.Checked = Main_ModbusConnection.GetFoamStatus();
                    this.FoamPrice_Num.Value = Main_ModbusConnection.GetFoamPrice();
                    this.FoamTime_Num.Value = Main_ModbusConnection.GetFoamTime();

                    this.AirStatus_TglBtn.Checked = Main_ModbusConnection.GetAirmaticStatus();
                    this.AirPrice_Num.Value = Main_ModbusConnection.GetAirmaticPrice();
                    this.AirTime_Num.Value = Main_ModbusConnection.GetAirmaticTime();

                    this.VacuumStatus_TglBtn.Checked = Main_ModbusConnection.GetVacuummaticStatus();
                    this.VacuumPrice_Num.Value = Main_ModbusConnection.GetVacuummaticPrice();
                    this.VacuumTime_Num.Value = Main_ModbusConnection.GetVacuummaticTime();

                    this.VarnishStatus_TglBtn.Checked = Main_ModbusConnection.GetVarnishStatus();
                    this.VarnishPrice_Num.Value = Main_ModbusConnection.GetVarnishPrice();
                    this.VarnishTime_Num.Value = Main_ModbusConnection.GetVarnishTime();
                }
                else
                {
                    using (MsgBox _msgBox = new MsgBox())
                    {
                        _msgBox.Show("Ne yazıkki makine kontrol kartı ile bağlantı kurulamadı.", "BAĞLANTI HATASI", MsgBox.Buttons.OK, MsgBox.Icons.Error);
                    }
                }
                SetAllPbxBackColor();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.FetchDate_Btn_Click -> ", _ex);
            }
        }
        private void FactoryReset_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                CommunicationAddress = Convert.ToInt32(CommunicationAddress_Num.Value);
                if (Main_ModbusConnection == null)
                {
                    Main_ModbusConnection = new ModbusConnection(CommunicationAddress);
                }
                else
                {
                    Main_ModbusConnection.SlaveId = (byte)CommunicationAddress;
                    if (Main_ModbusConnection.SetRestoreFactorySettings())
                        Main_ModbusConnection.ReadParameter();
                }
                if (Main_ModbusConnection.Connected)
                {


                    this.P10Usage_TglBtn.Checked = Main_ModbusConnection.GetP10Usage();
                    this.FlowAlarmIsActive_TglBtn.Checked = Main_ModbusConnection.GetFlowAlarmIsActive();
                    this.TemperatureAlarmIsActive_TglBtn.Checked = Main_ModbusConnection.GetTemperatureAlarmIsActive();
                    this.P10Address_Lbl.Text = Main_ModbusConnection.GetP10Address().ToString();
                    this.EmbeddedVersion_Lbl.Text = Main_ModbusConnection.GetVersion().ToString();
                    this.FlowInitialCalibrationLimit_Num.Value = Main_ModbusConnection.GetFlowInitialCalibrationLimit();
                    this.HighFlowAlarmCount_Num.Value = Main_ModbusConnection.GetHighFlowAlarmCount();
                    this.LowFlowAlarmCount_Num.Value = Main_ModbusConnection.GetLowFlowAlarmCount();

                    this.MopStatus_TglBtn.Checked = Main_ModbusConnection.GetMopStatus();
                    this.MopPrice_Num.Value = Main_ModbusConnection.GetMopPrice();
                    this.MopTime_Num.Value = Main_ModbusConnection.GetMopTime();

                    this.WashStatus_TglBtn.Checked = Main_ModbusConnection.GetWashingStatus();
                    this.WashPrice_Num.Value = Main_ModbusConnection.GetWashingPrice();
                    this.WashTime_Num.Value = Main_ModbusConnection.GetWashingTime();

                    this.FoamStatus_TglBtn.Checked = Main_ModbusConnection.GetFoamStatus();
                    this.FoamPrice_Num.Value = Main_ModbusConnection.GetFoamPrice();
                    this.FoamTime_Num.Value = Main_ModbusConnection.GetFoamTime();

                    this.AirStatus_TglBtn.Checked = Main_ModbusConnection.GetAirmaticStatus();
                    this.AirPrice_Num.Value = Main_ModbusConnection.GetAirmaticPrice();
                    this.AirTime_Num.Value = Main_ModbusConnection.GetAirmaticTime();

                    this.VacuumStatus_TglBtn.Checked = Main_ModbusConnection.GetVacuummaticStatus();
                    this.VacuumPrice_Num.Value = Main_ModbusConnection.GetVacuummaticPrice();
                    this.VacuumTime_Num.Value = Main_ModbusConnection.GetVacuummaticTime();

                    this.VarnishStatus_TglBtn.Checked = Main_ModbusConnection.GetVarnishStatus();
                    this.VarnishPrice_Num.Value = Main_ModbusConnection.GetVarnishPrice();
                    this.VarnishTime_Num.Value = Main_ModbusConnection.GetVarnishTime();
                }
                else
                {
                    using (MsgBox _msgBox = new MsgBox())
                    {
                        _msgBox.Show("Ne yazıkki W@shWiz kontrol kartı ile bağlantı kurulamadı.", "BAĞLANTI HATASI", MsgBox.Buttons.OK, MsgBox.Icons.Error);
                    }
                }
                SetAllPbxBackColor();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.FetchDate_Btn_Click -> ", _ex);
            }
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                int _totalActiveModCount = CalculateActiveModCount();
                if (_totalActiveModCount < 4)
                {
                    CommunicationAddress = Convert.ToInt32(CommunicationAddress_Num.Value);
                    if (Main_ModbusConnection != null && Main_ModbusConnection.Connected)
                    {
                        Main_ModbusConnection.SlaveId = (byte)CommunicationAddress;
                        WriteParametersByModbus();
                    }
                    else
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Parametreleri yazabilmek için lütfen ilk olarak makineye bağlanınız.";
                            string _title = "BAĞLANTI HATASI";
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
        private int CalculateActiveModCount()
        {
            try
            {
                int _totalActiveModCount = 0;
                if (MopStatus_TglBtn.Checked)
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
                Logger.WriteLog("MachineCreater.CalculateActiveModCount -> ", _ex);
                return 0;
            }
        }
        private void WriteParametersByModbus()
        {
            try
            {
                int _communicationAddress = Convert.ToInt32(CommunicationAddress_Num.Value);
                if (Main_ModbusConnection == null)
                {
                    Main_ModbusConnection = new ModbusConnection(_communicationAddress);
                }
                Main_ModbusConnection.SlaveId = (byte)CommunicationAddress;
                if (Main_ModbusConnection.Connected)
                {
                    Main_ModbusConnection.SetCommunicationAddress(_communicationAddress);
                }
                Main_ModbusConnection.SlaveId = (byte)_communicationAddress;
                if (Main_ModbusConnection.Connected)
                {
                    CommunicationAddress = _communicationAddress;
                    Main_ModbusConnection.SetP10Usage(this.P10Usage_TglBtn.Checked);
                    Main_ModbusConnection.SetFlowAlarmIsActive(this.FlowAlarmIsActive_TglBtn.Checked);
                    Main_ModbusConnection.SetTemperatureAlarmIsActive(this.TemperatureAlarmIsActive_TglBtn.Checked);
                    Main_ModbusConnection.SetFlowInitialCalibrationLimit(Convert.ToInt32(this.FlowInitialCalibrationLimit_Num.Value));
                    Main_ModbusConnection.SetHighFlowAlarmCount(Convert.ToInt32(this.HighFlowAlarmCount_Num.Value));
                    Main_ModbusConnection.SetLowFlowAlarmCount(Convert.ToInt32(this.LowFlowAlarmCount_Num.Value));

                    Main_ModbusConnection.SetMopStatus(this.MopStatus_TglBtn.Checked);
                    Main_ModbusConnection.SetMopPrice(Convert.ToInt32(this.MopPrice_Num.Value));
                    Main_ModbusConnection.SetMopTime(Convert.ToInt32(this.MopTime_Num.Value));

                    Main_ModbusConnection.SetWashingStatus(this.WashStatus_TglBtn.Checked);
                    Main_ModbusConnection.SetWashingPrice(Convert.ToInt32(this.WashPrice_Num.Value));
                    Main_ModbusConnection.SetWashingTime(Convert.ToInt32(this.WashTime_Num.Value));

                    Main_ModbusConnection.SetFoamStatus(this.FoamStatus_TglBtn.Checked);
                    Main_ModbusConnection.SetFoamPrice(Convert.ToInt32(this.FoamPrice_Num.Value));
                    Main_ModbusConnection.SetFoamTime(Convert.ToInt32(this.FoamTime_Num.Value));

                    Main_ModbusConnection.SetAirmaticStatus(this.AirStatus_TglBtn.Checked);
                    Main_ModbusConnection.SetAirmaticPrice(Convert.ToInt32(this.AirPrice_Num.Value));
                    Main_ModbusConnection.SetAirmaticTime(Convert.ToInt32(this.AirTime_Num.Value));

                    Main_ModbusConnection.SetVacuummaticStatus(this.VacuumStatus_TglBtn.Checked);
                    Main_ModbusConnection.SetVacuummaticPrice(Convert.ToInt32(this.VacuumPrice_Num.Value));
                    Main_ModbusConnection.SetVacuummaticTime(Convert.ToInt32(this.VacuumTime_Num.Value));

                    Main_ModbusConnection.SetVarnishStatus(this.VarnishStatus_TglBtn.Checked);
                    Main_ModbusConnection.SetVarnishPrice(Convert.ToInt32(this.VarnishPrice_Num.Value));
                    Main_ModbusConnection.SetVarnishTime(Convert.ToInt32(this.VarnishTime_Num.Value));
                }
                else
                {
                    using (MsgBox _msgBox = new MsgBox())
                    {
                        _msgBox.Show("Ne yazıkki W@shWiz kontrol kartı ile bağlantı kurulamadı.", "BAĞLANTI HATASI", MsgBox.Buttons.OK, MsgBox.Icons.Error);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineCreater.WriteParametersByModbus -> ", _ex);
            }
        }
        private void Varnish_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "Varnish_Table")
                {
                    SetAllPbxBackColor();
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
                    SetAllPbxBackColor();
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
                    SetAllPbxBackColor();
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
                    SetAllPbxBackColor();
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
                    SetAllPbxBackColor();
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
                    SetAllPbxBackColor();
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
                    SetAllPbxBackColor();
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