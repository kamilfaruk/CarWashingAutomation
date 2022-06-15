
using CarWashingAutomation.Components;
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Controls
{
    partial class MachineStatusesOfRelay
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
            this.MoneyHopperRelay_Lbl = new Label();
            this.WaterFlowRelay_Lbl = new Label();
            this.WaterMopRelay_Lbl = new Label();
            this.FoamAirRelay_Lbl = new Label();
            this.VacuumVarnishRelay_Lbl = new Label();
            this.BuzzerRelay_Lbl = new Label();
            this.Main_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            this.Main_Table.RowCount = 3;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            this.Main_Table.Controls.Add(this.MoneyHopperRelay_Lbl, 0, 0);
            this.Main_Table.Controls.Add(this.WaterFlowRelay_Lbl, 1, 0);
            this.Main_Table.Controls.Add(this.BuzzerRelay_Lbl, 2, 0);
            this.Main_Table.Controls.Add(this.WaterMopRelay_Lbl, 0, 1);
            this.Main_Table.Controls.Add(this.FoamAirRelay_Lbl, 1, 1);
            this.Main_Table.Controls.Add(this.VacuumVarnishRelay_Lbl, 2, 1);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            //MoneyHopperRelay_Lbl
            // 
            this.MoneyHopperRelay_Lbl.Dock = DockStyle.Fill;
            this.MoneyHopperRelay_Lbl.BackColor = Color.Transparent;
            this.MoneyHopperRelay_Lbl.Name = "MoneyHopperRelay_Lbl";
            this.MoneyHopperRelay_Lbl.Text = "Para Haznesi";
            this.MoneyHopperRelay_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoneyHopperRelay_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
            this.MoneyHopperRelay_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //WaterFlowRelay_Lbl
            // 
            this.WaterFlowRelay_Lbl.Dock = DockStyle.Fill;
            this.WaterFlowRelay_Lbl.BackColor = Color.Transparent;
            this.WaterFlowRelay_Lbl.Name = "WaterFlowRelay_Lbl";
            this.WaterFlowRelay_Lbl.Text = "Su Akışı";
            this.WaterFlowRelay_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WaterFlowRelay_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
            this.WaterFlowRelay_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //WaterMopRelay_Lbl
            // 
            this.WaterMopRelay_Lbl.Dock = DockStyle.Fill;
            this.WaterMopRelay_Lbl.BackColor = Color.Transparent;
            this.WaterMopRelay_Lbl.Name = "WaterMopRelay_Lbl";
            this.WaterMopRelay_Lbl.Text = "Yıkama/Paspas";
            this.WaterMopRelay_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WaterMopRelay_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
            this.WaterMopRelay_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //FoamAirRelay_Lbl
            // 
            this.FoamAirRelay_Lbl.Dock = DockStyle.Fill;
            this.FoamAirRelay_Lbl.BackColor = Color.Transparent;
            this.FoamAirRelay_Lbl.Name = "FoamAirRelay_Lbl";
            this.FoamAirRelay_Lbl.Text = "Köpük/Hava";
            this.FoamAirRelay_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FoamAirRelay_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
            this.FoamAirRelay_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //VacuumVarnishRelay_Lbl
            // 
            this.VacuumVarnishRelay_Lbl.Dock = DockStyle.Fill;
            this.VacuumVarnishRelay_Lbl.BackColor = Color.Transparent;
            this.VacuumVarnishRelay_Lbl.Name = "VacuumVarnishRelay_Lbl";
            this.VacuumVarnishRelay_Lbl.Text = "Süpürge/Cila";
            this.VacuumVarnishRelay_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VacuumVarnishRelay_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
            this.VacuumVarnishRelay_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //BuzzerRelay_Lbl
            // 
            this.BuzzerRelay_Lbl.Dock = DockStyle.Fill;
            this.BuzzerRelay_Lbl.BackColor = Color.Transparent;
            this.BuzzerRelay_Lbl.Name = "BuzzerRelay_Lbl";
            this.BuzzerRelay_Lbl.Text = "Buzzer";
            this.BuzzerRelay_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BuzzerRelay_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
            this.BuzzerRelay_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //MachineStatusesOfRelay
            //
            components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += MachineStatusesOfRelay_Load;
            //this.Disposed += MachineDetails_Disposed;
            this.Controls.Add(this.Main_Table);
            this.BackColor = Color.FromArgb(37, 40, 45);
            this.Name = "MachineStatusesOfRelay";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Label MoneyHopperRelay_Lbl;
        private Label WaterFlowRelay_Lbl;
        private Label WaterMopRelay_Lbl;
        private Label FoamAirRelay_Lbl;
        private Label VacuumVarnishRelay_Lbl;
        private Label BuzzerRelay_Lbl;
    }
}
