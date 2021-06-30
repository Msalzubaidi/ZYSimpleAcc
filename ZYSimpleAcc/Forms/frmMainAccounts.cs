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
    public partial class frmMainAccounts : Form
    {
        public frmMainAccounts()
        {
            InitializeComponent();
        }
        Shared s = new Shared();
        DataBase db = new DataBase();
        SystemSetup ss = new SystemSetup();
        string MainAcctable = "MainAccounts";

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text) || s.isDigitsOnly(txtaccno.Text) == false || s.isDigitsOnly(txtMaxBalance.Text) == false) || string.IsNullOrEmpty(acc_type.Text) || string.IsNullOrEmpty(cur.Text))
            {

                XtraMessageBox.Show(Resources.emptyFields + " / " + Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int accStatus = 1;
                string accNo = txtaccno.Text.Trim();
                string accName = txtaccname.Text.Trim();
                string accType = acc_type.Text.Trim();
                string accMaxBalance = txtMaxBalance.Text.Trim();
                string accCurency = cur.Text.Trim();
                int IsParent = 1;
                string accParentName = "MainAccount";
                string accParent = "MainAccount";

                int rslt = ss.AddAccount(accNo, accName, accType, accMaxBalance, accStatus, accCurency, IsParent , accParent, accParentName);

                if (rslt > 0)
                {
                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            acc_type.ResetText();
            cur.ResetText();
            txtaccno.Clear();
            txtaccname.Clear();
            txtaccStatus.Text = "فعال";
            txtCure.Text = "عملة الحساب";
            txtAccType.Text = "نوع الحساب";
            txtMaxBalance.Text = "000";
            txtaccno.Focus();
          //  txtMaxBalance.Clear();
            btnupdate.Visible = false;
            btnactivate.Visible = false;
            btndeactivaete.Visible = false;
            btndelete.Visible = false;
            btnadd.Visible = true;


            DataTable dtable = s.SelctData(MainAcctable, 0, "");
            int x = dtable.Rows.Count;
            MyGrid.RefreshDataSource();
            MyGrid.DataSource = dtable;




        }

        private void frmMainAccounts_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();

            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from MainAccounts where isParent=1";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(0).ToString();

                acc.Properties.Items.Add(item1);

            }

            acc_type.Properties.Items.Add("موجودات - الأصول");
            acc_type.Properties.Items.Add(" المطلوبات - التزامات");
            acc_type.Properties.Items.Add(" الايرادات");
            acc_type.Properties.Items.Add("تكلفة المبيعات");
            acc_type.Properties.Items.Add("مصاريف");
            cur.Properties.Items.Add("دينار");
            cur.Properties.Items.Add("دولار");



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
                string condition = "accNo=" + "'" + v.ToString()+ "'" ;


                DataTable dtable = s.SelctData(MainAcctable, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtaccno.Text = dtable.Rows[0]["accNO"].ToString();//1
                    txtaccname.Text = dtable.Rows[0]["accName"].ToString();//2
                    txtMaxBalance.Text = dtable.Rows[0]["accMaxBalance"].ToString();
                    txtCure.Text = dtable.Rows[0]["accCurrency"].ToString();
                    txtAccType.Text = dtable.Rows[0]["accType"].ToString();
                    acc_type.Text = dtable.Rows[0]["accType"].ToString();
                    cur.Text = dtable.Rows[0]["accCurrency"].ToString();
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

                    btnupdate.Visible = true;
                    btnactivate.Visible = true;
                    btndeactivaete.Visible = true;
                    btndelete.Visible = true;
                    btnadd.Visible = false;
                }
                else
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnclear.PerformClick();
                }
            }
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("سيتم تفعيل الحساب ؟ متأكد ؟  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtaccno.Text) || string.IsNullOrEmpty(txtaccname.Text))
                {
                    XtraMessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {
                    string accNo = txtaccno.Text;
                    string accName = txtaccname.Text;

                    int rest = ss.ActivateOrDeactivate(accNo, accName, 10);


                    if (rest > 0)
                    {

                        XtraMessageBox.Show("تم التفعيل", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                        db.UserLogTransactions(DataBase.Username.ToString(), " تفعيل حساب " + accNo.ToString() + " / " + accName.ToString(), DateTime.Now, Environment.MachineName);
                        btnclear.PerformClick();
                    }
                    else if (rest <= 0)
                    {
                        XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, 0, MessageBoxIcon.Error);

                    }
                    else
                        XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);

                }


            }

            else if (result == DialogResult.No)
            {
                XtraMessageBox.Show(Resources.CancelByUser, Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
                btnclear.PerformClick();
            }
        }

        private void btndeactivaete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("سيتم  الغاء تفعيل الحساب ؟ متأكد ؟  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtaccno.Text) || string.IsNullOrEmpty(txtaccname.Text))
                {
                    XtraMessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {
                    string accNo = txtaccno.Text;
                    string accName = txtaccname.Text;

                    int rest = ss.ActivateOrDeactivate(accNo, accName, 20);


                    if (rest > 0)
                    {

                        XtraMessageBox.Show("تم  الغاء التفعيل ولن يقبل هذا الحساب حركات", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                        db.UserLogTransactions(DataBase.Username.ToString(), " تجميد حساب " + accNo.ToString() + " / " + accName.ToString(), DateTime.Now, Environment.MachineName);
                        btnclear.PerformClick();
                    }
                    else if (rest <= 0)
                    {
                        XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, 0, MessageBoxIcon.Error);

                    }
                    else
                        XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);

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
            DialogResult result = XtraMessageBox.Show("سيتم تعديل الحساب ؟ متأكد ؟  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text) || s.isDigitsOnly(txtaccno.Text) == false || s.isDigitsOnly(txtMaxBalance.Text) == false) || string.IsNullOrEmpty(acc_type.Text) || string.IsNullOrEmpty(cur.Text))
                {

                    XtraMessageBox.Show(Resources.emptyFields + " / " + Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int accStatus = 1;
                    string accNo = txtaccno.Text.Trim();
                    string accName = txtaccname.Text.Trim();
                    string accType = acc_type.Text.Trim();
                    string accMaxBalance = txtMaxBalance.Text.Trim();
                    string accCurency = cur.Text.Trim();
                    int IsParent = 1;
                    string accParent = "MainAccount";
                    //التأكد من وجود حركات قبل الحذف وأنه ليس له أبناء
                    int rest = ss.UpdateAccount(accNo, accName, accType, accMaxBalance, accStatus, accCurency, IsParent, accParent);
                    

                    if (rest > 0)
                    {

                        XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                        db.UserLogTransactions(DataBase.Username.ToString(), " تعديل حساب " + accNo.ToString() + " / ", DateTime.Now, Environment.MachineName);
                        btnclear.PerformClick();
                    }
                   
                    else 
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("سيتم حذف الحساب ؟ متأكد ؟  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtaccno.Text))
                {
                    XtraMessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {
                    string accNo = txtaccno.Text;

                    //التأكد من وجود حركات قبل الحذف وأنه ليس له أبناء
                    int rest = ss.DeletAccount(accNo);


                    if (rest > 0)
                    {

                        XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                        db.UserLogTransactions(DataBase.Username.ToString(), " حذف حساب " + accNo.ToString() + " / " , DateTime.Now, Environment.MachineName);
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

        private void acc_Validated(object sender, EventArgs e)
        {

        }

        private void MyGrid_Click(object sender, EventArgs e)
        {
            string id = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "accNO") + "").ToString();


            
            string condition = "accNo=" + "'" + id.ToString() + "'";


                DataTable dtable = s.SelctData(MainAcctable, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtaccno.Text = dtable.Rows[0]["accNO"].ToString();//1
                    txtaccname.Text = dtable.Rows[0]["accName"].ToString();//2
                    txtMaxBalance.Text = dtable.Rows[0]["accMaxBalance"].ToString();
                    txtCure.Text = dtable.Rows[0]["accCurrency"].ToString();
                    txtAccType.Text = dtable.Rows[0]["accType"].ToString();
                    acc_type.Text = dtable.Rows[0]["accType"].ToString();
                    cur.Text = dtable.Rows[0]["accCurrency"].ToString();
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

                    btnupdate.Visible = true;
                    btnactivate.Visible = true;
                    btndeactivaete.Visible = true;
                    btndelete.Visible = true;
                    btnadd.Visible = false;
                }

            else
            {
                XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnclear.PerformClick();
            }

        }

        private void frmMainAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
    }

