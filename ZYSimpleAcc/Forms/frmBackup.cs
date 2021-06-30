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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }
        SqlConnection con;

        SqlCommand cmd;

        SqlDataReader dr;

        private void frmBackup_Load(object sender, EventArgs e)
        {
            serverName(".");
        }


        public void serverName(string str)

        {

            con = new SqlConnection(DataBase.connstring);

            con.Open();

            cmd = new SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                ComboBoxserverName.Items.Add(dr[2]);

            }

            dr.Close();

        }


        public void Createconnection()

        {

            con = new SqlConnection(DataBase.connstring);

            con.Open();

            //  ComboBoxDatabaseName.Items.Clear();

            cmd = new SqlCommand("select * from sysdatabases", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())

            {


            }

            dr.Close();

        }


        public void blank(string str)

        {

            if (string.IsNullOrEmpty(ComboBoxserverName.Text) | string.IsNullOrEmpty(ComboBoxDatabaseName.Text))

            {

                // label3.Visible = true;


                XtraMessageBox.Show("الرجاء اختيار السيرفر وقاعدة البيانات ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);

                return;

            }

            else

            {

                if (str == "backup")

                {

                    SaveFileDialog1.FileName = ComboBoxDatabaseName.Text;

                    SaveFileDialog1.ShowDialog();

                    string s = null;

                    s = SaveFileDialog1.FileName;

                    query("Backup database " + ComboBoxDatabaseName.Text + " to disk='" + s + "'");



                    XtraMessageBox.Show(Resources.Completed, Resources.MessageTitle, 0, MessageBoxIcon.Information);

                }

            }
        }

        public void query(string que)

        {

            // ERROR: Not supported in C#: OnErrorStatement



            cmd = new SqlCommand(que, con);

            cmd.ExecuteNonQuery();

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            blank("backup");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
