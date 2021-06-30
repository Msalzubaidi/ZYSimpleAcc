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
    public partial class frmActivation : Form
    {
        public frmActivation()
        {
            InitializeComponent();
        }

        Shared sh = new Shared();
        string table = "SystemInfo";
        string imglocation = "";

        private void frmActivation_Load(object sender, EventArgs e)
        {
            string condition = "";

            DataTable dtable = sh.SelctData(table, 0, condition);

            DataTable dtable2 = sh.SelctData("ActivationApp", 0, condition);

            string comname = dtable.Rows[0]["name"].ToString();
            int ActiveStatus = int.Parse(dtable2.Rows[0]["Activated"].ToString());
            txt_comname.Text = dtable.Rows[0]["name"].ToString();
            from.Text = dtable.Rows[0]["licencefrom"].ToString();
            to.Text = dtable.Rows[0]["licenceto"].ToString();

            string date = DateTime.Now.ToString("ddMMyyyy");
            string day = date[0] + "" + date[1];
            string month = date[2] + "" + date[3];
            string f = date[4] + "";
            string s = date[5] + "";
            string t = date[6] + "";
            string fth = date[7] + "";
            StringBuilder sb = new StringBuilder();

            sb.Append('Z');
            sb.Append(day);
            sb.Append('Y');
            sb.Append(month);
            sb.Append('S');
            sb.Append(f);
            sb.Append('A');
            sb.Append(s);
            sb.Append('S');
            sb.Append(t);
            sb.Append('S');
            sb.Append(fth);

            string newcomname = comname.Replace(" ", String.Empty);

            key.Text = sb.ToString();

            if (ActiveStatus == 0)
            {
                toggleSwitch1.IsOn = false;
            }
            if (ActiveStatus == 1)
            {
                toggleSwitch1.IsOn = true;
            }

            master.Visible = false;
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            labelControl11.Visible = false;
            checkBox1.Visible = false; 

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == DataBase.MasterPassword)
            {
               XtraMessageBox.Show("ZYTech2020" + DataBase.MasterPassword, "Activation Key - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                master.Visible = true;
                simpleButton1.Visible = true;
                simpleButton2.Visible = true;
                labelControl11.Visible = true;
                checkBox1.Visible = true;
            }
            else
            {
               XtraMessageBox.Show("Please Try Again After 1 Miniute ", "Activation Key - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            if (master.Text == "ZYTech2020" + DataBase.MasterPassword && string.IsNullOrEmpty(master.Text) == false)
            {
                db.ActivaApp();

               XtraMessageBox.Show("Activated Done Successfully", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.KeyAdd(key.Text);
            
                this.Hide();
                frmLogin l = new frmLogin();
                l.Show();
            }
            else
            {
               XtraMessageBox.Show("Try Again - Invalid Master Key or License", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                master.UseSystemPasswordChar = false; 
            }
            if (checkBox1.Checked == false)
            {
                master.UseSystemPasswordChar = true;
            }
        }

        private void frmActivation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
