using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Tools;
namespace CarWashingAutomation.Forms
{
    partial class SettingsForm
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
            this.TabButtons_Table = new TableLayoutPanel();
            this.MachineCreater_Btn = new Button();
            this.UserManagement_Btn = new Button();
            this.LogoFormDesigner_Btn = new Button();
            this.SoftwareConstants_Btn = new Button();
            this.Main_Pnl = new Panel();
            this.Main_Table.SuspendLayout();
            this.TabButtons_Table.SuspendLayout();
            this.Main_Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Table
            // 
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Main_Table.RowCount = 3;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 33));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 7));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Close_Btn, 0, 0);
            this.Main_Table.Controls.Add(this.TabButtons_Table, 1, 0);
            this.Main_Table.SetRowSpan(this.TabButtons_Table, 2);
            this.Main_Table.Controls.Add(this.Main_Pnl, 0, 2);
            this.Main_Table.SetColumnSpan(this.Main_Pnl, 2);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            // TabButtons_Table
            // 
            this.TabButtons_Table.ColumnCount = 4;
            this.TabButtons_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.TabButtons_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.TabButtons_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.TabButtons_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.TabButtons_Table.RowCount = 1;
            this.TabButtons_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.TabButtons_Table.Controls.Add(this.MachineCreater_Btn, 0, 0);
            this.TabButtons_Table.Controls.Add(this.UserManagement_Btn, 1, 0);
            this.TabButtons_Table.Controls.Add(this.LogoFormDesigner_Btn, 2, 0);
            this.TabButtons_Table.Controls.Add(this.SoftwareConstants_Btn, 3, 0);
            this.TabButtons_Table.Dock = DockStyle.Fill;
            this.TabButtons_Table.Name = "Main_Table";
            //
            //MachineCreater_Btn
            //
            this.MachineCreater_Btn.Dock = DockStyle.Fill;
            this.MachineCreater_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.MachineCreater_Btn.FlatAppearance.BorderSize = 1;
            this.MachineCreater_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.MachineCreater_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.MachineCreater_Btn.FlatStyle = FlatStyle.Flat;
            this.MachineCreater_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.MachineCreater_Btn.Name = "MachineCreater_Btn";
            this.MachineCreater_Btn.Padding = new Padding(5, 0, 0, 0);
            this.MachineCreater_Btn.TextAlign = ContentAlignment.MiddleCenter;
            this.MachineCreater_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            this.MachineCreater_Btn.Text = "Makine Ekle";
            this.MachineCreater_Btn.UseVisualStyleBackColor = true;
            this.MachineCreater_Btn.Click += new System.EventHandler(this.MachineCreater_Btn_Click);
            //
            //UserManagement_Btn
            //
            this.UserManagement_Btn.Dock = DockStyle.Fill;
            this.UserManagement_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.UserManagement_Btn.FlatAppearance.BorderSize = 1;
            this.UserManagement_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.UserManagement_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.UserManagement_Btn.FlatStyle = FlatStyle.Flat;
            this.UserManagement_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.UserManagement_Btn.Name = "UserManagement_Btn";
            this.UserManagement_Btn.Padding = new Padding(5, 0, 0, 0);
            this.UserManagement_Btn.TextAlign = ContentAlignment.MiddleCenter;
            this.UserManagement_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            this.UserManagement_Btn.Text = "Kullanıcılar";
            this.UserManagement_Btn.UseVisualStyleBackColor = true;
            this.UserManagement_Btn.Click += new System.EventHandler(this.UserManagement_Btn_Click);
            //
            //LogoFormDesigner_Btn
            //
            this.LogoFormDesigner_Btn.Dock = DockStyle.Fill;
            this.LogoFormDesigner_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.LogoFormDesigner_Btn.FlatAppearance.BorderSize = 1;
            this.LogoFormDesigner_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.LogoFormDesigner_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.LogoFormDesigner_Btn.FlatStyle = FlatStyle.Flat;
            this.LogoFormDesigner_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.LogoFormDesigner_Btn.Name = "LogoFormDesigner_Btn";
            this.LogoFormDesigner_Btn.Padding = new Padding(5, 0, 0, 0);
            this.LogoFormDesigner_Btn.TextAlign = ContentAlignment.MiddleCenter;
            this.LogoFormDesigner_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            this.LogoFormDesigner_Btn.Text = "Logo ve Şirket";
            this.LogoFormDesigner_Btn.UseVisualStyleBackColor = true;
            this.LogoFormDesigner_Btn.Click += new System.EventHandler(this.LogoFormDesigner_Btn_Click);
            //
            //SoftwareConstants_Btn
            //
            this.SoftwareConstants_Btn.Dock = DockStyle.Fill;
            this.SoftwareConstants_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.SoftwareConstants_Btn.FlatAppearance.BorderSize = 1;
            this.SoftwareConstants_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.SoftwareConstants_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.SoftwareConstants_Btn.FlatStyle = FlatStyle.Flat;
            this.SoftwareConstants_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.SoftwareConstants_Btn.Name = "SoftwareConstants_Btn";
            this.SoftwareConstants_Btn.Padding = new Padding(5, 0, 0, 0);
            this.SoftwareConstants_Btn.TextAlign = ContentAlignment.MiddleCenter;
            this.SoftwareConstants_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            this.SoftwareConstants_Btn.Text = "Yazılım Sabitleri";
            this.SoftwareConstants_Btn.UseVisualStyleBackColor = true;
            this.SoftwareConstants_Btn.Click += new System.EventHandler(this.SoftwareConstants_Btn_Click);
            //
            //Main_Pnl
            //
            this.Main_Pnl.Dock = DockStyle.Fill;
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
            //SettingsForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(47, 52, 58);
            this.ClientSize = new Size(870, 457);
            this.Controls.Add(Main_Table);
            this.Text = "SettingsForm";
            this.Name = "SettingsForm";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.TabButtons_Table.ResumeLayout(false);
            this.TabButtons_Table.PerformLayout();
            this.Main_Pnl.ResumeLayout(false);
            this.Main_Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private TableLayoutPanel Main_Table;
        private Button Close_Btn;
        private TableLayoutPanel TabButtons_Table;
        private Button MachineCreater_Btn;
        private Button UserManagement_Btn;
        private Button LogoFormDesigner_Btn;
        private Button SoftwareConstants_Btn;
        private Panel Main_Pnl;
    }
}