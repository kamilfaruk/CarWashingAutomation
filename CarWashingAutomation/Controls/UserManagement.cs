/* Coder by KFY */
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CarWashingAutomation.Models;
using CarWashingAutomation.Components;

namespace CarWashingAutomation.Controls
{
    public partial class UserManagement : UserControl
    {
        User Main_User = new User();
        public delegate void AddUserEvent();
        public event AddUserEvent AddUser;
        public delegate void UpdateUserEvent();
        public event UpdateUserEvent UpdateUser;
        public delegate void DeleteUserEvent();
        public event DeleteUserEvent DeleteUser;
        public delegate void UserSelectedEvent();
        public event UserSelectedEvent UserSelected;
        public UserManagement()
        {
            try
            {
                InitializeComponent();
                TechnicalSupportable_Cbx.Items.Add("HAYIR");
                TechnicalSupportable_Cbx.Items.Add("EVET");
                Authority_Cbx.Items.Add("KULLANICI");
                Authority_Cbx.Items.Add("YÖNETİCİ");
                Authority_Cbx.Items.Add("MÜDÜR");
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("UserManagement.UserManagement -> ", _ex);
            }
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                PopulateDataGridView();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("UserManagement.UserManagement_Load -> ", _ex);
            }
        }
        private void User_Dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (User_Dgv.CurrentRow.Index != -1)
                    {
                        Main_User.Id = Convert.ToInt32(User_Dgv.CurrentRow.Cells["Id"].Value);
                        Main_User = _dbManager.GetUserList().Where(x => x.Id == Main_User.Id).FirstOrDefault();
                        Name_Txt.Texts = Main_User.Name;
                        Surname_Txt.Texts = Main_User.Surname;
                        UserName_Txt.Texts = Main_User.UserName;
                        Password_Txt.Texts = Main_User.Password;
                        Mail_Txt.Texts = Main_User.Mail;
                        Phone_Txt.Texts = Main_User.Phone;
                        Authority_Cbx.SelectedItem = Main_User.Authority;
                        TechnicalSupportable_Cbx.SelectedIndex = Main_User.TechnicalSupportable;
                        Save_Btn.Text = "DÜZENLE";
                        Delete_Btn.Enabled = true;
                        if (UserSelected != null)
                        {
                            UserSelected();
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("UserManagerControl.User_Dgv_DoubleClick -> ", _ex);
            }
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Main_User.Name = Name_Txt.Texts;
                Main_User.Surname = Surname_Txt.Texts;
                Main_User.UserName = UserName_Txt.Texts;
                Main_User.Password = Password_Txt.Texts;
                Main_User.Phone = Phone_Txt.Texts;
                Main_User.Mail = Mail_Txt.Texts;
                Main_User.TechnicalSupportable = (int)TechnicalSupportable_Cbx.SelectedIndex;
                Main_User.Authority = (string)Authority_Cbx.SelectedItem;
                using (DBManager _dbManager = new DBManager())
                {
                    if (Main_User.Id == 0)
                    {
                        if (_dbManager.AddUser(Main_User))
                        {
                            if (AddUser != null)
                            {
                                AddUser();
                            }
                        }
                    }
                    else
                    {
                        if (_dbManager.UpdateUser(Main_User))
                        {
                            if (UpdateUser != null)
                            {
                                UpdateUser();
                            }
                        }
                    }
                }
                Clear();
                PopulateDataGridView();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("UserManagerControl.Save_Btn_Click -> ", _ex);
            }
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Kullanıcıyı silmek istediğinizden emin misiniz?";
                    string _header = "KULLANICI SİLME ONAYI";
                    DialogResult _ans = _msgBox.Show(_message, _header, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        using (DBManager _dbManager = new DBManager())
                        {
                            if (_dbManager.DeleteUser(Main_User))
                            {
                                if (DeleteUser != null)
                                {
                                    DeleteUser();
                                }
                            }
                        }
                        PopulateDataGridView();
                        Clear();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("UserManagerControl.Delete_Btn_Click -> ", _ex);
            }
        }
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("UserManagement.Cancel_Btn_Clicks -> ", _ex);
            }
        }
        private void Clear()
        {
            try
            {
                TechnicalSupportable_Cbx.SelectedIndex = -1;
                Authority_Cbx.SelectedIndex = -1;
                Name_Txt.Texts = Surname_Txt.Texts = UserName_Txt.Texts = Password_Txt.Texts = Mail_Txt.Texts = Phone_Txt.Texts = "";
                Save_Btn.Text = "KAYDET";
                Delete_Btn.Enabled = false;
                Main_User.Id = 0;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("UserManagerControl.Clear -> ", _ex);
            }
        }
        private void PopulateDataGridView()
        {
            try
            {
                User_Dgv.AutoGenerateColumns = false;
                using (DBManager _dbManager = new DBManager())
                {
                    User_Dgv.DataSource = _dbManager.GetUserList();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("UserManagerControl.PopulateDataGridView -> ", _ex);
            }
        }
    }
}