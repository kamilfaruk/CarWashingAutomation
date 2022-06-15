/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Tools;
using System.Collections.Generic;
using CarWashingAutomation.Models;
using CarWashingAutomation.Components;

namespace CarWashingAutomation.Forms
{
    public partial class TechnicalSupportForm : Form
    {
        public TechnicalSupportForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("TechnicalSupportForm.TechnicalSupportForm -> ", _ex);
            }
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("TechnicalSupportForm.Close_Btn_Click -> ", _ex);
            }
        }
        private void Send_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Message_Txt.Text != "" && Subject_Txt.Texts != "")
                {
                    using (GMail _gmail = new GMail())
                    {
                        using (DBManager _dbManager = new DBManager())
                        {
                            string _mailFailedUserList = "";
                            User _currentUser = _dbManager.GetUser(Constants.CurrentUserId);
                            List<User> _userList = _dbManager.GetUserList().FindAll(_u => _u.TechnicalSupportable == 1);
                            PdfReport _pdfReport = new PdfReport();
                            if (_pdfReport.GenerateAndSaveReport("Mail Eki (" + _currentUser.ToString() + ")"))
                            {
                                using (FileManager _fileManager = new FileManager())
                                {

                                    using (NotificationManager _notificationManager = new NotificationManager())
                                    {
                                        string _notificationText = "Mail Eki Raporu Oluşturuldu";
                                        _notificationManager.Notification_PC(_notificationText, NotificationType.Success);
                                    }
                                    string _attachmentsReportPath = _fileManager.GetLastCreatedFile(Application.StartupPath.ToString() + @"\" + Constants.ReportsDirectory);
                                    if (_fileManager.FileExists(_attachmentsReportPath))
                                    {
                                        foreach (User _user in _userList)
                                        {
                                            if (_gmail.SendMailbyAttachment(Constants.TechnicSupportMail, Constants.TechnicSupportPassword, _user.Mail, Subject_Txt.Texts, Message_Txt.Text, _attachmentsReportPath))
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                _mailFailedUserList = _mailFailedUserList + _user.Name + ", ";
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                using (NotificationManager _notificationManager = new NotificationManager())
                                {
                                    string _notificationText = "Mail Eki Raporu Oluşturulamadı";
                                    _notificationManager.Notification_PC(_notificationText, NotificationType.Error);
                                }
                                foreach (User _user in _userList)
                                {
                                    if (_gmail.SendMail(Constants.TechnicSupportMail, Constants.TechnicSupportPassword, _user.Mail, Subject_Txt.Texts, Message_Txt.Text))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        _mailFailedUserList = _mailFailedUserList + _user.Name + ", ";
                                    }
                                }
                            }

                            if (_mailFailedUserList == "")
                            {
                                this.Info_Lbl.Text = "Teknik destek mesajı başarılı bir şekilde iletildi.";
                                this.Info_Lbl.ForeColor = Color.FromArgb(75, 225, 100);
                                Message_Txt.Text = "";
                                Subject_Txt.Texts = "";
                            }
                            else
                            {
                                this.Info_Lbl.Text = _mailFailedUserList + " kullanıcılarına teknik destek mesajı iletilemedi.";
                                this.Info_Lbl.ForeColor = Color.FromArgb(255, 89, 100);
                            }
                        }
                    }
                    Info_Lbl.Visible = true;
                }
                else
                {
                    using (MsgBox _msgBox = new MsgBox())
                    {
                        _msgBox.Show("Teknik destem mesajı gönderebilmek için lütfen yukarıdaki tüm alanları eksiksiz olarak doldurunuz.", "FORM DOLDURMA HATASI", MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("TechnicalSupportForm.Send_Btn_Click -> ", _ex);
            }
        }
    }
}
