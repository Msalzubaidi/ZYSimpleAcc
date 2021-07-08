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
    public partial class frmStoreIn : Form
    {
        public frmStoreIn()
        {
            InitializeComponent();
        }

        string masterstoretable = "StoreTransMaster";
        Shared s = new Shared();
        Transactions t = new Transactions();

        private void label37_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("لعرض مواد صنف معين اختر الصنف واضغط على عرض", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStoreIn_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            DataTable dtable1 = s.SelctData(masterstoretable, 7, "");

            int max1 = int.Parse(dtable1.Rows[0]["TransID"].ToString());


            if (max1 == 0)
            {
                txtTransID.Clear();
                txtTransID.Text = "1";


            }
            else
            {
                txtTransID.Text = (max1 + 1).ToString();
                txtTransID.Enabled = false;

            }
            datetransdate.DateTime = DateTime.Now; 
            txtTransnotes.Text = "سند إدخال ";
            cboStore.ResetText();
            cboCat.ResetText();
            txtstoreid.Clear();

            btnsave.Visible = true;
            btnupdate.Visible = false;
            btndelete.Visible = false;

            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;


            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd;
            SqlDataReader dr;

            string qry = "select * from Stores";

            cboStore.Items.Clear();
            con.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cboStore.Items.Add(dr.GetValue(1).ToString());

            }

            ///////////////

            SqlConnection con2 = new SqlConnection(connstring);
            SqlCommand cmd2;
            SqlDataReader dr2;

            string qry2 = "select * from Items";

            cboCat.Items.Clear();
            con2.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmd2 = new SqlCommand(qry2, con2);
            dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {

                cboCat.Items.Add(dr2.GetValue(3).ToString());

            }

            SqlConnection con23 = new SqlConnection(connstring);
            SqlCommand cmd23;
            SqlDataReader dr23;

            string qry23 = "select * from Items";

            cboitemsids.Items.Clear();
            cbonames.Items.Clear();
            con23.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmd23 = new SqlCommand(qry23, con23);
            dr23 = cmd23.ExecuteReader();

            while (dr23.Read())
            {

                cboitemsids.Items.Add(dr23.GetValue(0).ToString());
                cbonames.Items.Add(dr23.GetValue(1).ToString());

            }


         


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void cboStore_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboStore.Text))
            {
                // XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }

            else

            {

                string v = cboStore.Text.ToString();
                string condition = "StoreTitle=" + "'" + v.ToString() + "'";


                DataTable dtable = s.SelctData("Stores", 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtstoreid.Text = dtable.Rows[0]["StoreID"].ToString();//1
           
                }
                else
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTransID.Text) || s.isDigitsOnly(txtTransID.Text)==false || string.IsNullOrWhiteSpace(cboStore.Text.ToString()) || string.IsNullOrWhiteSpace(txtstoreid.Text) || s.isDigitsOnly(txtstoreid.Text)==false ||string.IsNullOrWhiteSpace(txtTransnotes.Text) || string.IsNullOrWhiteSpace(txtTotalIN.Text))
            {
                XtraMessageBox.Show(Resources.missingTextboxes, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int transid = int.Parse(txtTransID.Text);
          
                DateTime date = DateTime.Parse(datetransdate.EditValue.ToString());
                string notes = txtTransnotes.Text; 
                float total = float.Parse(txtTotalIN.Text);
                int rowsnum = int.Parse(txtrowsCount.Text);
                int storeid = int.Parse(txtstoreid.Text);
                string transtype = txtTranstype.Text;


                int rest = t.NewStoreTransMaster(transid , date , notes , total , rowsnum , storeid , transtype);

                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // db.UserLogTransactions(DataBase.Username.ToString(), "   سند ادحال جديد" + CorVid.ToString() + " / " + Name.ToString(), DateTime.Now, Environment.MachineName);
                    btnclear.PerformClick();
                }
             
                else if (rest == -150)
                {
                    XtraMessageBox.Show(Resources.Exist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void cboitemsids_TextChanged(object sender, EventArgs e)
        {
            string itemid = cboitemsids.Text.ToString();


            string condition = "ItemID=" + "'" + itemid.ToString() + "'";


            DataTable dtable = s.SelctData("Items", 1, condition);
            int x = dtable.Rows.Count;

            if (dtable != null && dtable.Rows.Count > 0)
            {

                txtItemID.Text = dtable.Rows[0]["ItemID"].ToString();
                cbonames.Text = dtable.Rows[0]["ItemName"].ToString();
                txtUnit.Text = dtable.Rows[0]["ItemMainUnitName"].ToString();
                txtUnitPrice.Text = dtable.Rows[0]["ItemBuyPriceMainUnit"].ToString();
                txtTax.Text = dtable.Rows[0]["ItemTaxPercentValue"].ToString();
                cbonames.Enabled = false; 

                
            }
            else
            {
                XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQty.Text))
                {
                XtraMessageBox.Show(Resources.qtyRequired, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
            }
            else
            {
                float total =float.Parse(txtQty.Text) * float.Parse(txtUnitPrice.Text);
                float tax = total * (float.Parse(txtTax.Text) / 100);
                total = total + tax; 
                txtTotal.Text = total.ToString();
                txtTax.Text = tax.ToString();

            }
        }
    }
}
