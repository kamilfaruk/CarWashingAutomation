/* Coder by KFY */
using System;
using System.IO;
using System.Linq;
using System.Drawing;
using Microsoft.Win32;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace LicenseKeyGenerator.Tools
{
    public class Helper : IDisposable
    {
        public void Dispose()
        {
        }
        public DateTime GetCurrentTime()
        {
            try
            {
                return DateTime.Now;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetCurrentTime -> ", _ex);
                return DateTime.Parse("2000-01-01 00:00");
            }
        }
        public string GetCurrentDate()
        {
            try
            {
                return GetCurrentTime().ToString("dd/MM/yyyy");
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetCurrentDate -> ", _ex);
                return "";
            }
        }
        public string GetCurrentHour()
        {
            try
            {
                return GetCurrentTime().ToString("HHmmss");
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetCurrentHour -> ", _ex);
                return "";
            }
        }
        public bool TurkishIdentityVerification(string _tcNo)
        {
            try
            {
                if (_tcNo.Length < 11)
                {
                    return false;
                }
                else if (_tcNo.Substring(0, 1) == "0")
                {
                    return false;
                }
                int toplam1 = Convert.ToInt32(_tcNo[0].ToString()) + Convert.ToInt32(_tcNo[2].ToString()) + Convert.ToInt32(_tcNo[4].ToString()) + Convert.ToInt32(_tcNo[6].ToString()) + Convert.ToInt32(_tcNo[8].ToString());
                int toplam2 = Convert.ToInt32(_tcNo[1].ToString()) + Convert.ToInt32(_tcNo[3].ToString()) + Convert.ToInt32(_tcNo[5].ToString()) + Convert.ToInt32(_tcNo[7].ToString());
                int sonuc = ((toplam1 * 7) - toplam2) % 10;
                if (sonuc.ToString() != _tcNo[9].ToString())
                {
                    return false;
                }
                int toplam3 = 0;
                for (int i = 0; i < 10; i++)
                {
                    toplam3 += Convert.ToInt32(_tcNo[i].ToString());
                }
                if ((toplam3 % 10).ToString() != _tcNo[10].ToString())
                {
                    return false;
                }
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.CreditCardVerification -> ", _ex);
                return false;
            }
        }
        public bool CreditCardVerification(string _cardNo)
        {
            try
            {
                if (_cardNo.Length != 16)
                {
                    return false;
                }
                int toplam = 0;
                for (int i = 0; i < 16; i++)
                {
                    int sayi = Convert.ToInt32(_cardNo[i].ToString());
                    if (i % 2 == 0)
                    {
                        sayi = sayi * 2;
                        if (sayi.ToString().Length == 2)
                        {
                            sayi = Convert.ToInt32(sayi.ToString().Substring(0, 1)) + Convert.ToInt32(sayi.ToString().Substring(1, 1));
                        }
                    }
                    toplam += sayi;
                }
                if (toplam % 10 == 0)
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
                Logger.WriteLog("Helper.CreditCardVerification -> ", _ex);
                return false;
            }
        }
        public byte[] ImageToByteArray(Image imageIn, ImageFormat _imageFormat)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, _imageFormat);
                    return ms.ToArray();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.ImageToByteArray -> ", _ex);
                return null;
            }
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                using (var ms = new MemoryStream(byteArrayIn))
                {
                    var returnImage = Image.FromStream(ms);
                    return returnImage;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.ByteArrayToImage -> ", _ex);
                return null;
            }
        }
        public Color RandomColorGenerator()
        {
            try
            {
                Byte[] b = new Byte[3];
                RandomGenerator.NextBytes(b);
                return Color.FromArgb(b[0], b[1], b[2]);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.RandomColorGenerator -> ", _ex);
                return Color.Red;
            }
        }
        public Color SpesificColorGenerator(int _red, int _green, int _blue, int _tolerance)
        {
            try
            {
                int _r = RandomGenerator.Next(_red - _tolerance, _red + _tolerance);
                int _g = RandomGenerator.Next(_green - _tolerance, _green + _tolerance);
                int _b = RandomGenerator.Next(_blue - _tolerance, _blue + _tolerance);
                if (_r < 0) _r = 0;
                if (_g < 0) _g = 0;
                if (_b < 0) _b = 0;
                if (_r > 255) _r = 255;
                if (_g > 255) _g = 255;
                if (_b > 255) _b = 255;
                return Color.FromArgb(_r, _g, _b);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.SpesificColorGenerator -> ", _ex);
                return Color.Red;
            }
        }
        public Random RandomGenerator = new Random();
        public int RandomIntegerGenerator()
        {
            try
            {
                return RandomGenerator.Next();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.RandomIntegerGenerator -> ", _ex);
                return 0;
            }
        }
        public int RandomIntegerGenerator(int _maxLimit)
        {
            try
            {
                return RandomGenerator.Next(_maxLimit);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.RandomIntegerGenerator -> ", _ex);
                return 0;
            }
        }
        public int RandomIntegerGenerator(int _minLimit, int _maxLimit)
        {
            try
            {
                return RandomGenerator.Next(_minLimit, _maxLimit);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.RandomIntegerGenerator -> ", _ex);
                return 0;
            }
        }
        public double RandomDoubleGenerator(int _minLimit, int _maxLimit)
        {
            try
            {
                double _d1 = RandomGenerator.Next(_minLimit, _maxLimit);
                double _d2 = RandomGenerator.Next(0, 100);
                return (_d1 + (_d2 / 100));
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.RandomDoubleGenerator -> ", _ex);
                return 0;
            }
        }
        public string GetVersion()
        {
            try
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetVersion -> ", _ex);
                return "";
            }
        }
        public string GetName()
        {
            try
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetName -> ", _ex);
                return "";
            }
        }
        public Dictionary<string, string> DifferenceBetweenDictionaries(Dictionary<string, string> _dictionary1, Dictionary<string, string> _dictionary2)
        {
            try
            {
                Dictionary<string, string> _differenceDictionary = new Dictionary<string, string>();
                foreach (string _key in _dictionary1.Keys)
                {
                    if (!_dictionary2.Keys.Contains(_key))
                    {
                        _differenceDictionary.Add(_key, _dictionary1[_key]);
                    }
                }
                return _differenceDictionary;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.DifferenceBetweenDictionaries -> ", _ex);
                return null;
            }
        }
        public string GetStringbyDictionay(Dictionary<string, string> _dictionary)
        {
            try
            {
                string _dictionaryString = "";
                foreach (string _key in _dictionary.Keys)
                {
                    _dictionaryString = _dictionaryString + "\n" + _key + "," + _dictionary[_key];
                }
                return _dictionaryString;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetStringbyDictionay -> ", _ex);
                return "";
            }
        }
        public bool ExecuteQueryByFile(string _connectionString, string _fileName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string data = File.ReadAllText(_fileName);
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = data;
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.ExecuteQuresybyFile -> ", _ex);
                return false;
            }
        }
        public int CalculateDateDifference(DateTime _date1, DateTime _date2)
        {
            try
            {
                TimeSpan _difference = _date1 - _date2;
                return (int)_difference.TotalDays;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.CalculateDateDifference -> ", _ex);
                return 0;
            }
        }
        public List<string> GetPrinters()
        {
            try
            {
                List<string> _printerList = new List<string>();
                foreach (string _printerName in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    _printerList.Add(_printerName);
                }
                return _printerList;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetPrinters -> ", _ex);
                return null;
            }
        }
   
        public int ConvertToAmcColor(Color color)
        {
            int amcColor = 0;
            amcColor |= color.R;
            amcColor |= color.G << 8;
            amcColor |= color.B << 16;
            return amcColor;
        }
        public bool CheckProgram(string ProgramName)
        {
            try
            {
                bool status = false;
                string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
                {
                    foreach (string subkey_name in key.GetSubKeyNames())
                    {
                        using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(subkey.GetValue("DisplayName"))))
                            {
                                if (Convert.ToString(subkey.GetValue("DisplayName")).Contains(ProgramName))
                                    status = true;
                            }
                        }
                    }
                }
                return status;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.CheckProgram -> ", _ex);
                return false;
            }
        }
        public double GetCurrentCpuUsage()
        {
            try
            {
                PerformanceCounter cpuCounter;
                cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                return Convert.ToDouble(cpuCounter.NextValue());
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetCurrentCpuUsage -> ", _ex);
                return 0;
            }
        }
        public double GetAvailableRAM()
        {
            try
            {
                PerformanceCounter ramCounter;
                ramCounter = new PerformanceCounter("Memory", "Available MBytes");
                return Math.Round(ramCounter.NextValue() / 1024, 2);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Helper.GetAvailableRAM -> ", _ex);
                return 0;
            }
        }
    }
}
