/* Coder by KFY */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarWashingAutomation.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Alias { get; set; } //otomasyonda gösterilecek isim
        public int PeriodicMaintenanceHour { get; set; } //makinenin periyodik olarak bakıma alınması gereken çalışma saati
        public int DeviceStatus { get; set; } //cihaz aç-kapat
        public int CountdownValue { get; set; } //geri sayım kalan saniye
        public int MoneyHopperState { get; set; } //cihaz durumuna göre otomatik değişecek cihaz kapanırsa buda kapanacak fakat cihaz açıkken para haznesi kapatılabilir
        public int Version { get; set; } //gömülü yazılım versiyonu (sadece okunabilir)
        public int CommunicationAddress { get; set; } //cihaz bağlantı adresi (her cihaz için farklı olacak)
        public int StatusesOfOutputs { get; set; } //röle durumları                                                    
        public List<string> GetActiveOutputs()
        {
            try
            {
                List<string> _activeRelayList = new List<string>();
                string _currentModArray = Convert.ToString(StatusesOfOutputs, 2);
                int[] bits = _currentModArray.PadLeft(16, '0').Select(c => int.Parse(c.ToString())).ToArray();
                if (bits[15] == 1)
                {
                    _activeRelayList.Add("Paramatik");
                }
                if (bits[14] == 1)
                {
                    _activeRelayList.Add("Su Akış");
                }
                if (bits[13] == 1)
                {
                    if (WashingStatus == 1)
                    {
                        _activeRelayList.Add("Yıkama");
                    }
                    else if (MopStatus == 1)
                    {
                        _activeRelayList.Add("Paspas");
                    }
                }
                if (bits[12] == 1)
                {
                    if (FoamStatus == 1)
                    {
                        _activeRelayList.Add("Köpük");
                    }
                    else if (AirmaticStatus == 1)
                    {
                        _activeRelayList.Add("Hava");
                    }
                }
                if (bits[11] == 1)
                {
                    if (VacuummaticStatus == 1)
                    {
                        _activeRelayList.Add("Süpürge");
                    }
                    else if (VarnishStatus == 1)
                    {
                        _activeRelayList.Add("Cila");
                    }
                }
                if (bits[10] == 1)
                {
                    _activeRelayList.Add("Buzzer");
                }
                if (bits[9] == 1)
                {
                    _activeRelayList.Add("Harici 1");
                }
                if (bits[8] == 1)
                {
                    _activeRelayList.Add("Harici 2");
                }
                return _activeRelayList;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatus.GetRelays -> ", _ex);
                return null;
            }
        }
        public int P10Usage { get; set; } //P10 led ekran olmayıp sadece LCD ekran kullanılabilir
        public int RestoreFactorySettings { get; set; } //fabrika ayarlarına dön
        public int DeleteDeviceTotals { get; set; } //cihazın toplam süreleri,paraları ve su kullanımı gibi sürekli saydığı değerleri sıfırlar
        public int CurrentMoney { get; set; } //anlık cihazdaki para değeri
        public int TotalMoney { get; set; } //toplam şimdiye kadar cihazda toplanan para değeri
        public int AlarmStates { get; set; } //cihazda oluşan alarm durumları
        public List<string> GetAlarms()
        {
            try
            {
                List<string> _currentAlarmList = new List<string>();
                string _currentAlarmArray = Convert.ToString(AlarmStates, 2);
                int[] bits = _currentAlarmArray.PadLeft(16, '0').Select(c => int.Parse(c.ToString())).ToArray();
                if (bits[15] == 1)
                {
                    _currentAlarmList.Add("Acil Stop");
                }
                if (bits[14] == 1)
                {
                    _currentAlarmList.Add("Yüksek Akış");
                }
                if (bits[13] == 1)
                {
                    _currentAlarmList.Add("Düşük Akış");
                }
                if (bits[12] == 1)
                {
                    _currentAlarmList.Add("Yüksek Sıcaklık");
                }
                if (bits[11] == 1)
                {
                    _currentAlarmList.Add("Düşük Sıcaklık");
                }
                return _currentAlarmList;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatus.GetAlarms -> ", _ex);
                return null;
            }
        }
        public double CurrentTemperature { get; set; } //anlık ortam sıcaklığı
        public int LowTemperatureAlarm { get; set; } //ortam sıcaklığı alt alarm değeri (buzlanmaya karşı)
        public int HighTemperatureAlarm { get; set; } //ortam sıcaklığı üst alarm değeri (kaynamaya karşı)
        public int TemperatureAlarmIsActive { get; set; } //ortam sıcaklığı alarm aç-kapat
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
        public int FlowAlarmIsActive { get; set; } //su akış sensörü aç-kapat (sistemde pulser olmaması durumunda kapatılabilir) 
        public int FlowInitialCalibrationLimit { get; set; } //ilk açılışta sistemin çalışması için olması gereken basınç değeri 
        public int HighFlowAlarmCount { get; set; } //su akışı üst alarm değeri (hotrum patlak olabilir)
        public int LowFlowAlarmCount { get; set; } //su akışı alt alarm değeri (şebeke suyu çok az geliyor olabilir)
        //Mop
        public int MopPrice { get; set; }
        public int MopTime { get; set; }
        public int MopStatus { get; set; }
        public int MopTotalMoney { get; set; }
        public int MopTotalTime { get; set; }
        public int MopWorkCount
        {
            get
            {
                try
                {
                    return MopTotalTime / MopTime;
                }
                catch
                {
                    Logger.Write(Alias + "-MopTotalTime = 0");
                    return -1;
                }
            }
        }
        //Washing
        public int WashingPrice { get; set; }
        public int WashingTime { get; set; }
        public int WashingStatus { get; set; }
        public int WashingTotalMoney { get; set; }
        public int WashingTotalTime { get; set; }
        public int WashingWorkCount
        {
            get
            {
                try
                {
                    return WashingTotalTime / WashingTime;
                }
                catch
                {
                    Logger.Write(Alias + "-WashingTotalTime = 0");
                    return -1;
                }
            }
        }
        //Foam
        public int FoamPrice { get; set; }
        public int FoamTime { get; set; }
        public int FoamStatus { get; set; }
        public int FoamTotalMoney { get; set; }
        public int FoamTotalTime { get; set; }
        public int FoamWorkCount
        {
            get
            {
                try
                {
                    return FoamTotalTime / FoamTime;
                }
                catch
                {
                    Logger.Write(Alias + "-FoamTotalTime = 0");
                    return -1;
                }
            }
        }
        //Airmatic
        public int AirmaticPrice { get; set; }
        public int AirmaticTime { get; set; }
        public int AirmaticStatus { get; set; }
        public int AirmaticTotalMoney { get; set; }
        public int AirmaticTotalTime { get; set; }
        public int AirmaticWorkCount
        {
            get
            {
                try
                {
                    return AirmaticTotalTime / AirmaticTime;
                }
                catch
                {
                    Logger.Write(Alias + "-AirmaticTotalTime = 0");
                    return -1;
                }
            }
        }
        //Vacuummatic
        public int VacuummaticPrice { get; set; }
        public int VacuummaticTime { get; set; }
        public int VacuummaticStatus { get; set; }
        public int VacuummaticTotalMoney { get; set; }
        public int VacuummaticTotalTime { get; set; }
        public int VacuummaticWorkCount
        {
            get
            {
                try
                {
                    return VacuummaticTotalTime / VacuummaticTime;
                }
                catch
                {
                    Logger.Write(Alias + "-VacuummaticTotalTime = 0");
                    return -1;
                }
            }
        }
        //Varnish
        public int VarnishPrice { get; set; }
        public int VarnishTime { get; set; }
        public int VarnishStatus { get; set; }
        public int VarnishTotalMoney { get; set; }
        public int VarnishTotalTime { get; set; }
        public int VarnishWorkCount
        {
            get
            {
                try
                {
                    return VarnishTotalTime / VarnishTime;
                }
                catch
                {
                    Logger.Write(Alias + "-VarnishTotalTime = 0");
                    return -1;
                }
            }
        }
        //
        public string GetActiveMods()
        {
            try
            {
                string _activeMods = "";
                if (MopStatus == 1)
                {
                    if (_activeMods == "")
                    {
                        _activeMods = "Paspas";
                    }
                    else
                    {
                        _activeMods = _activeMods + ", Paspas";
                    }
                }
                if (WashingStatus == 1)
                {
                    if (_activeMods == "")
                    {
                        _activeMods = "Yıkama";
                    }
                    else
                    {
                        _activeMods = _activeMods + ", Yıkama";
                    }
                }
                if (AirmaticStatus == 1)
                {
                    if (_activeMods == "")
                    {
                        _activeMods = "Hava";
                    }
                    else
                    {
                        _activeMods = _activeMods + ", Hava";
                    }
                }
                if (FoamStatus == 1)
                {
                    if (_activeMods == "")
                    {
                        _activeMods = "Köpük";
                    }
                    else
                    {
                        _activeMods = _activeMods + ", Köpük";
                    }
                }
                if (VacuummaticStatus == 1)
                {
                    if (_activeMods == "")
                    {
                        _activeMods = "Süpürge";
                    }
                    else
                    {
                        _activeMods = _activeMods + ", Süpürge";
                    }
                }
                if (VarnishStatus == 1)
                {
                    if (_activeMods == "")
                    {
                        _activeMods = "Cila";
                    }
                    else
                    {
                        _activeMods = _activeMods + ", Cila";
                    }
                }
                return _activeMods;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MachineStatus.GetActiveMods -> ", _ex);
                return null;
            }
        }
        public int TotalDeviceWorkTime
        {
            get
            {
                int _totalTime = MopTotalTime + WashingTotalTime + FoamTotalTime + AirmaticTotalTime + VacuummaticTotalTime + VarnishTotalTime;
                return _totalTime;
            }
        }
        public virtual List<MachineAlarm> MachineAlarms { get; set; }
        public override string ToString()
        {
            return this.Alias;
        }
    }
}
