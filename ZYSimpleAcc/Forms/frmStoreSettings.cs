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

                int rest = ss.AddNewService(id, name, value, tax);
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

                int rest = ss.UpdateOrDeleteService(id, name, value, tax, 1);
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


            DataTable dtable = s.SelctData(servicetable, 1, condition);
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

            cbotaxitem.Items.Clear();
            contax.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmdtax = new SqlCommand(qrytax, contax);
            drtax = cmdtax.ExecuteReader();

            while (drtax.Read())
            {

                cbotaxitem.Items.Add(drtax.GetValue(1).ToString());

            }

            SqlConnection conunit = new SqlConnection(connstring);
            SqlCommand cmdunit;
            SqlDataReader drunit;

            string qryunit = "select* from Units";


            cboUnits.Items.Clear();
            conunit.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmdunit = new SqlCommand(qryunit, conunit);
            drunit = cmdunit.ExecuteReader();

            while (drunit.Read())
            {

                cboUnits.Items.Add(drunit.GetValue(1).ToString());

            }
            txtitemID.Enabled = true; 
            this.ClearTextBoxes();
            cbotaxitem.ResetText();
            cbostatus.ResetText();
            cboSupllier.ResetText();
            cboCat.ResetText();
            cboUnits.ResetText();
            btnadditem.Visible = true;
            btndeleteitem.Visible = false;
            btnupdateitem.Visible = false;
            //////////////////////////////////////

            DataTable dtable = s.SelctData("Items", 0, "");
            int x = dtable.Rows.Count;
            GridItems.RefreshDataSource();
            GridItems.DataSource = dtable;



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

                string v = cboSupllier.Text.ToString();
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

                    txtsupllierid.Clear();
                }
            }
        }

        private void cboCat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboCat.Text))
            {
                // XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else

            {

                string v = cboCat.Text.ToString();
                string condition = "CatTitle=" + "'" + v.ToString() + "'";


                DataTable dtable = s.SelctData(cattable, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtCatItemid.Text = dtable.Rows[0]["CatID"].ToString();//1
                    DataTable dtable1 = s.SelctData("Items", 6, dtable.Rows[0]["CatID"].ToString());//Customer

                    int max1 = int.Parse(dtable1.Rows[0]["ItemID"].ToString());

                  
                        if (max1 == 0)
                        {
                            txtitemID.Clear();
                            txtitemID.Enabled = true;
                          

                        }
                        else
                        {
                            txtitemID.Text = (max1 + 1).ToString();
                            txtitemID.Enabled = false;
                           
                        }
                 



                }
                else
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtCatItemid.Clear();
                }


            }
        }

        private void cboUnits_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboUnits.Text))
            {
                // XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else

            {

                string v = cboUnits.Text.ToString();
                string condition = "MainUnitName=" + "'" + v.ToString() + "'";


                DataTable dtable = s.SelctData(unittable, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtMainUnititemName.Text = dtable.Rows[0]["MainUnitName"].ToString();//1
                    txtMainUnititemequal.Text = dtable.Rows[0]["MainUnitValue"].ToString();//1
                    txtSubUnititemName.Text = dtable.Rows[0]["SubUnitName"].ToString();//1
                    txtSubUnititemequal.Text = dtable.Rows[0]["SubUnitValue"].ToString();//1
                    txtitemUnitId.Text = dtable.Rows[0]["UnitID"].ToString();//1

                }
                else
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    txtMainUnitName.Clear();
                    txtMainUnitequal.Clear();
                    txtSubUnitName.Clear();
                    txtSubUnitequal.Clear();
                    txtitemUnitId.Clear();
                }
            }
        }

        private void cboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuyPriceMain_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuyPriceMain.Text) || string.IsNullOrWhiteSpace(txtSubUnititemequal.Text))
            {

                XtraMessageBox.Show(Resources.emptyPrice, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuyPriceMain.Text = "0";
                txtBuyPriceUnit.Text = "0";

            }
            else
            {
                double mainprice = double.Parse(txtBuyPriceMain.Text);
                double unitprice = mainprice / int.Parse(txtSubUnititemequal.Text);
                txtBuyPriceUnit.Text = unitprice.ToString();
            }
        }

        private void txtSalePriceMian_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalePriceMian.Text) || string.IsNullOrWhiteSpace(txtSubUnititemequal.Text))
            {

                XtraMessageBox.Show(Resources.emptyPrice, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalePriceMian.Text = "0";
                txtSalePriceUnit.Text = "0";

            }
            else
            {
                double mainprice = double.Parse(txtSalePriceMian.Text);
                double unitprice = mainprice / int.Parse(txtSubUnititemequal.Text);
                txtSalePriceUnit.Text = unitprice.ToString();
            }
        }

        private void txtitemID_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtitemID.Text))
            {

            }
            else
            {
                string x = txtitemID.Text.ToString();
                txtBarcCode.Text = x; 
            }
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            if ( 1 > 2  )
               
            {
                XtraMessageBox.Show(Resources.missingTextboxes ,  Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string itemID = txtitemID.Text;
                string itemName = txtItemName.Text;
                int ItemCatID = int.Parse(txtCatItemid.Text);
                string ItemCategoryName = cboCat.Text.ToString() ;
                int ItemSupplierID = int.Parse(txtsupllierid.Text);
                string ItemSupplierName = cboSupllier.Text.ToString();
                string ItemBarCode = txtBarcCode.Text;
                float ItemBuyPriceMainUnit = float.Parse(txtBuyPriceMain.Text);
                float ItemBuyPriceSubUnit = float.Parse(txtBuyPriceUnit.Text);
                float ItemSellPriceMainUnit = float.Parse(txtSalePriceMian.Text);
                float ItemSellPriceSubUnit = float.Parse(txtSalePriceUnit.Text);
                float ItemTaxPercentValue = float.Parse(cbotaxitem.Text.ToString());
                int ItemStatus = 1;
                if (cbostatus.Text.ToString() == "فعالة")
                    ItemStatus = 1;
                else if (cbostatus.Text.ToString() == "غير فعالة")
                    ItemStatus = 0;
             
                int ItemUnitID = int.Parse(txtitemUnitId.Text);
                int ItemMainUnitValue = int.Parse(txtMainUnititemequal.Text);
                string ItemMainUnitName = txtMainUnititemName.Text;
                int ItemSubUnitValue = int.Parse(txtSubUnititemequal.Text);
                string ItemSubUnitName = txtSubUnititemName.Text;

                int rest = ss.AddNewItem(itemID , itemName , ItemCatID, ItemCategoryName , ItemSupplierID , ItemSupplierName , 
                               ItemBarCode , ItemBuyPriceMainUnit , ItemBuyPriceSubUnit , ItemSellPriceMainUnit , ItemSellPriceSubUnit , ItemTaxPercentValue
                                , ItemStatus , ItemUnitID , ItemMainUnitValue , ItemMainUnitName , ItemSubUnitValue , ItemSubUnitName);
                if (rest > 0 )
                {
                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // db.UserLogTransactions(DataBase.Username.ToString(), " اضافة  مادة جديدة " + CorVid.ToString() + " / " + Name.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearitem.PerformClick();
                }
                else if (rest == -150 )
                {
                    XtraMessageBox.Show(Resources.Exist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtitemID.Text))
            {

            }
            else
            {
                string x = txtitemID.Text.ToString();
                txtBarcCode.Text = x;
            }
        }

        private void btndeleteitem_Click(object sender, EventArgs e)
        {
            //check invoices //transaction 
            if (1 > 2)

            {
                XtraMessageBox.Show(Resources.missingTextboxes, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string itemID = txtitemID.Text;
                string itemName = txtItemName.Text;
                int ItemCatID = int.Parse(txtCatItemid.Text);
                string ItemCategoryName = cboCat.Text.ToString();
                int ItemSupplierID = int.Parse(txtsupllierid.Text);
                string ItemSupplierName = cboSupllier.Text.ToString();
                string ItemBarCode = txtBarcCode.Text;
                float ItemBuyPriceMainUnit = float.Parse(txtBuyPriceMain.Text);
                float ItemBuyPriceSubUnit = float.Parse(txtBuyPriceUnit.Text);
                float ItemSellPriceMainUnit = float.Parse(txtSalePriceMian.Text);
                float ItemSellPriceSubUnit = float.Parse(txtSalePriceUnit.Text);
                float ItemTaxPercentValue = float.Parse(cbotaxitem.Text.ToString());
                int ItemStatus = 1;
                if (cbostatus.Text.ToString() == "فعالة")
                    ItemStatus = 1;
                else if (cbostatus.Text.ToString() == "غير فعالة")
                    ItemStatus = 0;

                int ItemUnitID = int.Parse(txtitemUnitId.Text);
                int ItemMainUnitValue = int.Parse(txtMainUnititemequal.Text);
                string ItemMainUnitName = txtMainUnititemName.Text;
                int ItemSubUnitValue = int.Parse(txtSubUnititemequal.Text);
                string ItemSubUnitName = txtSubUnititemName.Text;

                int rest = ss.UpdateOrDeleteItem(itemID, itemName, ItemCatID, ItemCategoryName, ItemSupplierID, ItemSupplierName,
                               ItemBarCode, ItemBuyPriceMainUnit, ItemBuyPriceSubUnit, ItemSellPriceMainUnit, ItemSellPriceSubUnit, ItemTaxPercentValue
                                , ItemStatus, ItemUnitID, ItemMainUnitValue, ItemMainUnitName, ItemSubUnitValue, ItemSubUnitName , 1 );
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // db.UserLogTransactions(DataBase.Username.ToString(), " حذف  مادة  " + CorVid.ToString() + " / " + Name.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearitem.PerformClick();
                }
              
                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnupdateitem_Click(object sender, EventArgs e)
        {
            //check invoices //transaction 
            if (1 > 2)

            {
                XtraMessageBox.Show(Resources.missingTextboxes, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string itemID = txtitemID.Text;
                string itemName = txtItemName.Text;
                int ItemCatID = int.Parse(txtCatItemid.Text);
                string ItemCategoryName = cboCat.Text.ToString();
                int ItemSupplierID = int.Parse(txtsupllierid.Text);
                string ItemSupplierName = cboSupllier.Text.ToString();
                string ItemBarCode = txtBarcCode.Text;
                float ItemBuyPriceMainUnit = float.Parse(txtBuyPriceMain.Text);
                float ItemBuyPriceSubUnit = float.Parse(txtBuyPriceUnit.Text);
                float ItemSellPriceMainUnit = float.Parse(txtSalePriceMian.Text);
                float ItemSellPriceSubUnit = float.Parse(txtSalePriceUnit.Text);
                float ItemTaxPercentValue = float.Parse(cbotaxitem.Text.ToString());
                int ItemStatus = 1;
                if (cbostatus.Text.ToString() == "فعالة")
                    ItemStatus = 1;
                else if (cbostatus.Text.ToString() == "غير فعالة")
                    ItemStatus = 0;

                int ItemUnitID = int.Parse(txtitemUnitId.Text);
                int ItemMainUnitValue = int.Parse(txtMainUnititemequal.Text);
                string ItemMainUnitName = txtMainUnititemName.Text;
                int ItemSubUnitValue = int.Parse(txtSubUnititemequal.Text);
                string ItemSubUnitName = txtSubUnititemName.Text;

                int rest = ss.UpdateOrDeleteItem(itemID, itemName, ItemCatID, ItemCategoryName, ItemSupplierID, ItemSupplierName,
                               ItemBarCode, ItemBuyPriceMainUnit, ItemBuyPriceSubUnit, ItemSellPriceMainUnit, ItemSellPriceSubUnit, ItemTaxPercentValue
                                , ItemStatus, ItemUnitID, ItemMainUnitValue, ItemMainUnitName, ItemSubUnitValue, ItemSubUnitName  , 0 );
                if (rest > 0)
                {
                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // db.UserLogTransactions(DataBase.Username.ToString(), " تعديل  مادة  " + CorVid.ToString() + " / " + Name.ToString(), DateTime.Now, Environment.MachineName);
                    btnclearitem.PerformClick();
                }
             
                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btncloseitem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridItems_Click(object sender, EventArgs e)
        {
            string id = (gridView6.GetRowCellValue(gridView6.FocusedRowHandle, "ItemID") + "").ToString();


            string condition = "ItemID=" + "'" + id.ToString() + "'";


            DataTable dtable = s.SelctData("Items", 1, condition);
            int x = dtable.Rows.Count;

            if (dtable != null && dtable.Rows.Count > 0)
            {

                txtitemID.Text = dtable.Rows[0]["ItemID"].ToString();
                txtItemName.Text = dtable.Rows[0]["ItemName"].ToString();
                txtCatItemid.Text = dtable.Rows[0]["ItemCategoryID"].ToString();
                cboCat.Text = dtable.Rows[0]["ItemCategoryName"].ToString();
                txtsupllierid.Text = dtable.Rows[0]["ItemSupplierID"].ToString();
                cboSupllier.Text = dtable.Rows[0]["ItemSupplierName"].ToString();
                txtBarcCode.Text = dtable.Rows[0]["ItemBarCode"].ToString();
                txtBuyPriceMain.Text = dtable.Rows[0]["ItemBuyPriceMainUnit"].ToString();
                txtBuyPriceUnit.Text = dtable.Rows[0]["ItemBuyPriceSubUnit"].ToString();
                txtSalePriceMian.Text = dtable.Rows[0]["ItemSellPriceMainUnit"].ToString();
                txtSalePriceUnit.Text = dtable.Rows[0]["ItemSellPriceSubUnit"].ToString();
                cboUnits.Text = dtable.Rows[0]["ItemMainUnitName"].ToString();
                cbotaxitem.Text = dtable.Rows[0]["ItemTaxPercentValue"].ToString();

                int status = int.Parse(dtable.Rows[0]["ItemStatus"].ToString());
                if (status == 0)
                    cbostatus.Text = "غير فعالة";
                if (status == 1)
                    cbostatus.Text = "فعالة";

                txtitemUnitId.Text = dtable.Rows[0]["ItemUnitID"].ToString();
                txtMainUnititemequal.Text = dtable.Rows[0]["ItemMainUnitValue"].ToString();
                txtMainUnititemName.Text = dtable.Rows[0]["ItemMainUnitName"].ToString();
                txtSubUnititemequal.Text = dtable.Rows[0]["ItemSubUnitValue"].ToString();
                txtSubUnititemName.Text = dtable.Rows[0]["ItemSubUnitName"].ToString();
                btnadditem.Visible = false;
                btndeleteitem.Visible = false;
                btnupdateitem.Visible = true;


            }
            else
            {
                XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCatItemid.Text))
            {
                DataTable dtable = s.SelctData("Items", 0, "");
                int x = dtable.Rows.Count;
                GridItems.RefreshDataSource();
                GridItems.DataSource = dtable;
            }
            else
            {
                DataTable dtable = s.SelctData("Items", 1, " ItemCategoryID=" +  int.Parse(txtCatItemid.Text));
                int x = dtable.Rows.Count;
                GridItems.RefreshDataSource();
                GridItems.DataSource = dtable;
            }
        
        }
    }
}



