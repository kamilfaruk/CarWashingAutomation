/* Coder by KFY */
using System;
using System.Text;
using System.Windows.Forms;
using ParameterEditor.Components;
using ParameterEditor.Tools;

namespace ParameterEditor
{
    class Logger
    {
        static StringBuilder Main_LogStringBuilder = new StringBuilder();
        public static void Write(string _log)
        {
            using (Helper _helper = new Helper())
            {
                Main_LogStringBuilder.AppendLine(_helper.GetCurrentTime() + " => " + _log);
            }
            Console.WriteLine(_log);
        }
        public static void WriteLog(string _class_method, Exception _ex)
        {
            if (_ex.Message == "An error occurred while updating the entries. See the inner exception for details.")
            {
                Write(_class_method + _ex.InnerException.Message);
            }
            else
            {
                Write(_class_method + _ex.Message);
            }
        }
        public static void ExportLog()
        {
            try
            {
                using (FileManager _fm = new FileManager())
                {
                    _fm.Copy(Application.StartupPath.ToString() + "\\" + Constants.LogPath, Application.StartupPath.ToString() + "\\" + Constants.MailAttechmentLogPath);
                    if (_fm.GetSize(Application.StartupPath.ToString() + "\\" + Constants.LogPath) > 10)
                    {
                        StringBuilder _oldLog = _fm.Read(Application.StartupPath.ToString() + "\\" + Constants.LogPath);
                        _oldLog.Append(Main_LogStringBuilder);
                        StringBuilder _mailText = _fm.Read(Application.StartupPath.ToString() + "\\" + Constants.MailTextLogPath);
                        using (GMail _gmail = new GMail())
                        {
                            bool _isok = _gmail.SendMailbyAttachment(Constants.TechnicSupportMail, Constants.TechnicSupportPassword, "kamilfarukyel94@gmail.com", "ERROR LOG", _mailText.ToString(), Application.StartupPath.ToString() + "\\" + Constants.MailAttechmentLogPath);
                            if (!_isok)
                            {
                                using (MsgBox _msgBox = new MsgBox())
                                {
                                    _msgBox.Show("Ne yazık ki sistem uyarı ve hatalarını içeren bildirim maili üretici firmaya iletilemedi.", "MAİL İLETİLEMEDİ", MsgBox.Buttons.OK, MsgBox.Icons.Info);
                                }
                            }
                        }
                        _fm.Delete(Application.StartupPath.ToString() + "\\" + Constants.LogPath);
                        StringBuilder _createFolder = new StringBuilder();
                        using (Helper _helper = new Helper())
                        {
                            _createFolder.AppendLine(_helper.GetCurrentTime() + " => LOG DOSYASI OLUŞTURULDU.");
                        }
                        _fm.Write(Application.StartupPath.ToString() + "\\" + Constants.LogPath, _createFolder.ToString());
                        StringBuilder _newLog = _fm.Read(Application.StartupPath.ToString() + "\\" + Constants.LogPath);
                        _newLog.Append(Main_LogStringBuilder);
                        _fm.Write(Application.StartupPath.ToString() + "\\" + Constants.LogPath, _newLog.ToString());
                        _fm.Delete(Application.StartupPath.ToString() + "\\" + Constants.MailAttechmentLogPath);
                    }
                    else
                    {
                        StringBuilder _oldLog = _fm.Read(Application.StartupPath.ToString() + "\\" + Constants.LogPath);
                        _oldLog.Append(Main_LogStringBuilder);
                        _fm.Write(Application.StartupPath.ToString() + "\\" + Constants.LogPath, _oldLog.ToString());
                    }
                    _fm.Delete(Application.StartupPath.ToString() + "\\" + Constants.MailAttechmentLogPath);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void WriteErrorMsg(string _message, string _title)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Error);
                }
            }
            catch
            { }
        }
    }
}
