/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using LicenseKeyGenerator.Tools;
using LicenseKeyGenerator.Components;

namespace LicenseKeyGenerator
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
                Application.Run(new Forms.MainForm());
                Logger.Write("Uygulama Düzgün Kapatıldı.");
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Uygulama Kritik Bir Hata Nedeni İle Kapandı. Hata: ", _ex);
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Program kritik bir hata kaynaklı kapatıldı.";
                    string _header = "HATA";
                    _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Error);
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
                Initializer.InitializeTempFolder();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Program.ConnectOPCServer -> ", _ex);
            }
        }
    }
}
