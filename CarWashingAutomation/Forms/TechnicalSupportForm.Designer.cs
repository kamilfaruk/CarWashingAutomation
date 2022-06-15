using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Components;
using CarWashingAutomation.Tools;
namespace CarWashingAutomation.Forms
{
    partial class TechnicalSupportForm
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
            this.Main_Table = new TableLayoutPanel();
            this.Close_Btn = new Button();
            this.Subject_Lbl = new Label();
            this.Subject_Txt = new Custom_TextBox();
            this.Message_Lbl = new Label();
            this.Message_Txt = new RichTextBox();
            this.Bottom_Table = new TableLayoutPanel();
            this.Send_Btn = new Button();
            this.Info_Lbl = new Label();
            this.Main_Table.SuspendLayout();
            this.Bottom_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Table
            // 
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 4;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            this.Main_Table.RowCount = 6;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 33));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            this.Main_Table.Controls.Add(this.Close_Btn, 0, 0);
            this.Main_Table.Controls.Add(this.Subject_Lbl, 2, 1);
            this.Main_Table.Controls.Add(this.Subject_Txt, 2, 2);
            this.Main_Table.Controls.Add(this.Message_Lbl, 2, 3);
            this.Main_Table.Controls.Add(this.Message_Txt, 2, 4);
            this.Main_Table.Controls.Add(this.Bottom_Table, 2, 5);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Location = new System.Drawing.Point(0, 0);
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.Size = new System.Drawing.Size(800, 450);
            this.Main_Table.TabIndex = 0;
            // 
            // Subject_Lbl
            // 
            this.Subject_Lbl.AutoSize = true;
            this.Subject_Lbl.Dock = DockStyle.Fill;
            this.Subject_Lbl.Location = new System.Drawing.Point(3, 0);
            this.Subject_Lbl.Name = "Subject_Lbl";
            this.Subject_Lbl.Size = new System.Drawing.Size(794, 36);
            this.Subject_Lbl.TabIndex = 1;
            this.Subject_Lbl.Text = "Konu";
            this.Subject_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subject_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.Subject_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Subject_Txt
            // 
            this.Subject_Txt.AutoSize = true;
            this.Subject_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.Subject_Txt.TextAlign = HorizontalAlignment.Left;
            this.Subject_Txt.BorderColor = Color.FromArgb(16, 154, 208);
            this.Subject_Txt.BorderFocusColor = Color.FromArgb(11, 112, 152);
            this.Subject_Txt.UnderlinedStyle = true;
            this.Subject_Txt.Dock = DockStyle.Fill;
            this.Subject_Txt.Name = "Subject_Txt";
            this.Subject_Txt.TabIndex = 0;
            this.Subject_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Subject_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Message_Lbl
            // 
            this.Message_Lbl.AutoSize = true;
            this.Message_Lbl.Dock = DockStyle.Fill;
            this.Message_Lbl.Location = new System.Drawing.Point(3, 99);
            this.Message_Lbl.Name = "Message_Lbl";
            this.Message_Lbl.Size = new System.Drawing.Size(794, 36);
            this.Message_Lbl.TabIndex = 2;
            this.Message_Lbl.Text = "Mesaj";
            this.Message_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Message_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.Message_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Message_Txt
            // 
            this.Message_Txt.Dock = DockStyle.Fill;
            this.Message_Txt.Location = new System.Drawing.Point(3, 138);
            this.Message_Txt.Name = "Message_Txt";
            this.Message_Txt.Size = new System.Drawing.Size(794, 219);
            this.Message_Txt.TabIndex = 3;
            this.Message_Txt.Text = "";
            this.Message_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Message_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            this.Message_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            // 
            // Bottom_Table
            // 
            this.Bottom_Table.BackColor = Color.Transparent;
            this.Bottom_Table.ColumnCount = 2;
            this.Bottom_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Bottom_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            this.Bottom_Table.Controls.Add(this.Send_Btn, 0, 0);
            this.Bottom_Table.Controls.Add(this.Info_Lbl, 1, 0);
            this.Bottom_Table.Dock = DockStyle.Fill;
            this.Bottom_Table.Location = new System.Drawing.Point(3, 363);
            this.Bottom_Table.Name = "Bottom_Table";
            this.Bottom_Table.RowCount = 1;
            this.Bottom_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Bottom_Table.Size = new System.Drawing.Size(794, 84);
            this.Bottom_Table.TabIndex = 0;
            // 
            // Send_Btn
            // 
            this.Send_Btn.Dock = DockStyle.Fill;
            this.Send_Btn.FlatAppearance.BorderColor = Color.FromArgb(16, 154, 208);
            this.Send_Btn.FlatAppearance.BorderSize = 1;
            this.Send_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Send_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Send_Btn.FlatStyle = FlatStyle.Flat;
            this.Send_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Send_Btn.Image = Properties.Resources.SendMessage_Image;
            this.Send_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Send_Btn.Location = new System.Drawing.Point(0, 512);
            this.Send_Btn.Name = "Send_Btn";
            this.Send_Btn.Padding = new Padding(5, 0, 0, 0);
            this.Send_Btn.Size = new System.Drawing.Size(229, 45);
            this.Send_Btn.TabIndex = 5;
            this.Send_Btn.Text = "GÖNDER";
            this.Send_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Send_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.Send_Btn.UseVisualStyleBackColor = true;
            this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
            // 
            // Info_Lbl
            // 
            this.Info_Lbl.AutoSize = true;
            this.Info_Lbl.Dock = DockStyle.Fill;
            this.Info_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.Info_Lbl.Location = new System.Drawing.Point(241, 0);
            this.Info_Lbl.Name = "Info_Lbl";
            this.Info_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Info_Lbl.Size = new System.Drawing.Size(550, 84);
            this.Info_Lbl.TabIndex = 5;
            this.Info_Lbl.Visible = false;
            // 
            // Close_Btn
            // 
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Close_Btn.FlatStyle = FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.Close_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Close_Btn.Location = new System.Drawing.Point(0, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(25, 25);
            this.Close_Btn.Image = ((System.Drawing.Image)(Properties.Resources.Close_Image));
            this.Close_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            //TechnicalSupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(47, 52, 58);
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(Main_Table);
            this.Text = "TechnicalSupportForm";
            this.Name = "TechnicalSupportForm";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Bottom_Table.ResumeLayout(false);
            this.Bottom_Table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private TableLayoutPanel Main_Table;
        private Button Close_Btn;
        private Custom_TextBox Subject_Txt;
        private Label Subject_Lbl;
        private Label Message_Lbl;
        private RichTextBox Message_Txt;
        private TableLayoutPanel Bottom_Table;
        private Button Send_Btn;
        private Label Info_Lbl;
    }
}