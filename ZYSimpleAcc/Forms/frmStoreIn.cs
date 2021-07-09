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


        private void ResizeGrid()

        {
            this.StoreInDetailsGrid.RowHeadersWidth = 50;
            this.StoreInDetailsGrid.Columns[0].Width = 100;
            this.StoreInDetailsGrid.Columns[1].Width = 194;
            this.StoreInDetailsGrid.Columns[2].Width = 90;
            this.StoreInDetailsGrid.Columns[3].Width = 90;
            this.StoreInDetailsGrid.Columns[4].Width = 65;
            this.StoreInDetailsGrid.Columns[5].Width = 65;
            this.StoreInDetailsGrid.Columns[6].Width = 118;
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
            this.ResizeGrid();
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "الغاء";
            //btn.Text = "الغاء السطر";
            //btn.UseColumnTextForButtonValue = true;
            //StoreInDetailsGrid.Columns.Insert(0, btn); 


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

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            
            frmViewItems vi = new frmViewItems();
            vi.ShowDialog();
            txtItemID.Text = vi.ItemsGrid.CurrentRow.Cells[0].Value.ToString();
            txtItemName.Text = vi.ItemsGrid.CurrentRow.Cells[1].Value.ToString();
            txtTax.Text = vi.ItemsGrid.CurrentRow.Cells[5].Value.ToString();
            txtUnit.Text = vi.ItemsGrid.CurrentRow.Cells[6].Value.ToString();
            txtUnitPrice.Text = vi.ItemsGrid.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
