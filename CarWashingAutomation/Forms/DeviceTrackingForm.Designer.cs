using System.Drawing;
using System.Windows.Forms;
namespace CarWashingAutomation.Forms
{
    partial class DeviceTrackingForm
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
            this.Main_Pnl = new Panel();
            this.Main_Table.SuspendLayout();
            this.Main_Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Table
            // 
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 33));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Close_Btn, 0, 0);
            this.Main_Table.Controls.Add(this.Main_Pnl, 1, 1);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Location = new Point(0, 0);
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.Size = new Size(800, 450);
            this.Main_Table.TabIndex = 0;
            // 
            // Main_Pnl
            // 
            this.Main_Pnl.Dock = DockStyle.Fill;
            this.Main_Pnl.AutoScroll = false;
            this.Main_Pnl.HorizontalScroll.Enabled = false;
            this.Main_Pnl.HorizontalScroll.Visible = false;
            this.Main_Pnl.HorizontalScroll.Maximum = 0;
            this.Main_Pnl.AutoScroll = true;
            this.Main_Pnl.Text = "Main_Pnl";
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
            //DeviceTrackingForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(47, 52, 58);
            this.ClientSize = new Size(870, 457);
            this.Controls.Add(Main_Table);
            this.Load += DeviceTrackingForm_Load;
            this.Text = "DeviceTrackingForm";
            this.Name = "DeviceTrackingForm";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Main_Pnl.ResumeLayout(false);
            this.Main_Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Button Close_Btn;
        private Panel Main_Pnl;
    }
}