/* Coder by KFY */
using System;
using System.Threading;
using System.Collections.Generic;
using CarWashingAutomation.Models;
using CarWashingAutomation.Tools;

namespace CarWashingAutomation.Components
{
    public class NotificationManager : IDisposable
    {
        public void Dispose()
        {

        }
        public void Notification_NonController(string _message, NotificationType _notificationType)
        {
            try
            {
                if (Constants.NotificationOpen)
                {
                    NotificationForm _notificationForm = new NotificationForm();
                    _notificationForm.ShowNotification(_message, _notificationType);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("NotificationManager.Notification_NonController -> ", _ex);
            }
        }
        public void Notification_PC(string _message, NotificationType _notificationType)
        {
            try
            {
                if (Constants.NotificationOpen)
                {
                    NotificationForm _notificationForm = new NotificationForm();
                    _notificationForm.ShowNotification(_message, _notificationType);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("NotificationManager.Notification_PC -> ", _ex);
            }
        }
        public void Notification_PCMail(string _message, NotificationType _notificationType)
        {
            try
            {
                if (Constants.NotificationOpen)
                {
                    Mail_message = _message;
                    Thread _mailThread = new Thread(new ThreadStart(SendNotificationMailsByAdmins));
                    _mailThread.Start();
                    Notification_PC(_message, _notificationType);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("NotificationManager.Notification_PCMail -> ", _ex);
            }
        }
        String Mail_message = "";
        private void SendNotificationMailsByAdmins()
        {
            try
            {
                if (Constants.NotificationOpen)
                {
                    using (DBManager _dbManager = new DBManager())
                    {
                        List<User> _mailList = _dbManager.GetUserList().FindAll(_u => _u.TechnicalSupportable == 1);
                        foreach (User _user in _mailList)
                        {
                            string _toMail = _user.Mail;
                            using (GMail _gmail = new GMail())
                            {
                                bool _isok = _gmail.SendMail(Constants.TechnicSupportMail, Constants.TechnicSupportPassword, _toMail, "Car Washing Automation", Mail_message);
                                if (!_isok)
                                {
                                    Notification_PC(_user.ToString() + "-Mail Gönderilemedi", NotificationType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("NotificationManager.SendAllNotificationMail -> ", _ex);
            }
        }
    }
}
