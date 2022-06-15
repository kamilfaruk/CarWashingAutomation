
using CarWashingAutomation.Components;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Controls
{
    partial class AlarmsViewer
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Table = new TableLayoutPanel();
            this.Filter_Table = new TableLayoutPanel();
            this.FilterMachineName_Lbl = new Label();
            this.FilterMachineName_Cbx = new Custom_ComboBox();
            this.FilterStartTime_Lbl = new Label();
            this.FilterStartTime_Dtp = new Custom_DateTimePicker();
            this.FilterStopTime_Lbl = new Label();
            this.FilterStopTime_Dtp = new Custom_DateTimePicker();
            this.Filter_Btn = new Button();
            this.FilterClear_Btn = new Button();
            this.MachineAlarm_Dgv = new Custom_DataGridView();
            this.Id = new DataGridViewTextBoxColumn();
            this.Machine = new DataGridViewTextBoxColumn();
            this.Machine_Id = new DataGridViewTextBoxColumn();
            this.AlarmDate = new DataGridViewTextBoxColumn();
            this.Alarms = new DataGridViewTextBoxColumn();
            this.Main_Table.SuspendLayout();
            ((ISupportInitialize)(this.MachineAlarm_Dgv)).BeginInit();
            this.Filter_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 1;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Filter_Table, 0, 0);
            this.Main_Table.Controls.Add(this.MachineAlarm_Dgv, 0, 1);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            //
            //Filter_Table
            //
            this.Filter_Table.BackColor = Color.Transparent;
            this.Filter_Table.ColumnCount = 8;
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            this.Filter_Table.RowCount = 1;
            this.Filter_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Filter_Table.Controls.Add(this.FilterMachineName_Lbl, 0, 0);
            this.Filter_Table.Controls.Add(this.FilterMachineName_Cbx, 1, 0);
            this.Filter_Table.Controls.Add(this.FilterStartTime_Lbl, 2, 0);
            this.Filter_Table.Controls.Add(this.FilterStartTime_Dtp, 3, 0);
            this.Filter_Table.Controls.Add(this.FilterStopTime_Lbl, 4, 0);
            this.Filter_Table.Controls.Add(this.FilterStopTime_Dtp, 5, 0);
            this.Filter_Table.Controls.Add(this.Filter_Btn, 6, 0);
            this.Filter_Table.Controls.Add(this.FilterClear_Btn, 7, 0);
            this.Filter_Table.Dock = DockStyle.Fill;
            this.Filter_Table.Name = "Filter_Table";
            this.Filter_Table.TabIndex = 1;
            // 
            //FilterMachineName_Lbl
            // 
            this.FilterMachineName_Lbl.Dock = DockStyle.Fill;
            this.FilterMachineName_Lbl.BackColor = Color.Transparent;
            this.FilterMachineName_Lbl.Name = "FilterMachineName_Lbl";
            this.FilterMachineName_Lbl.Text = "Makine:";
            this.FilterMachineName_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.FilterMachineName_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.FilterMachineName_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FilterMachineName_Cbx
            //
            this.FilterMachineName_Cbx.Name = "FilterMachineName_Cbx";
            this.FilterMachineName_Cbx.BackColor = Color.FromArgb(64, 69, 76);
            this.FilterMachineName_Cbx.ForeColor = Color.FromArgb(192, 192, 192);
            this.FilterMachineName_Cbx.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.FilterMachineName_Cbx.Dock = DockStyle.Fill;
            // 
            //FilterStartTime_Lbl
            // 
            this.FilterStartTime_Lbl.Dock = DockStyle.Fill;
            this.FilterStartTime_Lbl.BackColor = Color.Transparent;
            this.FilterStartTime_Lbl.Name = "FilterStartTime_Lbl";
            this.FilterStartTime_Lbl.Text = "Başlngıç:";
            this.FilterStartTime_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.FilterStartTime_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.FilterStartTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FilterStartTime_Dtp
            //
            this.FilterStartTime_Dtp.Dock = DockStyle.Fill;
            this.FilterStartTime_Dtp.Format = DateTimePickerFormat.Short;
            this.FilterStartTime_Dtp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            // 
            //FilterStopTime_Lbl
            // 
            this.FilterStopTime_Lbl.Dock = DockStyle.Fill;
            this.FilterStopTime_Lbl.BackColor = Color.Transparent;
            this.FilterStopTime_Lbl.Name = "FilterStopTime_Lbl";
            this.FilterStopTime_Lbl.Text = "Bitiş:";
            this.FilterStopTime_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.FilterStopTime_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.FilterStopTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FilterStopTime_Dtp
            //
            this.FilterStopTime_Dtp.Dock = DockStyle.Fill;
            this.FilterStopTime_Dtp.Format = DateTimePickerFormat.Short;
            this.FilterStopTime_Dtp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            //
            //Filter_Btn
            //
            this.Filter_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filter_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Filter_Btn.FlatAppearance.BorderSize = 1;
            this.Filter_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Filter_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Filter_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Filter_Btn.Image = Properties.Resources.Save_Image;
            this.Filter_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Filter_Btn.Location = new Point(0, 512);
            this.Filter_Btn.Name = "Filter_Btn";
            this.Filter_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Filter_Btn.Size = new Size(229, 45);
            this.Filter_Btn.TabIndex = 5;
            this.Filter_Btn.Text = "FİLTRELE";
            this.Filter_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Filter_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Filter_Btn.UseVisualStyleBackColor = true;
            this.Filter_Btn.Click += new System.EventHandler(this.Filter_Btn_Click);
            //
            //FilterClear_Btn
            //
            this.FilterClear_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterClear_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.FilterClear_Btn.FlatAppearance.BorderSize = 1;
            this.FilterClear_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.FilterClear_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.FilterClear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterClear_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.FilterClear_Btn.Image = Properties.Resources.Save_Image;
            this.FilterClear_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.FilterClear_Btn.Location = new Point(0, 512);
            this.FilterClear_Btn.Name = "FilterClear_Btn";
            this.FilterClear_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.FilterClear_Btn.Size = new Size(229, 45);
            this.FilterClear_Btn.TabIndex = 5;
            this.FilterClear_Btn.Text = "TEMİZLE";
            this.FilterClear_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.FilterClear_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FilterClear_Btn.UseVisualStyleBackColor = true;
            this.FilterClear_Btn.Click += new System.EventHandler(this.FilterClear_Btn_Click);
            // 
            //MachineAlarm_Dgv
            // 
            this.MachineAlarm_Dgv.Dock = DockStyle.Fill;
            this.MachineAlarm_Dgv.Name = "MachineAlarm_Dgv";
            this.MachineAlarm_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Machine,
            this.Machine_Id,
            this.AlarmDate,
            this.Alarms});
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Machine
            // 
            this.Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Machine.DataPropertyName = "Machine";
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // Machine_Id
            // 
            this.Machine_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Machine_Id.DataPropertyName = "Machine_Id";
            this.Machine_Id.HeaderText = "Machine_Id";
            this.Machine_Id.Name = "Machine_Id";
            this.Machine_Id.ReadOnly = true;
            this.Machine_Id.Visible = false;
            // 
            // AlarmDate
            // 
            this.AlarmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlarmDate.DataPropertyName = "AlarmDate";
            this.AlarmDate.HeaderText = "AlarmDate";
            this.AlarmDate.Name = "AlarmDate";
            this.AlarmDate.ReadOnly = true;
            // 
            // Alarms
            // 
            this.Alarms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alarms.DataPropertyName = "Alarms";
            this.Alarms.HeaderText = "Alarms";
            this.Alarms.Name = "Alarms";
            this.Alarms.ReadOnly = true;
            // 
            // AlarmsViewer
            // 
            components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(800, 600);
            this.Load += AlarmsViewer_Load;
            this.Controls.Add(this.Main_Table);
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Filter_Table.ResumeLayout(false);
            this.Filter_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MachineAlarm_Dgv)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private TableLayoutPanel Filter_Table;
        private Label FilterMachineName_Lbl;
        private Custom_ComboBox FilterMachineName_Cbx;
        private Label FilterStartTime_Lbl;
        private Custom_DateTimePicker FilterStartTime_Dtp;
        private Label FilterStopTime_Lbl;
        private Custom_DateTimePicker FilterStopTime_Dtp;
        private Button Filter_Btn;
        private Button FilterClear_Btn;
        private Custom_DataGridView MachineAlarm_Dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Machine;
        private DataGridViewTextBoxColumn Machine_Id;
        private DataGridViewTextBoxColumn AlarmDate;
        private DataGridViewTextBoxColumn Alarms;
    }
}
