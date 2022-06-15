/* Coder by KFY */
using System;
using System.Linq;
using System.Collections.Generic;
using CarWashingAutomation.Models;
using System.Data.SqlClient;

namespace CarWashingAutomation.Components
{
    public class DBManager : IDisposable
    {
        CarWashingDbContext DB = null;
        public DBManager()
        {
            try
            {
                DB = new CarWashingDbContext();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DBManager -> ", _ex);
            }
        }
        public void Dispose()
        {
            try
            {
                DB.Dispose();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.Dispose -> ", _ex);
            }
        }
        public void RunQuery(string _queryString)
        {
            using (SqlConnection connection = new SqlConnection(Constants.SQLConnectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(_queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception _ex)
                {
                    Logger.WriteLog("DBManager.RunQuery -> ", _ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        #region Users
        public List<User> GetUserList()
        {
            try
            {
                return DB.Users.ToList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetUserList -> ", _ex);
                return null;
            }
        }
        public User GetUser(int _id)
        {
            try
            {
                return GetUserList().Find(_user => _user.Id == _id);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetUser -> ", _ex);
                return null;
            }
        }
        public bool AddUser(User _user)
        {
            try
            {
                DB.Users.Add(_user);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.AddUser -> ", _ex);
                string _message = "Ne Yazıkki yeni kullanıcı eklenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool UpdateUser(User _user)
        {
            try
            {
                DB.Entry(_user).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.UpdateUser -> ", _ex);
                string _message = "Ne Yazıkki yeni kullanıcı güncellenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool DeleteUser(User _user)
        {
            try
            {
                var entry = DB.Entry(_user);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    DB.Users.Attach(_user);
                }
                DB.Users.Remove(_user);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DeleteUser -> ", _ex);
                string _message = "Ne Yazıkki yeni kullanıcı silinemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        #endregion

        #region Machines
        public List<Machine> GetMachineList()
        {
            try
            {
                return DB.Machines.ToList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetMachineList -> ", _ex);
                return null;
            }
        }
        public Machine GetMachine(int _id)
        {
            try
            {
                return GetMachineList().Find(_machine => _machine.Id == _id);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetMachine -> ", _ex);
                return null;
            }
        }
        public bool AddMachine(Machine _machine)
        {
            try
            {
                DB.Machines.Add(_machine);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.AddMachine -> ", _ex);
                string _message = "Ne Yazıkki yeni makine eklenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool UpdateMachine(Machine _machine)
        {
            try
            {
                DB.Entry(_machine).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.UpdateMachine -> ", _ex);
                string _message = "Ne Yazıkki yeni makine güncellenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool DeleteMachine(Machine _machine)
        {
            try
            {
                var entry = DB.Entry(_machine);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    DB.Machines.Attach(_machine);
                }
                DB.Machines.Remove(_machine);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DeleteMachine -> ", _ex);
                string _message = "Ne Yazıkki yeni makine silinemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        #endregion

        #region MachineAlarms
        public List<MachineAlarm> GetMachineAlarmList()
        {
            try
            {
                return DB.MachineAlarms.Include("Machine").ToList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetMachineAlarmList -> ", _ex);
                return null;
            }
        }
        public MachineAlarm GetMachineAlarm(int _id)
        {
            try
            {
                return GetMachineAlarmList().Find(_machineAlarm => _machineAlarm.Id == _id);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetMachineAlarm -> ", _ex);
                return null;
            }
        }
        public bool AddMachineAlarm(MachineAlarm _machineAlarm)
        {
            try
            {
                DB.MachineAlarms.Add(_machineAlarm);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.AddMachineAlarm -> ", _ex);
                string _message = "Ne Yazıkki yeni makine alarmı eklenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool UpdateMachineAlarm(MachineAlarm _machineAlarm)
        {
            try
            {
                DB.Entry(_machineAlarm).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.UpdateMachineAlarm -> ", _ex);
                string _message = "Ne Yazık ki makine alarmı güncellenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool DeleteMachineAlarm(MachineAlarm _machineAlarm)
        {
            try
            {
                var entry = DB.Entry(_machineAlarm);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    DB.MachineAlarms.Attach(_machineAlarm);
                }
                DB.MachineAlarms.Remove(_machineAlarm);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DeleteMachineAlarm -> ", _ex);
                string _message = "Ne Yazıkki makine alarmı silinemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        #endregion

        #region MachineReports
        public List<MachineReport> GetMachineReportList()
        {
            try
            {
                return DB.MachineReports.Include("Machine").ToList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetMachineReportList -> ", _ex);
                return null;
            }
        }
        public MachineReport GetMachineReport(int _id)
        {
            try
            {
                return GetMachineReportList().Find(_machineReport => _machineReport.Id == _id);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetMachineReport -> ", _ex);
                return null;
            }
        }
        public bool AddMachineReport(MachineReport _machineReport)
        {
            try
            {
                DB.MachineReports.Add(_machineReport);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.AddMachineReport -> ", _ex);
                string _message = "Ne Yazıkki yeni makine raporu eklenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool UpdateMachineReport(MachineReport _machineReport)
        {
            try
            {
                DB.Entry(_machineReport).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.UpdateMachineReport -> ", _ex);
                string _message = "Ne Yazık ki makine raporu güncellenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool DeleteMachineReport(MachineReport _machineReport)
        {
            try
            {
                var entry = DB.Entry(_machineReport);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    DB.MachineReports.Attach(_machineReport);
                }
                DB.MachineReports.Remove(_machineReport);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DeleteMachineReport -> ", _ex);
                string _message = "Ne Yazıkki makine raporu silinemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        #endregion
    }
}
