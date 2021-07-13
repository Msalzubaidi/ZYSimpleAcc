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
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        
        }

        Shared s = new Shared();

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailbeg.Text) || string.IsNullOrEmpty(users.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtpaswordsender.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                MailMessage myMsg = new MailMessage();
                string senderemail = emailbeg.Text.Trim();
                myMsg.From = new MailAddress(senderemail);
                string nl = "\r\n";
                myMsg.To.Add(txtemail.Text);
                myMsg.Subject = "ZY TECH APP - SimpleAcc 2021";
                  myMsg.Body = "مرحبا " + users.Text + nl + " كلمة المرور الخاصة بك هي :  " + "( " + txtpassword.Text + " ) " + "الرجاء عدم مشاركتها مع الآخرين" + nl + "نتمنى لك يوم سعيد ";
             //   myMsg.Body = "Hi " + users.Text + " Your password is  " + "( " + txtpassword.Text + " ) " + "Please Don't Share it with other.";

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    try
                    {

                    
                    smtp.Credentials = new NetworkCredential(emailbeg.Text, txtpaswordsender.Text);
                    smtp.EnableSsl = true;
                    smtp.Send(myMsg);
                    XtraMessageBox.Show("الرجاء تفقد بريدك الإلكتروني - تم ارسال كلمة المرور", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void users_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(users.Text))
            {
                // XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                Shared s = new Shared();
                string user = users.Text;
                string condition = "user_name=" + "'" + @user + "'";

                DataTable dtable = s.SelctData("Users", 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtemail.Text = dtable.Rows[0]["email"].ToString();//2
                    txtpassword.Text = dtable.Rows[0]["password"].ToString();//2


                }

                else
                {
                    XtraMessageBox.Show("الرجاء اختيار اسم المستخدم", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;


            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd;
            SqlDataReader dr;

            string qry = "select* from Users";

            con.Open();
            //XtraMessageBox.Show("Connected ... ");

            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                users.Properties.Items.Add(dr.GetValue(1).ToString());

            }

            string condition = "";

            DataTable dtable = s.SelctData("SystemInfo", 0, condition);

            
            emailbeg.Text = dtable.Rows[0]["passemail"].ToString();
            txtpaswordsender.Text = dtable.Rows[0]["passpass"].ToString();
        }

        private void frmResetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            XtraMessageBox.Show("يجب أن يتم تسجيل الدخول بالبريد المرسل منه على الجهاز المرسل", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            XtraMessageBox.Show("يجب تفعيل وصول التطبيقات الأقل أمانا من المتصفح", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
    }
}
