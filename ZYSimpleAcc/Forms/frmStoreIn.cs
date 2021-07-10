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
        string detailsstoretable = "StoreTransDetails";
        Shared s = new Shared();
        Transactions t = new Transactions();
        float TotalofIN = 0;
        DataTable dt = new DataTable();
        public static int UnitEnteringValue = 0;  


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



        void CalculateTotalOfin()
        {

            txtTotalIN.Text = (from DataGridViewRow row in StoreInDetailsGrid.Rows
                               where row.Cells[7].FormattedValue.ToString() != string.Empty
                               select Convert.ToDecimal(row.Cells[7].FormattedValue)).Sum().ToString();

        }
        private void ResizeGrid()
        {
            this.StoreInDetailsGrid.RowHeadersWidth = 50;
            this.StoreInDetailsGrid.Columns[0].Width = 100;
            this.StoreInDetailsGrid.Columns[1].Width = 183;
            this.StoreInDetailsGrid.Columns[2].Width = 90;
            this.StoreInDetailsGrid.Columns[3].Width = 90;
            this.StoreInDetailsGrid.Columns[4].Width = 65;
            this.StoreInDetailsGrid.Columns[5].Width = 55;
            this.StoreInDetailsGrid.Columns[6].Width = 65;
            this.StoreInDetailsGrid.Columns[7].Width = 75;

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




        private void label37_Click(object sender, EventArgs e)
        {
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
           
           
            
           
            TotalofIN = 0;
            DataTable dtable1 = s.SelctData(masterstoretable, 7, "");
            int max1 = int.Parse(dtable1.Rows[0]["TransID"].ToString());
            if (max1 == 0)
            {
                txtTransID.Clear();
                txtTransID.Text = "1";
            }
            else if(max1 > 0)
            {
                txtTransID.Clear();
                txtTransID.Text = (max1 + 1).ToString();
                txtLastNum.Text = max1.ToString();
            



            }
            datetransdate.DateTime = DateTime.Now;
            txtTransnotes.Text = "سند إدخال ";
            cboStore.ResetText();
            txtstoreid.Clear();
      



            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd;
            SqlDataReader dr;
            string qry = "select * from Stores";
            cboStore.Items.Clear();
            con.Open();
            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cboStore.Items.Add(dr.GetValue(1).ToString());

            }
            this.ResizeGrid();
            this.claerTextItems();
            simpleButton3.PerformClick();
            UnitEnteringValue = 0;

            if (frmMain.instate == 10)
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
            txtLastNum.Enabled = false;
        }


    

       
        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace( txtItemID.Text) || string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtQty.Text)
                || string.IsNullOrWhiteSpace(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtUnit.Text) || string.IsNullOrWhiteSpace(txtTotal.Text)
                || string.IsNullOrWhiteSpace(txtTaxValue.Text))

            {
                XtraMessageBox.Show(Resources.noDatatoEnterToGrid, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            else
            {
               
            for(int i = 0; i < StoreInDetailsGrid.Rows.Count - 1; i++ )
            {
                if (StoreInDetailsGrid.Rows[i].Cells[0].Value.ToString() == txtItemID.Text)
                {
                    XtraMessageBox.Show(Resources.itemInEnteredGrid, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.claerTextItems();
                       
                        return;
                    }
             
            }

                DataGridViewRow rowi = (DataGridViewRow)StoreInDetailsGrid.Rows[0].Clone();
             
                rowi.Cells[0].Value = txtItemID.Text;
                rowi.Cells[1].Value = txtItemName.Text;
                rowi.Cells[2].Value = txtUnit.Text;
                rowi.Cells[3].Value = txtUnitPrice.Text;
                rowi.Cells[4].Value = txtQty.Text;
                rowi.Cells[5].Value = txtTaxPercent.Text;
                rowi.Cells[6].Value = txtTaxValue.Text;
                rowi.Cells[7].Value = txtTotal.Text;

                StoreInDetailsGrid.Rows.Add(rowi);
                this.claerTextItems();
                simpleButton2.Focus();

             
                 this.CalculateTotalOfin();
          
         
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                StoreInDetailsGrid.Rows.RemoveAt(StoreInDetailsGrid.CurrentRow.Index);
                this.CalculateTotalOfin();
            }
            catch
            {
                XtraMessageBox.Show(Resources.norowstodelete, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTransID.Text) || s.isDigitsOnly(txtTransID.Text)==false || string.IsNullOrWhiteSpace(cboStore.Text.ToString()) || string.IsNullOrWhiteSpace(txtstoreid.Text) || s.isDigitsOnly(txtstoreid.Text)==false ||string.IsNullOrWhiteSpace(txtTransnotes.Text) || string.IsNullOrWhiteSpace(txtTotalIN.Text))
            {
                XtraMessageBox.Show(Resources.InfoOfStoreinnotEntered, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int transid = int.Parse(txtTransID.Text);
          
                DateTime date = DateTime.Parse(datetransdate.EditValue.ToString());
                string notes = txtTransnotes.Text; 
                float total = float.Parse(txtTotalIN.Text);
             
                int storeid = int.Parse(txtstoreid.Text);
                string transtype = txtTranstype.Text;

                if(StoreInDetailsGrid.Rows.Count - 1 > 0)
                {

                    int rest = t.NewStoreTransMaster(transid, date, notes, total, storeid, transtype , 0);

                    if (rest > 0)
                    {
                        
                        // db.UserLogTransactions(DataBase.Username.ToString(), "   سند ادحال جديد" + CorVid.ToString() + " / " + Name.ToString(), DateTime.Now, Environment.MachineName);
                        //Enter data of Grid
                        for(int i = 0; i < StoreInDetailsGrid.Rows.Count -1 ; i++ )
                        {
                            int id = int.Parse(txtTransID.Text);
                            int StoreID = int.Parse(txtstoreid.Text);
                            string ttype = txtTranstype.Text;
                            string itemid = StoreInDetailsGrid.Rows[i].Cells[0].Value.ToString();
                            string itemname = StoreInDetailsGrid.Rows[i].Cells[1].Value.ToString();
                            float qty =float.Parse( StoreInDetailsGrid.Rows[i].Cells[4].Value.ToString());
                            float unitprice = float.Parse( StoreInDetailsGrid.Rows[i].Cells[3].Value.ToString());
                            float taxperc = float.Parse(StoreInDetailsGrid.Rows[i].Cells[5].Value.ToString());
                            float taxval = float.Parse(StoreInDetailsGrid.Rows[i].Cells[6].Value.ToString());
                            string unitname = StoreInDetailsGrid.Rows[i].Cells[2].Value.ToString();
                            float linevalue = float.Parse(StoreInDetailsGrid.Rows[i].Cells[7].Value.ToString());





                            t.NewStoreTransDetails(id ,StoreID  , ttype  , date , itemid , itemname , qty , unitprice , unitname , taxperc , taxval , linevalue);
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

      


        private void txtQty_Leave(object sender, EventArgs e)
        {
            this.CalculateTotlaOfLine();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
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

        private void frmStoreIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void StoreInDetailsGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            { 
            txtItemID.Text = this.StoreInDetailsGrid.CurrentRow.Cells[0].Value.ToString();
            txtItemName.Text = this.StoreInDetailsGrid.CurrentRow.Cells[1].Value.ToString();
            txtUnit.Text = this.StoreInDetailsGrid.CurrentRow.Cells[2].Value.ToString();
            txtUnitPrice.Text = this.StoreInDetailsGrid.CurrentRow.Cells[3].Value.ToString();
            txtQty.Text = this.StoreInDetailsGrid.CurrentRow.Cells[4].Value.ToString();
            txtTaxPercent.Text = this.StoreInDetailsGrid.CurrentRow.Cells[5].Value.ToString();
                txtTaxValue.Text = this.StoreInDetailsGrid.CurrentRow.Cells[6].Value.ToString();
                txtTotal.Text = this.StoreInDetailsGrid.CurrentRow.Cells[7].Value.ToString();
            StoreInDetailsGrid.Rows.RemoveAt(StoreInDetailsGrid.CurrentRow.Index);
             this.CalculateTotalOfin();
             txtQty.Focus();
            }

            catch
            {
                return; 
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8 && (e.KeyChar != '.'))
            {
                e.Handled = true; 
            }
            else
            {

            }
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

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnsaveandprint_Click(object sender, EventArgs e)
        {
            btnsave.PerformClick();
            //print

        }

        private void simpleButton3_Click_2(object sender, EventArgs e)
        {
            try
            {
                StoreInDetailsGrid.Rows.Clear();
                this.CalculateTotalOfin();

            }
            catch
            {
                XtraMessageBox.Show(Resources.norowstodelete, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkmainunit_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radmainunit_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chksubunit_CheckedChanged(object sender, EventArgs e)
        {
     
        }

        private void radsubnunit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
           
        }

        private void toggleSwitch1_Toggled_1(object sender, EventArgs e)
        {
            if(toggleSwitch1.IsOn)
            {
                UnitEnteringValue = 55; 
            }
            if (toggleSwitch1.IsOn==false)
            {
                UnitEnteringValue = 0;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTransID.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtTransID.Text);
                int rest = t.CancelStoreMasterTransaction(id); 

                if(rest > 0 )
                {
                    XtraMessageBox.Show(Resources.cancelled, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnclear.PerformClick();
                }
                else if (rest == -150 )
                {
                    XtraMessageBox.Show(Resources.AlreadyCancelled, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnclear.PerformClick();
                }
                else if(rest == -250 )
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
            if(string.IsNullOrWhiteSpace(txtTransID.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dtMaster = new DataTable();
                DataTable dtDetails = new DataTable();
                dtMaster = s.SelctData(masterstoretable , 0 , "" );
                dtDetails = s.SelctData(detailsstoretable , 0, "");
                int state = int.Parse(dtMaster.Rows[0]["IsCancelled"].ToString());

                if (state == 1 )
                {
                    txtTransnotes.Enabled = false;
                    txtTransnotes.Text = "هذا السند ملغى سابقا";
                   XtraMessageBox.Show(Resources.AlreadyCancelled, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                    
                }

                if (state == 0)
                {
                  
                }
            }

      
        }
    }
}
