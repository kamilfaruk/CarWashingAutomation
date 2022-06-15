/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Forms;
using CarWashingAutomation.Tools;
using CarWashingAutomation.Components;

namespace CarWashingAutomation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {

                Logger.Write("Uygulama Başlatıldı.");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using (WaitForm _waitForm = new WaitForm(InitializeProgram, "Program Başlatılıyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                {
                    _waitForm.ShowDialog();
                }
                Application.Run(new MainForm());
                Logger.Write("Uygulama Düzgün Kapatıldı.");
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Uygulama Kritik Bir Hata Nedeni İle Kapandı. Hata: ", _ex);
                using (MsgBox _msgBox = new MsgBox())
                {
                    _msgBox.Show("Uygulama kritik bir hatadan dolayı kapatıldı.", "KRİTİK HATA", MsgBox.Buttons.OK, MsgBox.Icons.Error);
                }
            }
            finally
            {
                Logger.ExportLog();
            }
        }
        private static void InitializeProgram()
        {
            try
            {
                Initializer.ChackTempFolder();
                System.Threading.Thread.Sleep(500);
                using (LicenseManager _licenseManager = new LicenseManager())
                {
                    if (!_licenseManager.ChackLicense())
                    {
                        if (!_licenseManager.ChackLicense())
                        {
                            if (!_licenseManager.ChackLicense())
                            {
                                LicenseForm _licenseForm = new LicenseForm();
                                _licenseForm.ShowDialog();
                                if (!_licenseForm.IsActivated)
                                {
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                }
                System.Threading.Thread.Sleep(500);      
                Initializer.InitializeConstants();
                System.Threading.Thread.Sleep(500);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Program.ConnectOPCServer -> ", _ex);
            }
        }
    }
}
