/* Coder by KFY */
using CarWashingAutomation.Components;
using CarWashingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Controls
{
    public partial class MachineStatusesOfRelay : UserControl
    {
        Machine Main_Machine;
        List<string> StatusesOfRelay;
        Timer Refresh_Timer;
        int RefreshPeriodMs = 1000;
        public MachineStatusesOfRelay(int _machineId)
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
                Logger.WriteLog("MachineStatusesOfRelay.MachineStatusesOfRelay -> ", _ex);
            }
        }

        private void Refresh_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    Machine _machine = _dbManager.GetMachine(Main_Machine.Id);
                    if (_machine != null)
                    {
                        Main_Machine = _machine;
                        RefreshControl();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatusesOfRelay.Refresh_Timer_Tick -> ", _ex);
            }
        }

        private void MachineStatusesOfRelay_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshControl();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatusesOfRelay.MachineStatusesOfRelay_Load -> ", _ex);
            }
        }
        public void RefreshControl()
        {
            try
            {
                StatusesOfRelay = Main_Machine.GetActiveOutputs();
                MoneyHopperRelay_Lbl.BackColor = WaterFlowRelay_Lbl.BackColor = WaterMopRelay_Lbl.BackColor = Color.Transparent;
                FoamAirRelay_Lbl.BackColor = VacuumVarnishRelay_Lbl.BackColor = BuzzerRelay_Lbl.BackColor = Color.Transparent;
                if (StatusesOfRelay.Contains("Paramatik"))
                {
                    MoneyHopperRelay_Lbl.BackColor = Color.FromArgb(25, 160, 60);
                }
                if (StatusesOfRelay.Contains("Su Akış"))
                {
                    WaterFlowRelay_Lbl.BackColor = Color.FromArgb(25, 160, 60);
                }
                if (StatusesOfRelay.Contains("Yıkama") || StatusesOfRelay.Contains("Paspas"))
                {
                    WaterMopRelay_Lbl.BackColor = Color.FromArgb(25, 160, 60);
                }
                if (StatusesOfRelay.Contains("Köpük") || StatusesOfRelay.Contains("Hava"))
                {
                    FoamAirRelay_Lbl.BackColor = Color.FromArgb(25, 160, 60);
                }
                if (StatusesOfRelay.Contains("Süpürge") || StatusesOfRelay.Contains("Cila"))
                {
                    VacuumVarnishRelay_Lbl.BackColor = Color.FromArgb(25, 160, 60);
                }
                if (StatusesOfRelay.Contains("Buzzer"))
                {
                    BuzzerRelay_Lbl.BackColor = Color.FromArgb(25, 160, 60);
                }
                StatusesOfRelay.Clear();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatusesOfRelay.MachineStatusesOfRelay_Load -> ", _ex);
            }
        }
    }
}
