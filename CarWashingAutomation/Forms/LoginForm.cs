/* Coder by KFY */
using System;
using System.Drawing;
using System.Windows.Forms;
using CarWashingAutomation.Models;
using System.Runtime.InteropServices;
using CarWashingAutomation.Components;
using System.Collections.Generic;

namespace CarWashingAutomation.Forms
{
    public partial class LoginForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        public bool Logined = false;
        public LoginForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LoginForm.LoginForm -> ", _ex);
            }
        }
        private void Logo_Pnl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LoginForm.Logo_Pnl_MouseDown -> ", _ex);
            }
        }
        private void Username_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Username_Txt.Text == "")
                {
                    Username_Txt.Text = "Kullanıcı Adı";
                    Username_Txt.ForeColor = Color.Silver;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LoginForm.Username_Txt_Leave -> ", _ex);
            }
        }
        private void Username_Txt_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Username_Txt.Text == "Kullanıcı Adı")
                {
                    Username_Txt.Text = "";
                    Username_Txt.ForeColor = Color.LightGray;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LoginForm.Username_Txt_Enter -> ", _ex);
            }
        }
        private void Password_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Password_Txt.Text == "")
                {
                    Password_Txt.Text = "Şifre";
                    Password_Txt.ForeColor = Color.Silver;
                    Password_Txt.UseSystemPasswordChar = false;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LoginForm.Password_Txt_Leave -> ", _ex);
            }
        }
        private void Password_Txt_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Password_Txt.Text == "Şifre")
                {
                    Password_Txt.Text = "";
                    Password_Txt.ForeColor = Color.LightGray;
                    Password_Txt.UseSystemPasswordChar = true;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LoginForm.Password_Txt_Enter -> ", _ex);
            }
        }
        private void Minimize_Pbx_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LoginForm.Minimize_Pbx_Click -> ", _ex);
            }
        }
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LoginForm.LoginForm_MouseDown -> ", _ex);
            }
        }
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username_Txt.Text != "Kullanıcı Adı" && Password_Txt.Text != "Şifre")
                {
                    using (DBManager _dbManager = new DBManager())
                    {
                        List<User> _userList = _dbManager.GetUserList();
                        if (_userList != null)
                        {
                            User _user = _userList.Find(_u => _u.UserName == Username_Txt.Text && _u.Password == Password_Txt.Text);
                            if (_user != null)
                            {
                                Logined = true;
                                Constants.CurrentUserId = _user.Id;
                                this.Close();
                            }
                            else
                            {
                                using (MsgBox _msgBox = new MsgBox())
                                {
                                    string _message = "Ne yazıkki girmiş olduğunuz kullanıcı adı veya şifre ile eşleşen bir kullanıcı bulunamadı.";
                                    string _title = "KULLANICI BULUNAMADI";
                                    _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("GetUserList olumsuz");
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                MessageBox.Show("KEŞŞŞ: " + _ex.ToString());
                Logger.WriteLog("LoginForm.Login_Btn_Click -> ", _ex);
            }
        }
    }
}
