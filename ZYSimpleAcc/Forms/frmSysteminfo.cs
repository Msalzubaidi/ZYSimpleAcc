using DevExpress.XtraEditors;
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
    public partial class frmSysteminfo : Form
    {
        public frmSysteminfo()
        {
            InitializeComponent();
        }


        Shared s = new Shared();
        DataBase db = new DataBase();

        string table = "SystemInfo";
        string imglocation = "";

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSysteminfo_Load(object sender, EventArgs e)
        {
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


            string systeminfotable = "SystemInfo";
            DataTable datatable = s.SelctData(systeminfotable, 0, "");

            


        }

        private void frmSysteminfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("سيتم تحديث البيانات متأكد ؟   ", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_mobile.Text) || string.IsNullOrEmpty(imglocation.ToString()))
                {
                    XtraMessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {

                    byte[] logo = null;
                    FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                    BinaryReader bre = new BinaryReader(stream);
                    logo = bre.ReadBytes((int)stream.Length);
                    string cid = txt_comno.Text;
                    string tax = txt_taxno.Text;

                    string oemail = txt_email.Text;
                    string omobile = txt_mobile.Text;
                    string oaddress = txt_address.Text;

                    string emailpass = txtEmailSender.Text;
                    string passpass = txtPasswordSender.Text;




                    int x = db.updatesysinfo(cid, oemail, omobile, oaddress, tax , emailpass, passpass);
                    int LogoUpload = db.UploadLogo(cid, logo);

                    if (x > 0)
                    {
                        XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    
                    }
                    else if (x < 0)
                    {
                        XtraMessageBox.Show("لم يحدث أي تغيير ", Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    }

                }
            }
            else if (result == DialogResult.No)
            {
                XtraMessageBox.Show(Resources.CancelByUser, Resources.MessageTitle, 0, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                imglocation = opnfd.FileName.ToString();
                pictureBox1.Image = new Bitmap(imglocation);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Backup")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmBackup b = new frmBackup();
                b.Show();
            }
        }
    }
}
