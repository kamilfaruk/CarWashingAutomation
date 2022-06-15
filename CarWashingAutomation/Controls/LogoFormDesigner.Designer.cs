
using CarWashingAutomation.Components;
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Controls
{
    partial class LogoFormDesigner
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
            this.Main_Tbl = new TableLayoutPanel();
            this.Logo_Pbx = new PictureBox();
            this.Logo_Txt = new Custom_TextBox();
            //
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Pbx)).BeginInit();
            this.Main_Tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Tbl
            // 
            this.Main_Tbl.BackColor = Color.Transparent;
            this.Main_Tbl.ColumnCount = 3;
            this.Main_Tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Main_Tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Main_Tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Main_Tbl.RowCount = 4;
            this.Main_Tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.Main_Tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
            this.Main_Tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            this.Main_Tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.Main_Tbl.Controls.Add(this.Logo_Pbx, 1, 1);
            this.Main_Tbl.Controls.Add(this.Logo_Txt, 0, 2);
            this.Main_Tbl.SetColumnSpan(this.Logo_Txt, 3);
            this.Main_Tbl.Dock = DockStyle.Fill;
            this.Main_Tbl.Name = "Main_Tbl";
            this.Main_Tbl.TabIndex = 0;
            // 
            // Logo_Pbx
            // 
            this.Logo_Pbx.SizeMode = PictureBoxSizeMode.Zoom;
            this.Logo_Pbx.Dock = DockStyle.Fill;
            this.Logo_Pbx.Name = "Logo_Pbx";
            this.Logo_Pbx.TabIndex = 1;
            this.Logo_Pbx.TabStop = false;
            this.Logo_Pbx.DoubleClick += Logo_Pbx_DoubleClick;
            // 
            // Logo_Txt
            // 
            this.Logo_Txt.AutoSize = true;
            this.Logo_Txt.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            this.Logo_Txt.ForeColor = Color.FromArgb(192,192,192);
            this.Logo_Txt.Name = "Logo_Txt";        
            this.Logo_Txt.Dock = DockStyle.Fill;
            this.Logo_Txt.TabIndex = 2;
            this.Logo_Txt.Texts = Constants.LogoFormMessage;
            this.Logo_Txt.TextAlign = HorizontalAlignment.Center;
            this.Logo_Txt._TextChanged += Logo_Txt_TextChanged;
            this.Logo_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Logo_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Logo_Txt.UnderlinedStyle = true;
            // 
            // FormLogoDesigner
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Load += LogoFormDesigner_Load;
            this.BackColor = Color.FromArgb( 64 ,  69 ,  76 );
            this.ClientSize = new Size(870, 457);
            this.Controls.Add(this.Main_Tbl);
            this.Name = "FormLogoDesigner";
            this.Text = "FormLogoDesigner";
            //
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Pbx)).EndInit();
            this.Main_Tbl.ResumeLayout(false);
            this.Main_Tbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private TableLayoutPanel Main_Tbl;
        private PictureBox Logo_Pbx;
        private Custom_TextBox Logo_Txt;
    }
}