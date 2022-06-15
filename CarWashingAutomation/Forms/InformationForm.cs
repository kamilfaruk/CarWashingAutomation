/* Coder by KFY */
using System;
using System.Windows.Forms;

namespace CarWashingAutomation.Forms
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            try
            {
                InitializeComponent();
                this.BackgroundImage = Properties.Resources.GeneralInformation;
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("InformationForm.InformationForm -> ", _ex);
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
                Logger.WriteLog("InformationForm.Close_Btn_Click -> ", _ex);
            }
        }
    }
}
