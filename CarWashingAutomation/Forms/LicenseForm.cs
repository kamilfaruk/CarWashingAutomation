/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CarWashingAutomation.Components;
using CarWashingAutomation.Tools;

namespace CarWashingAutomation.Forms
{
    public partial class LicenseForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        public bool IsActivated = false;
        public LicenseForm()
        {
            try
            {
                InitializeComponent();
                using (LicenseManager _licenseManager = new LicenseManager())
                {
                    Token_Txt.Text = _licenseManager.GetToken();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseForm.LicenseForm -> ", _ex);
            }
        }
        private void Logo_Pnl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseForm.Logo_Pnl_MouseDown -> ", _ex);
            }
        }
        private void LicenseKey_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (LicenseKey_Txt.Text == "")
                {
                    LicenseKey_Txt.Text = "Lisans Anahtarı";
                    LicenseKey_Txt.ForeColor = Color.Silver;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseForm.LicenseKey_Txt_Leave -> ", _ex);
            }
        }
        private void LicenseKey_Txt_Enter(object sender, EventArgs e)
        {
            try
            {
                if (LicenseKey_Txt.Text == "Lisans Anahtarı")
                {
                    LicenseKey_Txt.Text = "";
                    LicenseKey_Txt.ForeColor = Color.LightGray;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseForm.LicenseKey_Txt_Enter -> ", _ex);
            }
        }
        private void Close_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseForm.Close_Pbx_Click -> ", _ex);
            }
        }
        private void LicenseForm_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseForm.LicenseForm_MouseDown -> ", _ex);
            }
        }
        private void Activate_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LicenseKey_Txt.Text != "" && LicenseKey_Txt.Text != "Lisans Anahtarı")
                {
                    using (LicenseManager _licenseManager = new LicenseManager())
                    {
                        if (_licenseManager.AddLicenseKey(LicenseKey_Txt.Text))
                        {
                            IsActivated = true;
                            this.Close();
                        }
                        else
                        {
                            using (MsgBox _msgBox = new MsgBox())
                            {
                                string _message = "Lütfen programı aktif edebilmek için geçerli bir lisans anahtarı giriniz.";
                                string _header = "LİSANS ANAHTARI GEÇERSİZ";
                                _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Info);
                            }
                        }
                    }
                }
                else
                {
                    using (MsgBox _msgBox = new MsgBox())
                    {
                        string _message = "Lütfen programı aktif edebilmek için bir lisans anahtarı giriniz.";
                        string _header = "LİSANS ANAHTARI GİRİNİZ";
                        _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Info);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseForm.Activate_Btn_Click -> ", _ex);
            }
        }
    }
}
