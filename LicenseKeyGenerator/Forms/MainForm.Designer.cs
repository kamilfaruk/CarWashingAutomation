
namespace LicenseKeyGenerator.Forms
{
    partial class MainForm
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
            this.Generate_Btn = new System.Windows.Forms.Button();
            this.ValidityYear_Num = new System.Windows.Forms.NumericUpDown();
            this.ValidityYear_Lbl = new System.Windows.Forms.Label();
            this.Token_Lbl = new System.Windows.Forms.Label();
            this.Token_Txt = new System.Windows.Forms.RichTextBox();
            this.LicenseKey_Txt = new System.Windows.Forms.RichTextBox();
            this.LicenseRegistrations_Txt = new System.Windows.Forms.RichTextBox();
            this.LicenseKey_Lbl = new System.Windows.Forms.Label();
            this.LicenseRegistrations_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ValidityYear_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate_Btn
            // 
            this.Generate_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Generate_Btn.Location = new System.Drawing.Point(284, 138);
            this.Generate_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Generate_Btn.Name = "Generate_Btn";
            this.Generate_Btn.Size = new System.Drawing.Size(261, 37);
            this.Generate_Btn.TabIndex = 1;
            this.Generate_Btn.Text = "Yeni Lisans Anahtarı Oluştur";
            this.Generate_Btn.UseVisualStyleBackColor = true;
            this.Generate_Btn.Click += new System.EventHandler(this.Generate_Btn_Click);
            // 
            // ValidityYear_Num
            // 
            this.ValidityYear_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ValidityYear_Num.Location = new System.Drawing.Point(218, 144);
            this.ValidityYear_Num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ValidityYear_Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ValidityYear_Num.Name = "ValidityYear_Num";
            this.ValidityYear_Num.Size = new System.Drawing.Size(61, 26);
            this.ValidityYear_Num.TabIndex = 3;
            this.ValidityYear_Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ValidityYear_Lbl
            // 
            this.ValidityYear_Lbl.AutoSize = true;
            this.ValidityYear_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ValidityYear_Lbl.Location = new System.Drawing.Point(12, 146);
            this.ValidityYear_Lbl.Name = "ValidityYear_Lbl";
            this.ValidityYear_Lbl.Size = new System.Drawing.Size(200, 20);
            this.ValidityYear_Lbl.TabIndex = 4;
            this.ValidityYear_Lbl.Text = "Lisans Sürenizi Girniz (Yıl) :";
            // 
            // Token_Lbl
            // 
            this.Token_Lbl.AutoSize = true;
            this.Token_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Token_Lbl.Location = new System.Drawing.Point(5, 9);
            this.Token_Lbl.Name = "Token_Lbl";
            this.Token_Lbl.Size = new System.Drawing.Size(491, 20);
            this.Token_Lbl.TabIndex = 5;
            this.Token_Lbl.Text = "Lütfen Uygulamadan Tarafından Üretilmiş Olan Token Bilgisini Giriniz";
            // 
            // Token_Txt
            // 
            this.Token_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Token_Txt.Location = new System.Drawing.Point(12, 32);
            this.Token_Txt.Name = "Token_Txt";
            this.Token_Txt.Size = new System.Drawing.Size(533, 101);
            this.Token_Txt.TabIndex = 6;
            this.Token_Txt.Text = "";
            // 
            // LicenseKey_Txt
            // 
            this.LicenseKey_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LicenseKey_Txt.Location = new System.Drawing.Point(12, 200);
            this.LicenseKey_Txt.Name = "LicenseKey_Txt";
            this.LicenseKey_Txt.Size = new System.Drawing.Size(533, 101);
            this.LicenseKey_Txt.TabIndex = 7;
            this.LicenseKey_Txt.Text = "";
            // 
            // LicenseRegistrations_Txt
            // 
            this.LicenseRegistrations_Txt.Enabled = false;
            this.LicenseRegistrations_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LicenseRegistrations_Txt.Location = new System.Drawing.Point(9, 327);
            this.LicenseRegistrations_Txt.Name = "LicenseRegistrations_Txt";
            this.LicenseRegistrations_Txt.Size = new System.Drawing.Size(533, 292);
            this.LicenseRegistrations_Txt.TabIndex = 8;
            this.LicenseRegistrations_Txt.Text = "";
            // 
            // LicenseKey_Lbl
            // 
            this.LicenseKey_Lbl.AutoSize = true;
            this.LicenseKey_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LicenseKey_Lbl.Location = new System.Drawing.Point(5, 177);
            this.LicenseKey_Lbl.Name = "LicenseKey_Lbl";
            this.LicenseKey_Lbl.Size = new System.Drawing.Size(399, 20);
            this.LicenseKey_Lbl.TabIndex = 9;
            this.LicenseKey_Lbl.Text = "Aşağıdaki Lisans Anahtarını Kullanıcı İle Paylaşabilirsiniz";
            // 
            // LicenseRegistrations_Lbl
            // 
            this.LicenseRegistrations_Lbl.AutoSize = true;
            this.LicenseRegistrations_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LicenseRegistrations_Lbl.Location = new System.Drawing.Point(12, 304);
            this.LicenseRegistrations_Lbl.Name = "LicenseRegistrations_Lbl";
            this.LicenseRegistrations_Lbl.Size = new System.Drawing.Size(365, 20);
            this.LicenseRegistrations_Lbl.TabIndex = 10;
            this.LicenseRegistrations_Lbl.Text = "Daha Önceden Oluşturulmuş Lisans Anahtarlarınız";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 631);
            this.Controls.Add(this.LicenseRegistrations_Lbl);
            this.Controls.Add(this.LicenseKey_Lbl);
            this.Controls.Add(this.LicenseRegistrations_Txt);
            this.Controls.Add(this.LicenseKey_Txt);
            this.Controls.Add(this.Token_Txt);
            this.Controls.Add(this.Token_Lbl);
            this.Controls.Add(this.ValidityYear_Lbl);
            this.Controls.Add(this.ValidityYear_Num);
            this.Controls.Add(this.Generate_Btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ValidityYear_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Generate_Btn;
        private System.Windows.Forms.NumericUpDown ValidityYear_Num;
        private System.Windows.Forms.Label ValidityYear_Lbl;
        private System.Windows.Forms.Label Token_Lbl;
        private System.Windows.Forms.RichTextBox Token_Txt;
        private System.Windows.Forms.RichTextBox LicenseKey_Txt;
        private System.Windows.Forms.RichTextBox LicenseRegistrations_Txt;
        private System.Windows.Forms.Label LicenseKey_Lbl;
        private System.Windows.Forms.Label LicenseRegistrations_Lbl;
    }
}