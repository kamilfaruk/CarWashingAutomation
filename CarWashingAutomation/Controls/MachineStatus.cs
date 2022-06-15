/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Models;
using CarWashingAutomation.Components;

namespace CarWashingAutomation.Controls
{
    public partial class MachineStatus : UserControl
    {
        Machine Main_Machine;
        Timer Refresh_Timer;
        int RefreshPeriodMs = 1000;
        public MachineStatus(int _machineId)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    Main_Machine = _dbManager.GetMachine(_machineId);
                    if (Main_Machine != null)
                    {
                        InitializeComponent();
                        if (Refresh_Timer == null)
                        {
                            Refresh_Timer = new Timer();
                            Refresh_Timer.Interval = RefreshPeriodMs;
                            Refresh_Timer.Enabled = true;
                            Refresh_Timer.Tick += Refresh_Timer_Tick;
                            Refresh_Timer.Start();
                        }
                        else
                        {
                            Refresh_Timer.Enabled = true;
                            Refresh_Timer.Start();
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatus.MachineStatus -> ", _ex);
            }
        }

        private void Refresh_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Parent.Parent != null)
            {
                if (this.Parent.Parent.Parent.Parent.Parent is Forms.MainForm)
                {
                    Forms.MainForm _mainForm = (Forms.MainForm)this.Parent.Parent.Parent.Parent.Parent;
                    if (_mainForm.CommunicationErrorList.Contains(Main_Machine.Id))
                    {
                        this.Alias_Lbl.Text = Main_Machine.Alias;
                        this.CurrentMoney_Lbl.Text = "HATA";
                        this.CurrentCountdownValue_Lbl.Text = "";
                        this.CurrentMode_Lbl.Text = "";
                    }
                    else
                    {
                        using (DBManager _dbManager = new DBManager())
                        {
                            Main_Machine = _dbManager.GetMachine(Main_Machine.Id);
                            if (Main_Machine != null)
                            {
                                this.Alias_Lbl.Text = Main_Machine.Alias;
                                this.CurrentMoney_Lbl.Text = Main_Machine.CurrentMoney.ToString() + "TL";
                                this.CurrentCountdownValue_Lbl.Text = Main_Machine.CountdownValue.ToString();
                                this.CurrentMode_Lbl.Text = Main_Machine.GetCurrentMode();
                            }
                        }
                    }
                }
            }
        }
        private void MachineStatus_Disposed(object sender, EventArgs e)
        {
            try
            {
                Refresh_Timer.Enabled = false;
                Refresh_Timer.Stop();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatus.MachineStatus_DisposedE -> ", _ex);
            }
        }
        private void MachineStatus_Load(object sender, EventArgs e)
        {
            try
            {
                this.Alias_Lbl.Text = Main_Machine.Alias;
                this.CurrentMoney_Lbl.Text = Main_Machine.CurrentMoney.ToString() + "TL";
                this.CurrentMode_Lbl.Text = Main_Machine.GetCurrentMode();
                this.CurrentCountdownValue_Lbl.Text = Main_Machine.CountdownValue.ToString();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatus.MachineStatus_Load -> ", _ex);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                base.OnPaint(e);
                Graphics g = e.Graphics;
                int _frameLenght = 2;
                Rectangle _rectangle = new Rectangle(new Point(_frameLenght, _frameLenght), new Size(this.Width - 2 * _frameLenght, this.Height - 2 * _frameLenght));
                Pen _pen;
                Brush _brush;
                if (Main_Machine.DeviceStatus == 0)
                {
                    _brush = new SolidBrush(Color.FromArgb(147, 80, 83));
                    _pen = new Pen(Color.FromArgb(230, 90, 90), _frameLenght);
                }
                else
                {
                    string _currentMode = Main_Machine.GetCurrentMode();
                    if (_currentMode == "---")
                    {
                        _brush = new SolidBrush(Color.FromArgb(52, 91, 109));
                        _pen = new Pen(Color.FromArgb(16, 154, 208), _frameLenght);
                    }
                    else
                    {
                        _brush = new SolidBrush(Color.FromArgb(45, 115, 68));
                        _pen = new Pen(Color.FromArgb(25, 160, 60), _frameLenght);
                    }
                }
                g.DrawRectangle(_pen, _rectangle);
                g.FillRectangle(_brush, _rectangle);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatus.OnPaint -> ", _ex);
            }
        }
    }
}
