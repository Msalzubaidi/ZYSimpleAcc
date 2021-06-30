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
using System.Text.RegularExpressions;
using ZYSimpleAcc.Properties;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace ZYSimpleAcc.Forms
{
    public partial class frmCustomersAndVendors : Form
    {
        public frmCustomersAndVendors()
        {
            InitializeComponent();
        }

        Shared s = new Shared();
        DataBase db = new DataBase();
        SystemSetup ss = new SystemSetup();
        string table = "SpecializedAcc";
        static Regex validate_emailaddress = email_validation();
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }



        private void frmCustomersAndVendors_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();

            string condition = "";

            DataTable dtable = s.SelctData(table, 0, condition);
            string v = dtable.Rows[0]["VendAcc"].ToString();
            string c = dtable.Rows[0]["CustAcc"].ToString();

            if (toggleSwitch1.IsOn == false)
            {
                txtMainAcc.Text = c.ToString();
                label10.Text = "معـــلــومـات الــعـميــل";
                txtType.Text = "C";
                btnclear.PerformClick();

            }
            if (toggleSwitch1.IsOn == true)
            {
                txtMainAcc.Text = v.ToString();
                label10.Text = "معـــلــومـات الــمــورد";
                txtType.Text = "V";
                btnclear.PerformClick();
            }
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from Areas ";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(0).ToString();

                txtManfu.Properties.Items.Add(item1);

            }

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

        }





        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void active_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void notactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMainAcc.Text) || string.IsNullOrEmpty(txtcusvenid.Text) || string.IsNullOrEmpty(txtCusvenanme.Text) || string.IsNullOrEmpty(txtDetailedAddress.Text) || string.IsNullOrEmpty(txtMobile.Text)
               || string.IsNullOrEmpty(txtMail.Text)|| string.IsNullOrEmpty(txtTaxNo.Text) || string.IsNullOrEmpty(txtMaxBalance.Text) || string.IsNullOrEmpty(txtManfu.Text) || s.isDigitsOnly(txtcusvenid.Text) == false || s.isDigitsOnly(txtMobile.Text) == false || s.isDigitsOnly(txtMaxBalance.Text) == false)
            {

               XtraMessageBox.Show(Resources.emptyFields + " / " + Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string MianAcc = txtMainAcc.Text;
                string Name = txtCusvenanme.Text;
                string CorVid = txtcusvenid.Text;
                string Address = txtDetailedAddress.Text;
                string Mobile = txtMobile.Text;
                string Email = txtMail.Text;
                string MaxBal = txtMaxBalance.Text;
                string Type = txtType.Text;
                string tax = txtTaxNo.Text;


                int status = 1;
                if (active.Checked)
                {
                    status = 1;

                }
                if (notactive.Checked)
                {
                    status = 0;

                }

                int rslt = ss.AddCusOrVen(MianAcc, CorVid, Name, Address, Mobile, Email, MaxBal, status, Type , tax);
                if (rslt > 0)
                {
                   XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // db.UserLogTransactions(DataBase.Username.ToString(), " اضافة عميل / مورد جديد" + CorVid.ToString() + " / " + Name.ToString(), DateTime.Now, Environment.MachineName);
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

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtMail.Text = "Example@domain.com";

            DataTable dtable1 = s.SelctData("CustomersAndVendors", 2, " ");//Customer
            DataTable dtable2 = s.SelctData("CustomersAndVendors", 3, " ");//Vendors
            int max1 = int.Parse(dtable1.Rows[0]["CusVenID"].ToString());
            int max2 = int.Parse(dtable2.Rows[0]["CusVenID"].ToString());

            if (txtType.Text == "C")
                if (max1 == 0)
                {
                    txtcusvenid.Clear();
                    txtcusvenid.Enabled = true;
                    label19.Text = " لماذا رقم الحساب فارغا ؟";

                }
                else
                {
                    txtcusvenid.Text = (max1 + 1).ToString();
                    txtcusvenid.Enabled = false;
                    label19.Text = "تعني حقول مطلوبة *";
                }
            if (txtType.Text == "V")
                if (max2 == 0)
                {
                    txtcusvenid.Clear();
                    txtcusvenid.Enabled = true;
                    label19.Text = " لماذا رقم الحساب فارغا ؟";
                }
                else
                {
                    txtcusvenid.Text = (max2 +1).ToString();
                    txtcusvenid.Enabled = false;
                    label19.Text = "تعني حقول مطلوبة *";
                }

            txtCusvenanme.Clear();
            txtDetailedAddress.Clear();
            txtMobile.Clear();

            btnadd.Visible = true;
            btnupdate.Visible = false; 

            txtMaxBalance.Clear();
            txtTaxNo.Clear();
            active.Checked = true;
            DataTable dtable = new DataTable ();
            if (txtType.Text == "C")
                dtable = s.SelctData("CustomersAndVendors", 4, "");
            if (txtType.Text == "V")
                dtable = s.SelctData("CustomersAndVendors", 5, "");

          
            MyGrid.RefreshDataSource();
            MyGrid.DataSource = dtable;
        }
   
        private void simpleButton1_Click_1(object sender, EventArgs e)
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

        private void toggleSwitch1_Toggled_1(object sender, EventArgs e)
        {
            btnclear.PerformClick();

            string condition = "";

            DataTable dtable = s.SelctData(table, 0, condition);
            string v = dtable.Rows[0]["VendAcc"].ToString();
            string c = dtable.Rows[0]["CustAcc"].ToString();

            if (toggleSwitch1.IsOn == false)
            {
                txtMainAcc.Text = c.ToString();
                label10.Text = "معـــلــومـات الــعـميــل";
                txtType.Text = "C";
                btnclear.PerformClick();

            }
            if (toggleSwitch1.IsOn == true)
            {
                txtMainAcc.Text = v.ToString();
                label10.Text = "معـــلــومـات الــمــورد";
                txtType.Text = "V";
                btnclear.PerformClick();
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (validate_emailaddress.IsMatch(txtMail.Text) != true)
            {
               XtraMessageBox.Show("صيغة البريد الالكتروني خطأ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMail.Focus();
                //  return;
            }
            else
            {

            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (label19.Text == "لماذا رقم الحساب فارغا ؟")
                XtraMessageBox.Show("الرجاء بناء رقم الحساب الأول لبناء باقي الحسابات عليه", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                XtraMessageBox.Show("لا يمكن ترك الحقول المعلمة بإشارة * فارغا لغايات التقارير لاحقا", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void active_CheckedChanged_1(object sender, EventArgs e)
        {
            if (active.Checked)
                notactive.Checked = false;
            if (notactive.Checked)
                active.Checked = false;
        }

        private void notactive_CheckedChanged_1(object sender, EventArgs e)
        {
            if (active.Checked)
                notactive.Checked = false;
            if (notactive.Checked)
                active.Checked = false;
        }

        private void btnareas_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "العناوين")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAreas a = new frmAreas();
                a.Show();
            }
        }

        private void txtManfu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManfu.Text) || s.isDigitsOnly(txtManfu.Text) == false)
            {
                //XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnclear.PerformClick();
            }

            else

            {

                string v = txtManfu.EditValue.ToString();
                string condition = "AreaID=" + "'" + v.ToString() + "'";

             
                DataTable dtable = s.SelctData("Areas", 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtDetailedAddress.Text = dtable.Rows[0]["AreaTitle"].ToString();//1        
                    
                }
                else
                {
                   XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnclear.PerformClick();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
          
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult result =XtraMessageBox.Show(Resources.updatePrompt, Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                if (string.IsNullOrEmpty(txtMainAcc.Text) || string.IsNullOrEmpty(txtcusvenid.Text) || string.IsNullOrEmpty(txtCusvenanme.Text) || string.IsNullOrEmpty(txtDetailedAddress.Text) || string.IsNullOrEmpty(txtMobile.Text)
                 || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtTaxNo.Text) || string.IsNullOrEmpty(txtMaxBalance.Text) || s.isDigitsOnly(txtcusvenid.Text) == false || s.isDigitsOnly(txtMobile.Text) == false || s.isDigitsOnly(txtMaxBalance.Text) == false)
                {

                   XtraMessageBox.Show(Resources.emptyFields + " / " + Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string MianAcc = txtMainAcc.Text;
                    string Name = txtCusvenanme.Text;
                    string CorVid = txtcusvenid.Text;
                    string Address = txtDetailedAddress.Text;
                    string Mobile = txtMobile.Text;
                    string Email = txtMail.Text;
                    string MaxBal = txtMaxBalance.Text;
                    string Type = txtType.Text;
                    string tax = txtTaxNo.Text;


                    int status = 1;
                    if (active.Checked)
                    {
                        status = 1;

                    }
                    if (notactive.Checked)
                    {
                        status = 0;

                    }

                    int rslt = ss.UpdateCusOrVen(CorVid, Name, Address, Mobile, Email, MaxBal, status, tax);
                    if (rslt > 0)
                    {
                       XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // db.UserLogTransactions(DataBase.Username.ToString(), " اضافة عميل / مورد جديد" + CorVid.ToString() + " / " + Name.ToString(), DateTime.Now, Environment.MachineName);
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
            else if (result == DialogResult.No)
            {
               XtraMessageBox.Show(Resources.CancelByUser, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void MyGrid_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void MyGrid_Click(object sender, EventArgs e)
        {
           
            string id = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CusVenID") + "").ToString();

           
             
                string condition = "CusVenID=" + "'" + id.ToString() + "'";

                int status = 0;
                DataTable dtable = s.SelctData("CustomersAndVendors", 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtMainAcc.Text = dtable.Rows[0]["CusVenAcc"].ToString();//1
                    txtType.Text = dtable.Rows[0]["CusOrVen"].ToString();//2
                    txtcusvenid.Text = dtable.Rows[0]["CusVenID"].ToString();
                    txtCusvenanme.Text = dtable.Rows[0]["CusVenName"].ToString();
                    txtDetailedAddress.Text = dtable.Rows[0]["CusVenDetailedAddress"].ToString();
                    txtMobile.Text = dtable.Rows[0]["CusVenMobile"].ToString();
                    txtMaxBalance.Text = dtable.Rows[0]["CusVenMaxBalance"].ToString();
                    txtTaxNo.Text = dtable.Rows[0]["CusVenTaxNo"].ToString();
                    txtMail.Text = dtable.Rows[0]["CusVenEmail"].ToString();
                    status = int.Parse(dtable.Rows[0]["CusVenStatus"].ToString());//2
                   



                    if (status == 0)
                    {
                        active.Checked= false;
                    notactive.Checked = true;
                    }
                   if(status == 1)
                    {
                    active.Checked = true;
                    notactive.Checked = false;
                }

                btnadd.Visible = false;
                btnupdate.Visible = true;
            }
                else
                {
                   XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnclear.PerformClick();
                }
            }

        private void frmCustomersAndVendors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
