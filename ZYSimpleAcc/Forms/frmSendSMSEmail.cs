using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmSendSMSEmail : Form
    {
        public frmSendSMSEmail()
        {
            InitializeComponent();
        }

        Shared s = new Shared();

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void frmSendSMSEmail_Load(object sender, EventArgs e)
        {
          
        }

        private void btnemailview_Click(object sender, EventArgs e)
        {
            frmCustomersAndVendoesView v = new frmCustomersAndVendoesView();
            v.ShowDialog();
            txtCustId.Text = v.CustsGrid.CurrentRow.Cells[0].Value.ToString();
            txtCustName.Text = v.CustsGrid.CurrentRow.Cells[1].Value.ToString();
            txtCustEmail.Text = v.CustsGrid.CurrentRow.Cells[4].Value.ToString();
          

        }

        private void btnSmsiew_Click(object sender, EventArgs e)
        {
            frmCustomersAndVendoesView v = new frmCustomersAndVendoesView();
            v.ShowDialog();
            txtCusIDSMS.Text = v.CustsGrid.CurrentRow.Cells[0].Value.ToString();
            txtCusNameSMS.Text = v.CustsGrid.CurrentRow.Cells[1].Value.ToString();
            txtMobile.Text = v.CustsGrid.CurrentRow.Cells[3].Value.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtCustId.Clear();
            txtCustName.Clear();
            txtCustEmail.Clear();
            txtMessage.Clear();
        }

        private void simpleButton2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            txtCusIDSMS.Clear();
            txtCusNameSMS.Clear();
            txtMobile.Clear();
            txtMessageSMS.Clear();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCusIDSMS.Text) || string.IsNullOrWhiteSpace(txtCusNameSMS.Text) || string.IsNullOrWhiteSpace(txtMobile.Text) || string.IsNullOrWhiteSpace(txtMessageSMS.Text))
            {
                MessageBox.Show(Resources.missingTextboxes, Resources.MessageTitle, 0, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    WebClient client = new WebClient();
                    string to, messagee;
                    to = txtMobile.Text;
                    messagee = txtMessageSMS.Text.ToString();
                    string baseURL = "http://api.clickatell.com/http/sendmsg?user=zisan94268&password=OYeNLVUHTNIHbD&api_id=3528011&to='" + to + "'&text='" + messagee + "'";
                    client.OpenRead(baseURL);
                    XtraMessageBox.Show("تم ارسال الرسالة بنجاح", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    simpleButton3.PerformClick();
                }


                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMobile.UseSystemPasswordChar = true;
            }
            if (checkBox1.Checked == false)
            {
                txtMobile.UseSystemPasswordChar = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (englang.Checked)
            {
                txtMessageSMS.TextAlign = HorizontalAlignment.Right;
                txtMessageSMS.Focus();
            }
            if (arlang.Checked)
            {
                txtMessageSMS.TextAlign = HorizontalAlignment.Left;
                txtMessageSMS.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtMessage.TextAlign = HorizontalAlignment.Right;
                txtMessage.Focus();
            }
            if (radioButton1.Checked)
            {
                txtMessage.TextAlign = HorizontalAlignment.Left;
                txtMessage.Focus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtCustEmail.UseSystemPasswordChar = true;
            }
            if (checkBox2.Checked == false)
            {
                txtCustEmail.UseSystemPasswordChar = false;
            }
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustId.Text) || string.IsNullOrWhiteSpace(txtCustName.Text) || string.IsNullOrWhiteSpace(txtCustEmail.Text) || string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show(Resources.missingTextboxes, Resources.MessageTitle, 0, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dtable = s.SelctData("SystemInfo", 0, "");
                
               string email = dtable.Rows[0]["passemail"].ToString();
               string pass = dtable.Rows[0]["passpass"].ToString();
                string name = dtable.Rows[0]["name"].ToString();

                MailMessage myMsg = new MailMessage();
              
                myMsg.From = new MailAddress(email);

                myMsg.To.Add(txtCustEmail.Text);
                myMsg.Subject = name;
                myMsg.Body = txtMessage.Text.ToString();

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    try
                    {
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = new NetworkCredential(email, pass);
                        smtp.EnableSsl = true;
                        smtp.Send(myMsg);

                        XtraMessageBox.Show("تم ارسال البريد بنجاح", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        simpleButton3.PerformClick();
                    }
                    catch
                    {
                        XtraMessageBox.Show(" حدث خطأ غير متوقع - الرجاء التأكد من الاعدادات وللمساعدة اضغط على زر مساعدة  ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        XtraMessageBox.Show("يجب أن يتم تسجيل الدخول بالبريد المرسل منه على الجهاز المرسل", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        XtraMessageBox.Show("يجب تفعيل وصول التطبيقات الأقل أمانا من المتصفح", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }

            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("يجب أن يتم تسجيل الدخول بالبريد المرسل منه على الجهاز المرسل", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            XtraMessageBox.Show("يجب تفعيل وصول التطبيقات الأقل أمانا من المتصفح", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
