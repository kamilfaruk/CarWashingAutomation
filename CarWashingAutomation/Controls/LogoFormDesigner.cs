/* Coder by KFY */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CarWashingAutomation.Tools;

namespace CarWashingAutomation.Controls
{
    public partial class LogoFormDesigner : UserControl
    {
        public LogoFormDesigner()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LogoFormDesigner.LogoFormDesigner -> ", _ex);
            }
        }
        private void LogoFormDesigner_Load(object sender, EventArgs e)
        {
            try
            {
                this.Logo_Pbx.Image = Properties.Resources.UploadLogo_Image;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LogoFormDesigner.LogoFormDesigner_Load -> ", _ex);
            }
        }
        private void Logo_Pbx_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog _file = new OpenFileDialog();
                _file.Filter = "Resim Dosyası |*.jpg; *.png";
                _file.Title = "Logo Seçiniz";
                _file.ShowDialog();
                string _imagePath = _file.FileName;
                string _imageName = _file.SafeFileName;
                using (FileManager _fileManager = new FileManager())
                {
                    _fileManager.Delete(Application.StartupPath.ToString() + "\\" + Constants.TempDirectory + "\\" + Constants.LogoFormImage);
                    _fileManager.Copy(_imagePath, Application.StartupPath.ToString() + "\\" + Constants.TempDirectory + "\\" + Constants.LogoFormImage);
                }
                Logo_Pbx.ImageLocation = _imagePath;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LogoFormDesigner.Logo_Pbx_DoubleClick -> ", _ex);
            }
        }
        private void Logo_Txt_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                Constants.LogoFormMessage = Logo_Txt.Texts;
                Constants.ExportConstantsJson();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LogoFormDesigner.Logo_Txt_TextChanged -> ", _ex);
            }
        }
    }
}
