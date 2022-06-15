
using CarWashingAutomation.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Controls
{
    partial class SoftwareConstants
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
            this.Mail_Lbl = new Label();
            this.Mail_Txt = new Custom_TextBox();
            this.Password_Lbl = new Label();
            this.Password_Txt = new Custom_TextBox();
            this.MailInformation_Lbl = new Label();
            this.StartTime_Lbl = new Label();
            this.StartHour_Num = new NumericUpDown();
            this.StartMinute_Num = new NumericUpDown();
            this.EndTime_Lbl = new Label();
            this.EndHour_Num = new NumericUpDown();
            this.EndMinute_Num = new NumericUpDown();
            this.Notification_TglBtn = new Custom_ToggleButton();
            this.Notification_Lbl = new Label();
            this.Save_Btn = new Button();
            this.Main_Table.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 4;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.Main_Table.RowCount = 7;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Mail_Lbl, 0, 0);
            this.Main_Table.Controls.Add(this.Mail_Txt, 1, 0);
            this.Main_Table.SetColumnSpan(this.Mail_Txt, 2);
            this.Main_Table.Controls.Add(this.Password_Lbl, 0, 1);
            this.Main_Table.Controls.Add(this.Password_Txt, 1, 1);
            this.Main_Table.SetColumnSpan(this.Password_Txt, 2);
            this.Main_Table.Controls.Add(this.MailInformation_Lbl, 3, 0);
            this.Main_Table.SetRowSpan(this.MailInformation_Lbl, 2);
            this.Main_Table.Controls.Add(this.StartTime_Lbl, 0, 2);             
            this.Main_Table.Controls.Add(this.StartHour_Num, 1, 2);
            this.Main_Table.Controls.Add(this.StartMinute_Num, 2, 2);
            this.Main_Table.Controls.Add(this.EndTime_Lbl, 0, 3);             
            this.Main_Table.Controls.Add(this.EndHour_Num, 1, 3);
            this.Main_Table.Controls.Add(this.EndMinute_Num, 2, 3);          
            this.Main_Table.Controls.Add(this.Notification_TglBtn, 0, 4);
            this.Main_Table.Controls.Add(this.Notification_Lbl, 1, 4);
            this.Main_Table.Controls.Add(this.Save_Btn, 0, 5);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            // Mail_Lbl
            // 
            this.Mail_Lbl.Dock = DockStyle.Fill;
            this.Mail_Lbl.BackColor = Color.Transparent;
            this.Mail_Lbl.Name = "Mail_Lbl";
            this.Mail_Lbl.Text = "Mail:";
            this.Mail_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Mail_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Mail_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Mail_Txt
            // 
            this.Mail_Txt.Name = "Mail_Txt";
            this.Mail_Txt.Dock = DockStyle.Fill;
            this.Mail_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Mail_Txt.AutoSize = true;
            this.Mail_Txt.TextAlign = HorizontalAlignment.Left;
            this.Mail_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Mail_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Mail_Txt.UnderlinedStyle = true;
            this.Mail_Txt.TabIndex = 0;
            this.Mail_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Mail_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Password_Lbl
            // 
            this.Password_Lbl.Dock = DockStyle.Fill;
            this.Password_Lbl.BackColor = Color.Transparent;
            this.Password_Lbl.Name = "Password_Lbl";
            this.Password_Lbl.Text = "Password:";
            this.Password_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Password_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Password_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Password_Txt
            // 
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.Dock = DockStyle.Fill;
            this.Password_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Password_Txt.AutoSize = true;
            this.Password_Txt.TextAlign = HorizontalAlignment.Left;
            this.Password_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Password_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Password_Txt.UnderlinedStyle = true;
            this.Password_Txt.TabIndex = 0;
            this.Password_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Password_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //MailInformation_Lbl
            //
            this.MailInformation_Lbl.Dock = DockStyle.Fill;
            this.MailInformation_Lbl.BackColor = Color.Transparent;
            this.MailInformation_Lbl.Name = "MailInformation_Lbl";
            this.MailInformation_Lbl.Text = "Lütfen girmiş olduğunuz mail hesabının ayarlarından \"Düşük Günelikli Uygulamalara İzin Ver\" seçebeğini aktif ediniz.";
            this.MailInformation_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            this.MailInformation_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.MailInformation_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //StartTime_Lbl
            //
            this.StartTime_Lbl.Dock = DockStyle.Fill;
            this.StartTime_Lbl.BackColor = Color.Transparent;
            this.StartTime_Lbl.Name = "StartTime_Lbl";
            this.StartTime_Lbl.Text = "Vardiya Başlangıç Saati:";
            this.StartTime_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.StartTime_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.StartTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //StartHour_Num
            //
            this.StartHour_Num.Dock = DockStyle.Fill;
            this.StartHour_Num.Maximum = 23;
            this.StartHour_Num.Minimum = 0;
            this.StartHour_Num.Name = "StartHour_Num";
            this.StartHour_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.StartHour_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.StartHour_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            //
            //StartMinute_Num
            //
            this.StartMinute_Num.Dock = DockStyle.Fill;
            this.StartMinute_Num.Maximum = 59;
            this.StartMinute_Num.Minimum = 0;
            this.StartMinute_Num.Name = "StartMinute_Num";
            this.StartMinute_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.StartMinute_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.StartMinute_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            //
            //EndTime_Lbl
            //
            this.EndTime_Lbl.Dock = DockStyle.Fill;
            this.EndTime_Lbl.BackColor = Color.Transparent;
            this.EndTime_Lbl.Name = "EndTime_Lbl";
            this.EndTime_Lbl.Text = "Vardiya Bitiş Saati:";
            this.EndTime_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.EndTime_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.EndTime_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //EndtHour_Num
            //
            this.EndHour_Num.Dock = DockStyle.Fill;
            this.EndHour_Num.Maximum = 23;
            this.EndHour_Num.Minimum = 0;
            this.EndHour_Num.Name = "EndHour_Num";
            this.EndHour_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.EndHour_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.EndHour_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            //
            //EndMinute_Num
            //
            this.EndMinute_Num.Dock = DockStyle.Fill;
            this.EndMinute_Num.Maximum = 59;
            this.EndMinute_Num.Minimum = 0;
            this.EndMinute_Num.Name = "EndMinute_Num";
            this.EndMinute_Num.BackColor = Color.FromArgb(11, 112, 152);
            this.EndMinute_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.EndMinute_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            //
            //Notification_Lbl
            //
            this.Notification_Lbl.Dock = DockStyle.Fill;
            this.Notification_Lbl.BackColor = Color.Transparent;
            this.Notification_Lbl.Name = "Notification_Lbl";
            this.Notification_Lbl.Text = "Bildirim Gönderimi";
            this.Notification_Lbl.TextAlign = ContentAlignment.MiddleLeft;
            this.Notification_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Notification_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //Notification_TglBtn
            //
            this.Notification_TglBtn.Dock = DockStyle.Right;
            this.Notification_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.Notification_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.Notification_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.Notification_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.Notification_TglBtn.Checked = false;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Save_Btn.FlatAppearance.BorderSize = 1;
            this.Save_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Save_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Save_Btn.Image = Properties.Resources.Save_Image;
            this.Save_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Save_Btn.Location = new Point(0, 512);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Save_Btn.Size = new Size(229, 45);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "KAYDET";
            this.Save_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Save_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            //SoftwareConstants
            // 
            components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.BackColor = Color.FromArgb(64, 69, 76);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(800, 600);
            this.Load += SoftwareConstants_Load;
            this.Controls.Add(this.Main_Table);
            //this.Name = "SoftwareConstants";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel Main_Table;
        private Label Mail_Lbl;
        private Custom_TextBox Mail_Txt;
        private Label Password_Lbl;
        private Custom_TextBox Password_Txt;
        private Label MailInformation_Lbl;
        private Label StartTime_Lbl;
        private NumericUpDown StartHour_Num;
        private NumericUpDown StartMinute_Num;
        private Label EndTime_Lbl;
        private NumericUpDown EndHour_Num;
        private NumericUpDown EndMinute_Num;
        private Custom_ToggleButton Notification_TglBtn;
        private Label Notification_Lbl;
        private Button Save_Btn;

    }
}
