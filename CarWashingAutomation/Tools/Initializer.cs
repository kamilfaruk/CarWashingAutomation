/* Coder by KFY */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CarWashingAutomation.Packets;
using CarWashingAutomation.Components;

namespace CarWashingAutomation.Tools
{
    public class Initializer : IDisposable
    {
        public void Dispose()
        {

        }
        public static void ChackTempFolder()
        {
            try
            {
                using (FileManager _fm = new FileManager())
                {
                    if (_fm.DirectoryExists(Application.StartupPath.ToString() + "\\" + Constants.TempDirectory))
                    {
                        if (!_fm.FileExists(Application.StartupPath.ToString() + "\\" + Constants.ConstantsJson))
                        {
                            Constants.ExportConstantsJson();
                        }
                        if (!_fm.FileExists(Application.StartupPath.ToString() + "\\" + Constants.LogPath))
                        {
                            if (!_fm.DirectoryExists(Application.StartupPath.ToString() + "\\" + Constants.LogDirectory))
                            {
                                _fm.CreateDirectory(Application.StartupPath.ToString() + "\\" + Constants.LogDirectory);
                            }
                            _fm.CreatFile(Application.StartupPath.ToString() + "\\" + Constants.LogPath);
                        }
                    }
                    else
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            using (FileManager _fileManager = new FileManager())
                            {
                                using (LicenseManager _licenseManager = new LicenseManager())
                                {
                                    string _licenseRenewalPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\LisansYenileme.txt";
                                    _fileManager.Write(_licenseRenewalPath, _licenseManager.GetOldLicenseKey());
                                }
                            }
                            string _message = "Programın temel bilgilerinin içeren klasöt tespit edilemedi. Lütfen programı bilgisayarınızdan kaldırıp tekrar kurunuz ve masaüstünüze otomatik oluşturulmuş olan LisansYenileme.txt dosyasındaki lisans anahtarı ile programınızı yeniden aktifleştiriniz.";
                            string _header = "HATA";
                            _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Info);

                        }
                        Application.Exit();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Initializer.ChackTempFolder -> ", _ex);
            }
        }
        public static void InitializeConstants()
        {
            try
            {
                using (FileManager _fm = new FileManager())
                {
                    if (_fm.FileExists(Application.StartupPath.ToString() + "\\" + Constants.ConstantsJson))
                    {
                        JSonPacket _constJson = JSonPacket.ReadJsonFromFile(Application.StartupPath.ToString() + "\\" + Constants.ConstantsJson);
                        if (_constJson != null)
                        {
                            Dictionary<string, string> _constDictionary = _constJson.DeserializeObject<Dictionary<string, string>>();
                            foreach (var kv in _constDictionary)
                            {
                                if (kv.Key == "LogoFormMessage")
                                {
                                    Constants.LogoFormMessage = Convert.ToString(kv.Value);

                                }
                                else if (kv.Key == "LogoFormImage")
                                {
                                    Constants.LogoFormImage = Convert.ToString(kv.Value);
                                }
                                else if (kv.Key == "TechnicSupportMail")
                                {
                                    Constants.TechnicSupportMail = Convert.ToString(kv.Value);
                                }
                                else if (kv.Key == "TechnicSupportPassword")
                                {
                                    Constants.TechnicSupportPassword = Convert.ToString(kv.Value);
                                }
                                else if (kv.Key == "NotificationOpen")
                                {
                                    Constants.NotificationOpen = Convert.ToBoolean(kv.Value);
                                }
                                else if (kv.Key == "ShiftStartTime")
                                {
                                    Constants.ShiftStartTime = Convert.ToString(kv.Value);
                                }
                                else if (kv.Key == "ShiftEndTime")
                                {
                                    Constants.ShiftEndTime = Convert.ToString(kv.Value);
                                }
                            }
                        }
                        else
                        {
                            Constants.ExportConstantsJson();
                        }

                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Initializer.InitializeConstants -> ", _ex);
            }
        }
    }
}
