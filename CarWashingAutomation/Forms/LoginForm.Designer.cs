using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
namespace CarWashingAutomation.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Logo_Pnl = new Panel();
            this.Logo_Pbx = new PictureBox();
            this.LineContainer_Cntnr = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Password_Line = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Username_Line = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Username_Txt = new TextBox();
            this.Password_Txt = new TextBox();
            this.Title_Lbl = new Label();
            this.Login_Btn = new Button();
            this.UserAgreement_LnkBtn = new LinkLabel();
            this.Minimize_Pbx = new PictureBox();
            this.Logo_Pnl.SuspendLayout();
            ((ISupportInitialize)(this.Logo_Pbx)).BeginInit();
            ((ISupportInitialize)(this.Minimize_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_Pnl
            // 
            this.Logo_Pnl.BackColor = Color.FromArgb(16, 154, 208);
            this.Logo_Pnl.Controls.Add(this.Logo_Pbx);
            this.Logo_Pnl.Dock = DockStyle.Left;
            this.Logo_Pnl.Location = new Point(0, 0);
            this.Logo_Pnl.Name = "Logo_Pnl";
            this.Logo_Pnl.Size = new Size(250, 330);
            this.Logo_Pnl.TabIndex = 0;
            this.Logo_Pnl.MouseDown += new MouseEventHandler(this.Logo_Pnl_MouseDown);
            // 
            // Logo_Pbx
            // 
            this.Logo_Pbx.Image = Properties.Resources.CarWashingAutomation_Image;
            this.Logo_Pbx.Location = new Point(59, 118);
            this.Logo_Pbx.Name = "Logo_Pbx";
            this.Logo_Pbx.Size = new Size(114, 90);
            this.Logo_Pbx.SizeMode = PictureBoxSizeMode.Zoom;
            this.Logo_Pbx.TabIndex = 0;
            this.Logo_Pbx.TabStop = false;
            // 
            // LineContainer_Cntnr
            // 
            this.LineContainer_Cntnr.Location = new Point(0, 0);
            this.LineContainer_Cntnr.Margin = new Padding(0);
            this.LineContainer_Cntnr.Name = "LineContainer_Cntnr";
            this.LineContainer_Cntnr.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Password_Line,
            this.Username_Line});
            this.LineContainer_Cntnr.Size = new Size(780, 330);
            this.LineContainer_Cntnr.TabIndex = 1;
            this.LineContainer_Cntnr.TabStop = false;
            // 
            // Password_Line
            // 
            this.Password_Line.BorderColor = Color.FromArgb(192, 192, 192);
            this.Password_Line.Enabled = false;
            this.Password_Line.Name = "Password_Line";
            this.Password_Line.X1 = 309;
            this.Password_Line.X2 = 716;
            this.Password_Line.Y1 = 165;
            this.Password_Line.Y2 = 165;
            // 
            // Username_Line
            // 
            this.Username_Line.BorderColor = Color.FromArgb(192, 192, 192);
            this.Username_Line.Enabled = false;
            this.Username_Line.Name = "Username_Line";
            this.Username_Line.X1 = 310;
            this.Username_Line.X2 = 717;
            this.Username_Line.Y1 = 100;
            this.Username_Line.Y2 = 100;
            // 
            // Username_Txt
            // 
            this.Username_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Username_Txt.BorderStyle = BorderStyle.None;
            this.Username_Txt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Username_Txt.ForeColor = Color.Silver;
            this.Username_Txt.Location = new Point(310, 77);
            this.Username_Txt.Name = "Username_Txt";
            this.Username_Txt.Size = new Size(408, 20);
            this.Username_Txt.TabIndex = 1;
            this.Username_Txt.Text = "Kullanıcı Adı";
            this.Username_Txt.Enter += new System.EventHandler(this.Username_Txt_Enter);
            this.Username_Txt.Leave += new System.EventHandler(this.Username_Txt_Leave);
            // 
            // Password_Txt
            // 
            this.Password_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Password_Txt.BorderStyle = BorderStyle.None;
            this.Password_Txt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Password_Txt.ForeColor = Color.Silver;
            this.Password_Txt.Location = new Point(310, 142);
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.Size = new Size(408, 20);
            this.Password_Txt.TabIndex = 2;
            this.Password_Txt.Text = "Şifre";
            this.Password_Txt.Enter += new System.EventHandler(this.Password_Txt_Enter);
            this.Password_Txt.Leave += new System.EventHandler(this.Password_Txt_Leave);
            // 
            // Title_Lbl
            // 
            this.Title_Lbl.AutoSize = true;
            this.Title_Lbl.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lbl.ForeColor = Color.White;
            this.Title_Lbl.Location = new Point(420, 0);
            this.Title_Lbl.Name = "Title_Lbl";
            this.Title_Lbl.Size = new Size(101, 32);
            this.Title_Lbl.TabIndex = 4;
            this.Title_Lbl.Text = "GİRİŞ YAP";
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = Color.Transparent;
            this.Login_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Login_Btn.FlatAppearance.BorderSize = 1;
            this.Login_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Login_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Login_Btn.FlatStyle = FlatStyle.Flat;
            this.Login_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Login_Btn.Location = new Point(310, 236);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new Size(408, 40);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "GİRİŞ";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // UserAgreement_LnkBtn
            // 
            this.UserAgreement_LnkBtn.ActiveLinkColor = Color.FromArgb(16, 154, 208);
            this.UserAgreement_LnkBtn.AutoSize = true;
            this.UserAgreement_LnkBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.UserAgreement_LnkBtn.LinkColor = Color.DarkGray;
            this.UserAgreement_LnkBtn.Location = new Point(360, 286);
            this.UserAgreement_LnkBtn.Name = "UserAgreement_LnkBtn";
            this.UserAgreement_LnkBtn.Size = new Size(182, 17);
            this.UserAgreement_LnkBtn.TabIndex = 0;
            this.UserAgreement_LnkBtn.TabStop = true;
            this.UserAgreement_LnkBtn.Text = "\"Kullanıcı Sözleşmesi\"'ni incelemek ister misiniz?";
            // 
            // Minimize_Pbx
            // 
            this.Minimize_Pbx.Cursor = Cursors.Hand;
            this.Minimize_Pbx.Image = Properties.Resources.Minimize_Image;
            this.Minimize_Pbx.Location = new Point(761, 3);
            this.Minimize_Pbx.Name = "Minimize_Pbx";
            this.Minimize_Pbx.Size = new Size(15, 15);
            this.Minimize_Pbx.SizeMode = PictureBoxSizeMode.Zoom;
            this.Minimize_Pbx.TabIndex = 8;
            this.Minimize_Pbx.TabStop = false;
            this.Minimize_Pbx.Click += new System.EventHandler(this.Minimize_Pbx_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(64, 69, 76);
            this.ClientSize = new Size(780, 330);
            this.Controls.Add(this.Minimize_Pbx);
            this.Controls.Add(this.UserAgreement_LnkBtn);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Title_Lbl);
            this.Controls.Add(this.Password_Txt);
            this.Controls.Add(this.Username_Txt);
            this.Controls.Add(this.Logo_Pnl);
            this.Controls.Add(this.LineContainer_Cntnr);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Opacity = 0.9D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.CarWashingAutomation_Icon;
            this.Text = "LoginForm";
            this.MouseDown += new MouseEventHandler(this.LoginForm_MouseDown);
            this.Logo_Pnl.ResumeLayout(false);
            ((ISupportInitialize)(this.Logo_Pbx)).EndInit();
            ((ISupportInitialize)(this.Minimize_Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private Panel Logo_Pnl;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer LineContainer_Cntnr;
        private Microsoft.VisualBasic.PowerPacks.LineShape Password_Line;
        private Microsoft.VisualBasic.PowerPacks.LineShape Username_Line;
        private TextBox Username_Txt;
        private TextBox Password_Txt;
        private Label Title_Lbl;
        private Button Login_Btn;
        private LinkLabel UserAgreement_LnkBtn;
        private PictureBox Logo_Pbx;
        private PictureBox Minimize_Pbx;
    }
}