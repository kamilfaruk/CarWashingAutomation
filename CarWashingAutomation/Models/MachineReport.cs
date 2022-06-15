/* Coder by KFY */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarWashingAutomation.Models
{
    public class MachineReport
    {
        public int Id { get; set; }
        public string ReportDate { get; set; }
        public Machine Machine { get; set; }
        public int MachineId { get; set; }
        public int TotalMoney { get; set; } //toplam şimdiye kadar cihazda toplanan para değeri
        public double CurrentTemperature { get; set; } //anlık ortam sıcaklığı
        public int CurrentModeStates { get; set; } //cihazın anlık olarak bulunduğu mod ve çalışma durumu
        public string GetCurrentMode()
        {
            try
            {
                string _currentMod = "---";
                string _currentModArray = Convert.ToString(CurrentModeStates, 2);
                int[] bits = _currentModArray.PadLeft(16, '0').Select(c => int.Parse(c.ToString())).ToArray();
                if (bits[15] == 1)
                {
                    _currentMod = "Yıkama";
                }
                else if (bits[14] == 1)
                {
                    _currentMod = "Paspas";
                }
                else if (bits[13] == 1)
                {
                    _currentMod = "Köpük";
                }
                else if (bits[12] == 1)
                {
                    _currentMod = "Hava";
                }
                else if (bits[11] == 1)
                {
                    _currentMod = "Süpürge";
                }
                else if (bits[10] == 1)
                {
                    _currentMod = "Cila";
                }
                return _currentMod;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatus.MachineStatus_Load -> ", _ex);
                return null;
            }
        }
        public int TotalDeviceWorkTime { get; set; }
        //Mop
        public int MopTotalMoney { get; set; }
        public int MopTotalTime { get; set; }
        public int MopWorkCount { get; set; }
        //Washing
        public int WashingTotalMoney { get; set; }
        public int WashingTotalTime { get; set; }
        public int WashingWorkCount { get; set; }
        //Foam
        public int FoamTotalMoney { get; set; }
        public int FoamTotalTime { get; set; }
        public int FoamWorkCount { get; set; }
        //Airmatic
        public int AirmaticTotalMoney { get; set; }
        public int AirmaticTotalTime { get; set; }
        public int AirmaticWorkCount { get; set; }
        //Vacuummatic
        public int VacuummaticTotalMoney { get; set; }
        public int VacuummaticTotalTime { get; set; }
        public int VacuummaticWorkCount { get; set; }
        //Varnish
        public int VarnishTotalMoney { get; set; }
        public int VarnishTotalTime { get; set; }
        public int VarnishWorkCount { get; set; }
    }
}
