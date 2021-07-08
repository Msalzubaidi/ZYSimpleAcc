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
            DataTable dtable1 = s.SelctData(masterstoretable, 7 , "");//Customer

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
            transnotes.Text = "سند إخراج ";
            cboStore.ResetText();
            txtstoreid.Clear();
            cboCat.ResetText();
           

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

        }

        private void frmStoreOut_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
        }
    }
}
