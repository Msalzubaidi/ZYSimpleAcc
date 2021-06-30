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
    public partial class frmAreas : Form
    {
        public frmAreas()
        {
            InitializeComponent();
        }
        string table = "Areas";
        Shared s = new Shared();
        SystemSetup ss = new SystemSetup();
        DataBase db = new DataBase();


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
            
            btndelete.Visible = false; 
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            int y = s.FindMax(table, 0);
            txtareaid.Text = y.ToString();
            txtareatitle.Clear();
            txtareatitle.Focus();
            btnupdate.Visible = false;
            btndelete.Visible = false;
            btnadd.Visible = true;
            DataTable dtable = s.SelctData("Areas", 0, "");
            int x = dtable.Rows.Count;
            MyGrid.RefreshDataSource();
            MyGrid.DataSource = dtable;
            btndelete.Visible = false;
        }

        private void area_id_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void area_id_Validated(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtareaid.Text) || string.IsNullOrEmpty(txtareatitle.Text))
            {
               XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtareaid.Text);
                string title = txtareatitle.Text;

                int rest = ss.AddNewArea(id, title);
                if (rest > 0)
                {
                   XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " اضافة منطقة جديدة" + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclear.PerformClick();

                }

                else
                {
                   XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtareaid.Text) || string.IsNullOrEmpty(txtareatitle.Text))
            {
               XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtareaid.Text);
                string title = txtareatitle.Text;

                int rest = ss.UpdateOrDeleteArea(id, title, 1);
                if (rest > 0)
                {
                   XtraMessageBox.Show(Resources.deleted, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   db.UserLogTransactions(DataBase.Username.ToString(), " حذف منطقة " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclear.PerformClick();

                }

                else
                {
                   XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtareaid.Text) || string.IsNullOrEmpty(txtareatitle.Text))
            {
               XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtareaid.Text);
                string title = txtareatitle.Text;

                int rest = ss.UpdateOrDeleteArea(id, title, 0);
                if (rest > 0)
                {
                   XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //db.UserLogTransactions(DataBase.Username.ToString(), " تعديل منطقة " + id.ToString() + " / " + title.ToString(), DateTime.Now, Environment.MachineName);
                    btnclear.PerformClick();

                }

                else
                {
                   XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void MyGrid_Click(object sender, EventArgs e)
        {
            string id = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AreaID") + "").ToString();

            
            string condition = "AreaID=" + "'" + id.ToString() + "'";

          
            DataTable dtable = s.SelctData("Areas", 1, condition);
            int x = dtable.Rows.Count;

            if (dtable != null && dtable.Rows.Count > 0)
            {

                txtareaid.Text = dtable.Rows[0]["AreaID"].ToString();//1
                txtareatitle.Text = dtable.Rows[0]["AreaTitle"].ToString();//2
             
                
                btnadd.Visible = false;
                btnupdate.Visible = true;
            }
            else
            {
               XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnclear.PerformClick();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtareaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtareatitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAreas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
    }

