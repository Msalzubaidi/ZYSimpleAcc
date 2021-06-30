using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmUserLogTransactions : Form
    {
        public frmUserLogTransactions()
        {
            InitializeComponent();
        }

        private void frmUserLogTransactions_Load(object sender, EventArgs e)
        {
            dtp_from.EditValue = DateTime.Now;
            dtp_to.EditValue = DateTime.Now;



            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;

            SqlConnection con4 = new SqlConnection(connstring);
            SqlCommand cmd4;
            SqlDataReader dr4;

            string qry4 = "select distinct (TransType) from UserLogTransactions";
            con4.Open();



            cmd4 = new SqlCommand(qry4, con4);
            dr4 = cmd4.ExecuteReader();

            while (dr4.Read())
            {
                string item1F = dr4.GetValue(0).ToString();

                cbo_transtype.Properties.Items.Add(item1F);


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            DataBase db = new DataBase();
            if (string.IsNullOrEmpty(cbo_transtype.EditValue.ToString()) || string.IsNullOrWhiteSpace(dtp_from.EditValue.ToString()) || string.IsNullOrWhiteSpace(dtp_to.EditValue.ToString()))
            {
              XtraMessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Information);

            }
            if (chk_all.Checked)
            {
                dt = db.ViewUserLogs(DateTime.Now, DateTime.Now, "", 55);
            }
            else
            {
                dt = db.ViewUserLogs(DateTime.Parse(dtp_from.EditValue.ToString()), DateTime.Parse(dtp_to.EditValue.ToString()), cbo_transtype.EditValue.ToString(), 0);
            }


            MyGrid.DataSource = null;
            gridView1.Columns.Clear();
            MyGrid.Refresh();

            MyGrid.DataSource = dt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MyGrid.DataSource = null;
            gridView1.Columns.Clear();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (gridView1.Columns.Count <= 0)
            {
                XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string path = "Users Log Transactions Report.xlsx";
                gridView1.ExportToXlsx(path);
                // Open the created XLSX file with the default application.
                XtraMessageBox.Show("Report Exported To Excel Successfully ... ", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                Process.Start(path);
            }
        }

        private void frmUserLogTransactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
