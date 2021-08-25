using System;
using System.Data;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmAboutWhatsNew : Form
    {
        public frmAboutWhatsNew()
        {
            InitializeComponent();
        }

        Shared s = new Shared();

        DataBase db = new DataBase();

        string systeminfotable = "SystemInfo";

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAboutWhatsNew_Load(object sender, EventArgs e)
        {
           
            DataTable datatable = s.SelctData(systeminfotable, 0, "");


           


            DateTime dt = DateTime.Parse(datatable.Rows[0]["licenceto"].ToString());
            DateTime dt1 = DateTime.Parse(datatable.Rows[0]["licencefrom"].ToString());

            DateTime now = DateTime.Parse(DateTime.Now.ToString());

            string titleform = datatable.Rows[0]["name"].ToString();
            string version = datatable.Rows[0]["version"].ToString();
            TimeSpan t = dt - now;
            double NrOfDays = t.TotalDays;
            string nl = "\r\n";

            lblversion.Text = version.ToString();
            lblfrom.Text = dt1.ToString();
            lblto.Text = dt.ToString();
            lblname.Text = titleform.ToString();
            label1.Text = Resources.AppVersion;
            label2.Text = Resources.servercon;
            label3.Text = Resources.dbnamecon;
            simpleButton1.Text = "جديد النظام ؟ في هذا الإصدار" + " "  +  Resources.AppVersion;
            label4.Text =  NrOfDays.ToString() + " يوم  ";



        }

        private void lblversion_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmAboutWhatsNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
    }

