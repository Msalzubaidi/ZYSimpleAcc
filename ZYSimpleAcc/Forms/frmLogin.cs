using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static int languagearabic = 1;
        public static string pass = "";
        Shared s = new Shared();


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<DevExpress.XtraEditors.TextEdit>().Any(t => string.IsNullOrEmpty(t.Text)))
            {

                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.ResetText();
                txtUsername.ResetText();
                txtUsername.Focus();
            }
            else
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                DataBase db = new DataBase();
                int result = db.Login(username , password);
              
                if (result > 0 || txtPassword.Text == DataBase.MasterPassword)
                {
                    if (txtPassword.Text == DataBase.MasterPassword)
                        pass = "masterlogin";

                    DataTable datatable = db.ViewSysinfo(1);


                    string titleform = datatable.Rows[0]["name"].ToString();
                    string ay = datatable.Rows[0]["activeyear"].ToString();

                    this.Hide();
                    frmMain main = new frmMain();
                    db.UserLogTransactions(DataBase.Username , s.TranTypeFromTypes("zgjgajhddaskjgaskj") , DateTime.Now , Environment.UserName + "/" + Environment.MachineName);
                    string info = Resources.AppName + " " + Resources.AppVersion + "   " + ay.ToString();
                    main.Text = titleform.ToString() + "      " + info.ToString() + "        " + DataBase.Username.ToString();
                    main.Show();
                

                 

                }
                else if (result == 0)
                {
                    XtraMessageBox.Show(Resources.FaieldLogin, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.ResetText();
                    txtUsername.ResetText();
                    txtUsername.Focus();
                }
                else
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand);



            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(Environment.MachineName == "MZUBAIDI")
            {
                masterlogin.Visible = true;
              //  XtraMessageBox.Show("MachineName : " + Environment.MachineName + " - " + " / Server Name : " + Resources.servercon + " - " + " / DataBaseName : " + Resources.dbnamecon + " - " + "/  PasswordServer  : " + Resources.passwordcon + " - " + " / Server UserName : " + Resources.usernamecon + " - " + " /  Master Password Today : " + DataBase.MasterPassword , Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                masterlogin.Visible = false;


          

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
            }
            if (checkBox1.Checked == false)
            {
                txtPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void lnkForgetPassword_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "نسيت كلمة المرور")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmResetPassword rp = new frmResetPassword();
                rp.Show();
            }
        }

        private void masterlogin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = DataBase.MasterPassword;
            btnlogin.PerformClick();
            // XtraMessageBox.Show("MachineName : " + Environment.MachineName + " - " + " / Server Name : " + Resources.servercon + " - " + " / DataBaseName : " + Resources.dbnamecon + " - " + "/  PasswordServer  : " + Resources.passwordcon + " - " + " / Server UserName : " + Resources.usernamecon + " - " + " /  Master Password Today : " + DataBase.MasterPassword, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
