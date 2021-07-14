using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmAccounts : Form
    {
        public frmAccounts()
        {
            InitializeComponent();
        }

        Shared s = new Shared();
        SystemSetup ss = new SystemSetup();
        DataBase db = new DataBase();
        string table = "SpecializedAcc";

        int Confirmed = 0; 


        private void txt_comname_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            string condition = "";

            DataTable dtable = s.SelctData(table, 0, condition);


            txtSalesAcc.Text = dtable.Rows[0]["SalesAcc"].ToString();
            txtRetSalesAcc.Text = dtable.Rows[0]["RetSalesAcc"].ToString();
            txtBuyAcc.Text = dtable.Rows[0]["BuyAcc"].ToString();
            txtRetBuyAcc.Text = dtable.Rows[0]["RetBuyAcc"].ToString();
            txtExpAcc.Text = dtable.Rows[0]["ExpAcc"].ToString();
            txtSalaries.Text = dtable.Rows[0]["SalariesAcc"].ToString();
            txtTaxAcc.Text = dtable.Rows[0]["TaxAcc"].ToString();
            int saved = int.Parse(dtable.Rows[0]["Saved"].ToString());
            txtVendors.Text = dtable.Rows[0]["VendAcc"].ToString();
            txtCustomers.Text = dtable.Rows[0]["CustAcc"].ToString();
            if (saved > 0 )
            {
                txtSaved.Text = "نعم";
                simpleButton1.Enabled = false;
                txtBuyAcc.Enabled = false;
                txtRetBuyAcc.Enabled = false;
                txtSalesAcc.Enabled = false;
                txtRetSalesAcc.Enabled = false;
                txtTaxAcc.Enabled = false;
                txtExpAcc.Enabled = false;
                txtSalaries.Enabled = false;
                checkBox1.Checked = true; 
                checkBox1.Enabled = false; 
                txtVendors.Enabled = false;
                txtCustomers.Enabled = false;
            }
            else 
            {
                txtSaved.Text = "لا";
                simpleButton1.Enabled = true;
                txtBuyAcc.Enabled = true;
                txtRetBuyAcc.Enabled = true;
                txtSalesAcc.Enabled = true;
                txtRetSalesAcc.Enabled = true;
                txtTaxAcc.Enabled = true;
                txtExpAcc.Enabled = true;
                txtSalaries.Enabled = true;
                checkBox1.Checked = false;
                checkBox1.Enabled = true;
                txtVendors.Enabled = true;
                txtCustomers.Enabled = true;
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {

               XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string sales = txtSalesAcc.Text;
                string rsales = txtRetSalesAcc.Text;
                string buy = txtBuyAcc.Text;
                string rbuy = txtRetBuyAcc.Text;
                string tax = txtTaxAcc.Text;
                string exp = txtExpAcc.Text;
                string sal = txtSalaries.Text;
                string Cust = txtCustomers.Text;
                string Vend = txtVendors.Text;

                int result = db.UpdateSpecAccounts(sales, rsales , buy , rbuy , tax , sal , exp , Confirmed , Cust , Vend );
                if (result > 0)
                {

                   XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    this.Close();
                }
                else
                {
                   XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Confirmed = 1;
            }
        
        }

        private void frmAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtBuyAcc_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtBuyAcc.Text);
             if(rest > 0 )
            {
               
            }
             if(rest <= 0 )
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuyAcc.Text = "0";
            }
        }

        private void txtSalesAcc_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtSalesAcc.Text);
            if (rest > 0)
            {
               
            }
            if (rest <= 0)
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuyAcc.Text = "0";
            }
        }

        private void txtRetBuyAcc_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtRetSalesAcc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRetBuyAcc_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtRetBuyAcc.Text);
            if (rest > 0)
            {

            }
            if (rest <= 0)
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRetBuyAcc.Text = "0";
            }
        }

        private void txtRetSalesAcc_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtRetSalesAcc.Text);
            if (rest > 0)
            {

            }
            if (rest <= 0)
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRetSalesAcc.Text = "0";
            }
        }

        private void txtSalaries_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtSalaries.Text);
            if (rest > 0)
            {

            }
            if (rest <= 0)
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalaries.Text = "0";
            }
        }

        private void txtTaxAcc_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtTaxAcc.Text);
            if (rest > 0)
            {

            }
            if (rest <= 0)
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaxAcc.Text = "0";
            }
        }

        private void txtCustomers_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtCustomers.Text);
            if (rest > 0)
            {

            }
            if (rest <= 0)
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomers.Text = "0";
            }
        }

        private void txtExpAcc_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtExpAcc.Text);
            if (rest > 0)
            {

            }
            if (rest <= 0)
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExpAcc.Text = "0";
            }
        }

        private void txtVendors_Leave(object sender, EventArgs e)
        {
            int rest = ss.checkexistandnotparent(txtVendors.Text);
            if (rest > 0)
            {

            }
            if (rest <= 0)
            {
               XtraMessageBox.Show("الحساب غير موجود في قائمة الحسابات أو أنه متفرع", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVendors.Text = "0";
            }
        }
    }
}
