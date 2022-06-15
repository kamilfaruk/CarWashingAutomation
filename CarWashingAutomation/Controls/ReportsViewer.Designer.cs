
using CarWashingAutomation.Components;
using System.Windows.Forms;

namespace CarWashingAutomation.Controls
{
    partial class ReportsViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsViewer));
            this.Main_Table = new System.Windows.Forms.TableLayoutPanel();
            this.ReportSelect_Lbl = new System.Windows.Forms.Label();
            this.ReportSelect_Cbx = new CarWashingAutomation.Components.Custom_ComboBox();
            this.ReadReport_Btn = new System.Windows.Forms.Button();
            this.NewReport_Btn = new System.Windows.Forms.Button();
            this.PDFViewer_Adobe = new AxAcroPDFLib.AxAcroPDF();
            this.Main_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer_Adobe)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Table
            // 
            this.Main_Table.BackColor = System.Drawing.Color.Transparent;
            this.Main_Table.ColumnCount = 4;
            this.Main_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Main_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Main_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Main_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Main_Table.Controls.Add(this.ReportSelect_Lbl, 0, 0);
            this.Main_Table.Controls.Add(this.ReportSelect_Cbx, 1, 0);
            this.Main_Table.Controls.Add(this.ReadReport_Btn, 2, 0);
            this.Main_Table.Controls.Add(this.NewReport_Btn, 3, 0);
            this.Main_Table.Controls.Add(this.PDFViewer_Adobe, 0, 1);
            this.Main_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Table.Location = new System.Drawing.Point(0, 0);
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Main_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_Table.Size = new System.Drawing.Size(150, 150);
            this.Main_Table.TabIndex = 0;
            // 
            // ReportSelect_Lbl
            // 
            this.ReportSelect_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.ReportSelect_Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportSelect_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportSelect_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReportSelect_Lbl.Location = new System.Drawing.Point(3, 0);
            this.ReportSelect_Lbl.Name = "ReportSelect_Lbl";
            this.ReportSelect_Lbl.Size = new System.Drawing.Size(46, 40);
            this.ReportSelect_Lbl.TabIndex = 0;
            this.ReportSelect_Lbl.Text = "İncelemek İstediğiniz Raporu Seçiniz:";
            this.ReportSelect_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReportSelect_Cbx
            // 
            this.ReportSelect_Cbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ReportSelect_Cbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(154)))), ((int)(((byte)(208)))));
            this.ReportSelect_Cbx.BorderSize = 1;
            this.ReportSelect_Cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportSelect_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ReportSelect_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportSelect_Cbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReportSelect_Cbx.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(154)))), ((int)(((byte)(208)))));
            this.ReportSelect_Cbx.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ReportSelect_Cbx.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReportSelect_Cbx.Location = new System.Drawing.Point(55, 3);
            this.ReportSelect_Cbx.MinimumSize = new System.Drawing.Size(100, 20);
            this.ReportSelect_Cbx.Name = "ReportSelect_Cbx";
            this.ReportSelect_Cbx.Padding = new System.Windows.Forms.Padding(1);
            this.ReportSelect_Cbx.Size = new System.Drawing.Size(100, 34);
            this.ReportSelect_Cbx.TabIndex = 1;
            this.ReportSelect_Cbx.Texts = "";
            // 
            // ReadReport_Btn
            // 
            this.ReadReport_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadReport_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(154)))), ((int)(((byte)(208)))));
            this.ReadReport_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ReadReport_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ReadReport_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadReport_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReadReport_Btn.Image = global::CarWashingAutomation.Properties.Resources.Save_Image;
            this.ReadReport_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadReport_Btn.Location = new System.Drawing.Point(92, 3);
            this.ReadReport_Btn.Name = "ReadReport_Btn";
            this.ReadReport_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ReadReport_Btn.Size = new System.Drawing.Size(24, 34);
            this.ReadReport_Btn.TabIndex = 5;
            this.ReadReport_Btn.Text = "RAPORU OKU";
            this.ReadReport_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadReport_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReadReport_Btn.UseVisualStyleBackColor = true;
            this.ReadReport_Btn.Click += new System.EventHandler(this.ReadReport_Btn_Click);
            // 
            // NewReport_Btn
            // 
            this.NewReport_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewReport_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(154)))), ((int)(((byte)(208)))));
            this.NewReport_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.NewReport_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.NewReport_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewReport_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NewReport_Btn.Image = global::CarWashingAutomation.Properties.Resources.Save_Image;
            this.NewReport_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewReport_Btn.Location = new System.Drawing.Point(122, 3);
            this.NewReport_Btn.Name = "NewReport_Btn";
            this.NewReport_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.NewReport_Btn.Size = new System.Drawing.Size(25, 34);
            this.NewReport_Btn.TabIndex = 5;
            this.NewReport_Btn.Text = "YENİ RAPOR";
            this.NewReport_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewReport_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewReport_Btn.UseVisualStyleBackColor = true;
            this.NewReport_Btn.Click += new System.EventHandler(this.NewReport_Btn_Click);
            // 
            // PDFViewer_Adobe
            // 
            this.Main_Table.SetColumnSpan(this.PDFViewer_Adobe, 4);
            this.PDFViewer_Adobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDFViewer_Adobe.Enabled = true;
            this.PDFViewer_Adobe.Location = new System.Drawing.Point(3, 43);
            this.PDFViewer_Adobe.Name = "PDFViewer_Adobe";
            this.PDFViewer_Adobe.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFViewer_Adobe.OcxState")));
            this.PDFViewer_Adobe.Size = new System.Drawing.Size(144, 104);
            this.PDFViewer_Adobe.TabIndex = 0;
            // 
            // ReportsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_Table);
            this.Name = "ReportsViewer";
            this.Load += ReportsViewer_Load;
            this.Main_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer_Adobe)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Label ReportSelect_Lbl;
        private Custom_ComboBox ReportSelect_Cbx;
        private Button ReadReport_Btn;
        private Button NewReport_Btn;
        private AxAcroPDFLib.AxAcroPDF PDFViewer_Adobe;
    }
}