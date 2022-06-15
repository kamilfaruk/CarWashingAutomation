/* Coder by KFY */
using System;
using System.Windows.Forms;
using CarWashingAutomation.Controls;

namespace CarWashingAutomation.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            try
            {
                InitializeComponent();
                MachineCreater _machineCreater = new MachineCreater();
                _machineCreater.Name = "MachineCreater";
                _machineCreater.Dock = DockStyle.Fill;
                Main_Pnl.Controls.Add(_machineCreater);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SettingsForm.SettingsForm -> ", _ex);
            }
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SettingsForm.Close_Btn_Click -> ", _ex);
            }
        }
        private void LogoFormDesigner_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "LogoFormDesigner")
                {
                    LogoFormDesigner _logoFormDesigner = new LogoFormDesigner();
                    _logoFormDesigner.Name = "LogoFormDesigner";
                    _logoFormDesigner.Dock = DockStyle.Fill;
                    foreach (Control _control in Main_Pnl.Controls)
                    {
                        _control.Dispose();
                    }
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(_logoFormDesigner);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SettingsForm.LogoFormDesigner_Btn_Click -> ", _ex);
            }
        }
        private void MachineCreater_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "MachineCreater")
                {
                    MachineCreater _machineCreater = new MachineCreater();
                    _machineCreater.Name = "MachineCreater";
                    _machineCreater.Dock = DockStyle.Fill;
                    foreach (Control _control in Main_Pnl.Controls)
                    {
                        _control.Dispose();
                    }
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(_machineCreater);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SettingsForm.MachineCreater_Btn_Click -> ", _ex);
            }
        }
        private void UserManagement_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "UserManagement")
                {
                    UserManagement _userManagement = new UserManagement();
                    _userManagement.Name = "UserManagement";
                    _userManagement.Dock = DockStyle.Fill;
                    foreach (Control _control in Main_Pnl.Controls)
                    {
                        _control.Dispose();
                    }
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(_userManagement);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SettingsForm.UserManagement_Btn_Click -> ", _ex);
            }
        }
        private void SoftwareConstants_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Pnl.Controls[0].Name != "SoftwareConstants")
                {
                    SoftwareConstants _softwareConstants = new SoftwareConstants();
                    _softwareConstants.Name = "SoftwareConstants";
                    _softwareConstants.Dock = DockStyle.Fill;
                    foreach (Control _control in Main_Pnl.Controls)
                    {
                        _control.Dispose();
                    }
                    Main_Pnl.Controls.Clear();
                    Main_Pnl.Controls.Add(_softwareConstants);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SettingsForm.SoftwareConstants_Btn_Click -> ", _ex);
            }
        }
    }
}
