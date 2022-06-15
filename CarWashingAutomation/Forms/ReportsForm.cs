/* Coder by KFY */
using System;
using System.Windows.Forms;

namespace CarWashingAutomation.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            try
            {
                InitializeComponent();
                this.Viewer_Pnl.Controls.Add(this.Main_AlarmsViewer);
                this.Reports_Btn.FlatAppearance.BorderSize = 1;
                this.Alarms_Btn.FlatAppearance.BorderSize = 3;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ReportsForm.ReportsForm -> ", _ex);
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
                Logger.WriteLog("ReportsForm.Close_Btn_Click -> ", _ex);
            }
        }
        private void Reports_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Viewer_Pnl.Controls.Contains(this.Main_ReportsViewer))
                {
                    this.Viewer_Pnl.Controls.Clear();
                    this.Viewer_Pnl.Controls.Add(this.Main_ReportsViewer);
                    this.Alarms_Btn.FlatAppearance.BorderSize = 1;
                    this.Reports_Btn.FlatAppearance.BorderSize = 3;

                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ReportsForm.Reports_Btn_Click -> ", _ex);
            }
        }
        private void Alarms_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Viewer_Pnl.Controls.Contains(this.Main_AlarmsViewer))
                {
                    this.Viewer_Pnl.Controls.Clear();
                    this.Viewer_Pnl.Controls.Add(this.Main_AlarmsViewer);
                    this.Reports_Btn.FlatAppearance.BorderSize = 1;
                    this.Alarms_Btn.FlatAppearance.BorderSize = 3;
                }

            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ReportsForm.Alarms_Btn_Click -> ", _ex);
            }
        }
    }
}
