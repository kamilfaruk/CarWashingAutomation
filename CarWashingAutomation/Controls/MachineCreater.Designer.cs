using System;
using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Components;
using CarWashingAutomation.Tools;
namespace CarWashingAutomation.Controls
{
    partial class MachineCreater
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
            this.Buttons_Table = new TableLayoutPanel();
            this.Machine_Pbx = new PictureBox();
            this.Mop_Pbx = new PictureBox();
            this.Wash_Pbx = new PictureBox();
            this.Foam_Pbx = new PictureBox();
            this.Air_Pbx = new PictureBox();
            this.Vacuum_Pbx = new PictureBox();
            this.Varnish_Pbx = new PictureBox();
            this.Main_Pnl = new Panel();
            this.Save_Btn = new Button();
            this.Machine_Table = new TableLayoutPanel();
            this.Alias_Lbl = new Label();
            this.Alias_Txt = new Custom_TextBox();
            this.PeriodicMaintenanceHour_Lbl = new Label();
            this.PeriodicMaintenanceHour_Num = new NumericUpDown();
            this.CommunicationAddress_Lbl = new Label();
            this.CommunicationAddress_Num = new NumericUpDown();
            this.FetchDate_Btn = new Button();
            this.P10Usage_Lbl = new Label();
            this.P10Usage_TglBtn = new Custom_ToggleButton();
            this.TemperatureAlarmIsActive_Lbl = new Label();
            this.TemperatureAlarmIsActive_TglBtn = new Custom_ToggleButton();
            this.LowTemperatureAlarm_Lbl = new Label();
            this.LowTemperatureAlarm_Num = new NumericUpDown();
            this.HighTemperatureAlarm_Lbl = new Label();
            this.HighTemperatureAlarm_Num = new NumericUpDown();
            this.FlowAlarmIsActive_Lbl = new Label();
            this.FlowAlarmIsActive_TglBtn = new Custom_ToggleButton();
            this.FlowInitialCalibrationLimit_Lbl = new Label();
            this.FlowInitialCalibrationLimit_Num = new NumericUpDown();
            this.HighFlowAlarmCount_Lbl = new Label();
            this.HighFlowAlarmCount_Num = new NumericUpDown();
            this.LowFlowAlarmCount_Lbl = new Label();
            this.LowFlowAlarmCount_Num = new NumericUpDown();
            this.Mop_Table = new TableLayoutPanel();
            this.Mop_Lbl = new Label();
            this.MopStatus_TglBtn = new Custom_ToggleButton();
            this.MopPrice_Lbl = new Label();
            this.MopPrice_Num = new NumericUpDown();
            this.MopTime_Lbl = new Label();
            this.MopTime_Num = new NumericUpDown();
            this.Wash_Table = new TableLayoutPanel();
            this.Wash_Lbl = new Label();
            this.WashStatus_TglBtn = new Custom_ToggleButton();
            this.WashPrice_Lbl = new Label();
            this.WashPrice_Num = new NumericUpDown();
            this.WashTime_Lbl = new Label();
            this.WashTime_Num = new NumericUpDown();
            this.Foam_Table = new TableLayoutPanel();
            this.Foam_Lbl = new Label();
            this.FoamStatus_TglBtn = new Custom_ToggleButton();
            this.FoamPrice_Lbl = new Label();
            this.FoamPrice_Num = new NumericUpDown();
            this.FoamTime_Lbl = new Label();
            this.FoamTime_Num = new NumericUpDown();
            this.Air_Table = new TableLayoutPanel();
            this.Air_Lbl = new Label();
            this.AirStatus_TglBtn = new Custom_ToggleButton();
            this.AirPrice_Lbl = new Label();
            this.AirPrice_Num = new NumericUpDown();
            this.AirTime_Lbl = new Label();
            this.AirTime_Num = new NumericUpDown();
            this.Vacuum_Table = new TableLayoutPanel();
            this.Vacuum_Lbl = new Label();
            this.VacuumStatus_TglBtn = new Custom_ToggleButton();
            this.VacuumPrice_Lbl = new Label();
            this.VacuumPrice_Num = new NumericUpDown();
            this.VacuumTime_Lbl = new Label();
            this.VacuumTime_Num = new NumericUpDown();
            this.Varnish_Table = new TableLayoutPanel();
            this.Varnish_Lbl = new Label();
            this.VarnishStatus_TglBtn = new Custom_ToggleButton();
            this.VarnishPrice_Lbl = new Label();
            this.VarnishPrice_Num = new NumericUpDown();
            this.VarnishTime_Lbl = new Label();
            this.VarnishTime_Num = new NumericUpDown();
            //
            this.Main_Table.SuspendLayout();
            this.Buttons_Table.SuspendLayout();
            this.Main_Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Table
            // 
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            this.Main_Table.Controls.Add(this.Buttons_Table, 0, 0);
            this.Main_Table.Controls.Add(this.Main_Pnl, 1, 0);
            this.Main_Table.Controls.Add(this.Save_Btn, 0, 1);
            this.Main_Table.SetColumnSpan(this.Save_Btn, 2);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            // Buttons_Table
            // 
            this.Buttons_Table.ColumnCount = 1;
            this.Buttons_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Buttons_Table.RowCount = 7;
            this.Buttons_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Buttons_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Buttons_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Buttons_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Buttons_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Buttons_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Buttons_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Buttons_Table.Controls.Add(this.Machine_Pbx, 0, 0);
            this.Buttons_Table.Controls.Add(this.Mop_Pbx, 0, 1);
            this.Buttons_Table.Controls.Add(this.Wash_Pbx, 0, 2);
            this.Buttons_Table.Controls.Add(this.Foam_Pbx, 0, 3);
            this.Buttons_Table.Controls.Add(this.Air_Pbx, 0, 4);
            this.Buttons_Table.Controls.Add(this.Vacuum_Pbx, 0, 5);
            this.Buttons_Table.Controls.Add(this.Varnish_Pbx, 0, 6);
            this.Buttons_Table.Dock = DockStyle.Fill;
            this.Buttons_Table.Name = "Main_Table";
            //
            //Machine_Pbx
            //
            this.Machine_Pbx.Dock = DockStyle.Fill;
            this.Machine_Pbx.TabStop = false;
            this.Machine_Pbx.BackgroundImageLayout = ImageLayout.Zoom;
            this.Machine_Pbx.BackgroundImage = Properties.Resources.Machine_Image;
            this.Machine_Pbx.Click += Machine_Pbx_Click;
            //
            //Mop_Pbx
            //
            this.Mop_Pbx.Dock = DockStyle.Fill;
            this.Mop_Pbx.TabStop = false;
            this.Mop_Pbx.BackgroundImageLayout = ImageLayout.Zoom;
            this.Mop_Pbx.BackgroundImage = Properties.Resources.Mop_Image;
            this.Mop_Pbx.Click += Mop_Pbx_Click;
            //
            //Wash_Pbx
            //
            this.Wash_Pbx.Dock = DockStyle.Fill;
            this.Wash_Pbx.TabStop = false;
            this.Wash_Pbx.BackgroundImageLayout = ImageLayout.Zoom;
            this.Wash_Pbx.BackgroundImage = Properties.Resources.Wash_Image;
            this.Wash_Pbx.Click += Wash_Pbx_Click;
            //
            //Foam_Pbx
            //
            this.Foam_Pbx.Dock = DockStyle.Fill;
            this.Foam_Pbx.TabStop = false;
            this.Foam_Pbx.BackgroundImageLayout = ImageLayout.Zoom;
            this.Foam_Pbx.BackgroundImage = Properties.Resources.Foam_Image;
            this.Foam_Pbx.Click += Foam_Pbx_Click;
            //
            //Air_Pbx
            //
            this.Air_Pbx.Dock = DockStyle.Fill;
            this.Air_Pbx.TabStop = false;
            this.Air_Pbx.BackgroundImageLayout = ImageLayout.Zoom;
            this.Air_Pbx.BackgroundImage = Properties.Resources.Air_Image;
            this.Air_Pbx.Click += Air_Pbx_Click;
            //
            //Vacuum_Pbx
            //
            this.Vacuum_Pbx.Dock = DockStyle.Fill;
            this.Vacuum_Pbx.TabStop = false;
            this.Vacuum_Pbx.BackgroundImageLayout = ImageLayout.Zoom;
            this.Vacuum_Pbx.BackgroundImage = Properties.Resources.Vacuum_Image;
            this.Vacuum_Pbx.Click += Vacuum_Pbx_Click;
            //                                          
            //Varnish_Pbx
            //
            this.Varnish_Pbx.Dock = DockStyle.Fill;
            this.Varnish_Pbx.TabStop = false;
            this.Varnish_Pbx.BackgroundImageLayout = ImageLayout.Zoom;
            this.Varnish_Pbx.BackgroundImage = Properties.Resources.Varnish_Image;
            this.Varnish_Pbx.Click += Varnish_Pbx_Click;
            //
            //Main_Pnl
            //
            this.Main_Pnl.Dock = DockStyle.Fill;
            //
            //Machine_Table
            //
            this.Machine_Table.ColumnCount = 5;
            this.Machine_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Machine_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250));
            this.Machine_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75));
            this.Machine_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175));
            this.Machine_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Machine_Table.RowCount = 13;
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Machine_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Machine_Table.Controls.Add(this.Alias_Lbl, 1, 1);
            this.Machine_Table.Controls.Add(this.Alias_Txt, 2, 1);
            this.Machine_Table.SetColumnSpan(this.Alias_Txt, 2);
            this.Machine_Table.Controls.Add(this.PeriodicMaintenanceHour_Lbl, 1, 2);
            this.Machine_Table.Controls.Add(this.PeriodicMaintenanceHour_Num, 2, 2);
            this.Machine_Table.Controls.Add(this.CommunicationAddress_Lbl, 1, 3);
            this.Machine_Table.Controls.Add(this.CommunicationAddress_Num, 2, 3);
            this.Machine_Table.Controls.Add(this.FetchDate_Btn, 3, 3);
            this.Machine_Table.Controls.Add(this.P10Usage_Lbl, 1, 4);
            this.Machine_Table.Controls.Add(this.P10Usage_TglBtn, 2, 4);
            this.Machine_Table.Controls.Add(this.TemperatureAlarmIsActive_Lbl, 1, 5);
            this.Machine_Table.Controls.Add(this.TemperatureAlarmIsActive_TglBtn, 2, 5);
            this.Machine_Table.Controls.Add(this.LowTemperatureAlarm_Lbl, 1, 6);
            this.Machine_Table.Controls.Add(this.LowTemperatureAlarm_Num, 2, 6);
            this.Machine_Table.Controls.Add(this.HighTemperatureAlarm_Lbl, 1, 7);
            this.Machine_Table.Controls.Add(this.HighTemperatureAlarm_Num, 2, 7);
            this.Machine_Table.Controls.Add(this.FlowAlarmIsActive_Lbl, 1, 8);
            this.Machine_Table.Controls.Add(this.FlowAlarmIsActive_TglBtn, 2, 8);
            this.Machine_Table.Controls.Add(this.FlowInitialCalibrationLimit_Lbl, 1, 9);
            this.Machine_Table.Controls.Add(this.FlowInitialCalibrationLimit_Num, 2, 9);
            this.Machine_Table.Controls.Add(this.HighFlowAlarmCount_Lbl, 1, 10);
            this.Machine_Table.Controls.Add(this.HighFlowAlarmCount_Num, 2, 10);
            this.Machine_Table.Controls.Add(this.LowFlowAlarmCount_Lbl, 1, 11);
            this.Machine_Table.Controls.Add(this.LowFlowAlarmCount_Num, 2, 11);
            this.Machine_Table.Dock = DockStyle.Fill;
            this.Machine_Table.Name = "Machine_Table";
            //
            //Alias_Lbl
            //
            this.Alias_Lbl.Dock = DockStyle.Fill;
            this.Alias_Lbl.BackColor = Color.Transparent;
            this.Alias_Lbl.Name = "Alias_Lbl";
            this.Alias_Lbl.Text = "Makine Adı: ";
            this.Alias_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Alias_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.Alias_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //Alias_Txt
            //
            this.Alias_Txt.AutoSize = true;
            this.Alias_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.Alias_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            this.Alias_Txt.Name = "Alias_Txt";
            this.Alias_Txt.Dock = DockStyle.Fill;
            this.Alias_Txt.TabIndex = 2;
            this.Alias_Txt.TextAlign = HorizontalAlignment.Left;
            this.Alias_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Alias_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Alias_Txt.UnderlinedStyle = true;
            //
            //PeriodicMaintenanceHour_Lbl
            //
            this.PeriodicMaintenanceHour_Lbl.Dock = DockStyle.Fill;
            this.PeriodicMaintenanceHour_Lbl.BackColor = Color.Transparent;
            this.PeriodicMaintenanceHour_Lbl.Name = "PeriodicMaintenanceHour_Lbl";
            this.PeriodicMaintenanceHour_Lbl.Text = "Periyodik Bakım Saati: ";
            this.PeriodicMaintenanceHour_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PeriodicMaintenanceHour_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.PeriodicMaintenanceHour_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //PeriodicMaintenanceHour_Num
            //
            this.PeriodicMaintenanceHour_Num.Name = "PeriodicMaintenanceHour_Num";
            this.PeriodicMaintenanceHour_Num.Dock = DockStyle.Fill;
            this.PeriodicMaintenanceHour_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.PeriodicMaintenanceHour_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.PeriodicMaintenanceHour_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.PeriodicMaintenanceHour_Num.Minimum =1;
            this.PeriodicMaintenanceHour_Num.Maximum = 8760;
            //
            //CommunicationAddress_Lbl
            //
            this.CommunicationAddress_Lbl.Dock = DockStyle.Fill;
            this.CommunicationAddress_Lbl.BackColor = Color.Transparent;
            this.CommunicationAddress_Lbl.Name = "CommunicationAddress_Lbl";
            this.CommunicationAddress_Lbl.Text = "Makine Haberleşme Adresi: ";
            this.CommunicationAddress_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CommunicationAddress_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.CommunicationAddress_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //CommunicationAddress_Num
            //
            this.CommunicationAddress_Num.Name = "CommunicationAddress_Num";
            this.CommunicationAddress_Num.Dock = DockStyle.Fill;
            this.CommunicationAddress_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.CommunicationAddress_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.CommunicationAddress_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.CommunicationAddress_Num.Minimum = 0;
            this.CommunicationAddress_Num.Maximum = 247;

            //
            //FetchDate_Btn
            //
            this.FetchDate_Btn.Dock = DockStyle.Fill;
            this.FetchDate_Btn.Dock = DockStyle.Fill;
            this.FetchDate_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.FetchDate_Btn.FlatAppearance.BorderSize = 1;
            this.FetchDate_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.FetchDate_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.FetchDate_Btn.FlatStyle = FlatStyle.Flat;
            this.FetchDate_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.FetchDate_Btn.Name = "FetchDate_Btn";
            this.FetchDate_Btn.Padding = new Padding(5, 0, 0, 0);
            this.FetchDate_Btn.TextAlign = ContentAlignment.MiddleCenter;
            this.FetchDate_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            this.FetchDate_Btn.Text = "VARSAYILAN GETİR";
            this.FetchDate_Btn.UseVisualStyleBackColor = true;
            this.FetchDate_Btn.Click += new System.EventHandler(this.FetchDate_Btn_Click);
            //
            //P10Usage_Lbl
            //
            this.P10Usage_Lbl.Dock = DockStyle.Fill;
            this.P10Usage_Lbl.BackColor = Color.Transparent;
            this.P10Usage_Lbl.Name = "P10Usage_Lbl";
            this.P10Usage_Lbl.Text = "Led Ekram Drumu: ";
            this.P10Usage_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.P10Usage_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.P10Usage_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //P10Usage_TglBtn
            //
            this.P10Usage_TglBtn.Dock = DockStyle.Fill;
            this.P10Usage_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.P10Usage_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.P10Usage_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.P10Usage_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.P10Usage_TglBtn.Checked = false;
            //
            //TemperatureAlarmIsActive_Lbl
            //
            this.TemperatureAlarmIsActive_Lbl.Dock = DockStyle.Fill;
            this.TemperatureAlarmIsActive_Lbl.BackColor = Color.Transparent;
            this.TemperatureAlarmIsActive_Lbl.Name = "TemperatureAlarmIsActive_Lbl";
            this.TemperatureAlarmIsActive_Lbl.Text = "Ortam Sıcaklık Alarm Durumu: ";
            this.TemperatureAlarmIsActive_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TemperatureAlarmIsActive_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.TemperatureAlarmIsActive_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //TemperatureAlarmIsActive_TglBtn
            //
            this.TemperatureAlarmIsActive_TglBtn.Dock = DockStyle.Fill;
            this.TemperatureAlarmIsActive_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.TemperatureAlarmIsActive_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.TemperatureAlarmIsActive_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.TemperatureAlarmIsActive_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.TemperatureAlarmIsActive_TglBtn.Checked = false;
            //
            //LowTemperatureAlarm_Lbl
            //
            this.LowTemperatureAlarm_Lbl.Dock = DockStyle.Fill;
            this.LowTemperatureAlarm_Lbl.BackColor = Color.Transparent;
            this.LowTemperatureAlarm_Lbl.Name = "LowTemperatureAlarm_Lbl";
            this.LowTemperatureAlarm_Lbl.Text = "Ortam Sıcaklığı Alarm Alt Değeri: ";
            this.LowTemperatureAlarm_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LowTemperatureAlarm_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.LowTemperatureAlarm_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //LowTemperatureAlarm_Num
            //
            this.LowTemperatureAlarm_Num.Name = "LowTemperatureAlarm_Num";
            this.LowTemperatureAlarm_Num.Dock = DockStyle.Fill;
            this.LowTemperatureAlarm_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.LowTemperatureAlarm_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.LowTemperatureAlarm_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.LowTemperatureAlarm_Num.Minimum = 0;
            this.LowTemperatureAlarm_Num.Maximum = 99999;

            //
            //HighTemperatureAlarm_Lbl
            //
            this.HighTemperatureAlarm_Lbl.Dock = DockStyle.Fill;
            this.HighTemperatureAlarm_Lbl.BackColor = Color.Transparent;
            this.HighTemperatureAlarm_Lbl.Name = "HighTemperatureAlarm_Lbl";
            this.HighTemperatureAlarm_Lbl.Text = "Ortam Sıcaklığı Alarm Üst Değeri: ";
            this.HighTemperatureAlarm_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HighTemperatureAlarm_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.HighTemperatureAlarm_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //HighTemperatureAlarm_Num
            //
            this.HighTemperatureAlarm_Num.Name = "HighTemperatureAlarm_Num";
            this.HighTemperatureAlarm_Num.Dock = DockStyle.Fill;
            this.HighTemperatureAlarm_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.HighTemperatureAlarm_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.HighTemperatureAlarm_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.HighTemperatureAlarm_Num.Minimum = 0;
            this.HighTemperatureAlarm_Num.Maximum = 99999;
            //
            //FlowAlarmIsActive_Lbl
            //
            this.FlowAlarmIsActive_Lbl.Dock = DockStyle.Fill;
            this.FlowAlarmIsActive_Lbl.BackColor = Color.Transparent;
            this.FlowAlarmIsActive_Lbl.Name = "FlowAlarmIsActive_Lbl";
            this.FlowAlarmIsActive_Lbl.Text = "Su Akış Alarm Durumu: ";
            this.FlowAlarmIsActive_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FlowAlarmIsActive_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.FlowAlarmIsActive_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FlowAlarmIsActive_TglBtn
            //
            this.FlowAlarmIsActive_TglBtn.Dock = DockStyle.Fill;
            this.FlowAlarmIsActive_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.FlowAlarmIsActive_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.FlowAlarmIsActive_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.FlowAlarmIsActive_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.FlowAlarmIsActive_TglBtn.Checked = false;
            //
            //FlowInitialCalibrationLimit_Lbl
            //
            this.FlowInitialCalibrationLimit_Lbl.Dock = DockStyle.Fill;
            this.FlowInitialCalibrationLimit_Lbl.BackColor = Color.Transparent;
            this.FlowInitialCalibrationLimit_Lbl.Name = "FlowInitialCalibrationLimit_Lbl";
            this.FlowInitialCalibrationLimit_Lbl.Text = "Başlangıç Su Basınç Limiti: ";
            this.FlowInitialCalibrationLimit_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FlowInitialCalibrationLimit_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.FlowInitialCalibrationLimit_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FlowInitialCalibrationLimit_Num
            //
            this.FlowInitialCalibrationLimit_Num.Name = "FlowInitialCalibrationLimit_Num";
            this.FlowInitialCalibrationLimit_Num.Dock = DockStyle.Fill;
            this.FlowInitialCalibrationLimit_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.FlowInitialCalibrationLimit_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.FlowInitialCalibrationLimit_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.FlowInitialCalibrationLimit_Num.Minimum = 0;
            this.FlowInitialCalibrationLimit_Num.Maximum = 255;
            //
            //HighFlowAlarmCount_Lbl
            //
            this.HighFlowAlarmCount_Lbl.Dock = DockStyle.Fill;
            this.HighFlowAlarmCount_Lbl.BackColor = Color.Transparent;
            this.HighFlowAlarmCount_Lbl.Name = "HighFlowAlarmCount_Lbl";
            this.HighFlowAlarmCount_Lbl.Text = "Su Akış Alarm Üst Değeri: ";
            this.HighFlowAlarmCount_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HighFlowAlarmCount_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.HighFlowAlarmCount_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //HighFlowAlarmCount_Num
            //
            this.HighFlowAlarmCount_Num.Name = "HighFlowAlarmCount_Num";
            this.HighFlowAlarmCount_Num.Dock = DockStyle.Fill;
            this.HighFlowAlarmCount_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.HighFlowAlarmCount_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.HighFlowAlarmCount_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.HighFlowAlarmCount_Num.Minimum = 0;
            this.HighFlowAlarmCount_Num.Maximum = 2000;

            //
            //LowFlowAlarmCount_Lbl
            //
            this.LowFlowAlarmCount_Lbl.Dock = DockStyle.Fill;
            this.LowFlowAlarmCount_Lbl.BackColor = Color.Transparent;
            this.LowFlowAlarmCount_Lbl.Name = "LowFlowAlarmCount_Lbl";
            this.LowFlowAlarmCount_Lbl.Text = "Su Akış Alarm Alt Değeri: ";
            this.LowFlowAlarmCount_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LowFlowAlarmCount_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.LowFlowAlarmCount_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //LowFlowAlarmCount_Num
            //
            this.LowFlowAlarmCount_Num.Name = "LowFlowAlarmCount_Num";
            this.LowFlowAlarmCount_Num.Dock = DockStyle.Fill;
            this.LowFlowAlarmCount_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.LowFlowAlarmCount_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.LowFlowAlarmCount_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.LowFlowAlarmCount_Num.Minimum = 0;
            this.LowFlowAlarmCount_Num.Maximum = 2000;
            //
            //Mop_Table
            //
            this.Mop_Table.ColumnCount = 7;
            this.Mop_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Mop_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Mop_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Mop_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Mop_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Mop_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            this.Mop_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Mop_Table.RowCount = 6;
            this.Mop_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Mop_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Mop_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Mop_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Mop_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Mop_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Mop_Table.Controls.Add(this.Mop_Lbl, 1, 1);
            this.Mop_Table.SetColumnSpan(this.Mop_Lbl, 5);
            this.Mop_Table.Controls.Add(this.MopStatus_TglBtn, 2, 2);
            this.Mop_Table.SetColumnSpan(this.MopStatus_TglBtn, 2);
            this.Mop_Table.Controls.Add(this.MopPrice_Lbl, 1, 3);
            this.Mop_Table.SetColumnSpan(this.MopPrice_Lbl, 2);
            this.Mop_Table.Controls.Add(this.MopPrice_Num, 3, 3);
            this.Mop_Table.SetColumnSpan(this.MopPrice_Num, 2);
            this.Mop_Table.Controls.Add(this.MopTime_Lbl, 1, 4);
            this.Mop_Table.SetColumnSpan(this.MopTime_Lbl, 2);
            this.Mop_Table.Controls.Add(this.MopTime_Num, 3, 4);
            this.Mop_Table.SetColumnSpan(this.MopTime_Num, 2);
            this.Mop_Table.Dock = DockStyle.Fill;
            this.Mop_Table.Name = "Mop_Table";
            //
            //Mop_Lbl
            //
            this.Mop_Lbl.Dock = DockStyle.Fill;
            this.Mop_Lbl.BackColor = Color.Transparent;
            this.Mop_Lbl.Name = "Mop_Lbl";
            this.Mop_Lbl.Text = "PASPAS";
            this.Mop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mop_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Mop_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //MopStatus_TglBtn
            //
            this.MopStatus_TglBtn.Dock = DockStyle.Fill;
            this.MopStatus_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.MopStatus_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.MopStatus_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.MopStatus_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.MopStatus_TglBtn.Checked = false;
            this.MopStatus_TglBtn.CheckedChanged += MopStatus_TglBtn_CheckedChanged;
            //
            //MopPrice_Lbl
            //
            this.MopPrice_Lbl.Dock = DockStyle.Fill;
            this.MopPrice_Lbl.BackColor = Color.Transparent;
            this.MopPrice_Lbl.Name = "MopPrice_Lbl";
            this.MopPrice_Lbl.Text = "Paspas Çalışma Ücreti: ";
            this.MopPrice_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MopPrice_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.MopPrice_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //MopPrice_Num
            //
            this.MopPrice_Num.Name = "MopPrice_Num";
            this.MopPrice_Num.Dock = DockStyle.Fill;
            this.MopPrice_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.MopPrice_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.MopPrice_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.MopPrice_Num.Minimum = 0;
            this.MopPrice_Num.Maximum = 100;
            this.MopPrice_Num.Enabled = false;
            //
            //MopTime_Lbl
            //
            this.MopTime_Lbl.Dock = DockStyle.Fill;
            this.MopTime_Lbl.BackColor = Color.Transparent;
            this.MopTime_Lbl.Name = "MopTime_Lbl";
            this.MopTime_Lbl.Text = "Paspas Çalışma Süresi: ";
            this.MopTime_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MopTime_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.MopTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //MopTime_Num
            //
            this.MopTime_Num.Name = "MopTime_Num";
            this.MopTime_Num.Dock = DockStyle.Fill;
            this.MopTime_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.MopTime_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.MopTime_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.MopTime_Num.Minimum = 0;
            this.MopTime_Num.Maximum = 600;
            this.MopTime_Num.Enabled = false;
            //
            //Wash_Table
            //
            this.Wash_Table.ColumnCount = 7;
            this.Wash_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Wash_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Wash_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Wash_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Wash_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Wash_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            this.Wash_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Wash_Table.RowCount = 6;
            this.Wash_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Wash_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Wash_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Wash_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Wash_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Wash_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Wash_Table.Controls.Add(this.Wash_Lbl, 1, 1);
            this.Wash_Table.SetColumnSpan(this.Wash_Lbl, 5);
            this.Wash_Table.Controls.Add(this.WashStatus_TglBtn, 2, 2);
            this.Wash_Table.SetColumnSpan(this.WashStatus_TglBtn, 2);
            this.Wash_Table.Controls.Add(this.WashPrice_Lbl, 1, 3);
            this.Wash_Table.SetColumnSpan(this.WashPrice_Lbl, 2);
            this.Wash_Table.Controls.Add(this.WashPrice_Num, 3, 3);
            this.Wash_Table.SetColumnSpan(this.WashPrice_Num, 2);
            this.Wash_Table.Controls.Add(this.WashTime_Lbl, 1, 4);
            this.Wash_Table.SetColumnSpan(this.WashTime_Lbl, 2);
            this.Wash_Table.Controls.Add(this.WashTime_Num, 3, 4);
            this.Wash_Table.SetColumnSpan(this.WashTime_Num, 2);
            this.Wash_Table.Dock = DockStyle.Fill;
            this.Wash_Table.Name = "Wash_Table";
            //
            //Wash_Lbl
            //
            this.Wash_Lbl.Dock = DockStyle.Fill;
            this.Wash_Lbl.BackColor = Color.Transparent;
            this.Wash_Lbl.Name = "Wash_Lbl";
            this.Wash_Lbl.Text = "YIKAMA";
            this.Wash_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Wash_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Wash_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //WashStatus_TglBtn
            //
            this.WashStatus_TglBtn.Dock = DockStyle.Fill;
            this.WashStatus_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.WashStatus_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.WashStatus_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.WashStatus_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.WashStatus_TglBtn.Checked = false;
            this.WashStatus_TglBtn.CheckedChanged += WashStatus_TglBtn_CheckedChanged;
            //
            //WashPrice_Lbl
            //
            this.WashPrice_Lbl.Dock = DockStyle.Fill;
            this.WashPrice_Lbl.BackColor = Color.Transparent;
            this.WashPrice_Lbl.Name = "WashPrice_Lbl";
            this.WashPrice_Lbl.Text = "Yıkama Çalışma Ücreti: ";
            this.WashPrice_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WashPrice_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.WashPrice_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //WashPrice_Num
            //
            this.WashPrice_Num.Name = "WashPrice_Num";
            this.WashPrice_Num.Dock = DockStyle.Fill;
            this.WashPrice_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.WashPrice_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.WashPrice_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.WashPrice_Num.Minimum = 0;
            this.WashPrice_Num.Maximum = 100;
            this.WashPrice_Num.Enabled = false;
            //
            //WashTime_Lbl
            //
            this.WashTime_Lbl.Dock = DockStyle.Fill;
            this.WashTime_Lbl.BackColor = Color.Transparent;
            this.WashTime_Lbl.Name = "WashTime_Lbl";
            this.WashTime_Lbl.Text = "Yıkama Çalışma Süresi: ";
            this.WashTime_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WashTime_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.WashTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //WashTime_Num
            //
            this.WashTime_Num.Name = "WashTime_Num";
            this.WashTime_Num.Dock = DockStyle.Fill;
            this.WashTime_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.WashTime_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.WashTime_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.WashTime_Num.Enabled = false;
            this.WashTime_Num.Minimum = 0;
            this.WashTime_Num.Maximum = 600;
            //
            //Foam_Table
            //
            this.Foam_Table.ColumnCount = 7;
            this.Foam_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Foam_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Foam_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Foam_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Foam_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Foam_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            this.Foam_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Foam_Table.RowCount = 6;
            this.Foam_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Foam_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Foam_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Foam_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Foam_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Foam_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Foam_Table.Controls.Add(this.Foam_Lbl, 1, 1);
            this.Foam_Table.SetColumnSpan(this.Foam_Lbl, 5);
            this.Foam_Table.Controls.Add(this.FoamStatus_TglBtn, 2, 2);
            this.Foam_Table.SetColumnSpan(this.FoamStatus_TglBtn, 2);
            this.Foam_Table.Controls.Add(this.FoamPrice_Lbl, 1, 3);
            this.Foam_Table.SetColumnSpan(this.FoamPrice_Lbl, 2);
            this.Foam_Table.Controls.Add(this.FoamPrice_Num, 3, 3);
            this.Foam_Table.SetColumnSpan(this.FoamPrice_Num, 2);
            this.Foam_Table.Controls.Add(this.FoamTime_Lbl, 1, 4);
            this.Foam_Table.SetColumnSpan(this.FoamTime_Lbl, 2);
            this.Foam_Table.Controls.Add(this.FoamTime_Num, 3, 4);
            this.Foam_Table.SetColumnSpan(this.FoamTime_Num, 2);
            this.Foam_Table.Dock = DockStyle.Fill;
            this.Foam_Table.Name = "Foam_Table";
            //
            //Foam_Lbl
            //
            this.Foam_Lbl.Dock = DockStyle.Fill;
            this.Foam_Lbl.BackColor = Color.Transparent;
            this.Foam_Lbl.Name = "Foam_Lbl";
            this.Foam_Lbl.Text = "KÖPÜK";
            this.Foam_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Foam_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Foam_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FoamStatus_TglBtn
            //
            this.FoamStatus_TglBtn.Dock = DockStyle.Fill;
            this.FoamStatus_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.FoamStatus_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.FoamStatus_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.FoamStatus_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.FoamStatus_TglBtn.Checked = false;
            this.FoamStatus_TglBtn.CheckedChanged += FoamStatus_TglBtn_CheckedChanged;
            //
            //FoamPrice_Lbl
            //
            this.FoamPrice_Lbl.Dock = DockStyle.Fill;
            this.FoamPrice_Lbl.BackColor = Color.Transparent;
            this.FoamPrice_Lbl.Name = "FoamPrice_Lbl";
            this.FoamPrice_Lbl.Text = "Köpük Çalışma Ücreti: ";
            this.FoamPrice_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FoamPrice_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.FoamPrice_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FoamPrice_Num
            //
            this.FoamPrice_Num.Name = "FoamPrice_Num";
            this.FoamPrice_Num.Dock = DockStyle.Fill;
            this.FoamPrice_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.FoamPrice_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.FoamPrice_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.FoamPrice_Num.Minimum = 0;
            this.FoamPrice_Num.Maximum = 100;
            this.FoamPrice_Num.Enabled = false;
            //
            //FoamTime_Lbl
            //
            this.FoamTime_Lbl.Dock = DockStyle.Fill;
            this.FoamTime_Lbl.BackColor = Color.Transparent;
            this.FoamTime_Lbl.Name = "FoamTime_Lbl";
            this.FoamTime_Lbl.Text = "Köpük Çalışma Süresi: ";
            this.FoamTime_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FoamTime_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.FoamTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FoamTime_Num
            //
            this.FoamTime_Num.Name = "FoamTime_Num";
            this.FoamTime_Num.Dock = DockStyle.Fill;
            this.FoamTime_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.FoamTime_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.FoamTime_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.FoamTime_Num.Minimum = 0;
            this.FoamTime_Num.Maximum = 600;
            this.FoamTime_Num.Enabled = false;
            //
            //Air_Table
            //
            this.Air_Table.ColumnCount = 7;
            this.Air_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Air_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Air_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Air_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Air_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Air_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            this.Air_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Air_Table.RowCount = 6;
            this.Air_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Air_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Air_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Air_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Air_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Air_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Air_Table.Controls.Add(this.Air_Lbl, 1, 1);
            this.Air_Table.SetColumnSpan(this.Air_Lbl, 5);
            this.Air_Table.Controls.Add(this.AirStatus_TglBtn, 2, 2);
            this.Air_Table.SetColumnSpan(this.AirStatus_TglBtn, 2);
            this.Air_Table.Controls.Add(this.AirPrice_Lbl, 1, 3);
            this.Air_Table.SetColumnSpan(this.AirPrice_Lbl, 2);
            this.Air_Table.Controls.Add(this.AirPrice_Num, 3, 3);
            this.Air_Table.SetColumnSpan(this.AirPrice_Num, 2);
            this.Air_Table.Controls.Add(this.AirTime_Lbl, 1, 4);
            this.Air_Table.SetColumnSpan(this.AirTime_Lbl, 2);
            this.Air_Table.Controls.Add(this.AirTime_Num, 3, 4);
            this.Air_Table.SetColumnSpan(this.AirTime_Num, 2);
            this.Air_Table.Dock = DockStyle.Fill;
            this.Air_Table.Name = "Air_Table";
            //
            //Air_Lbl
            //
            this.Air_Lbl.Dock = DockStyle.Fill;
            this.Air_Lbl.BackColor = Color.Transparent;
            this.Air_Lbl.Name = "Air_Lbl";
            this.Air_Lbl.Text = "HAVA";
            this.Air_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Air_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Air_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //AirStatus_TglBtn
            //
            this.AirStatus_TglBtn.Dock = DockStyle.Fill;
            this.AirStatus_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.AirStatus_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.AirStatus_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.AirStatus_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.AirStatus_TglBtn.Checked = false;
            this.AirStatus_TglBtn.CheckedChanged += AirStatus_TglBtn_CheckedChanged;
            //
            //AirPrice_Lbl
            //
            this.AirPrice_Lbl.Dock = DockStyle.Fill;
            this.AirPrice_Lbl.BackColor = Color.Transparent;
            this.AirPrice_Lbl.Name = "AirPrice_Lbl";
            this.AirPrice_Lbl.Text = "Hava Çalışma Ücreti: ";
            this.AirPrice_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AirPrice_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.AirPrice_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //AirPrice_Num
            //
            this.AirPrice_Num.Name = "AirPrice_Num";
            this.AirPrice_Num.Dock = DockStyle.Fill;
            this.AirPrice_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.AirPrice_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.AirPrice_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.AirPrice_Num.Minimum = 0;
            this.AirPrice_Num.Maximum = 100;
            this.AirPrice_Num.Enabled = false;
            //
            //AirTime_Lbl
            //
            this.AirTime_Lbl.Dock = DockStyle.Fill;
            this.AirTime_Lbl.BackColor = Color.Transparent;
            this.AirTime_Lbl.Name = "AirTime_Lbl";
            this.AirTime_Lbl.Text = "Hava Çalışma Süresi: ";
            this.AirTime_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AirTime_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.AirTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //AirTime_Num
            //
            this.AirTime_Num.Name = "AirTime_Num";
            this.AirTime_Num.Dock = DockStyle.Fill;
            this.AirTime_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.AirTime_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.AirTime_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.AirTime_Num.Minimum = 0;
            this.AirTime_Num.Maximum = 600;
            this.AirTime_Num.Enabled = false;
            //
            //Vacuum_Table
            //
            this.Vacuum_Table.ColumnCount = 7;
            this.Vacuum_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Vacuum_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Vacuum_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Vacuum_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Vacuum_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Vacuum_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            this.Vacuum_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Vacuum_Table.RowCount = 6;
            this.Vacuum_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Vacuum_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Vacuum_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Vacuum_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Vacuum_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Vacuum_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Vacuum_Table.Controls.Add(this.Vacuum_Lbl, 1, 1);
            this.Vacuum_Table.SetColumnSpan(this.Vacuum_Lbl, 5);
            this.Vacuum_Table.Controls.Add(this.VacuumStatus_TglBtn, 2, 2);
            this.Vacuum_Table.SetColumnSpan(this.VacuumStatus_TglBtn, 2);
            this.Vacuum_Table.Controls.Add(this.VacuumPrice_Lbl, 1, 3);
            this.Vacuum_Table.SetColumnSpan(this.VacuumPrice_Lbl, 2);
            this.Vacuum_Table.Controls.Add(this.VacuumPrice_Num, 3, 3);
            this.Vacuum_Table.SetColumnSpan(this.VacuumPrice_Num, 2);
            this.Vacuum_Table.Controls.Add(this.VacuumTime_Lbl, 1, 4);
            this.Vacuum_Table.SetColumnSpan(this.VacuumTime_Lbl, 2);
            this.Vacuum_Table.Controls.Add(this.VacuumTime_Num, 3, 4);
            this.Vacuum_Table.SetColumnSpan(this.VacuumTime_Num, 2);
            this.Vacuum_Table.Dock = DockStyle.Fill;
            this.Vacuum_Table.Name = "Vacuum_Table";
            //
            //Vacuum_Lbl
            //
            this.Vacuum_Lbl.Dock = DockStyle.Fill;
            this.Vacuum_Lbl.BackColor = Color.Transparent;
            this.Vacuum_Lbl.Name = "Vacuum_Lbl";
            this.Vacuum_Lbl.Text = "VAKUM";
            this.Vacuum_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Vacuum_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Vacuum_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //VacuumStatus_TglBtn
            //
            this.VacuumStatus_TglBtn.Dock = DockStyle.Fill;
            this.VacuumStatus_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.VacuumStatus_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.VacuumStatus_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.VacuumStatus_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.VacuumStatus_TglBtn.Checked = false;
            this.VacuumStatus_TglBtn.CheckedChanged += VacuumStatus_TglBtn_CheckedChanged;
            //
            //VacuumPrice_Lbl
            //
            this.VacuumPrice_Lbl.Dock = DockStyle.Fill;
            this.VacuumPrice_Lbl.BackColor = Color.Transparent;
            this.VacuumPrice_Lbl.Name = "VacuumPrice_Lbl";
            this.VacuumPrice_Lbl.Text = "Vakum Çalışma Ücreti: ";
            this.VacuumPrice_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VacuumPrice_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.VacuumPrice_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //VacuumPrice_Num
            //
            this.VacuumPrice_Num.Name = "VacuumPrice_Num";
            this.VacuumPrice_Num.Dock = DockStyle.Fill;
            this.VacuumPrice_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.VacuumPrice_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.VacuumPrice_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.VacuumPrice_Num.Minimum = 0;
            this.VacuumPrice_Num.Maximum = 100;
            this.VacuumPrice_Num.Enabled = false;
            //
            //VacuumTime_Lbl
            //
            this.VacuumTime_Lbl.Dock = DockStyle.Fill;
            this.VacuumTime_Lbl.BackColor = Color.Transparent;
            this.VacuumTime_Lbl.Name = "VacuumTime_Lbl";
            this.VacuumTime_Lbl.Text = "Vakum Çalışma Süresi: ";
            this.VacuumTime_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VacuumTime_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.VacuumTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //VacuumTime_Num
            //
            this.VacuumTime_Num.Name = "VacuumTime_Num";
            this.VacuumTime_Num.Dock = DockStyle.Fill;
            this.VacuumTime_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.VacuumTime_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.VacuumTime_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.VacuumTime_Num.Minimum = 0;
            this.VacuumTime_Num.Maximum = 600;
            this.VacuumTime_Num.Enabled = false;
            //
            //Varnish_Table
            //
            this.Varnish_Table.ColumnCount = 7;
            this.Varnish_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Varnish_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Varnish_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Varnish_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.Varnish_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Varnish_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            this.Varnish_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Varnish_Table.RowCount = 6;
            this.Varnish_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Varnish_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Varnish_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Varnish_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Varnish_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Varnish_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Varnish_Table.Controls.Add(this.Varnish_Lbl, 1, 1);
            this.Varnish_Table.SetColumnSpan(this.Varnish_Lbl, 5);
            this.Varnish_Table.Controls.Add(this.VarnishStatus_TglBtn, 2, 2);
            this.Varnish_Table.SetColumnSpan(this.VarnishStatus_TglBtn, 2);
            this.Varnish_Table.Controls.Add(this.VarnishPrice_Lbl, 1, 3);
            this.Varnish_Table.SetColumnSpan(this.VarnishPrice_Lbl, 2);
            this.Varnish_Table.Controls.Add(this.VarnishPrice_Num, 3, 3);
            this.Varnish_Table.SetColumnSpan(this.VarnishPrice_Num, 2);
            this.Varnish_Table.Controls.Add(this.VarnishTime_Lbl, 1, 4);
            this.Varnish_Table.SetColumnSpan(this.VarnishTime_Lbl, 2);
            this.Varnish_Table.Controls.Add(this.VarnishTime_Num, 3, 4);
            this.Varnish_Table.SetColumnSpan(this.VarnishTime_Num, 2);
            this.Varnish_Table.Dock = DockStyle.Fill;
            this.Varnish_Table.Name = "Varnish_Table";
            //
            //Varnish_Lbl
            //
            this.Varnish_Lbl.Dock = DockStyle.Fill;
            this.Varnish_Lbl.BackColor = Color.Transparent;
            this.Varnish_Lbl.Name = "Varnish_Lbl";
            this.Varnish_Lbl.Text = "CİLA";
            this.Varnish_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Varnish_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Varnish_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //VarnishStatus_TglBtn
            //
            this.VarnishStatus_TglBtn.Dock = DockStyle.Fill;
            this.VarnishStatus_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.VarnishStatus_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.VarnishStatus_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.VarnishStatus_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.VarnishStatus_TglBtn.Checked = false;
            this.VarnishStatus_TglBtn.CheckedChanged += VarnishStatus_TglBtn_CheckedChanged;
            //
            //VarnishPrice_Lbl
            //
            this.VarnishPrice_Lbl.Dock = DockStyle.Fill;
            this.VarnishPrice_Lbl.BackColor = Color.Transparent;
            this.VarnishPrice_Lbl.Name = "VarnishPrice_Lbl";
            this.VarnishPrice_Lbl.Text = "Cila Çalışma Ücreti: ";
            this.VarnishPrice_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VarnishPrice_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.VarnishPrice_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //VarnishPrice_Num
            //
            this.VarnishPrice_Num.Name = "VarnishPrice_Num";
            this.VarnishPrice_Num.Dock = DockStyle.Fill;
            this.VarnishPrice_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.VarnishPrice_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.VarnishPrice_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.VarnishPrice_Num.Minimum = 0;
            this.VarnishPrice_Num.Maximum = 100;
            this.VarnishPrice_Num.Enabled = false;
            //
            //VarnishTime_Lbl
            //
            this.VarnishTime_Lbl.Dock = DockStyle.Fill;
            this.VarnishTime_Lbl.BackColor = Color.Transparent;
            this.VarnishTime_Lbl.Name = "VarnishTime_Lbl";
            this.VarnishTime_Lbl.Text = "Cila Çalışma Süresi: ";
            this.VarnishTime_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VarnishTime_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.VarnishTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //VarnishTime_Num
            //
            this.VarnishTime_Num.Name = "VarnishTime_Num";
            this.VarnishTime_Num.Dock = DockStyle.Fill;
            this.VarnishTime_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.VarnishTime_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.VarnishTime_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.VarnishTime_Num.Minimum = 0;
            this.VarnishTime_Num.Maximum = 600;
            this.VarnishTime_Num.Enabled = false;
            //
            //Save_Btn
            //
            this.Save_Btn.Dock = DockStyle.Fill;
            this.Save_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Save_Btn.FlatAppearance.BorderSize = 1;
            this.Save_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Save_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Save_Btn.FlatStyle = FlatStyle.Flat;
            this.Save_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Save_Btn.Image = Properties.Resources.Save_Image;
            this.Save_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Padding = new Padding(5, 0, 0, 0);
            this.Save_Btn.Text = "KAYDET";
            this.Save_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Save_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            //MachineCreater
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(47, 52, 58);
            this.ClientSize = new Size(870, 457);
            this.Controls.Add(Main_Table);
            this.Text = "MachineCreater";
            this.Name = "MachineCreater";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Buttons_Table.ResumeLayout(false);
            this.Buttons_Table.PerformLayout();
            this.Main_Pnl.ResumeLayout(false);
            this.Main_Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private TableLayoutPanel Buttons_Table;
        private PictureBox Machine_Pbx;
        private PictureBox Mop_Pbx;
        private PictureBox Wash_Pbx;
        private PictureBox Foam_Pbx;
        private PictureBox Air_Pbx;
        private PictureBox Vacuum_Pbx;
        private PictureBox Varnish_Pbx;
        private Panel Main_Pnl;
        private Button Save_Btn;
        private TableLayoutPanel Machine_Table;
        private Label Alias_Lbl;
        private Custom_TextBox Alias_Txt;
        private Label PeriodicMaintenanceHour_Lbl;
        private NumericUpDown PeriodicMaintenanceHour_Num;
        private Label CommunicationAddress_Lbl;
        private NumericUpDown CommunicationAddress_Num;
        private Button FetchDate_Btn;
        private Label P10Usage_Lbl;
        private Custom_ToggleButton P10Usage_TglBtn;
        private Label TemperatureAlarmIsActive_Lbl;
        private Custom_ToggleButton TemperatureAlarmIsActive_TglBtn;
        private Label LowTemperatureAlarm_Lbl;
        private NumericUpDown LowTemperatureAlarm_Num;
        private Label HighTemperatureAlarm_Lbl;
        private NumericUpDown HighTemperatureAlarm_Num;
        private Label FlowAlarmIsActive_Lbl;
        private Custom_ToggleButton FlowAlarmIsActive_TglBtn;
        private Label FlowInitialCalibrationLimit_Lbl;
        private NumericUpDown FlowInitialCalibrationLimit_Num;
        private Label HighFlowAlarmCount_Lbl;
        private NumericUpDown HighFlowAlarmCount_Num;
        private Label LowFlowAlarmCount_Lbl;
        private NumericUpDown LowFlowAlarmCount_Num;
        private TableLayoutPanel Mop_Table;
        private Label Mop_Lbl;
        private Custom_ToggleButton MopStatus_TglBtn;
        private Label MopPrice_Lbl;
        private NumericUpDown MopPrice_Num;
        private Label MopTime_Lbl;
        private NumericUpDown MopTime_Num;
        private TableLayoutPanel Wash_Table;
        private Label Wash_Lbl;
        private Custom_ToggleButton WashStatus_TglBtn;
        private Label WashPrice_Lbl;
        private NumericUpDown WashPrice_Num;
        private Label WashTime_Lbl;
        private NumericUpDown WashTime_Num;
        private TableLayoutPanel Foam_Table;
        private Label Foam_Lbl;
        private Custom_ToggleButton FoamStatus_TglBtn;
        private Label FoamPrice_Lbl;
        private NumericUpDown FoamPrice_Num;
        private Label FoamTime_Lbl;
        private NumericUpDown FoamTime_Num;
        private TableLayoutPanel Air_Table;
        private Label Air_Lbl;
        private Custom_ToggleButton AirStatus_TglBtn;
        private Label AirPrice_Lbl;
        private NumericUpDown AirPrice_Num;
        private Label AirTime_Lbl;
        private NumericUpDown AirTime_Num;
        private TableLayoutPanel Vacuum_Table;
        private Label Vacuum_Lbl;
        private Custom_ToggleButton VacuumStatus_TglBtn;
        private Label VacuumPrice_Lbl;
        private NumericUpDown VacuumPrice_Num;
        private Label VacuumTime_Lbl;
        private NumericUpDown VacuumTime_Num;
        private TableLayoutPanel Varnish_Table;
        private Label Varnish_Lbl;
        private Custom_ToggleButton VarnishStatus_TglBtn;
        private Label VarnishPrice_Lbl;
        private NumericUpDown VarnishPrice_Num;
        private Label VarnishTime_Lbl;
        private NumericUpDown VarnishTime_Num;
    }
}
