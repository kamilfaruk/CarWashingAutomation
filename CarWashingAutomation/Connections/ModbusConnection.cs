/* Coder by KFY */
using System;
using EasyModbus;
using System.IO.Ports;
using CarWashingAutomation.Components;
using System.Windows.Forms;
using CarWashingAutomation.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarWashingAutomation.Connections
{
    public class ModbusConnection : IDisposable
    {
        public int[] InputRegisters;
        public int[] HoldingRegisters;
        public byte SlaveId
        {
            get
            {
                return Main_ModbusClient.UnitIdentifier;
            }
            set
            {
                Main_ModbusClient.UnitIdentifier = value;
            }
        }
        public void Dispose()
        {
            Main_ModbusClient.Disconnect();
            Connected = false;
        }
        public bool Connected { get; set; }
        public ModbusClient Main_ModbusClient = new ModbusClient();
        public ModbusConnection(int _slaveId)
        {
            try
            {
                if (!Main_ModbusClient.Connected)
                {
                    string[] _ports = SerialPort.GetPortNames();
                    foreach (string _port in _ports)
                    {
                        Main_ModbusClient.SerialPort = _port;
                        Main_ModbusClient.Baudrate = 19200;
                        Main_ModbusClient.Parity = Parity.None;
                        Main_ModbusClient.StopBits = StopBits.One;
                        Main_ModbusClient.ConnectionTimeout = 100;
                        Main_ModbusClient.UnitIdentifier = (byte)_slaveId;
                        Main_ModbusClient.Connect();
                        int _control = Main_ModbusClient.ReadHoldingRegisters(3, 1)[0];
                        if (_control == 3)
                        {
                            Connected = true;
                            SlaveId = (byte)_slaveId;
                        }
                        else
                        {
                            Dispose();
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.ModbusConnection -> ", _ex);
                Dispose();
            }
        }
        public bool CommunicationControl(int _slaveId)
        {
            try
            {
                SlaveId = (byte)_slaveId;
                int _control = Main_ModbusClient.ReadHoldingRegisters(3, 1)[0];
                if (_control == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.CommunicationControl -> ", _ex);
                return false;
            }
        }
        public bool RefreshMachine(int _machineId)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    using (DBManager _dbManager = new DBManager())
                    {
                        Machine _machine = _dbManager.GetMachine(_machineId);
                        if (_machine != null)
                        {
                            SlaveId = (byte)_machine.CommunicationAddress;
                            InputRegisters = Main_ModbusClient.ReadInputRegisters(1, 8);
                            HoldingRegisters = Main_ModbusClient.ReadHoldingRegisters(1, 57);
                            _machine.CurrentMoney = GetCurrentMoney();
                            _machine.CountdownValue = GetCountdownValue();
                            _machine.CurrentModeStates = GetCurrentModeStates();
                            _machine.DeviceStatus = Convert.ToInt32(GetDeviceStatus());
                            _machine.AlarmStates = GetAlarmStates();
                            _machine.StatusesOfOutputs = GetStatusesOfOutputs();
                            _machine.MoneyHopperState = Convert.ToInt32(GetMoneyHopperState());
                            _machine.Version = GetVersion();
                            _machine.P10Usage = Convert.ToInt32(GetP10Usage());
                            _machine.TotalMoney = GetTotalMoney();
                            _machine.CurrentTemperature = GetCurrentTemperature();
                            _machine.LowTemperatureAlarm = GetLowTemperatureAlarm();
                            _machine.HighTemperatureAlarm = GetHighTemperatureAlarm();
                            _machine.TemperatureAlarmIsActive = Convert.ToInt32(GetTemperatureAlarmIsActive());
                            _machine.FlowAlarmIsActive = Convert.ToInt32(GetFlowAlarmIsActive());
                            _machine.FlowInitialCalibrationLimit = GetFlowInitialCalibrationLimit();
                            _machine.HighFlowAlarmCount = GetHighFlowAlarmCount();
                            _machine.LowFlowAlarmCount = GetLowFlowAlarmCount();
                            _machine.WashingStatus = Convert.ToInt32(GetWashingStatus());
                            //Washing               
                            _machine.WashingPrice = GetWashingPrice();
                            _machine.WashingTime = GetWashingTime();
                            _machine.WashingTotalMoney = GetWashingTotalMoney();
                            _machine.WashingTotalTime = GetWashingTotalTime();
                            _machine.FoamStatus = Convert.ToInt32(GetFoamStatus());
                            //FoamStatus 
                            _machine.FoamPrice = GetFoamPrice();
                            _machine.FoamTime = GetFoamTime();
                            _machine.FoamTotalMoney = GetFoamTotalMoney();
                            _machine.FoamTotalTime = GetFoamTotalTime();
                            _machine.MopStatus = Convert.ToInt32(GetMopStatus());
                            //Mop
                            _machine.MopPrice = GetMopPrice();
                            _machine.MopTime = GetMopTime();
                            _machine.MopTotalMoney = GetMopTotalMoney();
                            _machine.MopTotalTime = GetMopTotalTime();
                            _machine.AirmaticStatus = Convert.ToInt32(GetAirmaticStatus());
                            //Airmatic
                            _machine.AirmaticPrice = GetAirmaticPrice();
                            _machine.AirmaticTime = GetAirmaticTime();
                            _machine.AirmaticTotalMoney = GetAirmaticTotalMoney();
                            _machine.AirmaticTotalTime = GetAirmaticTotalTime();
                            _machine.VacuummaticStatus = Convert.ToInt32(GetVacuummaticStatus());
                            //Vacuummatic
                            _machine.VacuummaticPrice = GetVacuummaticPrice();
                            _machine.VacuummaticTime = GetVacuummaticTime();
                            _machine.VacuummaticTotalMoney = GetVacuummaticTotalMoney();
                            _machine.VacuummaticTotalTime = GetVacuummaticTotalTime();
                            _machine.VarnishStatus = Convert.ToInt32(GetVarnishStatus());
                            //Varnish
                            _machine.VarnishPrice = GetVarnishPrice();
                            _machine.VarnishTime = GetVarnishTime();
                            _machine.VarnishTotalMoney = GetVarnishTotalMoney();
                            _machine.VarnishTotalTime = GetVarnishTotalTime();
                            if (_dbManager.UpdateMachine(_machine))
                            {
                                if (MachineAlarmControl(_machine.Id))
                                {
                                    if (PeriodicMaintenanceControl(_machine.Id))
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
                return false;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.RefreshMachine (" + _machineId.ToString() + ") -> ", _ex);
                return false;
            }
        }
        private bool PeriodicMaintenanceControl(int _machineId)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    Machine _machine = _dbManager.GetMachine(_machineId);
                    double _workHour = (double)_machine.TotalDeviceWorkTime / 3600;
                    if ((_machine.PeriodicMaintenanceHour - _workHour) < 0)
                    {
                        if (GetDeviceStatus() == true)
                        {
                            if (SetDeviceStatus(false))
                            {
                                using (NotificationManager _notificationManager = new NotificationManager())
                                {
                                    string _notificationText = _machine.ToString() + "-Periyodik Bakım";
                                    _notificationManager.Notification_PCMail(_notificationText, NotificationType.Error);
                                    return true;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.PeriodicMaintenanceControl (" + _machineId.ToString() + ") -> ", _ex);
                return false;
            }
        }
        private bool MachineAlarmControl(int _machineId)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    Machine _machine = _dbManager.GetMachine(_machineId);
                    if (_machine.GetAlarms().Count != 0)
                    {
                        MachineAlarm _machineAlarm = new MachineAlarm();
                        _machineAlarm.Machine = _machine;
                        _machineAlarm.MachineId = _machine.Id;
                        _machineAlarm.AlarmDate = DateTime.Now.ToString();
                        string _alarms = string.Join(",", _machine.GetAlarms().ToArray());
                        _machineAlarm.Alarms = _alarms;

                        if (AlarmControl(_machineAlarm))
                        {
                            if (_dbManager.AddMachineAlarm(_machineAlarm))
                            {
                                using (NotificationManager _notificationManager = new NotificationManager())
                                {
                                    string _notificationText = _machine.ToString() + "-" + _alarms;
                                    _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                                    return true;
                                }
                            }
                        }
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.MachineAlarmControl (" + _machineId.ToString() + ") -> ", _ex);
                return false;
            }
        }
        private bool AlarmControl(MachineAlarm _machineAlarm)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    List<MachineAlarm> _machineAlarmList = _dbManager.GetMachineAlarmList();
                    if (_machineAlarmList != null)
                    {
                        List<MachineAlarm> _alarmList = _machineAlarmList.FindAll(_ma => _ma.Machine == _machineAlarm.Machine);
                        foreach (MachineAlarm _alarm in _alarmList)
                        {
                            if (_alarm.Alarms != _machineAlarm.Alarms)
                            {
                                if (DateTime.Parse(_alarm.AlarmDate) > DateTime.Now.AddMinutes(-10))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.AlarmTimingControl -> ", _ex);
                return false;
            }
        }
        public bool GenerateMachineReports()
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    using (DBManager _dbManager = new DBManager())
                    {
                        List<Machine> _machineList = _dbManager.GetMachineList();
                        int _reportCounter = 0;
                        int _totalReportCount = _machineList.Count;
                        foreach (Machine _machine in _machineList.ToList())
                        {
                            MachineReport _machineReport = new MachineReport();
                            _machineReport.Machine = _machine;
                            _machineReport.MachineId = _machine.Id;
                            _machineReport.ReportDate = DateTime.Now.ToString();
                            _machineReport.TotalMoney = _machine.TotalMoney;
                            _machineReport.CurrentTemperature = _machine.CurrentTemperature;
                            _machineReport.CurrentModeStates = _machine.CurrentModeStates;
                            _machineReport.TotalDeviceWorkTime = _machine.TotalDeviceWorkTime;
                            //Mop
                            _machineReport.MopTotalMoney = _machine.MopTotalMoney;
                            _machineReport.MopTotalTime = _machine.MopTotalTime;
                            _machineReport.MopWorkCount = _machine.MopWorkCount;
                            //Washing
                            _machineReport.WashingTotalMoney = _machine.WashingTotalMoney;
                            _machineReport.WashingTotalTime = _machine.WashingTotalTime;
                            _machineReport.WashingWorkCount = _machine.WashingWorkCount;
                            //Foam
                            _machineReport.FoamTotalMoney = _machine.FoamTotalMoney;
                            _machineReport.FoamTotalTime = _machine.FoamTotalTime;
                            _machineReport.FoamWorkCount = _machine.FoamWorkCount;
                            //Airmatic
                            _machineReport.AirmaticTotalMoney = _machine.AirmaticTotalMoney;
                            _machineReport.AirmaticTotalTime = _machine.AirmaticTotalTime;
                            _machineReport.AirmaticWorkCount = _machine.AirmaticWorkCount;
                            //Vacuummatic
                            _machineReport.VacuummaticTotalMoney = _machine.VacuummaticTotalMoney;
                            _machineReport.VacuummaticTotalTime = _machine.VacuummaticTotalTime;
                            _machineReport.VacuummaticWorkCount = _machine.VacuummaticWorkCount;
                            //Varnish
                            _machineReport.VarnishTotalMoney = _machine.VarnishTotalMoney;
                            _machineReport.VarnishTotalTime = _machine.VarnishTotalTime;
                            _machineReport.VarnishWorkCount = _machine.VarnishWorkCount;
                            if (_dbManager.AddMachineReport(_machineReport))
                            {
                                _reportCounter += 1;
                            }
                        }
                        if (_reportCounter == _totalReportCount)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GenerateMachineReports -> ", _ex);
                return false;
            }
        }
        public int GetStatusesOfOutputs()
        {
            try
            {
                return InputRegisters[0];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetMoneyHopperState -> ", _ex);
                return 0;
            }
        }
        public int GetAlarmStates()
        {
            try
            {
                return InputRegisters[2];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetMoneyHopperState -> ", _ex);
                return 0;
            }
        }
        public bool GetMoneyHopperState()
        {
            try
            {
                int _monetHopperState = HoldingRegisters[4];
                int _bytePos = 0;
                return (_monetHopperState & (1 << _bytePos)) != 0;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetMoneyHopperState -> ", _ex);
                return false;
            }
        }
        public bool SetMoneyHopperState(bool _state)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_state)
                    {
                        Main_ModbusClient.WriteSingleRegister(5, 1);
                        return true;
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(5, 0);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetP10Usage -> ", _ex);
                return false;
            }
        }
        public int GetCurrentMoney()
        {
            try
            {
                return InputRegisters[5];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetCurrentMoney -> ", _ex);
                return 0;
            }
        }
        public int GetTotalMoney()
        {
            try
            {
                return InputRegisters[6];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetTotalMoney -> ", _ex);
                return 0;
            }
        }
        public double GetCurrentTemperature()
        {
            try
            {
                int[] _temperatureValues = { InputRegisters[3], InputRegisters[4] };
                double _temperature = ModbusClient.ConvertRegistersToFloat(_temperatureValues, ModbusClient.RegisterOrder.HighLow);
                return Math.Round(_temperature, 2);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetCurrentTemperature -> ", _ex);
                return 0;
            }
        }
        public int GetCountdownValue()
        {
            try
            {
                return InputRegisters[1];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetCountdownValue -> ", _ex);
                return 0;
            }
        }
        public int GetCurrentModeStates()
        {
            try
            {
                return InputRegisters[7];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetCurrentModeStates -> ", _ex);
                return 0;
            }
        }
        public bool GetP10Usage()
        {
            try
            {
                int _p10Usage = HoldingRegisters[55];
                if (_p10Usage == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetP10Usage -> ", _ex);
                return false;
            }
        }
        public bool SetP10Usage(bool _usage)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_usage)
                    {
                        Main_ModbusClient.WriteSingleRegister(56, 1);
                        return true;
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(56, 0);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetP10Usage -> ", _ex);
                return false;
            }
        }
        public int GetP10Address()
        {
            try
            {
                return HoldingRegisters[3];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetP10Address -> ", _ex);
                return 0;
            }
        }
        public void SetP10Address(int _address)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(4, _address);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetP10Address -> ", _ex);
            }
        }
        public bool GetFlowAlarmIsActive()
        {
            try
            {
                int _flowAlarIsActive = HoldingRegisters[6];
                if (_flowAlarIsActive == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetFlowAlarmIsActive -> ", _ex);
                return false;
            }
        }
        public bool SetFlowAlarmIsActive(bool _isActive)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_isActive)
                    {
                        Main_ModbusClient.WriteSingleRegister(7, 1);
                        return true;
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(7, 0);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetFlowAlarmIsActive -> ", _ex);
                return false;
            }
        }
        public bool GetTemperatureAlarmIsActive()
        {
            try
            {
                int _temperatureAlarmIsActive = HoldingRegisters[53];
                if (_temperatureAlarmIsActive == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetTemperatureAlarmIsActive -> ", _ex);
                return false;
            }
        }
        public void SetTemperatureAlarmIsActive(bool _isActive)
        {
            try
            {
                if (_isActive)
                {
                    Main_ModbusClient.WriteSingleRegister(54, 1);
                }
                else
                {
                    Main_ModbusClient.WriteSingleRegister(54, 0);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetTemperatureAlarmIsActive -> ", _ex);
            }
        }
        public int GetLowTemperatureAlarm()
        {
            try
            {
                return HoldingRegisters[51];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetLowTemperatureAlarm -> ", _ex);
                return 0;
            }
        }
        public void SetLowTemperatureAlarm(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(52, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetLowTemperatureAlarm -> ", _ex);
            }
        }
        public int GetHighTemperatureAlarm()
        {
            try
            {
                return HoldingRegisters[52];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetHighTemperatureAlarm -> ", _ex);
                return 0;
            }
        }
        public void SetHighTemperatureAlarm(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(53, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetHighTemperatureAlarm -> ", _ex);
            }
        }
        public int GetFlowInitialCalibrationLimit()
        {
            try
            {
                return HoldingRegisters[54];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetFlowInitialCalibrationLimit -> ", _ex);
                return 0;
            }
        }
        public void SetFlowInitialCalibrationLimit(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(55, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetFlowInitialCalibrationLimit -> ", _ex);
            }
        }
        public int GetHighFlowAlarmCount()
        {
            try
            {
                return HoldingRegisters[49];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetHighFlowAlarmCount -> ", _ex);
                return 0;
            }
        }
        public void SetHighFlowAlarmCount(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(50, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetHighFlowAlarmCount -> ", _ex);
            }
        }
        public int GetLowFlowAlarmCount()
        {
            try
            {
                return HoldingRegisters[50];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetLowFlowAlarmCount -> ", _ex);
                return 0;
            }
        }
        public void SetLowFlowAlarmCount(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(51, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetLowFlowAlarmCount -> ", _ex);
            }
        }
        public bool GetDeviceStatus()
        {
            try
            {
                int _deviceStatus = HoldingRegisters[0];
                if (_deviceStatus == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetDeviceStatus -> ", _ex);
                return false;
            }
        }
        public bool SetDeviceStatus(bool _status)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_status)
                    {
                        using (DBManager _dbManager = new DBManager())
                        {
                            Machine _machine = _dbManager.GetMachineList().Find(_m => _m.CommunicationAddress == SlaveId);
                            if (_machine != null)
                            {
                                double _workHour = (double)_machine.TotalDeviceWorkTime / 3600;
                                if ((_machine.PeriodicMaintenanceHour - _workHour) > 0)
                                {
                                    Main_ModbusClient.WriteSingleRegister(1, 1);
                                    return true;
                                }
                                else
                                {
                                    using (NotificationManager _notificationManager = new NotificationManager())
                                    {
                                        string _notificationText = _machine.ToString() + "- Periyodik Bakımda (Açılamaz)";
                                        _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(1, 0);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetDeviceStatus -> ", _ex);
                return false;
            }
        }
        public int GetVersion()
        {
            try
            {
                return HoldingRegisters[2];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVersion -> ", _ex);
                return 0;
            }
        }
        public int GetCommunicationAddress()
        {
            try
            {
                return HoldingRegisters[1];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetCommunicationAddress -> ", _ex);
                return 0;
            }
        }
        public void SetCommunicationAddress(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(2, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetCommunicationAddress -> ", _ex);
            }
        }
        public bool SetRestoreFactorySettings()
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(6, 1);
                    //TODO: Fabrika ayarlarına dönen kartta haberleşme adresi 1 olarak default değer alıyor...
                }
                return false;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetRestoreFactorySettings -> ", _ex);
                return false;
            }
        }

        #region Mop
        public int GetMopPrice()
        {
            try
            {
                return HoldingRegisters[7];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetMopPrice -> ", _ex);
                return 0;
            }
        }
        public void SetMopPrice(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(8, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetMopPrice -> ", _ex);
            }
        }

        public int GetMopTime()
        {
            try
            {
                return HoldingRegisters[8];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetMopTime -> ", _ex);
                return 0;
            }
        }
        public void SetMopTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(9, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetMopTime -> ", _ex);
            }
        }

        public bool GetMopStatus()
        {
            try
            {
                int _mopStatus = HoldingRegisters[9];
                if (_mopStatus == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetMopStatus -> ", _ex);
                return false;
            }
        }
        public void SetMopStatus(bool _status)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_status)
                    {
                        Main_ModbusClient.WriteSingleRegister(10, 1);
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(10, 0);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetMopStatus -> ", _ex);
            }
        }

        public int GetMopTotalMoney()
        {
            try
            {
                int[] _mopTotalMoney = { HoldingRegisters[10], HoldingRegisters[11] };
                return ModbusClient.ConvertRegistersToInt(_mopTotalMoney, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetMopTotalMoney -> ", _ex);
                return 0;
            }
        }
        public void SetMopTotalMoney(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(11, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetMopTotalMoney -> ", _ex);
            }
        }

        public int GetMopTotalTime()
        {
            try
            {
                int[] _mopTotalTime = { HoldingRegisters[12], HoldingRegisters[13] };
                return ModbusClient.ConvertRegistersToInt(_mopTotalTime, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetMopTotalTime -> ", _ex);
                return 0;
            }
        }
        public void SetMopTotalTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(13, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetMopTotalTime -> ", _ex);
            }
        }
        #endregion

        #region Washing
        public int GetWashingPrice()
        {
            try
            {
                return HoldingRegisters[14];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetWashingPrice -> ", _ex);
                return 0;
            }
        }
        public void SetWashingPrice(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(15, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetWashingPrice -> ", _ex);
            }
        }

        public int GetWashingTime()
        {
            try
            {
                return HoldingRegisters[15];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetWashingTime -> ", _ex);
                return 0;
            }
        }
        public void SetWashingTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(16, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetWashingTime -> ", _ex);
            }
        }

        public bool GetWashingStatus()
        {
            try
            {
                int _mopStatus = HoldingRegisters[16];
                if (_mopStatus == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetWashingStatus -> ", _ex);
                return false;
            }
        }
        public void SetWashingStatus(bool _status)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_status)
                    {
                        Main_ModbusClient.WriteSingleRegister(17, 1);
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(17, 0);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetWashingStatus -> ", _ex);
            }
        }

        public int GetWashingTotalMoney()
        {
            try
            {
                int[] _washingTotalMoney = { HoldingRegisters[17], HoldingRegisters[18] };
                return ModbusClient.ConvertRegistersToInt(_washingTotalMoney, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetWashingTotalMoney -> ", _ex);
                return 0;
            }
        }
        public void SetWashingTotalMoney(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(18, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetWashingTotalMoney -> ", _ex);
            }
        }

        public int GetWashingTotalTime()
        {
            try
            {
                int[] _washingTotalTime = { HoldingRegisters[19], HoldingRegisters[20] };
                return ModbusClient.ConvertRegistersToInt(_washingTotalTime, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetWashingTotalTime -> ", _ex);
                return 0;
            }
        }
        public void SetWashingTotalTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(20, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetWashingTotalTime -> ", _ex);
            }
        }
        #endregion

        #region Foam
        public int GetFoamPrice()
        {
            try
            {
                return HoldingRegisters[21];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetFoamPrice -> ", _ex);
                return 0;
            }
        }
        public void SetFoamPrice(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(22, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetFoamPrice -> ", _ex);
            }
        }

        public int GetFoamTime()
        {
            try
            {
                return HoldingRegisters[22];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetFoamTime -> ", _ex);
                return 0;
            }
        }
        public void SetFoamTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(23, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetFoamTime -> ", _ex);
            }
        }

        public bool GetFoamStatus()
        {
            try
            {
                int _mopStatus = HoldingRegisters[23];
                if (_mopStatus == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetFoamStatus -> ", _ex);
                return false;
            }
        }
        public void SetFoamStatus(bool _status)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_status)
                    {
                        Main_ModbusClient.WriteSingleRegister(24, 1);
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(24, 0);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetFoamStatus -> ", _ex);
            }
        }

        public int GetFoamTotalMoney()
        {
            try
            {
                int[] _foamTotalMoney = { HoldingRegisters[24], HoldingRegisters[25] };
                return ModbusClient.ConvertRegistersToInt(_foamTotalMoney, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetFoamTotalMoney -> ", _ex);
                return 0;
            }
        }
        public void SetFoamTotalMoney(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(25, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetFoamTotalMoney -> ", _ex);
            }
        }

        public int GetFoamTotalTime()
        {
            try
            {
                int[] _foamTotalTime = { HoldingRegisters[26], HoldingRegisters[27] };
                return ModbusClient.ConvertRegistersToInt(_foamTotalTime, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetFoamTotalTime -> ", _ex);
                return 0;
            }
        }
        public void SetFoamTotalTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(27, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetFoamTotalTime -> ", _ex);
            }
        }
        #endregion

        #region Airmatic
        public int GetAirmaticPrice()
        {
            try
            {
                return HoldingRegisters[28];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetAirmaticPrice -> ", _ex);
                return 0;
            }
        }
        public void SetAirmaticPrice(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(29, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetAirmaticPrice -> ", _ex);
            }
        }

        public int GetAirmaticTime()
        {
            try
            {
                int _time = HoldingRegisters[29];
                return _time;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetAirmaticTime -> ", _ex);
                return 0;
            }
        }
        public void SetAirmaticTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(30, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetAirmaticTime -> ", _ex);
            }
        }

        public bool GetAirmaticStatus()
        {
            try
            {
                int _mopStatus = HoldingRegisters[30];
                if (_mopStatus == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetAirmaticStatus -> ", _ex);
                return false;
            }
        }
        public void SetAirmaticStatus(bool _status)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_status)
                    {
                        Main_ModbusClient.WriteSingleRegister(31, 1);
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(31, 0);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetAirmaticStatus -> ", _ex);
            }
        }

        public int GetAirmaticTotalMoney()
        {
            try
            {
                int[] _airmaticTotalMoney = { HoldingRegisters[31], HoldingRegisters[32] };
                return ModbusClient.ConvertRegistersToInt(_airmaticTotalMoney, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetAirmaticTotalMoney -> ", _ex);
                return 0;
            }
        }
        public void SetAirmaticTotalMoney(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(32, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetAirmaticTotalMoney -> ", _ex);
            }
        }

        public int GetAirmaticTotalTime()
        {
            try
            {
                int[] _airmaticTotalTime = { HoldingRegisters[33], HoldingRegisters[34] };
                return ModbusClient.ConvertRegistersToInt(_airmaticTotalTime, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetAirmaticTotalTime -> ", _ex);
                return 0;
            }
        }
        public void SetAirmaticTotalTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(34, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetAirmaticTotalTime -> ", _ex);
            }
        }
        #endregion

        #region Vacuummatic
        public int GetVacuummaticPrice()
        {
            try
            {
                return HoldingRegisters[35];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVacuummaticPrice -> ", _ex);
                return 0;
            }
        }
        public void SetVacuummaticPrice(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(36, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVacuummaticPrice -> ", _ex);
            }
        }

        public int GetVacuummaticTime()
        {
            try
            {
                return HoldingRegisters[36];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVacuummaticTime -> ", _ex);
                return 0;
            }
        }
        public void SetVacuummaticTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(37, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVacuummaticTime -> ", _ex);
            }
        }

        public bool GetVacuummaticStatus()
        {
            try
            {
                int _mopStatus = HoldingRegisters[37];
                if (_mopStatus == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVacuummaticStatus -> ", _ex);
                return false;
            }
        }
        public void SetVacuummaticStatus(bool _status)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_status)
                    {
                        Main_ModbusClient.WriteSingleRegister(38, 1);
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(38, 0);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVacuummaticStatus -> ", _ex);
            }
        }

        public int GetVacuummaticTotalMoney()
        {
            try
            {
                int[] _vacuummaticTotalMoney = { HoldingRegisters[38], HoldingRegisters[39] };
                return ModbusClient.ConvertRegistersToInt(_vacuummaticTotalMoney, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVacuummaticTotalMoney -> ", _ex);
                return 0;
            }
        }
        public void SetVacuummaticTotalMoney(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(39, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVacuummaticTotalMoney -> ", _ex);
            }
        }

        public int GetVacuummaticTotalTime()
        {
            try
            {
                int[] _vacuummaticTotalTime = { HoldingRegisters[40], HoldingRegisters[41] };
                return ModbusClient.ConvertRegistersToInt(_vacuummaticTotalTime, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVacuummaticTotalTime -> ", _ex);
                return 0;
            }
        }
        public void SetVacuummaticTotalTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(41, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVacuummaticTotalTime -> ", _ex);
            }
        }
        #endregion

        #region Varnish
        public int GetVarnishPrice()
        {
            try
            {
                return HoldingRegisters[42];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVarnishPrice -> ", _ex);
                return 0;
            }
        }
        public void SetVarnishPrice(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(43, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVarnishPrice -> ", _ex);
            }
        }

        public int GetVarnishTime()
        {
            try
            {
                return HoldingRegisters[43];
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVarnishTime -> ", _ex);
                return 0;
            }
        }
        public void SetVarnishTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    Main_ModbusClient.WriteSingleRegister(44, _value);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVarnishTime -> ", _ex);
            }
        }

        public bool GetVarnishStatus()
        {
            try
            {
                int _mopStatus = HoldingRegisters[44];
                if (_mopStatus == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVarnishStatus -> ", _ex);
                return false;
            }
        }
        public void SetVarnishStatus(bool _status)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    if (_status)
                    {
                        Main_ModbusClient.WriteSingleRegister(45, 1);
                    }
                    else
                    {
                        Main_ModbusClient.WriteSingleRegister(45, 0);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVarnishStatus -> ", _ex);
            }
        }

        public int GetVarnishTotalMoney()
        {
            try
            {
                int[] _varnishTotalMoney = { HoldingRegisters[45], HoldingRegisters[46] };
                return ModbusClient.ConvertRegistersToInt(_varnishTotalMoney, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVarnishTotalMoney -> ", _ex);
                return 0;
            }
        }
        public void SetVarnishTotalMoney(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(46, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVarnishTotalMoney -> ", _ex);
            }
        }

        public int GetVarnishTotalTime()
        {
            try
            {
                int[] _varnishTotalTime = { HoldingRegisters[47], HoldingRegisters[48] };
                return ModbusClient.ConvertRegistersToInt(_varnishTotalTime, ModbusClient.RegisterOrder.HighLow);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.GetVarnishTotalTime -> ", _ex);
                return 0;
            }
        }
        public void SetVarnishTotalTime(int _value)
        {
            try
            {
                if (Main_ModbusClient.Connected)
                {
                    int[] _registers = ModbusClient.ConvertIntToRegisters(_value);
                    Array.Reverse(_registers);
                    Main_ModbusClient.WriteMultipleRegisters(48, _registers);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ModbusConnection.SetVarnishTotalTime -> ", _ex);
            }
        }
        #endregion
    }
}
