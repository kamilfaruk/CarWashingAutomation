using System.Drawing;
using System.Windows.Forms;
namespace CarWashingAutomation.Controls
{
    partial class MachineOverview
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
            this.Alias_Lbl = new Label();
            this.CurrentMoney_Lbl = new Label();
            this.CurrentMode_Lbl = new Label();
            this.CurrentTemperature_Lbl = new Label();
            this.FlowAlarm_Pbx = new PictureBox();
            this.TemperatureAlarm_Pbx = new PictureBox();
            this.Main_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Main_Table.RowCount = 6;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Alias_Lbl, 0, 0);
            this.Main_Table.SetColumnSpan(this.Alias_Lbl, 2);
            this.Main_Table.Controls.Add(this.CurrentMoney_Lbl, 0, 1);
            this.Main_Table.SetColumnSpan(this.CurrentMoney_Lbl, 2);
            this.Main_Table.Controls.Add(this.CurrentMode_Lbl, 0, 2);
            this.Main_Table.SetColumnSpan(this.CurrentMode_Lbl, 2);
            this.Main_Table.Controls.Add(this.CurrentTemperature_Lbl, 0, 3);
            this.Main_Table.SetColumnSpan(this.CurrentTemperature_Lbl, 2);
            this.Main_Table.Controls.Add(this.FlowAlarm_Pbx, 0, 5);
            this.Main_Table.Controls.Add(this.TemperatureAlarm_Pbx, 1, 5);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            // Alias_Lbl
            // 
            this.Alias_Lbl.Dock = DockStyle.Fill;
            this.Alias_Lbl.BackColor = Color.Transparent;
            this.Alias_Lbl.Name = "Alias_Lbl";
            this.Alias_Lbl.Text = "---";
            this.Alias_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Alias_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.Alias_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // CurrentMoney_Lbl
            // 
            this.CurrentMoney_Lbl.Dock = DockStyle.Fill;
            this.CurrentMoney_Lbl.BackColor = Color.Transparent;
            this.CurrentMoney_Lbl.Name = "CurrentMoney_Lbl";
            this.CurrentMoney_Lbl.Text = "---";
            this.CurrentMoney_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentMoney_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.CurrentMoney_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // CurrentMode_Lbl
            // 
            this.CurrentMode_Lbl.Dock = DockStyle.Fill;
            this.CurrentMode_Lbl.BackColor = Color.Transparent;
            this.CurrentMode_Lbl.Name = "CurrentMoney_Lbl";
            this.CurrentMode_Lbl.Text = "---";
            this.CurrentMode_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentMode_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.CurrentMode_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // CurrentTemperature_Lbl
            // 
            this.CurrentTemperature_Lbl.Dock = DockStyle.Fill;
            this.CurrentTemperature_Lbl.BackColor = Color.Transparent;
            this.CurrentTemperature_Lbl.Name = "CurrentTemperature_Lbl";
            this.CurrentTemperature_Lbl.Text = "---";
            this.CurrentTemperature_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentTemperature_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.CurrentTemperature_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //FlowAlarm_Pbx
            //
            this.FlowAlarm_Pbx.Image = Properties.Resources.FlowAlarm_Image;
            this.FlowAlarm_Pbx.Dock = DockStyle.Fill;
            this.FlowAlarm_Pbx.Margin = new Padding(4);
            this.FlowAlarm_Pbx.Name = "FlowAlarm_Pbx";
            this.FlowAlarm_Pbx.SizeMode = PictureBoxSizeMode.Zoom;
            this.FlowAlarm_Pbx.TabStop = false;
            //
            //TemperatureAlarm_Pbx
            //
            this.TemperatureAlarm_Pbx.Image = Properties.Resources.TemperatureAlarm_Image;
            this.TemperatureAlarm_Pbx.Dock = DockStyle.Fill;
            this.TemperatureAlarm_Pbx.Margin = new Padding(4);
            this.TemperatureAlarm_Pbx.Name = "TemperatureAlarm_Pbx";
            this.TemperatureAlarm_Pbx.SizeMode = PictureBoxSizeMode.Zoom;
            this.TemperatureAlarm_Pbx.TabStop = false;
            // 
            // MachineOverview
            // 
            components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += MachineOverview_Load;
            this.Disposed += MachineOverview_Disposed;
            this.Controls.Add(this.Main_Table);
            this.Name = "MachineOverview";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Label Alias_Lbl;
        private Label CurrentMoney_Lbl;
        private Label CurrentMode_Lbl;
        private Label CurrentTemperature_Lbl;
        private PictureBox FlowAlarm_Pbx;
        private PictureBox TemperatureAlarm_Pbx;

    }
}
