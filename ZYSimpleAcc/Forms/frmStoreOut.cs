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
    public partial class frmStoreOut : Form
    {
        public frmStoreOut()
        {
            InitializeComponent();
        }

        SystemSetup ss = new SystemSetup();
        Shared s = new Shared(); 
        string masterstoretable = "StoreTransMaster";
        string detailsstoretable = "StoreTransDetails";



        Transactions t = new Transactions();
        float Totalofout = 0;
        DataTable dt = new DataTable();
        public static int UnitEnteroutgValue = 0;


        void CalculateTotlaOfLine()
        {

            if (string.IsNullOrWhiteSpace(txtQty.Text))
            {
                XtraMessageBox.Show(Resources.qtyRequired, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                {
                    XtraMessageBox.Show(Resources.emptyPrice, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    float total = float.Parse(txtQty.Text) * float.Parse(txtUnitPrice.Text);
                    float tax = total * (float.Parse(txtTaxPercent.Text) / 100);
                    total = total + tax;
                    txtTotal.Text = total.ToString();
                    txtTaxValue.Text = tax.ToString();
                }


            }

        }



        void CalculateTotalOfout()
        {

            txtTotalout.Text = (from DataGridViewRow row in StoreoutDetailsGrid.Rows
                               where row.Cells[7].FormattedValue.ToString() != string.Empty
                               select Convert.ToDecimal(row.Cells[7].FormattedValue)).Sum().ToString();

        }

        void claerTextItems()
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtQty.Clear();
            txtTaxValue.Text = "0";
            txtTaxPercent.Text = "0";
            txtUnit.Clear();
            txtUnitPrice.Clear();
            txtTotal.Clear();


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("لعرض مواد صنف معين اختر الصنف واضغط على عرض", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            


            Totalofout = 0;
            DataTable dtable1 = s.SelctData(masterstoretable, 7 , " where TransType="+"'"+txttransType.Text+"'");//Customer

            int max1 = int.Parse(dtable1.Rows[0]["TransID"].ToString());


            if (max1 == 0)
            {
                txtTransID.Clear();
                txtTransID.Text = "1";


            }
            else
            {
                txtTransID.Text = (max1 + 1).ToString();
                txtLastNum.Text = max1.ToString();


            }
            datetransdate.DateTime = DateTime.Now;
            transnotes.Text = "سند إخراج ";
            cboStore.ResetText();
            txtstoreid.Clear();
          

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
            this.claerTextItems();
            simpleButton4.PerformClick();    
            this.ResizeGrid();
            UnitEnteroutgValue = 0;
            if (frmMain.outstate == 20)
            {
                btnsave.Visible = false;
                btnsaveandprint.Visible = true;
                btnupdate.Visible = true;
                btndelete.Visible = true;
                txtTransID.Clear();
                txtTransID.Enabled = true;
                btnView.Visible = true;
                txtLastNum.Enabled = false;
            }
            else
            {
                btnsave.Visible = true;
                btnsaveandprint.Visible = true;
                btnupdate.Visible = false;
                btndelete.Visible = false;
                txtTransID.Enabled = false;
                btnView.Visible = false;
                txtLastNum.Enabled = false;
            }

        }

        private void frmStoreOut_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTransID.Text) || s.isDigitsOnly(txtTransID.Text) == false || string.IsNullOrWhiteSpace(cboStore.Text.ToString()) || string.IsNullOrWhiteSpace(txtstoreid.Text) || s.isDigitsOnly(txtstoreid.Text) == false || string.IsNullOrWhiteSpace(transnotes.Text) || string.IsNullOrWhiteSpace(txtTotalout.Text))
            {
                XtraMessageBox.Show(Resources.InfoOfStoreinnotEntered, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int transid = int.Parse(txtTransID.Text);

                DateTime date = DateTime.Parse(datetransdate.EditValue.ToString());
                string notes = transnotes.Text;
                float total = float.Parse(txtTotalout.Text);

                int storeid = int.Parse(txtstoreid.Text);
                string transtype = txttransType.Text;

                if (StoreoutDetailsGrid.Rows.Count - 1 > 0)
                {

                    int rest = t.NewStoreTransMaster(transid, date, notes, total, storeid, transtype , 0 );

                    if (rest > 0)
                    {

                        // db.UserLogTransactions(DataBase.Username.ToString(), "   سند ادحال جديد" + CorVid.ToString() + " / " + Name.ToString(), DateTime.Now, Environment.MachineName);
                        //Enter data of Grid
                        for (int i = 0; i < StoreoutDetailsGrid.Rows.Count - 1; i++)
                        {
                            int id = int.Parse(txtTransID.Text);
                            int StoreID = int.Parse(txtstoreid.Text);
                            string ttype = txttransType.Text;
                            string itemid = StoreoutDetailsGrid.Rows[i].Cells[0].Value.ToString();
                            string itemname = StoreoutDetailsGrid.Rows[i].Cells[1].Value.ToString();
                            float qty = float.Parse(StoreoutDetailsGrid.Rows[i].Cells[4].Value.ToString());
                            float unitprice = float.Parse(StoreoutDetailsGrid.Rows[i].Cells[3].Value.ToString());
                            float taxperc = float.Parse(StoreoutDetailsGrid.Rows[i].Cells[5].Value.ToString());
                            float taxval = float.Parse(StoreoutDetailsGrid.Rows[i].Cells[6].Value.ToString());
                            string unitname = StoreoutDetailsGrid.Rows[i].Cells[2].Value.ToString();
                            float linevalue = float.Parse(StoreoutDetailsGrid.Rows[i].Cells[7].Value.ToString());





                            t.NewStoreTransDetails(id, StoreID, ttype, date, itemid, itemname, qty, unitprice, unitname, taxperc, taxval, linevalue);
                        }
                        XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    XtraMessageBox.Show(Resources.noDataEnterinGrid, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void ResizeGrid()
        {
            this.StoreoutDetailsGrid.RowHeadersWidth = 50;
            this.StoreoutDetailsGrid.Columns[0].Width = 100;
            this.StoreoutDetailsGrid.Columns[1].Width = 183;
            this.StoreoutDetailsGrid.Columns[2].Width = 90;
            this.StoreoutDetailsGrid.Columns[3].Width = 90;
            this.StoreoutDetailsGrid.Columns[4].Width = 65;
            this.StoreoutDetailsGrid.Columns[5].Width = 55;
            this.StoreoutDetailsGrid.Columns[6].Width = 65;
            this.StoreoutDetailsGrid.Columns[7].Width = 78;

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

            if (toggleSwitch1.IsOn)
            {
                UnitEnteroutgValue = 55;
            }
            if (toggleSwitch1.IsOn == false)
            {
                UnitEnteroutgValue = 0;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmViewItems vi = new frmViewItems();
            vi.ShowDialog();
            txtItemID.Text = vi.ItemsGrid.CurrentRow.Cells[0].Value.ToString();
            txtItemName.Text = vi.ItemsGrid.CurrentRow.Cells[1].Value.ToString();
            txtTaxPercent.Text = vi.ItemsGrid.CurrentRow.Cells[5].Value.ToString();
            txtUnit.Text = vi.ItemsGrid.CurrentRow.Cells[6].Value.ToString();
            txtUnitPrice.Text = vi.ItemsGrid.CurrentRow.Cells[7].Value.ToString();
            txtQty.Focus();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                StoreoutDetailsGrid.Rows.RemoveAt(StoreoutDetailsGrid.CurrentRow.Index);
                this.CalculateTotalOfout();
            }
            catch
            {
                XtraMessageBox.Show(Resources.norowstodelete, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                StoreoutDetailsGrid.Rows.Clear();
                this.CalculateTotalOfout();

            }
            catch
            {
                XtraMessageBox.Show(Resources.norowstodelete, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnaddnewrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemID.Text) || string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtQty.Text)
                || string.IsNullOrWhiteSpace(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtUnit.Text) || string.IsNullOrWhiteSpace(txtTotal.Text)
                || string.IsNullOrWhiteSpace(txtTaxValue.Text))

            {
                XtraMessageBox.Show(Resources.noDatatoEnterToGrid, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                for (int i = 0; i < StoreoutDetailsGrid.Rows.Count - 1; i++)
                {
                    if (StoreoutDetailsGrid.Rows[i].Cells[0].Value.ToString() == txtItemID.Text)
                    {
                        XtraMessageBox.Show(Resources.itemInEnteredGrid, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.claerTextItems();

                        return;
                    }

                }

                DataGridViewRow rowi = (DataGridViewRow)StoreoutDetailsGrid.Rows[0].Clone();

                rowi.Cells[0].Value = txtItemID.Text;
                rowi.Cells[1].Value = txtItemName.Text;
                rowi.Cells[2].Value = txtUnit.Text;
                rowi.Cells[3].Value = txtUnitPrice.Text;
                rowi.Cells[4].Value = txtQty.Text;
                rowi.Cells[5].Value = txtTaxPercent.Text;
                rowi.Cells[6].Value = txtTaxValue.Text;
                rowi.Cells[7].Value = txtTotal.Text;

                StoreoutDetailsGrid.Rows.Add(rowi);
                this.claerTextItems();
                simpleButton3.Focus();

             
                this.CalculateTotalOfout();


            }
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

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnsaveandprint_Click(object sender, EventArgs e)
        {
            btnsave.PerformClick();
            //print
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void txtUnitPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                XtraMessageBox.Show(Resources.emptyPrice, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            this.CalculateTotlaOfLine();
            btnaddnewrow.Focus();
        }

        private void StoreoutDetailsGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtItemID.Text = this.StoreoutDetailsGrid.CurrentRow.Cells[0].Value.ToString();
                txtItemName.Text = this.StoreoutDetailsGrid.CurrentRow.Cells[1].Value.ToString();
                txtUnit.Text = this.StoreoutDetailsGrid.CurrentRow.Cells[2].Value.ToString();
                txtUnitPrice.Text = this.StoreoutDetailsGrid.CurrentRow.Cells[3].Value.ToString();
                txtQty.Text = this.StoreoutDetailsGrid.CurrentRow.Cells[4].Value.ToString();
                txtTaxPercent.Text = this.StoreoutDetailsGrid.CurrentRow.Cells[5].Value.ToString();
                txtTaxValue.Text = this.StoreoutDetailsGrid.CurrentRow.Cells[6].Value.ToString();
                txtTotal.Text = this.StoreoutDetailsGrid.CurrentRow.Cells[7].Value.ToString();
                StoreoutDetailsGrid.Rows.RemoveAt(StoreoutDetailsGrid.CurrentRow.Index);
                this.CalculateTotalOfout();
                txtQty.Focus();
            }

            catch
            {
                return;
            }
        }

        private void StoreoutDetailsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTransID.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtTransID.Text);
                int rest = t.CancelStoreMasterTransaction(id);

                    if (rest > 0)
                    {
                        XtraMessageBox.Show(Resources.cancelled, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnclear.PerformClick();
                    }
                    else if (rest == -150)
                    {
                        XtraMessageBox.Show(Resources.AlreadyCancelled, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnclear.PerformClick();
                    }
                    else if (rest == -250)
                    {
                        XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

            }
        }

        private void txtTransID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void txtTransID_Leave(object sender, EventArgs e)
        {
            btnView.PerformClick();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTransID.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dtMaster = new DataTable();
                DataTable dtDetails = new DataTable();
                dtMaster = s.SelctData(masterstoretable, 0, "");
                dtDetails = s.SelctData(detailsstoretable, 0, "");
                int state = int.Parse(dtMaster.Rows[0]["IsCancelled"].ToString());

                if (state == 1)
                {
                    transnotes.Enabled = false;
                    transnotes.Text = "هذا السند ملغى سابقا";
                    XtraMessageBox.Show(Resources.AlreadyCancelled, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }

                if (state == 0)
                {

                }
            }
        }
    }
}
