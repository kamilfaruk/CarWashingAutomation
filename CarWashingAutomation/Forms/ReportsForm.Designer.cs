using System;
using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Tools;
namespace CarWashingAutomation.Forms
{
    partial class ReportsForm
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
            this.Main_Table = new TableLayoutPanel();
            this.Close_Btn = new Button();
            this.Alarms_Btn = new Button();
            this.Reports_Btn = new Button();
            this.Viewer_Pnl = new Panel();
            this.Main_AlarmsViewer = new Controls.AlarmsViewer();
            this.Main_ReportsViewer = new Controls.ReportsViewer();
            this.Main_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Table
            // 
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 3;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Main_Table.RowCount = 3;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 33));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 7));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Close_Btn, 0, 0);
            this.Main_Table.Controls.Add(this.Alarms_Btn, 1, 0);
            this.Main_Table.SetRowSpan(this.Alarms_Btn, 2);
            this.Main_Table.Controls.Add(this.Reports_Btn, 2, 0);
            this.Main_Table.SetRowSpan(this.Reports_Btn, 2);
            this.Main_Table.Controls.Add(this.Viewer_Pnl, 0, 2);
            this.Main_Table.SetColumnSpan(this.Viewer_Pnl, 3);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Location = new Point(0, 0);
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.Size = new Size(800, 450);
            this.Main_Table.TabIndex = 0;
            // 
            // Close_Btn
            // 
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Close_Btn.FlatStyle = FlatStyle.Flat;
            this.Close_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            this.Close_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Close_Btn.Location = new Point(0, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new Size(25, 25);
            this.Close_Btn.Image = ((Image)(Properties.Resources.Close_Image));
            this.Close_Btn.ImageAlign = ContentAlignment.MiddleCenter;
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            //          
            //Alarms_Btn
            //
            this.Alarms_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Alarms_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Alarms_Btn.FlatAppearance.BorderSize = 1;
            this.Alarms_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Alarms_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Alarms_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alarms_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Alarms_Btn.Name = "Alarms_Btn";
            this.Alarms_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Alarms_Btn.Text = "ALARMLAR";
            this.Alarms_Btn.TextAlign = ContentAlignment.MiddleCenter;
            this.Alarms_Btn.UseVisualStyleBackColor = true;
            this.Alarms_Btn.Click += new System.EventHandler(this.Alarms_Btn_Click);
            //
            //Reports_Btn
            //
            this.Reports_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reports_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Reports_Btn.FlatAppearance.BorderSize = 1;
            this.Reports_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Reports_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Reports_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Reports_Btn.Name = "Reports_Btn";
            this.Reports_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Reports_Btn.TextAlign = ContentAlignment.MiddleCenter;
            this.Reports_Btn.UseVisualStyleBackColor = true;
            this.Reports_Btn.Text = "RAPORLAR";
            this.Reports_Btn.Click += new System.EventHandler(this.Reports_Btn_Click);
            //
            //Viewer_Pnl
            //
            this.Viewer_Pnl.Dock = DockStyle.Fill;
            //
            //Main_AlarmsViewer
            //
            this.Main_AlarmsViewer.Dock = DockStyle.Fill;
            //
            //Main_ReportsViewer
            //
            this.Main_ReportsViewer.Dock = DockStyle.Fill;
            // 
            //ReportsForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(47, 52, 58);
            this.ClientSize = new Size(870, 457);
            this.Controls.Add(Main_Table);
            this.Text = "ReportsForm";
            this.Name = "ReportsForm";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Button Close_Btn;
        private Button Alarms_Btn;
        private Panel Viewer_Pnl;
        private Controls.AlarmsViewer Main_AlarmsViewer;
        private Button Reports_Btn;
        private Controls.ReportsViewer Main_ReportsViewer;

    }
}