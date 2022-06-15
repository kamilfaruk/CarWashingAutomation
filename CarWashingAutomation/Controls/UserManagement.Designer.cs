using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using CarWashingAutomation.Tools;
using CarWashingAutomation.Components;
using System;

namespace CarWashingAutomation.Controls
{
    partial class UserManagement
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
            this.User_Dgv = new Custom_DataGridView();
            this.Id = new DataGridViewTextBoxColumn();
            this.Name = new DataGridViewTextBoxColumn();
            this.Surname = new DataGridViewTextBoxColumn();
            this.UserName = new DataGridViewTextBoxColumn();
            this.Password = new DataGridViewTextBoxColumn();
            this.Mail = new DataGridViewTextBoxColumn();
            this.Phone = new DataGridViewTextBoxColumn();
            this.Authority = new DataGridViewTextBoxColumn();
            this.TechnicalSupportable = new DataGridViewTextBoxColumn();
            this.Manager_Table = new TableLayoutPanel();
            this.Name_Lbl = new Label();
            this.Name_Txt = new Custom_TextBox();
            this.Surname_Lbl = new Label();
            this.Surname_Txt = new Custom_TextBox();
            this.UserName_Lbl = new Label();
            this.UserName_Txt = new Custom_TextBox();
            this.Password_Lbl = new Label();
            this.Password_Txt = new Custom_TextBox();
            this.Mail_Lbl = new Label();
            this.Mail_Txt = new Custom_TextBox();
            this.Phone_Lbl = new Label();
            this.Phone_Txt = new Custom_TextBox();
            this.Authority_Lbl = new Label();
            this.Authority_Cbx = new ComboBox();
            this.TechnicalSupportable_Lbl = new Label();
            this.TechnicalSupportable_Cbx = new ComboBox();
            this.Save_Btn = new Button();
            this.Delete_Btn = new Button();
            this.Cancel_Btn = new Button();
            this.Main_Table.SuspendLayout();
            ((ISupportInitialize)(this.User_Dgv)).BeginInit();
            this.Manager_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.User_Dgv, 0, 0);
            this.Main_Table.Controls.Add(this.Manager_Table, 1, 0);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            // User_Dgv
            // 
            this.User_Dgv.Dock = DockStyle.Fill;
            this.User_Dgv.Name = "User_Dgv";
            this.User_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Surname,
            this.UserName,
            this.Password,
            this.Mail,
            this.Phone,
            this.Authority,
            this.TechnicalSupportable});
            this.User_Dgv.DoubleClick += new System.EventHandler(this.User_Dgv_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "İSİM";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "SOYAD";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "KULLANICI ADI";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "ŞİFRE";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mail.DataPropertyName = "Mail";
            this.Mail.HeaderText = "MAİL";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "TELEFON";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Authority
            // 
            this.Authority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Authority.DataPropertyName = "Authority";
            this.Authority.HeaderText = "YETKİ";
            this.Authority.Name = "Authority";
            this.Authority.ReadOnly = true;
            // 
            // TechnicalSupportable
            // 
            this.TechnicalSupportable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TechnicalSupportable.DataPropertyName = "TechnicalSupportable";
            this.TechnicalSupportable.HeaderText = "TEKNİK DESTEKLEYEBİLİR";
            this.TechnicalSupportable.Name = "TechnicalSupportable";
            this.TechnicalSupportable.ReadOnly = true;
            //
            //Manager_Table
            //
            this.Manager_Table.BackColor = Color.Transparent;
            this.Manager_Table.ColumnCount = 4;
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Manager_Table.RowCount = 10;
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Manager_Table.Controls.Add(this.Name_Lbl, 0, 0);
            this.Manager_Table.Controls.Add(this.Name_Txt, 2, 0);
            this.Manager_Table.SetColumnSpan(this.Name_Txt, 2);
            this.Manager_Table.Controls.Add(this.Surname_Lbl, 0, 1);
            this.Manager_Table.Controls.Add(this.Surname_Txt, 2, 1);
            this.Manager_Table.SetColumnSpan(this.Surname_Txt, 2);
            this.Manager_Table.Controls.Add(this.UserName_Lbl, 0, 2);
            this.Manager_Table.Controls.Add(this.UserName_Txt, 2, 2);
            this.Manager_Table.SetColumnSpan(this.UserName_Txt, 2);
            this.Manager_Table.Controls.Add(this.Password_Lbl, 0, 3);
            this.Manager_Table.Controls.Add(this.Password_Txt, 2, 3);
            this.Manager_Table.SetColumnSpan(this.Password_Txt, 2);
            this.Manager_Table.Controls.Add(this.Mail_Lbl, 0, 4);
            this.Manager_Table.Controls.Add(this.Mail_Txt, 2, 4);
            this.Manager_Table.SetColumnSpan(this.Mail_Txt, 2);
            this.Manager_Table.Controls.Add(this.Phone_Lbl, 0, 5);
            this.Manager_Table.Controls.Add(this.Phone_Txt, 2, 5);
            this.Manager_Table.SetColumnSpan(this.Phone_Txt, 2);
            this.Manager_Table.Controls.Add(this.Authority_Lbl, 0, 6);
            this.Manager_Table.Controls.Add(this.Authority_Cbx, 2, 6);
            this.Manager_Table.SetColumnSpan(this.Authority_Cbx, 2);
            this.Manager_Table.Controls.Add(this.TechnicalSupportable_Lbl, 0, 7);
            this.Manager_Table.Controls.Add(this.TechnicalSupportable_Cbx, 2, 7);
            this.Manager_Table.SetColumnSpan(this.TechnicalSupportable_Cbx, 2);
            this.Manager_Table.Controls.Add(this.Save_Btn, 0, 8);
            this.Manager_Table.Controls.Add(this.Delete_Btn, 1, 8);
            this.Manager_Table.SetColumnSpan(this.Delete_Btn, 2);
            this.Manager_Table.Controls.Add(this.Cancel_Btn, 3, 8);
            this.Manager_Table.Dock = DockStyle.Fill;
            this.Manager_Table.Name = "Manager_Table";
            this.Manager_Table.TabIndex = 0;
            // 
            // Name_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Name_Lbl, 2);
            this.Name_Lbl.Dock = DockStyle.Fill;
            this.Name_Lbl.BackColor = Color.Transparent;
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Text = "İsim:";
            this.Name_Lbl.TextAlign =  ContentAlignment.MiddleRight;
            this.Name_Lbl.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Name_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Name_Txt
            // 
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Dock = DockStyle.Fill;
            this.Name_Txt.Font = new  Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Name_Txt.AutoSize = true;
            this.Name_Txt.TextAlign = HorizontalAlignment.Left;
            this.Name_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Name_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Name_Txt.UnderlinedStyle = true;
            this.Name_Txt.TabIndex = 0;
            this.Name_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Name_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Surname_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Surname_Lbl, 2);
            this.Surname_Lbl.Dock = DockStyle.Fill;
            this.Surname_Lbl.BackColor = Color.Transparent;
            this.Surname_Lbl.Name = "Surname_Lbl";
            this.Surname_Lbl.Text = "Soyad:";
            this.Surname_Lbl.TextAlign =  ContentAlignment.MiddleRight;
            this.Surname_Lbl.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Surname_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Surname_Txt
            // 
            this.Surname_Txt.Name = "Surname_Txt";
            this.Surname_Txt.Dock = DockStyle.Fill;
            this.Surname_Txt.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Surname_Txt.AutoSize = true;
            this.Surname_Txt.TextAlign = HorizontalAlignment.Left;
            this.Surname_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Surname_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Surname_Txt.UnderlinedStyle = true;
            this.Surname_Txt.TabIndex = 0;
            this.Surname_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Surname_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // UserName_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.UserName_Lbl, 2);
            this.UserName_Lbl.Dock = DockStyle.Fill;
            this.UserName_Lbl.BackColor = Color.Transparent;
            this.UserName_Lbl.Name = "UserName_Lbl";
            this.UserName_Lbl.Text = "Kullanıcı Adı:";
            this.UserName_Lbl.TextAlign =  ContentAlignment.MiddleRight;
            this.UserName_Lbl.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.UserName_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // UserName_Txt
            // 
            this.UserName_Txt.Name = "UserName_Txt";
            this.UserName_Txt.Dock = DockStyle.Fill;
            this.UserName_Txt.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.UserName_Txt.AutoSize = true;
            this.UserName_Txt.TextAlign = HorizontalAlignment.Left;
            this.UserName_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.UserName_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.UserName_Txt.UnderlinedStyle = true;
            this.UserName_Txt.TabIndex = 0;
            this.UserName_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.UserName_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Password_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Password_Lbl, 2);
            this.Password_Lbl.Dock = DockStyle.Fill;
            this.Password_Lbl.BackColor = Color.Transparent;
            this.Password_Lbl.Name = "Password_Lbl";
            this.Password_Lbl.Text = "Şifre";
            this.Password_Lbl.TextAlign =  ContentAlignment.MiddleRight;
            this.Password_Lbl.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Password_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Password_Txt
            // 
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.Dock = DockStyle.Fill;
            this.Password_Txt.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Password_Txt.AutoSize = true;
            this.Password_Txt.TextAlign = HorizontalAlignment.Left;
            this.Password_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Password_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Password_Txt.UnderlinedStyle = true;
            this.Password_Txt.TabIndex = 0;
            this.Password_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Password_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Mail_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Mail_Lbl, 2);
            this.Mail_Lbl.Dock = DockStyle.Fill;
            this.Mail_Lbl.BackColor = Color.Transparent;
            this.Mail_Lbl.Name = "Mail_Lbl";
            this.Mail_Lbl.Text = "Mail:";
            this.Mail_Lbl.TextAlign =  ContentAlignment.MiddleRight;
            this.Mail_Lbl.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Mail_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Mail_Txt
            // 
            this.Mail_Txt.Name = "Mail_Txt";
            this.Mail_Txt.Dock = DockStyle.Fill;
            this.Mail_Txt.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Mail_Txt.AutoSize = true;
            this.Mail_Txt.TextAlign = HorizontalAlignment.Left;
            this.Mail_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Mail_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Mail_Txt.UnderlinedStyle = true;
            this.Mail_Txt.TabIndex = 0;
            this.Mail_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Mail_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Phone_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Phone_Lbl, 2);
            this.Phone_Lbl.Dock = DockStyle.Fill;
            this.Phone_Lbl.BackColor = Color.Transparent;
            this.Phone_Lbl.Name = "Phone_Lbl";
            this.Phone_Lbl.Text = "Telefon:";
            this.Phone_Lbl.TextAlign =  ContentAlignment.MiddleRight;
            this.Phone_Lbl.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Phone_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Phone_Txt
            // 
            this.Phone_Txt.Name = "Phone_Txt";
            this.Phone_Txt.Dock = DockStyle.Fill;
            this.Phone_Txt.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Phone_Txt.AutoSize = true;
            this.Phone_Txt.TextAlign = HorizontalAlignment.Left;
            this.Phone_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Phone_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Phone_Txt.UnderlinedStyle = true;
            this.Phone_Txt.TabIndex = 0;
            this.Phone_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Phone_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Authority_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Authority_Lbl, 2);
            this.Authority_Lbl.Dock = DockStyle.Fill;
            this.Authority_Lbl.BackColor = Color.Transparent;
            this.Authority_Lbl.Name = "Authority_Lbl";
            this.Authority_Lbl.Text = "Yetki:";
            this.Authority_Lbl.TextAlign =  ContentAlignment.MiddleRight;
            this.Authority_Lbl.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Authority_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Authority_Cbx
            // 
            this.Authority_Cbx.Name = "Authority_Cbx";
            this.Authority_Cbx.BackColor = Color.FromArgb(64, 69, 76);
            this.Authority_Cbx.ForeColor = Color.FromArgb(192, 192, 192);
            this.Authority_Cbx.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.Authority_Cbx.Dock = DockStyle.Fill;
            // 
            //TechnicalSupportable_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.TechnicalSupportable_Lbl, 2);
            this.TechnicalSupportable_Lbl.Dock = DockStyle.Fill;
            this.TechnicalSupportable_Lbl.BackColor = Color.Transparent;
            this.TechnicalSupportable_Lbl.Name = "TechnicalSupportable_Lbl";
            this.TechnicalSupportable_Lbl.Text = "Teknik Destek Düzeyi:";
            this.TechnicalSupportable_Lbl.TextAlign =  ContentAlignment.MiddleRight;
            this.TechnicalSupportable_Lbl.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.TechnicalSupportable_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // TechnicalSupportable_Cbx
            // 
            this.TechnicalSupportable_Cbx.Name = "TechnicalSupportable_Cbx";
            this.TechnicalSupportable_Cbx.BackColor = Color.FromArgb(64, 69, 76);
            this.TechnicalSupportable_Cbx.ForeColor = Color.FromArgb(192, 192, 192);
            this.TechnicalSupportable_Cbx.Font = new  Font("Microsoft Sans Serif", 12F,  FontStyle.Regular);
            this.TechnicalSupportable_Cbx.Dock = DockStyle.Fill;
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
            this.Save_Btn.ImageAlign =  ContentAlignment.MiddleLeft;
            this.Save_Btn.Location = new  Point(0, 512);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Save_Btn.Size = new  Size(229, 45);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "KAYDET";
            this.Save_Btn.TextAlign =  ContentAlignment.MiddleLeft;
            this.Save_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Delete_Btn.FlatAppearance.BorderSize = 1;
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Delete_Btn.Image = Properties.Resources.Delete_Image;
            this.Delete_Btn.ImageAlign =  ContentAlignment.MiddleLeft;
            this.Delete_Btn.Location = new  Point(0, 512);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Delete_Btn.Size = new  Size(229, 45);
            this.Delete_Btn.TabIndex = 5;
            this.Delete_Btn.Text = "SİL";
            this.Delete_Btn.TextAlign =  ContentAlignment.MiddleLeft;
            this.Delete_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Cancel_Btn.FlatAppearance.BorderSize = 1;
            this.Cancel_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Cancel_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Cancel_Btn.Image = Properties.Resources.Cancel_Image;
            this.Cancel_Btn.ImageAlign =  ContentAlignment.MiddleLeft;
            this.Cancel_Btn.Location = new  Point(0, 512);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Cancel_Btn.Size = new  Size(229, 45);
            this.Cancel_Btn.TabIndex = 5;
            this.Cancel_Btn.Text = "İPTAL";
            this.Cancel_Btn.TextAlign =  ContentAlignment.MiddleLeft;
            this.Cancel_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new  SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new  Size(800, 600);
            this.Load += UserManagement_Load;
            this.Controls.Add(this.Main_Table);
            //this.Name = "UserManagement";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Manager_Table.ResumeLayout(false);
            this.Manager_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_Dgv)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Custom_DataGridView User_Dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Authority;
        private DataGridViewTextBoxColumn TechnicalSupportable;
        private TableLayoutPanel Manager_Table;
        private Label Name_Lbl;
        private Custom_TextBox Name_Txt;
        private Label Surname_Lbl;
        private Custom_TextBox Surname_Txt;
        private Label UserName_Lbl;
        private Custom_TextBox UserName_Txt;
        private Label Password_Lbl;
        private Custom_TextBox Password_Txt;
        private Label Mail_Lbl;
        private Custom_TextBox Mail_Txt;
        private Label Phone_Lbl;
        private Custom_TextBox Phone_Txt;
        private Label Authority_Lbl;
        private ComboBox Authority_Cbx;
        private Label TechnicalSupportable_Lbl;
        private ComboBox TechnicalSupportable_Cbx;
        private Button Save_Btn;
        private Button Delete_Btn;
        private Button Cancel_Btn;

    }
}
