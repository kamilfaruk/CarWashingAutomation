/* Coder by KFY */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarWashingAutomation.Models
{
    public class MachineAlarm
    {
        public int Id { get; set; }
        public Machine Machine { get; set; }
        public int MachineId { get; set; }
        public string AlarmDate { get; set; }
        public string Alarms { get; set; }
    }
}
