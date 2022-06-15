/* Coder by KFY */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CarWashingAutomation.Packets;
using CarWashingAutomation.Models;
using CarWashingAutomation.Connections;

namespace CarWashingAutomation
{
    class Constants
    {
        public static ModbusConnection Main_ModbusConnection = null;
        //Constants
        public static string TechnicSupportMail = "";
        public static string TechnicSupportPassword = "";
        public static string SQLConnectionString = "";
        public static string LogoFormMessage = "---";
        public static string LogoFormImage = "Logo_Image.png";
        public static string ShiftStartTime = "00:00";
        public static string ShiftEndTime = "00:00";

        //Paths
        public static string DB_ConnectionString = "CarWashingDB.sqlite";
        public static string TempDirectory = "Temp";
        public static string LogDirectory = "Temp/Logs";
        public static string ReportsDirectory = @"Temp/Reports";
        public static string LogPath = "Temp/Logs/SystemLog.txt";
        public static string MailAttechmentLogPath = "Temp/Logs/Mail/SystemLog.txt";
        public static string MailTextLogPath = "Temp/Logs/Mail/Mail.txt";
        public static string ConstantsJson = "Temp/Constants.json";
        public static string LicenseLic = "Temp/License.lic";
        //Current States
        public static int CurrentUserId = 0;
        public static bool NotificationOpen = true;
        public static void ExportConstantsJson()
        {
            try
            {
                JSonPacket _constantJson = new JSonPacket(@"{" +
                    @"""LogoFormMessage"":""" + LogoFormMessage +
                    @""",""LogoFormImage"":""" + LogoFormImage +
                    @""",""TechnicSupportMail"":""" + TechnicSupportMail +
                    @""",""TechnicSupportPassword"":""" + TechnicSupportPassword +
                    @""",""NotificationOpen"":""" + NotificationOpen.ToString() +
                    @""",""ShiftStartTime"":""" + ShiftStartTime +
                    @""",""ShiftEndTime"":""" + ShiftEndTime +
                    @"""}");
                JSonPacket.WriteJsonToFile(_constantJson, Application.StartupPath.ToString() + "\\" + ConstantsJson);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Constants.RefreshJson -> ", _ex);
            }
        }
    }
}
