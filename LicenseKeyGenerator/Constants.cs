/* Coder by KFY */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using LicenseKeyGenerator.Packets;

namespace LicenseKeyGenerator
{
    class Constants
    {      
        //Constants
        public static string TechnicSupportMail = "";
        public static string TechnicSupportPassword = "";
        //Paths
        public static string TempDirectory = "Temp";
        public static string LogDirectory = "Temp/Logs";
        public static string LogPath = "Temp/Logs/SystemLog.txt"; 
        public static string LicenseRegistrations = "Temp/LicenseRegistrations.txt";
        public static string MailAttechmentLogPath = "Temp/Logs/Mail/SystemLog.txt";
        public static string MailTextLogPath = "Temp/Logs/Mail/Mail.txt";
        public static string ConstantsJson = "Temp/Constants.json";
        public static string LicenseLic = "Temp/License.lic";
        public static void ExportConstantsJson()
        {
            try
            {
                JSonPacket.WriteJsonToFile(new JSonPacket(@"{" +
                    @"""TechnicSupportMail"":""" + TechnicSupportMail +
                    @""",""TechnicSupportPassword"":""" + TechnicSupportPassword +
                    @"""}"), Application.StartupPath.ToString() + "\\" + ConstantsJson);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Constants.RefreshJson -> ", _ex);
            }
        }
    }
}
