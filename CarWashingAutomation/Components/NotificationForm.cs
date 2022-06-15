/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Components
{
    public partial class NotificationForm : Form
    {
        private Action action;
        private int x, y;
        public NotificationForm()
        {
            try
            {
                InitializeComponent();
                this.TopMost = true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("NotificationForm.NotificationForm -> ", _ex);
            }
        }
        public enum Action
        {
            wait,
            start,
            close
        }
        private void Waiting_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (this.action)
                {
                    case Action.wait:
                        Waiting_Tmr.Interval = 5000;
                        action = Action.close;
                        break;
                    case NotificationForm.Action.start:
                        this.Waiting_Tmr.Interval = 1;
                        this.Opacity += 0.1;
                        if (this.x < this.Location.X)
                        {
                            this.Left--;
                        }
                        else
                        {
                            if (this.Opacity == 1.0)
                            {
                                action = NotificationForm.Action.wait;
                            }
                        }
                        break;
                    case Action.close:
                        Waiting_Tmr.Interval = 1;
                        this.Opacity -= 0.1;
                        this.Left -= 3;
                        if (base.Opacity == 0.0)
                        {
                            base.Close();
                        }
                        break;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("NotificationForm.Waiting_Tmr_Tick -> ", _ex);
            }
        }
        private void Close_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                Waiting_Tmr.Interval = 1;
                action = Action.close;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("NotificationForm.Close_Pbx_Click -> ", _ex);
            }
        }
        public void ShowNotification(string _message, NotificationType _notificationType)
        {
            try
            {
                this.Opacity = 0.0;
                this.StartPosition = FormStartPosition.Manual;
                string fname;
                for (int i = 1; i < 10; i++)
                {
                    fname = "notification" + i.ToString();
                    NotificationForm frm = (NotificationForm)Application.OpenForms[fname];
                    if (frm == null)
                    {
                        this.Name = fname;
                        this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                        this.Location = new Point(this.x, this.y);
                        break;
                    }
                }
                this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
                switch (_notificationType)
                {
                    case NotificationType.Success:
                        this.NotificationIcon_Pbx.Image = Properties.Resources.Notification_Success;
                        this.BackColor = Color.SeaGreen;
                        break;
                    case NotificationType.Error:
                        this.NotificationIcon_Pbx.Image = Properties.Resources.Notification_Error;
                        this.BackColor = Color.DarkRed;
                        break;
                    case NotificationType.Info:
                        this.NotificationIcon_Pbx.Image = Properties.Resources.Notification_Info;
                        this.BackColor = Color.RoyalBlue;
                        break;
                    case NotificationType.Warning:
                        this.NotificationIcon_Pbx.Image = Properties.Resources.Notification_Warning;
                        this.BackColor = Color.DarkOrange;
                        break;
                }
                this.Message_Lbl.Text = _message;
                this.Show();
                this.action = Action.start;
                this.Waiting_Tmr.Interval = 1;
                this.Waiting_Tmr.Start();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("NotificationForm.ShowNotification -> ", _ex);
            }
        }
    }
}
