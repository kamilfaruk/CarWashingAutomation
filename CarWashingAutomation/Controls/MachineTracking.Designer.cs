using CarWashingAutomation.Components;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace CarWashingAutomation.Controls
{
    partial class MachineTracking
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
            this.Version_Lbl = new Label();
            this.DeviceStatus_Lbl = new Label();
            this.DeviceStatus_TglBtn = new Custom_ToggleButton();
            this.MoneyHopperState_Lbl = new Label();
            this.MoneyHopperState_TglBtn = new Custom_ToggleButton();
            this.P10Usage_Lbl = new Label();
            this.P10Usage_TglBtn = new Custom_ToggleButton();
            this.FlowAlarmIsActive_Lbl = new Label();
            this.FlowAlarmIsActive_TglBtn = new Custom_ToggleButton();
            this.Main_MachineStatusesOfRelay = new MachineStatusesOfRelay(Main_Machine.Id);
            this.Main_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.Main_Table.RowCount = 6;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            this.Main_Table.Controls.Add(this.Alias_Lbl, 0, 0);
            this.Main_Table.SetColumnSpan(this.Alias_Lbl, 2);
            this.Main_Table.Controls.Add(this.Version_Lbl, 0, 1);
            this.Main_Table.SetColumnSpan(this.Version_Lbl, 2);
            this.Main_Table.Controls.Add(this.DeviceStatus_Lbl, 0, 2);
            this.Main_Table.Controls.Add(this.DeviceStatus_TglBtn, 1, 2);
            //this.Main_Table.Controls.Add(this.MoneyHopperState_Lbl, 0, 3);
            //this.Main_Table.Controls.Add(this.MoneyHopperState_TglBtn, 1, 3);
            this.Main_Table.Controls.Add(this.P10Usage_Lbl, 0, 3);
            this.Main_Table.Controls.Add(this.P10Usage_TglBtn, 1, 3);
            this.Main_Table.Controls.Add(this.FlowAlarmIsActive_Lbl, 0, 4);
            this.Main_Table.Controls.Add(this.FlowAlarmIsActive_TglBtn, 1, 4);
            this.Main_Table.Controls.Add(this.Main_MachineStatusesOfRelay, 0, 5);
            this.Main_Table.SetColumnSpan(this.Main_MachineStatusesOfRelay, 2);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.DoubleClick += ControlDoubleClick;
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
            this.Alias_Lbl.DoubleClick += ControlDoubleClick;
            // 
            // Version_Lbl
            // 
            this.Version_Lbl.Dock = DockStyle.Fill;
            this.Version_Lbl.BackColor = Color.Transparent;
            this.Version_Lbl.Name = "Version_Lbl";
            this.Version_Lbl.Text = "(---)";
            this.Version_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Version_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
            this.Version_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            this.Version_Lbl.DoubleClick += ControlDoubleClick;
            // 
            // DeviceStatus_Lbl
            // 
            this.DeviceStatus_Lbl.Dock = DockStyle.Fill;
            this.DeviceStatus_Lbl.BackColor = Color.Transparent;
            this.DeviceStatus_Lbl.Name = "DeviceStatus_Lbl";
            this.DeviceStatus_Lbl.Text = "Cihaz Durumu: ";
            this.DeviceStatus_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeviceStatus_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.DeviceStatus_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            this.DeviceStatus_Lbl.DoubleClick += ControlDoubleClick;
            //
            //DeviceStatus_TglBtn
            //
            this.DeviceStatus_TglBtn.Dock = DockStyle.Fill;
            this.DeviceStatus_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154); 
            this.DeviceStatus_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.DeviceStatus_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.DeviceStatus_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.DeviceStatus_TglBtn.Checked = false;
            // 
            // MoneyHopperState_Lbl
            // 
            this.MoneyHopperState_Lbl.Dock = DockStyle.Fill;
            this.MoneyHopperState_Lbl.BackColor = Color.Transparent;
            this.MoneyHopperState_Lbl.Name = "MoneyHopperState_Lbl";
            this.MoneyHopperState_Lbl.Text = "Para Haznesi: ";
            this.MoneyHopperState_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoneyHopperState_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.MoneyHopperState_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            this.MoneyHopperState_Lbl.DoubleClick += ControlDoubleClick;
            //
            //MoneyHopperState_TglBtn
            //
            this.MoneyHopperState_TglBtn.Dock = DockStyle.Fill;
            this.MoneyHopperState_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.MoneyHopperState_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.MoneyHopperState_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.MoneyHopperState_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.MoneyHopperState_TglBtn.Checked = false;
            // 
            // P10Usage_Lbl
            // 
            this.P10Usage_Lbl.Dock = DockStyle.Fill;
            this.P10Usage_Lbl.BackColor = Color.Transparent;
            this.P10Usage_Lbl.Name = "P10Usage_Lbl";
            this.P10Usage_Lbl.Text = "Led Ekran: ";
            this.P10Usage_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.P10Usage_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.P10Usage_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            this.P10Usage_Lbl.DoubleClick += ControlDoubleClick;
            //
            //P10Usage_TglBtn
            //
            this.P10Usage_TglBtn.Dock = DockStyle.Fill;
            this.P10Usage_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.P10Usage_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.P10Usage_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.P10Usage_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.P10Usage_TglBtn.Checked = false;
            // 
            // FlowAlarmIsActive_Lbl
            // 
            this.FlowAlarmIsActive_Lbl.Dock = DockStyle.Fill;
            this.FlowAlarmIsActive_Lbl.BackColor = Color.Transparent;
            this.FlowAlarmIsActive_Lbl.Name = "FlowAlarmIsActive_Lbl";
            this.FlowAlarmIsActive_Lbl.Text = "Basınç Sensörü: ";
            this.FlowAlarmIsActive_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FlowAlarmIsActive_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.FlowAlarmIsActive_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            this.FlowAlarmIsActive_Lbl.DoubleClick += ControlDoubleClick;
            //
            //FlowAlarmIsActive_TglBtn
            //
            this.FlowAlarmIsActive_TglBtn.Dock = DockStyle.Fill;
            this.FlowAlarmIsActive_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.FlowAlarmIsActive_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.FlowAlarmIsActive_TglBtn.OnToggleColor = Color.FromArgb(25, 160, 60);
            this.FlowAlarmIsActive_TglBtn.OffToggleColor = Color.FromArgb(230, 90, 90);
            this.FlowAlarmIsActive_TglBtn.Checked = false;
            //
            //Main_MachineStatusesOfRelay
            //
            this.Main_MachineStatusesOfRelay.Dock = DockStyle.Fill;
            // 
            //MachineDetails
            // 
            components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += MachineDetails_Load;
            this.Disposed += MachineDetails_Disposed;
            this.Controls.Add(this.Main_Table);
            this.Name = "MachineDetails";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Label Alias_Lbl;
        private Label Version_Lbl;
        private Label DeviceStatus_Lbl;
        private Custom_ToggleButton DeviceStatus_TglBtn;
        private Label MoneyHopperState_Lbl;
        private Custom_ToggleButton MoneyHopperState_TglBtn;
        private Label P10Usage_Lbl;
        private Custom_ToggleButton P10Usage_TglBtn;
        private Label FlowAlarmIsActive_Lbl;
        private Custom_ToggleButton FlowAlarmIsActive_TglBtn;
        private MachineStatusesOfRelay Main_MachineStatusesOfRelay;


    }
}
