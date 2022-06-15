/* Coder by KFY */
using CarWashingAutomation.Components;
using CarWashingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarWashingAutomation.Controls
{
    public partial class AlarmsViewer : UserControl
    {
        public AlarmsViewer()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AlarmsViewer.AlarmsViewer -> ", _ex);
            }
        }
        private void AlarmsViewer_Load(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    FilterMachineName_Cbx.DataSource = _dbManager.GetMachineList();
                    MachineAlarm_Dgv.AutoGenerateColumns = false;
                    MachineAlarm_Dgv.DataSource = _dbManager.GetMachineAlarmList();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AlarmsViewer.AlarmsViewer_Load -> ", _ex);
            }
        }
        private void FilterClear_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                FilterStartTime_Dtp.Value = DateTime.Now;
                FilterStopTime_Dtp.Value = DateTime.Now;
                FilterMachineName_Cbx.SelectedIndex = -1;
                using (DBManager _dbManager = new DBManager())
                {
                    MachineAlarm_Dgv.AutoGenerateColumns = false;
                    MachineAlarm_Dgv.DataSource = _dbManager.GetMachineAlarmList();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AlarmsViewer.FilterClear_Btn_Click -> ", _ex);
            }
        }
        private void Filter_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Machine _filterMachine = ((Machine)FilterMachineName_Cbx.SelectedItem);
                DateTime _filterStartTime = FilterStartTime_Dtp.Value;
                _filterStartTime = _filterStartTime.AddHours(00 - _filterStartTime.Hour);
                _filterStartTime = _filterStartTime.AddMinutes(00 - _filterStartTime.Minute);
                _filterStartTime = _filterStartTime.AddSeconds(00 - _filterStartTime.Second);
                DateTime _filterStopTime = FilterStopTime_Dtp.Value;
                _filterStopTime = _filterStopTime.AddHours(23 - _filterStopTime.Hour);
                _filterStopTime = _filterStopTime.AddMinutes(59 - _filterStopTime.Minute);
                _filterStopTime = _filterStopTime.AddSeconds(59 - _filterStopTime.Second);
                using (DBManager _dbManager = new DBManager())
                {
                    List<MachineAlarm> _machineAlarmList = _dbManager.GetMachineAlarmList();
                    _machineAlarmList = _machineAlarmList.FindAll(_alarm => _alarm.Machine.Id == _filterMachine.Id);
                    _machineAlarmList = _machineAlarmList.FindAll(_alarm => DateTime.Parse(_alarm.AlarmDate) > _filterStartTime && DateTime.Parse(_alarm.AlarmDate) < _filterStopTime);
                    MachineAlarm_Dgv.AutoGenerateColumns = false;
                    MachineAlarm_Dgv.DataSource = _machineAlarmList;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AlarmsViewer.Filter_Btn_Click -> ", _ex);
            }
        }
    }
}
