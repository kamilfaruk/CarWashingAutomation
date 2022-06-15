using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
namespace CarWashingAutomation.Forms
{
    partial class LicenseForm
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
            this.Logo_Pnl = new Panel();
            this.Logo_Pbx = new PictureBox();
            this.LineContainer_Cntnr = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LicenseKey_Line = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Token_Line = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Token_Txt = new TextBox();
            this.LicenseKey_Txt = new TextBox();
            this.Title_Lbl = new Label();
            this.Activate_Btn = new Button();
            this.Close_Pbx = new PictureBox();
            this.Logo_Pnl.SuspendLayout();
            ((ISupportInitialize)(this.Logo_Pbx)).BeginInit();
            ((ISupportInitialize)(this.Close_Pbx)).BeginInit();
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
            this.LicenseKey_Line,
            this.Token_Line});
            this.LineContainer_Cntnr.Size = new Size(780, 330);
            this.LineContainer_Cntnr.TabIndex = 1;
            this.LineContainer_Cntnr.TabStop = false;
            // 
            // LicenseKey_Line
            // 
            this.LicenseKey_Line.BorderColor = Color.FromArgb(192, 192, 192);
            this.LicenseKey_Line.Enabled = false;
            this.LicenseKey_Line.Name = "LicenseKey_Line";
            this.LicenseKey_Line.X1 = 309;
            this.LicenseKey_Line.X2 = 716;
            this.LicenseKey_Line.Y1 = 165;
            this.LicenseKey_Line.Y2 = 165;
            // 
            // Token_Line
            // 
            this.Token_Line.BorderColor = Color.FromArgb(192, 192, 192);
            this.Token_Line.Enabled = false;
            this.Token_Line.Name = "Token_Line";
            this.Token_Line.X1 = 310;
            this.Token_Line.X2 = 717;
            this.Token_Line.Y1 = 100;
            this.Token_Line.Y2 = 100;
            // 
            // Token_Txt
            // 
            this.Token_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Token_Txt.BorderStyle = BorderStyle.None;
            this.Token_Txt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Token_Txt.ForeColor = Color.Silver;
            this.Token_Txt.Location = new Point(310, 77);
            this.Token_Txt.Name = "Token_Txt";
            this.Token_Txt.Size = new Size(408, 20);
            this.Token_Txt.TabIndex = 1;
            this.Token_Txt.Text = "Token";
            // 
            // LicenseKey_Txt
            // 
            this.LicenseKey_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.LicenseKey_Txt.BorderStyle = BorderStyle.None;
            this.LicenseKey_Txt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.LicenseKey_Txt.ForeColor = Color.Silver;
            this.LicenseKey_Txt.Location = new Point(310, 142);
            this.LicenseKey_Txt.Name = "LicenseKey_Txt";
            this.LicenseKey_Txt.Size = new Size(408, 20);
            this.LicenseKey_Txt.TabIndex = 2;
            this.LicenseKey_Txt.Text = "Lisans Anahtarı";
            this.LicenseKey_Txt.Enter += new System.EventHandler(this.LicenseKey_Txt_Enter);
            this.LicenseKey_Txt.Leave += new System.EventHandler(this.LicenseKey_Txt_Leave);
            // 
            // Title_Lbl
            // 
            this.Title_Lbl.AutoSize = true;
            this.Title_Lbl.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lbl.ForeColor = Color.White;
            this.Title_Lbl.Location = new Point(325, 0);
            this.Title_Lbl.Name = "Title_Lbl";
            this.Title_Lbl.Size = new Size(101, 32);
            this.Title_Lbl.TabIndex = 4;
            this.Title_Lbl.Text = "LİSANS ANAHTARI AKTİVASYONU";
            // 
            // Activate_Btn
            // 
            this.Activate_Btn.BackColor = Color.Transparent;
            this.Activate_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Activate_Btn.FlatAppearance.BorderSize = 1;
            this.Activate_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Activate_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Activate_Btn.FlatStyle = FlatStyle.Flat;
            this.Activate_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Activate_Btn.Location = new Point(310, 236);
            this.Activate_Btn.Name = "Activate_Btn";
            this.Activate_Btn.Size = new Size(408, 40);
            this.Activate_Btn.TabIndex = 3;
            this.Activate_Btn.Text = "GİRİŞ";
            this.Activate_Btn.UseVisualStyleBackColor = false;
            this.Activate_Btn.Click += new System.EventHandler(this.Activate_Btn_Click);
            // 
            // Close_Pbx
            // 
            this.Close_Pbx.Cursor = Cursors.Hand;
            this.Close_Pbx.Image = Properties.Resources.Close_Image;
            this.Close_Pbx.Location = new Point(761, 3);
            this.Close_Pbx.Name = "Close_Pbx";
            this.Close_Pbx.Size = new Size(15, 15);
            this.Close_Pbx.SizeMode = PictureBoxSizeMode.Zoom;
            this.Close_Pbx.TabIndex = 7;
            this.Close_Pbx.TabStop = false;
            this.Close_Pbx.Click += new System.EventHandler(this.Close_Pbx_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(64, 69, 76);
            this.ClientSize = new Size(780, 330);
            this.Controls.Add(this.Close_Pbx);
            this.Controls.Add(this.Activate_Btn);
            this.Controls.Add(this.Title_Lbl);
            this.Controls.Add(this.LicenseKey_Txt);
            this.Controls.Add(this.Token_Txt);
            this.Controls.Add(this.Logo_Pnl);
            this.Controls.Add(this.LineContainer_Cntnr);
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Name = "LicenseForm";
            this.Opacity = 0.9D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.CarWashingAutomation_Icon;
            this.Text = "LicenseForm";
            this.MouseDown += new MouseEventHandler(this.LicenseForm_MouseDown);
            this.Logo_Pnl.ResumeLayout(false);
            ((ISupportInitialize)(this.Logo_Pbx)).EndInit();
            ((ISupportInitialize)(this.Close_Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private Panel Logo_Pnl;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer LineContainer_Cntnr;
        private Microsoft.VisualBasic.PowerPacks.LineShape LicenseKey_Line;
        private Microsoft.VisualBasic.PowerPacks.LineShape Token_Line;
        private TextBox Token_Txt;
        private TextBox LicenseKey_Txt;
        private Label Title_Lbl;
        private Button Activate_Btn;
        private PictureBox Logo_Pbx;
        private PictureBox Close_Pbx;
    }
}