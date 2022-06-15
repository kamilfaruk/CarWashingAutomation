/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Models;
using CarWashingAutomation.Components;
using System.Collections.Generic;

namespace CarWashingAutomation.Controls
{
    public partial class MachineOverview : UserControl
    {
        Machine Main_Machine;
        Timer Refresh_Timer;
        int RefreshPeriodMs = 1000;
        public MachineOverview(int _machineId)
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
                            Refresh_Timer.Tick += RefreshTimer_Tick;
                            Refresh_Timer.Start();
                        }
                        else
                        {
                            Refresh_Timer.Enabled = true;
                            Refresh_Timer.Start();
                        }
                    }
                    else
                    {
                        this.BackColor = Color.FromArgb(147, 80, 83);
                        Label _infoLbl = new Label();
                        _infoLbl.Dock = DockStyle.Fill;
                        _infoLbl.BackColor = Color.Transparent;
                        _infoLbl.Name = "_infoLbl";
                        _infoLbl.Text = "CİHAZ BULUNAMADI";
                        _infoLbl.TextAlign = ContentAlignment.MiddleCenter;
                        _infoLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                        _infoLbl.ForeColor = Color.FromArgb(192, 192, 192);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineOverview.MachineOverview -> ", _ex);
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            using (DBManager _dbManager = new DBManager())
            {
                Machine _machine = _dbManager.GetMachine(Main_Machine.Id);
                if (_machine != null)
                {
                    Main_Machine = _machine;
                    Alias_Lbl.Text = Main_Machine.Alias;
                    CurrentMoney_Lbl.Text = Main_Machine.CurrentMoney + " TL";
                    CurrentTemperature_Lbl.Text = Main_Machine.CurrentTemperature + " °C";
                    CurrentMode_Lbl.Text = Main_Machine.GetCurrentMode();
                    FlowAlarm_Pbx.Image = Properties.Resources.FlowAlarm_Image;
                    TemperatureAlarm_Pbx.Image = Properties.Resources.TemperatureAlarm_Image;
                    List<string> _alarmList = Main_Machine.GetAlarms();
                    if (_alarmList.Contains("Acil Stop"))
                    {
                        FlowAlarm_Pbx.Image = Properties.Resources.EmergencyStop;
                        TemperatureAlarm_Pbx.Image = Properties.Resources.EmergencyStop;
                    }
                    else
                    {
                        if (_alarmList.Contains("Yüksek Akış"))
                        {
                            FlowAlarm_Pbx.Image = Properties.Resources.HighFlowAlarm_Image;
                        }
                        else if (_alarmList.Contains("Düşük Akış"))
                        {
                            FlowAlarm_Pbx.Image = Properties.Resources.LowFlowAlarm_Image;
                        }
                        if (_alarmList.Contains("Yüksek Sıcaklık"))
                        {
                            TemperatureAlarm_Pbx.Image = Properties.Resources.HighTemperatureAlarm_Image;
                        }
                        else if (_alarmList.Contains("Düşük Sıcaklık"))
                        {
                            TemperatureAlarm_Pbx.Image = Properties.Resources.LowTemperatureAlarm_Image;
                        }
                    }



                }
            }
        }
        private void MachineOverview_Disposed(object sender, System.EventArgs e)
        {
            try
            {
                Refresh_Timer.Enabled = false;
                Refresh_Timer.Stop();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineOverview.MachineOverview_Disposed -> ", _ex);
            }
        }
        private void MachineOverview_Load(object sender, EventArgs e)
        {
            try
            {
                Alias_Lbl.Text = Main_Machine.Alias;
                CurrentMoney_Lbl.Text = Main_Machine.CurrentMoney + " TL";
                CurrentTemperature_Lbl.Text = Main_Machine.CurrentTemperature + " °C";
                CurrentMode_Lbl.Text = Main_Machine.GetCurrentMode();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineOverview.MachineOverview_Load -> ", _ex);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                base.OnPaint(e);
                Graphics g = e.Graphics;
                int _frameLenght = 3;
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
                Logger.WriteLog("MachineOverview.OnPaint -> ", _ex);
            }
        }
    }
}
