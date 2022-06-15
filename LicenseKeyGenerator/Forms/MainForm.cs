/* Coder by KFY */
using System;
using System.Text;
using System.Windows.Forms;
using LicenseKeyGenerator.Tools;

namespace LicenseKeyGenerator.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            try
            {
                InitializeComponent();
                RefreshLicenseRegistrations();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.MainForm -> ", _ex);
            }
        }
        private void Generate_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Token_Txt.Text != "")
                {
                    using (RSACrypter _rsaCrypter = new RSACrypter())
                    {
                        string _mac = _rsaCrypter.Decrypt(Token_Txt.Text);
                        if (_mac != null)
                        {
                            using (Tools.LicenseManager _licenseManager = new Tools.LicenseManager())
                            {
                                int _licenseNumber = GetLicenseNumber() + 1;
                                LicenseKey_Txt.Text = _licenseManager.GetLicenseKey(_licenseNumber, _mac, Convert.ToInt32(ValidityYear_Num.Value));
                                AddLicense(LicenseKey_Txt.Text);
                            }
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Generate_Btn_Click -> ", _ex);
            }
        }
        private int GetLicenseNumber()
        {
            try
            {
                using (FileManager _fm = new FileManager())
                {
                    if (!_fm.FileExists(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations))
                    {
                        _fm.Write(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations, "GEÇMİŞ LİSANS KAYITLARI\n");
                        return 0;
                    }
                    else
                    {
                        StringBuilder _oldLog = _fm.Read(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations);
                        string[] _lastLicenseArray = _oldLog.ToString().Split('\n');
                        string _lastLicense = _lastLicenseArray[_lastLicenseArray.Length - 2];
                        string _licenseNumber = _lastLicense.Split('#')[0];
                        return Convert.ToInt32(_licenseNumber);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.GetLicenseNumber -> ", _ex);
                return 0;
            }
        }
        private void AddLicense(string _licenseKey)
        {
            try
            {
                using (RSACrypter _rsaCrypter = new RSACrypter())
                {
                    string _license = _rsaCrypter.Decrypt(_licenseKey);
                    using (FileManager _fm = new FileManager())
                    {
                        if (!_fm.FileExists(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations))
                        {
                            _fm.Write(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations, "GEÇMİŞ LİSANS KAYITLARI \n");
                        }
                        using (Helper _helper = new Helper())
                        {
                            StringBuilder _oldLog = _fm.Read(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations);
                            _oldLog.AppendLine(_license);
                            _fm.Write(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations, _oldLog.ToString());
                        }
                    }
                }
                RefreshLicenseRegistrations();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.AddLicense -> ", _ex);
            }
        }
        private void RefreshLicenseRegistrations()
        {
            try
            {
                using (FileManager _fm = new FileManager())
                {
                    if (!_fm.FileExists(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations))
                    {
                        _fm.Write(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations, "GEÇMİŞ LİSANS KAYITLARI \n");
                    }
                    using (Helper _helper = new Helper())
                    {
                        StringBuilder _oldLog = _fm.Read(Application.StartupPath.ToString() + "\\" + Constants.LicenseRegistrations);
                        LicenseRegistrations_Txt.Text = _oldLog.ToString();
                        LicenseRegistrations_Txt.SelectionStart = LicenseRegistrations_Txt.Text.Length;
                        LicenseRegistrations_Txt.ScrollToCaret();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.AddLicense -> ", _ex);
            }
        }
    }
}
