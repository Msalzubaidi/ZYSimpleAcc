using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmDeveloper : Form
    {
        public frmDeveloper()
        {
            InitializeComponent();
        }


        Shared s = new Shared();
        DataBase db = new DataBase();

        string table = "SystemInfo";
        string imglocation = "";


        private void frmDeveloper_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            string condition = "";

            DataTable dtable = s.SelctData(table, 0, condition);


            txt_comno.Text = dtable.Rows[0]["id"].ToString();
            txt_comname.Text = dtable.Rows[0]["name"].ToString();
            txt_address.Text = dtable.Rows[0]["address"].ToString();
            txt_email.Text = dtable.Rows[0]["email"].ToString();
            txt_mobile.Text = dtable.Rows[0]["mobile"].ToString();

            int version = int.Parse(dtable.Rows[0]["version"].ToString());
            txt_version.Text = version.ToString();
            txt_taxno.Text = dtable.Rows[0]["tax_no"].ToString();
            txtEmailSender.Text = dtable.Rows[0]["passemail"].ToString();
            txtPasswordSender.Text = dtable.Rows[0]["passpass"].ToString();

            DataSet ds = db.viewLogo(1);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["logo"]);
            pictureBox1.Image = new Bitmap(ms);

           
            DataTable datatable = s.SelctData(table, 0, "");





            DateTime dt = DateTime.Parse(datatable.Rows[0]["licenceto"].ToString());
            DateTime dt1 = DateTime.Parse(datatable.Rows[0]["licencefrom"].ToString());
            string titleform = datatable.Rows[0]["name"].ToString();
          
            TimeSpan t = dt - dt1;
            double NrOfDays = t.TotalDays;
            string nl = "\r\n";

            lblversion.Text = version.ToString();
            lblfrom.Text = dt1.ToString();
            lblto.Text = dt.ToString();
            lblname.Text = titleform.ToString();
            lblappversion.Text = Resources.AppVersion;
            lblserver.Text = Resources.servercon;
            lbldbase.Text = Resources.dbnamecon;
            lblpassword.Text = Resources.passwordcon;
        
            lbldays.Text = NrOfDays.ToString() + " يوم  ";


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}
