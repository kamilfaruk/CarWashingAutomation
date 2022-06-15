using System.Drawing;

namespace CarWashingAutomation.Components
{
    partial class NotificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Message_Lbl = new System.Windows.Forms.Label();
            this.NotificationIcon_Pbx = new System.Windows.Forms.PictureBox();
            this.Waiting_Tmr = new System.Windows.Forms.Timer(this.components);
            this.Close_Pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationIcon_Pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Message_Lbl
            // 
            this.Message_Lbl.AutoSize = true;
            this.Message_Lbl.ForeColor = Color.White;
            this.Message_Lbl.Location = new System.Drawing.Point(65, 22);
            this.Message_Lbl.Name = "Message_Lbl";
            this.Message_Lbl.Size = new System.Drawing.Size(116, 21);
            this.Message_Lbl.TabIndex = 0;
            this.Message_Lbl.Text = "Message Text";
            // 
            // NotificationIcon_Pbx
            // 
            this.NotificationIcon_Pbx.Image = Properties.Resources.Notification_Success;
            this.NotificationIcon_Pbx.Location = new System.Drawing.Point(12, 13);
            this.NotificationIcon_Pbx.Name = "pictureBox1";
            this.NotificationIcon_Pbx.Size = new System.Drawing.Size(41, 39);
            this.NotificationIcon_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotificationIcon_Pbx.TabIndex = 2;
            this.NotificationIcon_Pbx.TabStop = false;
            // 
            // timer1
            // 
            this.Waiting_Tmr.Tick += new System.EventHandler(this.Waiting_Tmr_Tick);
            // 
            // Close_Pbx
            // 
            this.Close_Pbx.Image = Properties.Resources.Notification_Close;
            this.Close_Pbx.Location = new System.Drawing.Point(298, 22);
            this.Close_Pbx.Name = "Close_Pbx";
            this.Close_Pbx.Size = new System.Drawing.Size(26, 30);
            this.Close_Pbx.TabIndex = 3;
            this.Close_Pbx.TabStop = false;
            this.Close_Pbx.Click += new System.EventHandler(this.Close_Pbx_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Icon = Properties.Resources.CarWashingAutomation_Icon;
            this.ClientSize = new System.Drawing.Size(347, 74);
            this.Controls.Add(this.Close_Pbx);
            this.Controls.Add(this.NotificationIcon_Pbx);
            this.Controls.Add(this.Message_Lbl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.Text = "Bildirim";
            ((System.ComponentModel.ISupportInitialize)(this.NotificationIcon_Pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label Message_Lbl;
        private System.Windows.Forms.PictureBox NotificationIcon_Pbx;
        internal System.Windows.Forms.Timer Waiting_Tmr;
        private System.Windows.Forms.PictureBox Close_Pbx;
    }
}