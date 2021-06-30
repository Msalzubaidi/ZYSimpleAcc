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
    public partial class frmStoreSettings : Form
    {
        public frmStoreSettings()
        {
            InitializeComponent();
        }

        string stortable = "Stores";
        string cattable = "Categories";
        string unittable = "Units";
        string taxtable = "CatTax";
        string servicetable = "Services";
        string ventable = "CustomersAndVendors";
        Shared s = new Shared();
        SystemSetup ss = new SystemSetup();
        DataBase db = new DataBase();


        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtstoreid.Text) || string.IsNullOrEmpty(txtstorename.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtstoreid.Text);
                string title = txtstorename.Text;

                int rest = ss.AddNewStore(id, title);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " اضافة  مستودع جديد" + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    simpleButton2.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int y = s.FindMax(stortable, 0);
            txtstoreid.Text = y.ToString();
            txtstorename.Clear();
            txtstorename.Focus();
            simpleButton6.Visible = false;
            simpleButton7.Visible = false;
            simpleButton5.Visible = true;
            DataTable dtable = s.SelctData(stortable, 0, "");
            int x = dtable.Rows.Count;
            StoresGrid.RefreshDataSource();
            StoresGrid.DataSource = dtable;


        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtstoreid.Text) || string.IsNullOrEmpty(txtstorename.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtstoreid.Text);
                string title = txtstorename.Text;

                int rest = ss.UpdateOrDeleteStore(id, title, 0);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //db.UserLogTransactions(DataBase.Username.ToString(), " تعديل مستودع " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    simpleButton2.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtstoreid.Text) || string.IsNullOrEmpty(txtstorename.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtstoreid.Text);
                string title = txtstorename.Text;

                int rest = ss.UpdateOrDeleteStore(id, title, 1);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " حذف مستودع " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    simpleButton2.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void StoresGrid_Click(object sender, EventArgs e)
        {
            string id = (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "StoreID") + "").ToString();


            string condition = "StoreID=" + "'" + id.ToString() + "'";


            DataTable dtable = s.SelctData(stortable, 1, condition);
            int x = dtable.Rows.Count;

            if (dtable != null && dtable.Rows.Count > 0)
            {

                txtstoreid.Text = dtable.Rows[0]["StoreID"].ToString();
                txtstorename.Text = dtable.Rows[0]["StoreTitle"].ToString();


                simpleButton5.Visible = false;
                simpleButton7.Visible = true;
                simpleButton6.Visible = false;
            }
            else
            {
                XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton2.PerformClick();
            }
        }

        private void frmStoreSettings_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();
            btncatclear.PerformClick();
            btnclearunit.PerformClick();
            btncleartax.PerformClick();
            btnclearserv.PerformClick();
           
            btnclearitem.PerformClick();
           


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView2.Columns.Count <= 0)
            {
                XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (!StoresGrid.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                    return;
                }

                // Open the Preview window.
                StoresGrid.ShowPrintPreview();
            }
        }

        private void btnctaadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcatid.Text) || string.IsNullOrEmpty(txtcatname.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtcatid.Text);
                string title = txtcatname.Text;

                int rest = ss.AddNewCat(id, title);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " اضافة  صنف جديد" + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btncatclear.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void btncatupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcatid.Text) || string.IsNullOrEmpty(txtcatname.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtcatid.Text);
                string title = txtcatname.Text;

                int rest = ss.UpdateOrDeleteCat(id, title, 0);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //db.UserLogTransactions(DataBase.Username.ToString(), " تعديل صنف " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btncatclear.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btncatdelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcatid.Text) || string.IsNullOrEmpty(txtcatname.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtcatid.Text);
                string title = txtcatname.Text;

                int rest = ss.UpdateOrDeleteCat(id, title, 1);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //db.UserLogTransactions(DataBase.Username.ToString(), " حذف صنف " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btncatclear.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void CatGrid_Click(object sender, EventArgs e)
        {
            string id = (gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "CatID") + "").ToString();


            string condition = "CatID=" + "'" + id.ToString() + "'";


            DataTable dtable = s.SelctData(cattable, 1, condition);
            int x = dtable.Rows.Count;

            if (dtable != null && dtable.Rows.Count > 0)
            {

                txtcatid.Text = dtable.Rows[0]["CatID"].ToString();//1
                txtcatname.Text = dtable.Rows[0]["CatTitle"].ToString();//2


                btnctaadd.Visible = false;
                btncatupdate.Visible = true;
                btncatdelete.Visible = false;
            }
            else
            {
                XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton2.PerformClick();
            }
        }

        private void btncatclear_Click(object sender, EventArgs e)
        {

            int y = s.FindMax(cattable, 0);
            txtcatid.Text = y.ToString();
            txtcatname.Clear();
            txtcatname.Focus();

            DataTable dtable = s.SelctData(cattable, 0, "");
            int x = dtable.Rows.Count;
            CatGrid.RefreshDataSource();
            CatGrid.DataSource = dtable;


            btnctaadd.Visible = true;
            btncatupdate.Visible = false;
            btncatdelete.Visible = false;
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (gridView3.Columns.Count <= 0)
            {
                XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (!StoresGrid.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                    return;
                }

                // Open the Preview window.
                CatGrid.ShowPrintPreview();
            }
        }

        private void btncatclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddunit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitID.Text) || string.IsNullOrEmpty(txtMainUnitName.Text) || string.IsNullOrEmpty(txtSubUnitName.Text) || string.IsNullOrEmpty(txtMainUnitequal.Text) || string.IsNullOrEmpty(txtSubUnitequal.Text) || s.isDigitsOnly(txtSubUnitequal.Text) == false || s.isDigitsOnly(txtMainUnitequal.Text) == false)
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int unitid = int.Parse(txtUnitID.Text);
                string mainunitname = txtMainUnitName.Text;
                int mainunitvalue = int.Parse(txtMainUnitequal.Text);
                string subunitname = txtSubUnitName.Text;
                int subunitvalue = int.Parse(txtSubUnitequal.Text);


                int rest = ss.AddNewUnit(unitid, mainunitname, mainunitvalue, subunitname, subunitvalue);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " اضافة  وحدة جديدة" + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearunit.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void btnupdateunit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitID.Text) || string.IsNullOrEmpty(txtMainUnitName.Text) || string.IsNullOrEmpty(txtSubUnitName.Text) || string.IsNullOrEmpty(txtMainUnitequal.Text) || string.IsNullOrEmpty(txtSubUnitequal.Text) || s.isDigitsOnly(txtSubUnitequal.Text) == false || s.isDigitsOnly(txtMainUnitequal.Text) == false)
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int unitid = int.Parse(txtUnitID.Text);
                string mainunitname = txtMainUnitName.Text;
                int mainunitvalue = int.Parse(txtMainUnitequal.Text);
                string subunitname = txtSubUnitName.Text;
                int subunitvalue = int.Parse(txtSubUnitequal.Text);

                int rest = ss.UpdateOrDeleteUnit(unitid, mainunitname, mainunitvalue, subunitname, subunitvalue, 0);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //db.UserLogTransactions(DataBase.Username.ToString(), " تعديل وحدة قياس " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearunit.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btndeleteunit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitID.Text) || string.IsNullOrEmpty(txtMainUnitName.Text) || string.IsNullOrEmpty(txtSubUnitName.Text) || string.IsNullOrEmpty(txtMainUnitequal.Text) || string.IsNullOrEmpty(txtSubUnitequal.Text) || s.isDigitsOnly(txtSubUnitequal.Text) == false || s.isDigitsOnly(txtMainUnitequal.Text) == false)
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int unitid = int.Parse(txtUnitID.Text);
                string mainunitname = txtMainUnitName.Text;
                int mainunitvalue = int.Parse(txtMainUnitequal.Text);
                string subunitname = txtSubUnitName.Text;
                int subunitvalue = int.Parse(txtSubUnitequal.Text);

                int rest = ss.UpdateOrDeleteUnit(unitid, mainunitname, mainunitvalue, subunitname, subunitvalue, 1);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //db.UserLogTransactions(DataBase.Username.ToString(), " حذف وحدة قياس " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearunit.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnclearunit_Click(object sender, EventArgs e)
        {
            int y = s.FindMax(unittable, 0);
            txtUnitID.Text = y.ToString();
            txtMainUnitequal.Clear();
            txtMainUnitName.Clear();
            txtSubUnitName.Clear();
            txtSubUnitequal.Clear();
            txtMainUnitequal.Focus();
           
            DataTable dtable = s.SelctData(unittable, 0, "");
            int x = dtable.Rows.Count;
            UnitsGrid.RefreshDataSource();
            UnitsGrid.DataSource = dtable;


            btnaddunit.Visible = true;
            btnupdateunit.Visible = false;
            btndeleteunit.Visible = false;
        }

        private void btnprintunit_Click(object sender, EventArgs e)
        {
            if (gridView4.Columns.Count <= 0)
            {
                XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (!UnitsGrid.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                    return;
                }

                // Open the Preview window.
                UnitsGrid.ShowPrintPreview();
            }
        }

        private void UnitsGrid_Click(object sender, EventArgs e)
        {
            string id = (gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "UnitID") + "").ToString();


            string condition = "UnitID=" + "'" + id.ToString() + "'";


            DataTable dtable = s.SelctData(unittable, 1, condition);
            int x = dtable.Rows.Count;

            if (dtable != null && dtable.Rows.Count > 0)
            {

                txtUnitID.Text = dtable.Rows[0]["UnitID"].ToString();//1
                txtMainUnitName.Text = dtable.Rows[0]["MainUnitName"].ToString();//2
                txtMainUnitequal.Text = dtable.Rows[0]["MainUnitValue"].ToString();//3
                txtSubUnitName.Text = dtable.Rows[0]["SubUnitName"].ToString();//4
                txtSubUnitequal.Text = dtable.Rows[0]["SubUnitValue"].ToString();//5


                btnaddunit.Visible = false;
                btnupdateunit.Visible = true;
                btndeleteunit.Visible = false;
            }
            else
            {
                XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnclearunit.PerformClick();
            }
        }

        private void lblhelp_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("القيمة : 1 الوحدة الرئيسية : كرتونة = 12 الوحدة الفرعية : حبة ", "مساعدة " + " " + " مثال على تعريف وحدات القياس", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCloseunit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddtax_Click(object sender, EventArgs e)
        {

            //Type t2 = txtTaxCatId.Text.GetType();
            //Type t3 = txtTaxCatValue.Text.GetType();
            //((t2 == typeof(float) == false && t3 == typeof(int) == false))

            if (string.IsNullOrEmpty(txtTaxCatId.Text) || string.IsNullOrEmpty(txtTaxCatValue.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtTaxCatId.Text);
                float value = float.Parse(txtTaxCatValue.Text);
            

                int rest = ss.AddNewCatTax(id, value);
                    if (rest > 0)
                    {
                        XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //   db.UserLogTransactions(DataBase.Username.ToString(), " اضافة  فئة جديد" + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                        btncleartax.PerformClick();

                    }

                    else
                    {
                        XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                
            
            }
            
        }
    


        private void btndeleteatx_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaxCatId.Text) || string.IsNullOrEmpty(txtTaxCatValue.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtTaxCatId.Text);
                float value = float.Parse(txtTaxCatValue.Text);

                int rest = ss.UpdateOrDeleteCatTax(id, value, 1);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //db.UserLogTransactions(DataBase.Username.ToString(), " حذف فئة " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btncleartax.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnupdatetax_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaxCatId.Text) || string.IsNullOrEmpty(txtTaxCatValue.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtTaxCatId.Text);
                float value = float.Parse(txtTaxCatValue.Text);

                int rest = ss.UpdateOrDeleteCatTax(id, value, 0);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //db.UserLogTransactions(DataBase.Username.ToString(), " تعديل فئة " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btncleartax.PerformClick();


                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btncleartax_Click(object sender, EventArgs e)
        {
            int y = s.FindMax(taxtable, 0);
            txtTaxCatId.Text = y.ToString();
            txtTaxCatValue.Clear();
            txtTaxCatId.Focus();

            DataTable dtable = s.SelctData(taxtable, 0, "");
            int x = dtable.Rows.Count;
            GridTax.RefreshDataSource();
            GridTax.DataSource = dtable;


            btnaddtax.Visible = true;
            btnupdatetax.Visible = false;
            btndeleteatx.Visible = false;
        }

        private void txtprinttax_Click(object sender, EventArgs e)
        {
            if (gridView5.Columns.Count <= 0)
            {
                XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (!GridTax.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                    return;
                }

                // Open the Preview window.
                GridTax.ShowPrintPreview();
            }
        }

        private void txtclosetax_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridTax_Click(object sender, EventArgs e)
        {
            string id = (gridView5.GetRowCellValue(gridView5.FocusedRowHandle, "CatID") + "").ToString();


            string condition = "CatID=" + "'" + id.ToString() + "'";


            DataTable dtable = s.SelctData(taxtable, 1, condition);
            int x = dtable.Rows.Count;

            if (dtable != null && dtable.Rows.Count > 0)
            {

                txtTaxCatId.Text = dtable.Rows[0]["CatID"].ToString();//1
                txtTaxCatValue.Text = dtable.Rows[0]["CatTaxValuePercent"].ToString();//2


                btnaddtax.Visible = false;
                btnupdatetax.Visible = true;
                btndeleteatx.Visible = false;
            }
            else
            {
                XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btncleartax.PerformClick();
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserviceid.Text) || string.IsNullOrEmpty(txtservicevalue.Text) || string.IsNullOrEmpty(txtservicename.Text)  || string.IsNullOrEmpty(cboservicetax.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtserviceid.Text);
                string name = txtservicename.Text;
                float value = float.Parse(txtservicevalue.Text);
                float tax = float.Parse(cboservicetax.Text);

                int rest = ss.AddNewService(id , name , value , tax);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " اضافة  خدمة جديد" + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearserv.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void btnclearserv_Click(object sender, EventArgs e)
        {
            int y = s.FindMax(servicetable, 0);
            txtserviceid.Text = y.ToString();
            txtservicename.Clear();
            txtservicevalue.Clear();
            cboservicetax.ResetText();
            txtservicevalue.Focus();
            
            DataTable dtable = s.SelctData(servicetable, 0, "");
            int x = dtable.Rows.Count;
            GridServices.RefreshDataSource();
            GridServices.DataSource = dtable;
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;


            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd;
            SqlDataReader dr;

            string qry = "select* from CatTax";

            cboservicetax.Items.Clear();
            con.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cboservicetax.Items.Add(dr.GetValue(1).ToString());

            }

            btnaddserv.Visible = true;
            btnupdateserv.Visible = false;
            btndeleteserv.Visible = false;
        }

        private void btndeleteserv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserviceid.Text) || string.IsNullOrEmpty(txtservicevalue.Text) || string.IsNullOrEmpty(txtservicename.Text) || string.IsNullOrEmpty(cboservicetax.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtserviceid.Text);
                string name = txtservicename.Text;
                float value = float.Parse(txtservicevalue.Text);
                float tax = float.Parse(cboservicetax.Text);

                int rest = ss.UpdateOrDeleteService(id, name, value, tax , 1 );
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " حذف خدمة " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearserv.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void btnupdateserv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserviceid.Text) || string.IsNullOrEmpty(txtservicevalue.Text) || string.IsNullOrEmpty(txtservicename.Text) || string.IsNullOrEmpty(cboservicetax.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtserviceid.Text);
                string name = txtservicename.Text;
                float value = float.Parse(txtservicevalue.Text);
                float tax = float.Parse(cboservicetax.Text);

                int rest = ss.UpdateOrDeleteService(id, name, value, tax, 0);
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " تعديل خدمة " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearserv.PerformClick();

                }

                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void btnprintserv_Click(object sender, EventArgs e)
        {
            if (gridView1.Columns.Count <= 0)
            {
                XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (!GridServices.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", Resources.MessageTitle);
                    return;
                }

                // Open the Preview window.
                GridServices.ShowPrintPreview();
            }
        }

        private void btncloseserv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridServices_Click(object sender, EventArgs e)
        {
            string id = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ServiceID") + "").ToString();


            string condition = "ServiceID=" + "'" + id.ToString() + "'";


            DataTable dtable = s.SelctData( servicetable, 1, condition);
            int x = dtable.Rows.Count;

            if (dtable != null && dtable.Rows.Count > 0)
            {

                txtserviceid.Text = dtable.Rows[0]["ServiceID"].ToString();//1
                txtservicevalue.Text = dtable.Rows[0]["ServiceValue"].ToString();//2
                txtservicename.Text = dtable.Rows[0]["ServiceDesc"].ToString();//1
                cboservicetax.Text = dtable.Rows[0]["ServiceTaxPercentage"].ToString();//2



                btnaddserv.Visible = false;
                btnupdateserv.Visible = true;
                btndeleteserv.Visible = false;
            }
            else
            {
                XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnclearserv.PerformClick();
            }
        }

        private void btnclearitem_Click(object sender, EventArgs e)
        {

            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;


            SqlConnection consupllier = new SqlConnection(connstring);
            SqlCommand cmdsupllier;
            SqlDataReader drsupllier;

            string qrysupllier = "select * from CustomersAndVendors where CusOrVen='V'";

            cboSupllier.Items.Clear();
            consupllier.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmdsupllier = new SqlCommand(qrysupllier, consupllier);
            drsupllier = cmdsupllier.ExecuteReader();

            while (drsupllier.Read())
            {

                cboSupllier.Items.Add(drsupllier.GetValue(2).ToString());

            }

            

            SqlConnection concat = new SqlConnection(connstring);
            SqlCommand cmdcat;
            SqlDataReader drcat;

            string qrycat = "select * from Categories";

            cboCat.Items.Clear();
            concat.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmdcat = new SqlCommand(qrycat, concat);
            drcat = cmdcat.ExecuteReader();

            while (drcat.Read())
            {

                cboCat.Items.Add(drcat.GetValue(1).ToString());

            }

          


            SqlConnection contax = new SqlConnection(connstring);
            SqlCommand cmdtax;
            SqlDataReader drtax;

            string qrytax = "select* from CatTax";


            contax.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmdtax = new SqlCommand(qrytax, contax);
            drtax = cmdtax.ExecuteReader();

            while (drtax.Read())
            {

                cboatxitem.Items.Add(drtax.GetValue(1).ToString());

            }

            SqlConnection conunit = new SqlConnection(connstring);
            SqlCommand cmdunit;
            SqlDataReader drunit;

            string qryunit = "select* from Units";


            conunit.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmdunit  = new SqlCommand(qryunit, conunit);
            drunit = cmdunit.ExecuteReader();

            while (drunit.Read())
            {

                cboUnits.Items.Add(drunit.GetValue(1).ToString());

            }

            this.ClearTextBoxes();
            cboatxitem.ResetText();
            cbostatus.ResetText();
            cboSupllier.ResetText();
            cboCat.ResetText();
            cboUnits.ResetText();

        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void cboSupllier_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSupllier.Text))
            {
                // XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }

            else

            {

                string v = cboSupllier.ToString().Trim();
                string condition = "CusVenName=" + "'" + v.ToString() + "'";


                DataTable dtable = s.SelctData(ventable, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtsupllierid.Text = dtable.Rows[0]["CusVenID"].ToString();//1
                   
                }
                else
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                }
            }
        }
    }
}



