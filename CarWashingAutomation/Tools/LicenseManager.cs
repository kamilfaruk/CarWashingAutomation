/* Coder by KFY */
using System;
using System.Linq;
using System.Windows.Forms;
using CarWashingAutomation.Packets;
using System.Net.NetworkInformation;
using System.Collections.Generic;

namespace CarWashingAutomation.Tools
{
    class LicenseManager : IDisposable
    {
        public void Dispose()
        {

        }
        public LicenseManager()
        {

        }
        public string GetToken()
        {
            try
            {
                using (RSACrypter _rsaCrypter = new RSACrypter())
                {
                    string _mac = GetMacAddress();
                    if (_mac != null)
                    {
                        return _rsaCrypter.Encrypt(_mac);
                    }
                    return null;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseManager.GetToken -> ", _ex);
                return null;
            }
        }
        public string GetLicenseKey(int _licenseNumber, string _mac, int _validityYear = 1)
        {
            try
            {
                using (RSACrypter _rsaCrypter = new RSACrypter())
                {
                    DateTime _validityDate = DateTime.Now.AddYears(_validityYear);
                    string _licenseText = _licenseNumber + "#" + _mac + "#" + _validityDate.ToString();
                    string _cryptLicense = _rsaCrypter.Encrypt(_licenseText);
                    return _cryptLicense;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseManager.GetLicenseKey -> ", _ex);
                return null;
            }
        }
        public string GetOldLicenseKey()
        {
            try
            {
                using (RSACrypter _rsaCrypter = new RSACrypter())
                {
                    string _licenseNumber = "";
                    string _mac = "";
                    string _validityDate = "";
                    using (FileManager _fm = new FileManager())
                    {
                        //TODO: Geçmiş lisans bilgilerini klasörden değil başka bir yerden al...
                        if (_fm.FileExists(Application.StartupPath.ToString() + "\\" + Constants.LicenseLic))
                        {
                            JSonPacket _licenseJson = JSonPacket.ReadJsonFromFile(Application.StartupPath.ToString() + "\\" + Constants.LicenseLic);
                            if (_licenseJson != null)
                            {

                                Dictionary<string, string> _licenseDictionary = _licenseJson.DeserializeObject<Dictionary<string, string>>();
                                foreach (var kv in _licenseDictionary)
                                {
                                    if (kv.Key == "LicenseKey")
                                    {
                                        string _licenseKey = kv.Value;
                                        _mac = _rsaCrypter.Decrypt(_licenseKey);

                                    }
                                    if (kv.Key == "ValidityDate")
                                    {
                                        string _validity = kv.Value;
                                        _validityDate = _rsaCrypter.Decrypt(_validityDate);
                                    }
                                    if (kv.Key == "LicenseNumber")
                                    {
                                        _licenseNumber = kv.Value;
                                    }
                                }
                            }
                        }
                    }
                    if (_licenseNumber != "" && _mac != "" && _validityDate != "")
                    {
                        string _licenseText = _licenseNumber + "#" + _mac + "#" + _validityDate.ToString();
                        string _cryptLicense = _rsaCrypter.Encrypt(_licenseText);
                        return _cryptLicense;
                    }
                    else
                    {
                        return "Geçmiş lisans anahtarınıza ulaşılamadı. Lütfen lisans sağlayıcı firma ile iletişime geiniz.";
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseManager.GetOldLicenseKey -> ", _ex);
                return "Geçmiş lisans anahtarınıza ulaşılamadı. Lütfen lisans sağlayıcı firma ile iletişime geiniz.";
            }
        }
        public bool AddLicenseKey(string _licenseKey)
        {
            try
            {
                using (RSACrypter _rsaCrypter = new RSACrypter())
                {
                    string _licenseDecrypt = _rsaCrypter.Decrypt(_licenseKey);
                    int _licenseNumber = Convert.ToInt32(_licenseDecrypt.Split('#')[0]);
                    string _mac = _licenseDecrypt.Split('#')[1];
                    string _validityDate = _licenseDecrypt.Split('#')[2];
                    if (_mac == GetMacAddress())
                    {
                        JSonPacket.WriteJsonToFile(new JSonPacket(@"{" +
                            @"""LicenseNumber"":""" + _licenseNumber +
                            @""",""LicenseKey"":""" + _rsaCrypter.Encrypt(_mac) +
                            @""",""ValidityDate"":""" + _rsaCrypter.Encrypt(_validityDate) +
                            @"""}"), Application.StartupPath.ToString() + "\\" + Constants.LicenseLic);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseManager.AddLicenseKey -> ", _ex);
                return false;
            }
        }
        public bool ChackLicense()
        {
            try
            {
                bool _macControl = false;
                bool _validityControl = false;
                using (FileManager _fm = new FileManager())
                {
                    if (_fm.FileExists(Application.StartupPath.ToString() + "\\" + Constants.LicenseLic))
                    {
                        JSonPacket _licenseJson = JSonPacket.ReadJsonFromFile(Application.StartupPath.ToString() + "\\" + Constants.LicenseLic);
                        if (_licenseJson != null)
                        {
                            using (RSACrypter _rsaCrypter = new RSACrypter())
                            {
                                Dictionary<string, string> _licenseDictionary = _licenseJson.DeserializeObject<Dictionary<string, string>>();
                                foreach (var kv in _licenseDictionary)
                                {
                                    if (kv.Key == "LicenseKey")
                                    {
                                        string _licenseKey = kv.Value;
                                        string _mac = _rsaCrypter.Decrypt(_licenseKey);
                                        if (_mac == GetMacAddress())
                                        {
                                            _macControl = true;
                                        }
                                    }
                                    if (kv.Key == "ValidityDate")
                                    {
                                        string _validityDate = kv.Value;
                                        string _validity = _rsaCrypter.Decrypt(_validityDate);
                                        if (DateTime.Now < DateTime.Parse(_validity))
                                        {
                                            _validityControl = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (_validityControl && _macControl)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseManager.ChackLicense -> ", _ex);
                return false;
            }
        }
        private string GetMacAddress()
        {
            try
            {
                string _macAddress = (from nic in NetworkInterface.GetAllNetworkInterfaces()
                                      where nic.OperationalStatus == OperationalStatus.Up
                                      select nic.GetPhysicalAddress().ToString()
                                  ).FirstOrDefault();
                return _macAddress;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LicenseManager.GetMacAddress -> ", _ex);
                return null;
            }
        }
    }
}
