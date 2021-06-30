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
    public partial class frmMyAccount : Form
    {
        public frmMyAccount()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        Shared s = new Shared();


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMyAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_oldpass.Text) || string.IsNullOrWhiteSpace(txt_newpass.Text))
            {
                XtraMessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_newpass.Clear();
                txt_oldpass.Clear();
                txt_username.Clear();
               
                txt_username.Text = DataBase.Username.ToString();
            }
            else
            {


               
                string usern = txt_username.Text;
                string opass = txt_oldpass.Text;
                string npass = txt_newpass.Text;

                int rest = db.UpdateUserinfo(usern, opass, npass);

                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.UserLogTransactions(DataBase.Username.ToString(), "تغيير كلمة المرور", DateTime.Now, Environment.MachineName);
                    txt_newpass.Clear();
                    txt_oldpass.Clear();
                    txt_username.Clear();
               
                    txt_username.Text = DataBase.Username.ToString();

                }

                else if (rest <= 0)
                {
                    XtraMessageBox.Show(Resources.invalidPassword, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_newpass.Clear();
                    txt_oldpass.Clear();
              
                    txt_username.Text = DataBase.Username.ToString();

                }

                else
                {
                    XtraMessageBox.Show("Please Try Again", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_newpass.Clear();
                    txt_oldpass.Clear();
              
                    txt_username.Text = DataBase.Username.ToString();

                }
            }
        }

        private void frmMyAccount_Load(object sender, EventArgs e)
        {
          
            txt_username.Text = DataBase.Username.ToString();
        }
    }
}
