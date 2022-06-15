/* Coder by KFY */
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CarWashingAutomation.Packets
{
    public class JSonPacket
    {
        public JSonPacket()
        {
            try
            {
                Main_JSon = new JObject();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.JSonPacket() -> ", _ex);
            }
        }
        public JSonPacket(JObject _object)
        {
            try
            {
                Main_JSon = _object;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.JSonPacket(JObject) -> ", _ex);
            }
        }
        public JSonPacket(string _jsonString)
        {
            try
            {
                Main_JSon = JObject.Parse(_jsonString);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.JSonPacket(string) -> ", _ex);
            }
        }
        public JSonPacket(Dictionary<string, string> _dictionary)
        {
            try
            {
                string _jsonString = JsonConvert.SerializeObject(_dictionary, Formatting.Indented);
                Main_JSon = JObject.Parse(_jsonString);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.JSonPacket(Dictionary) -> ", _ex);
            }
        }
        public void WriteJsonPacket(string _key, JSonPacket _data)
        {
            try
            {
                Main_JSon[_key] = _data.Main_JSon;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.WriteJsonPacket(Key Error) -> ", _ex);
            }
        }
        public T DeserializeObject<T>()
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(Main_JSon.ToString());
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.DeserializeObject -> ", _ex);
                return default(T);
            }
        }
        public T DeserializeObject<T>(string _key)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(Main_JSon[_key].ToString());
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.DeserializeObject(string) -> ", _ex);
                return default(T);
            }
        }
        public object Deserialize(Type _objType)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                return serializer.Deserialize(new JTokenReader(Main_JSon), _objType);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.Deserialize -> ", _ex);
                return null;
            }
        }
        public object SerilazeObject()
        {
            try
            {
                return JsonConvert.SerializeObject(Main_JSon);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.SerilazeObject -> ", _ex);
                return null;
            }
        }
        public static object GetObjectbyJson(JSonPacket _json)
        {
            try
            {
                return _json.Main_JSon.ToObject<object>();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.GetObjectbyJson -> ", _ex);
                return null;
            }
        }
        public static JSonPacket ReadJsonFromFile(string _path)
        {
            try
            {
                using (StreamReader file = File.OpenText(_path))
                {
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JSonPacket _newJson = new JSonPacket((JObject)JToken.ReadFrom(reader));
                        return _newJson;
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.ReadJsonFromFile -> ", _ex);
                return null;
            }
        }
        public static void WriteJsonToFile(JSonPacket _json, string _path)
        {
            try
            {
                if (_json.Main_JSon != null)
                {
                    if (File.Exists(_path))
                    {
                        File.Delete(_path);
                    }
                    using (StreamWriter file = File.CreateText(_path))
                    {
                        using (JsonTextWriter writer = new JsonTextWriter(file))
                        {
                            _json.Main_JSon.WriteTo(writer);
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.WriteJsonToFile -> ", _ex);
            }
        }
        public JSonPacket ReadJson(string _key)
        {
            try
            {
                if (Main_JSon[_key].Type == JTokenType.Object)
                {
                    JSonPacket _newJson = new JSonPacket((JObject)Main_JSon[_key]);
                    return _newJson;
                }
                return null;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.ReadJson -> ", _ex);
                return null;
            }
        }
        public int ReadS32(string _key)
        {
            try
            {
                if (Main_JSon[_key].Type == JTokenType.Integer)
                {
                    return (int)Main_JSon[_key];
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.ReadS32 -> ", _ex);
            }
            return 0;
        }
        public string ReadString(string _key)
        {
            try
            {
                if (Main_JSon[_key].Type == JTokenType.String)
                {
                    return (string)Main_JSon[_key];
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.ReadString -> ", _ex);
            }
            return null;
        }
        public void WriteObject(string _key, object _data)
        {
            try
            {
                string output = JsonConvert.SerializeObject(_data);
                JSonPacket _jSonPacket = new JSonPacket(output);
                WriteJsonPacket(_key, _jSonPacket);
            }
            catch (Exception _ex)
            {
                Console.WriteLine("Json WriteObject Error key : " + _key + " ", _ex);
            }
        }
        public void WriteString(string _key, string _value)
        {
            try
            {
                Main_JSon[_key] = _value;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.WriteString -> ", _ex);
            }
        }
        public void WriteInt(string _key, int _value)
        {
            try
            {
                Main_JSon[_key] = _value;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.WriteInt -> ", _ex);
            }
        }
        public bool Contains(string _key)
        {
            try
            {
                if (Main_JSon.ContainsKey(_key))
                {
                    return true;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.Contains -> ", _ex);
            }
            return false;
        }
        public string toString()
        {
            try
            {
                return JsonConvert.SerializeObject(Main_JSon);

            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.toString -> ", _ex);
            }
            return null;
        }
        public char[] ToArray()
        {
            try
            {
                return Main_JSon.ToString().ToCharArray();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("JsonPacket.ToArray -> ", _ex);
            }
            return null;
        }
        private JObject Main_JSon;
    }
}
