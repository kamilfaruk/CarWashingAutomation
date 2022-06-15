using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
namespace CarWashingAutomation.Components
{
    partial class WaitForm
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
            this.components = new Container();
            this.Gif_Pbx = new PictureBox();
            this.Form_Lbl = new Label();
            ((ISupportInitialize)(this.Gif_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Gif_Pbx
            // 
            this.Gif_Pbx.Dock = DockStyle.Fill;
            this.Gif_Pbx.Name = "Gif_Pbx";
            this.Gif_Pbx.SizeMode = PictureBoxSizeMode.Zoom;
            this.Gif_Pbx.TabIndex = 1;
            this.Gif_Pbx.TabStop = false;
            // 
            // Form_Lbl
            // 
            this.Form_Lbl.BackColor = Color.Transparent;
            this.Form_Lbl.Dock = DockStyle.Fill;
            this.Form_Lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.Form_Lbl.Name = "Form_Lbl";
            this.Form_Lbl.TabIndex = 2;
            this.Form_Lbl.ForeColor = Color.Silver;
            //
            //WaitForm_Gif
            //
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 300);
            this.Icon = Properties.Resources.CarWashingAutomation_Icon;
            this.BackColor = Color.FromArgb(16, 154, 208);
            this.Padding = new Padding(3);
            this.StartPosition = FormStartPosition.CenterParent;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(this.Form_Lbl);
            this.Controls.Add(this.Gif_Pbx);
            this.Text = "WaitForm_Gif";
            ((ISupportInitialize)(this.Gif_Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private PictureBox Gif_Pbx;
        private Label Form_Lbl;
    }
}