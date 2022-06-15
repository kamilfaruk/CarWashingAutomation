/* Coder by KFY */
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace LicenseKeyGenerator.Tools
{
    public class GMail : IDisposable
    {
        public void Dispose()
        {

        }
        public bool SendMail(string _fromMail, string _fromPass, string _toMail, string _subject, string _text)
        {
            try
            {
                System.Net.NetworkCredential cred = new System.Net.NetworkCredential(_fromMail, _fromPass);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(_fromMail, Application.ProductName);
                mail.To.Add(_toMail);
                mail.Subject = _subject;
                mail.IsBodyHtml = true;
                mail.Body = _text;
                mail.Attachments.Clear();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = cred;
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail gönderilirkene bir hata ile karşılaşıldı: " + ex.Message);
                return false;
            }
        }
        public bool SendMailbyAttachment(string _fromMail, string _fromPass, string _toMail, string _subject, string _text, string _attachmenstPath)
        {
            try
            {
                System.Net.NetworkCredential cred = new System.Net.NetworkCredential(_fromMail, _fromPass);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(_fromMail, Application.ProductName);
                mail.To.Add(_toMail);
                mail.Subject = _subject;
                mail.IsBodyHtml = true;
                mail.Body = _text;
                mail.Attachments.Clear();
                Attachment attachment = new Attachment(_attachmenstPath);
                mail.Attachments.Add(attachment);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = cred;
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail gönderilirkene bir hata ile karşılaşıldı: " + ex.Message);
                return false;
            }
        }
    }
}
