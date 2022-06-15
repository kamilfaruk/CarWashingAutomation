
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Forms
{
    partial class LogoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoForm));
            this.Main_Tbl = new TableLayoutPanel();
            this.Logo_Pbx = new PictureBox();
            this.Logo_Lbl = new Label();
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
            this.Main_Tbl.Controls.Add(this.Logo_Lbl, 0, 2);
            this.Main_Tbl.SetColumnSpan(this.Logo_Lbl, 3);
            this.Main_Tbl.Dock = DockStyle.Fill;
            this.Main_Tbl.Name = "Main_Tbl";
            this.Main_Tbl.TabIndex = 0;
            // 
            // Logo_Pbx
            // 
            this.Logo_Pbx.BackgroundImageLayout = ImageLayout.Zoom;
            this.Logo_Pbx.Dock = DockStyle.Fill;
            this.Logo_Pbx.Name = "Logo_Pbx";
            this.Logo_Pbx.TabIndex = 1;
            this.Logo_Pbx.TabStop = false;
            // 
            // Logo_Lbl
            // 
            this.Logo_Lbl.AutoSize = true;
            this.Logo_Lbl.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Logo_Lbl.ForeColor = Color.FromArgb( 224 ,  224 ,  224 );
            this.Logo_Lbl.Location = new Point(286, 268);
            this.Logo_Lbl.Name = "Logo_Lbl";
            this.Logo_Lbl.Size = new Size(292, 39);
            this.Logo_Lbl.Dock = DockStyle.Fill;
            this.Logo_Lbl.TabIndex = 2;
            this.Logo_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            this.Logo_Lbl.Text = Constants.LogoFormMessage;
            // 
            // FormLogo
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb( 64 ,  69 ,  76 );
            this.ClientSize = new Size(870, 457);
            this.Controls.Add(this.Main_Tbl);
            this.Name = "FormLogo";
            this.Text = "FormLogo";
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
        private Label Logo_Lbl;
    }
}