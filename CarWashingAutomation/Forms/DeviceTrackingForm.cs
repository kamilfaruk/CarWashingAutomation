/* Coder by KFY */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CarWashingAutomation.Models;
using CarWashingAutomation.Controls;
using CarWashingAutomation.Components;

namespace CarWashingAutomation.Forms
{
    public partial class DeviceTrackingForm : Form
    {
        int TableColumnCount = 4;
        public DeviceTrackingForm()
        {
            try
            {
                InitializeComponent();
                this.SetStyle(ControlStyles.DoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
                this.SetStyle(ControlStyles.Opaque, false);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.ResizeRedraw, true);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingForm.DeviceTrackingForm -> ", _ex);
            }
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingForm.Close_Btn_Click -> ", _ex);
            }
        }
        private void DeviceTrackingForm_Load(object sender, EventArgs e)
        {
            try
            {
                Main_Pnl.Controls.Add(GetMachineTable());
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingForm.DeviceTrackingForm_Load -> ", _ex);
            }
        }
        private TableLayoutPanel GetMachineTable()
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    List<Machine> _machineList = _dbManager.GetMachineList();
                    int _rowCount = 0;
                    if (_machineList.Count % TableColumnCount == 0)
                    {
                        _rowCount = _machineList.Count / TableColumnCount;
                    }
                    else
                    {
                        _rowCount = (_machineList.Count / TableColumnCount) + 1;
                    }
                    TableLayoutPanel _machineTable = new TableLayoutPanel();
                    _machineTable.ColumnCount = TableColumnCount;
                    _machineTable.RowCount = _rowCount;
                    _machineTable.Width = Main_Pnl.Width;
                    _machineTable.Height = _rowCount * (Main_Pnl.Width / TableColumnCount);
                    int _searchCount = -1;
                    for (int _i = 0; _i < _machineTable.RowCount; _i++)
                    {
                        _machineTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                        for (int _j = 0; _j < _machineTable.ColumnCount; _j++)
                        {
                            _machineTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                            _searchCount += 1;
                            if (_searchCount < _machineList.Count)
                            {
                                Machine _machine = _machineList[_searchCount];
                                if (_machine != null)
                                {
                                    MachineTracking _machineOverview = new MachineTracking(_machine.Id);
                                    _machineOverview.Dock = DockStyle.Fill;
                                    _machineTable.Controls.Add(_machineOverview, _j, _i);
                                }
                            }
                        }
                    }
                    return _machineTable;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DeviceTrackingForm.GetMachineTable -> ", _ex);
                return null;
            }
        }
    }
}
