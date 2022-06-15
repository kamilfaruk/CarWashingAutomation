/* Coder by KFY */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Forms
{
    public partial class LogoForm : Form
    {
        public LogoForm()
        {
            try
            {
                InitializeComponent();
                FileStream _stream = File.Open(Application.StartupPath.ToString() + "\\" + Constants.TempDirectory + "\\" + Constants.LogoFormImage, FileMode.Open, FileAccess.Read);
                Image _logoImage = Image.FromStream(_stream);
                if (_logoImage == null)
                {
                    _logoImage = Properties.Resources.Logo_Image;
                }
                _stream.Close();
                this.Logo_Pbx.BackgroundImage = _logoImage;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LogoForm.LogoForm -> ", _ex);
            }
        }
    }
}
