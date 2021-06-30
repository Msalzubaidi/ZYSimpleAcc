using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmChildAccounts : Form
    {
        public frmChildAccounts()
        {
            InitializeComponent();
        }



        Shared s = new Shared();
        SystemSetup ss = new SystemSetup();
        DataBase db = new DataBase();
        string MainAcctable = "MainAccounts";

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            XtraMessageBox.Show("تعني هذه الإشارة بأنه حقل مطلوب", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void acc_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(acc.Text) || s.isDigitsOnly(acc.Text) == false)
            {
                // XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnclear.PerformClick();
            }

            else

            {

                string v = acc.EditValue.ToString();
                string condition = "accNo=" + "'" + v.ToString() + "'";

                int status = 0 ; 
                DataTable dtable = s.SelctData(MainAcctable, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {
                  
                        txtmainaccno.Text = dtable.Rows[0]["accNO"].ToString();//1
                        txtaccname.Text = dtable.Rows[0]["accName"].ToString();//2
                        txtMaxBalance.Text = dtable.Rows[0]["accMaxBalance"].ToString();
                        txtCure.Text = dtable.Rows[0]["accCurrency"].ToString();
                        txtAccType.Text = dtable.Rows[0]["accType"].ToString();
                        status = int.Parse(dtable.Rows[0]["accStatus"].ToString());//2
                        int IsParent = int.Parse(dtable.Rows[0]["IsParent"].ToString());//2
                   
                    

                    if (status == 0)
                    {
                        txtaccStatus.Text = "غير فعال";
                    }
                    if (status == 1)
                    {
                        txtaccStatus.Text = "فعال";
                    }

                    //btnupdate.Visible = true;
                    //btnactivate.Visible = true;
                    //btndeactivaete.Visible = true;
                    //btndelete.Visible = true;
                    //btnadd.Visible = false;
                }
                else
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnclear.PerformClick();
                }
            }
        }

        private void frmChildAccounts_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();

            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from MainAccounts ";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(0).ToString();

                acc.Properties.Items.Add(item1);

            }

            string connstring1 = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con31 = new SqlConnection(connstring1);
            SqlCommand cmd31;
            SqlDataReader dr31;

            string qry31 = "select * from MainAccounts where accParent <>'MainAccount' ";
            con31.Open();



            cmd31 = new SqlCommand(qry31, con31);
            dr31 = cmd31.ExecuteReader();

            while (dr31.Read())
            {
                string item11 = dr31.GetValue(0).ToString();

                comboBoxEdit1.Properties.Items.Add(item11);

            }


            cur.Properties.Items.Add("دينار");
            cur.Properties.Items.Add("دولار");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text) || s.isDigitsOnly(txtmainaccno.Text) == false || s.isDigitsOnly(txtchildaccno.Text) == false || s.isDigitsOnly(txtMaxBalance.Text) == false) || string.IsNullOrEmpty(txtAccType.Text) || string.IsNullOrEmpty(cur.Text))
            {

                XtraMessageBox.Show(Resources.emptyFields + " / " + Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int accStatus = 1;
                string accNo = txtchildaccno.Text.Trim();
                string accName = txtchildName.Text.Trim();
                string accType = txtAccType.Text.Trim();
                string accMaxBalance = txtchildMaxBal.Text.Trim();
                string accCurency = cur.Text.Trim();
                int IsParent = 0;
                string accParent = txtmainaccno.Text;
                string accParentName = txtaccname.Text; 

                int rslt = ss.AddAccount(accNo, accName, accType, accMaxBalance, accStatus, accCurency, IsParent, accParent , accParentName);

                if (rslt > 0)
                {
                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ss.MakeAccountParent(accParent , 1 );
                    db.UserLogTransactions(DataBase.Username.ToString(), " اضافة حساب جديد" + accNo.ToString() + " / " + accName.ToString(), DateTime.Now, Environment.MachineName);
                    btnclear.PerformClick();
                }
                else if (rslt == -150)
                {
                    XtraMessageBox.Show(Resources.Exist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            acc.ResetText();
            txtmainaccno.Text = "رقم الحساب ";
            txtaccname.Text = "اسم الحساب ";
            txtAccType.Text = "نوع الحساب ";
            txtchildaccno.Clear();
            txtMaxBalance.Text = "000";
            txtCure.Text = "عملة الحساب";
            txtaccStatus.Text = "حالة الحساب";
            txtchildName.Clear();
            
            txtchildMaxBal.Text = "000";
            cur.ResetText();
            txtchildaccno.Focus();
            //btnupdate.Visible = false;
            //btnactivate.Visible = false;
            //btndeactivaete.Visible = false;
            //btndelete.Visible = false;
            //btnadd.Visible = true;


            DataTable dtable = s.SelctData(MainAcctable, 0, "");
            int x = dtable.Rows.Count;
            MyGrid.RefreshDataSource();
            MyGrid.DataSource = dtable;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("سيتم حذف الحساب ؟ متأكد ؟  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtchildaccno.Text))
                {
                    XtraMessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {
                    string accNo = txtchildaccno.Text;

                    //التأكد من وجود حركات قبل الحذف وأنه ليس له أبناء
                    int rest = ss.DeletAccount(accNo);


                    if (rest > 0)
                    {

                        XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                        db.UserLogTransactions(DataBase.Username.ToString(), " حذف حساب " + accNo.ToString() + " / ", DateTime.Now, Environment.MachineName);
                        btnclear.PerformClick();
                    }
                    else if (rest == -150)
                    {
                        XtraMessageBox.Show(Resources.uesd, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                        btnclear.PerformClick();
                    }
                    else if (rest == -250)
                        XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    btnclear.PerformClick();
                }

            }

            else if (result == DialogResult.No)
            {
                XtraMessageBox.Show(Resources.CancelByUser, Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
                btnclear.PerformClick();
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxEdit1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(acc.Text) || s.isDigitsOnly(acc.Text) == false)
            {
                // XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnclear.PerformClick();
            }

            else

            {

                string v = acc.EditValue.ToString();
                string condition = "accNo=" + v.ToString();


                DataTable dtable = s.SelctData(MainAcctable, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtmainaccno.Text = dtable.Rows[0]["accNO"].ToString();//1
                    txtaccname.Text = dtable.Rows[0]["accName"].ToString();//2
                    txtMaxBalance.Text = dtable.Rows[0]["accMaxBalance"].ToString();
                    txtCure.Text = dtable.Rows[0]["accCurrency"].ToString();
                    txtAccType.Text = dtable.Rows[0]["accType"].ToString();
                    int status = int.Parse(dtable.Rows[0]["accStatus"].ToString());//2
                    int IsParent = int.Parse(dtable.Rows[0]["IsParent"].ToString());//2

                    if (status == 0)
                    {
                        txtaccStatus.Text = "غير فعال";
                    }
                    if (status == 1)
                    {
                        txtaccStatus.Text = "فعال";
                    }

                    //btnupdate.Visible = true;
                    //btnactivate.Visible = true;
                    //btndeactivaete.Visible = true;
                    //btndelete.Visible = true;
                    //btnadd.Visible = false;
                }
                else
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnclear.PerformClick();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.Columns.Count <= 0)
            {
                XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (!MyGrid.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                    return;
                }

                // Open the Preview window.
                MyGrid.ShowPrintPreview();
            }

        }

        private void frmChildAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
