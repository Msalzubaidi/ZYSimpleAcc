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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        Shared s = new Shared();
        string table = "Users";

        private void frmUsers_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from Users";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(0).ToString(); 

                cbo_userid.Properties.Items.Add(item1);

            }


        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_userid_TextChanged(object sender, EventArgs e)
        {

           
            if (string.IsNullOrEmpty(cbo_userid.Text) || s.isDigitsOnly(cbo_userid.Text) == false)
            {
                // XtraMessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnclear.PerformClick();
            }

            else

            {

                int v = int.Parse(cbo_userid.EditValue.ToString());
                string condition = "user_id=" + v.ToString();
          
             
                //   DataTable dtp = db.ViewUserper(v);

                DataTable dtable = s.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {
                    btnclear.PerformClick();
                    txt_userid.Text = dtable.Rows[0]["user_id"].ToString();//1
                    txt_username.Text = dtable.Rows[0]["user_name"].ToString();//2
                    txt_pass.Text = dtable.Rows[0]["password"].ToString();
                    txtemail.Text = dtable.Rows[0]["email"].ToString();//2
                    int status = int.Parse(dtable.Rows[0]["IsDeleted"].ToString());//2
                    int bin = int.Parse(dtable.Rows[0]["builtinuser"].ToString());//2
                    DataTable userPermission = db.ViewUserper(txt_username.Text);
                    ////////Setup System permisiions -------
                    int syssetup = int.Parse(userPermission.Rows[0]["syssetup"].ToString());
                    int sysinfo = int.Parse(userPermission.Rows[0]["sysinfo"].ToString());
                    int users = int.Parse(userPermission.Rows[0]["users"].ToString());
                    int invsetup = int.Parse(userPermission.Rows[0]["invsetup"].ToString());
                    int userslog = int.Parse(userPermission.Rows[0]["userslog"].ToString());
                    int newyear = int.Parse(userPermission.Rows[0]["newyear"].ToString());
                    int sendsmsemail = int.Parse(userPermission.Rows[0]["sendsmsemail"].ToString());
                    ////////Acc Tree permisiions -------
                    int AccTree = int.Parse(userPermission.Rows[0]["AccTree"].ToString());
                    int mainacc = int.Parse(userPermission.Rows[0]["mainacc"].ToString());
                    int subacc = int.Parse(userPermission.Rows[0]["subacc"].ToString());
                    int cusven = int.Parse(userPermission.Rows[0]["cusven"].ToString());
                    int linkacc = int.Parse(userPermission.Rows[0]["linkacc"].ToString());
                    ////////Stores Permissions -------
                    int Stores = int.Parse(userPermission.Rows[0]["Stores"].ToString());
                    int setupstores = int.Parse(userPermission.Rows[0]["setupstores"].ToString());
                    int instore = int.Parse(userPermission.Rows[0]["instore"].ToString());
                    int outstore = int.Parse(userPermission.Rows[0]["outstore"].ToString());
                    int updatecancelstores = int.Parse(userPermission.Rows[0]["updatecancelstores"].ToString());
                    ////////Acc trans Permissions -------
                    int acctrans = int.Parse(userPermission.Rows[0]["acctrans"].ToString());
                    int voucher = int.Parse(userPermission.Rows[0]["voucher"].ToString());
                    int recive = int.Parse(userPermission.Rows[0]["recive"].ToString());
                    int payment = int.Parse(userPermission.Rows[0]["payment"].ToString());
                    int updatecanceltrans = int.Parse(userPermission.Rows[0]["updatecanceltrans"].ToString());
                    ////////Sales Permissions -------
                    int sales = int.Parse(userPermission.Rows[0]["sales"].ToString());
                    int salesinv = int.Parse(userPermission.Rows[0]["salesinv"].ToString());
                    int retsaleinv = int.Parse(userPermission.Rows[0]["retsaleinv"].ToString());
                    int updatecancelsales = int.Parse(userPermission.Rows[0]["updatecancelsales"].ToString());
                    ////////Buy  Permissions -------
                    int buy = int.Parse(userPermission.Rows[0]["buy"].ToString());
                    int buyinv = int.Parse(userPermission.Rows[0]["buyinv"].ToString());
                    int retbuyinv = int.Parse(userPermission.Rows[0]["retbuyinv"].ToString());
                    int updatecancelbuy = int.Parse(userPermission.Rows[0]["updatecancelbuy"].ToString());

                    ////////HR Permissions -------
                    int hr = int.Parse(userPermission.Rows[0]["hr"].ToString());
                    int hrsetup = int.Parse(userPermission.Rows[0]["hrsetup"].ToString());
                    int empfiles = int.Parse(userPermission.Rows[0]["empfiles"].ToString());
                    int salaries = int.Parse(userPermission.Rows[0]["salaries"].ToString());
                    int holidaysandleaves = int.Parse(userPermission.Rows[0]["holidaysandleaves"].ToString());
                    ////////Reports Permissions -------
                    int reports = int.Parse(userPermission.Rows[0]["reports"].ToString());
                    int generalreports = int.Parse(userPermission.Rows[0]["generalreports"].ToString());
                    int statmentaccount = int.Parse(userPermission.Rows[0]["statmentaccount"].ToString());
                    int storesreports = int.Parse(userPermission.Rows[0]["storesreports"].ToString());
                    int hrreports = int.Parse(userPermission.Rows[0]["hrreports"].ToString());
                    int salesreports = int.Parse(userPermission.Rows[0]["salesreports"].ToString());
                    int buyreports = int.Parse(userPermission.Rows[0]["buyreports"].ToString());
                    int acctransreports = int.Parse(userPermission.Rows[0]["acctransreports"].ToString());
                    int accbalance = int.Parse(userPermission.Rows[0]["accbalance"].ToString());
                    int admin = int.Parse(userPermission.Rows[0]["admin"].ToString());

                    if (admin == 1 )
                    {
                        chkadmin.Checked = true;
                    }
                    if (status  == 1 )
                    {
                        userStatus.Text = "غير فعال";
                    }
                    if (status == 0)
                    {
                        userStatus.Text = "فعال";
                    }
                    if (syssetup == 1)
                    {
                        chksyssetup.Checked  = true;


                    }
                    if (sysinfo == 1)
                    {
                        chksysinfo.Checked  = true;

                    }
                    if (userslog == 1)
                    {

                        chkuserslog.Checked  = true;

                    }
                    if (users == 1)
                    {

                        chkusers.Checked  = true;

                    }

                    if (sendsmsemail == 1)
                    {

                        chksmsemail.Checked  = true;

                    }

                    if (newyear == 1)
                    {

                        chknewyear.Checked  = true;

                    }


                    if (AccTree == 1)
                    {
                        chkTree.Checked  = true;

                    }

                    if (mainacc == 1)
                    {
                        chkmainacc.Checked  = true;

                    }
                    if (subacc == 1)
                    {
                        chksubacc.Checked  = true;

                    }
                    if (cusven == 1)
                    {
                        chkcusven.Checked  = true;

                    }

                    if (linkacc == 1)
                    {
                        chklinkacc.Checked  = true;

                    }
                    if (Stores == 1)
                    {
                        chkStores.Checked  = true;
                       

                    }

                    if (setupstores == 1)
                    {
                        chkStoresSettings.Checked  = true;
                     

                    }
                    if (instore == 1)
                    {

                        chkstorein.Checked  = true;
                       

                    }
                    if (outstore == 1)
                    {
                        chkstoreout.Checked  = true;
                       
                    }

                    if (acctrans == 1)
                    {
                        chkacctrans.Checked  = true;
                      


                    }

                    if (voucher == 1)
                    {
                        chkvoucher.Checked  = true;
                        

                    }
                    if (recive == 1)
                    {

                        chkrecive.Checked  = true;
                       
                    }
                    if (payment == 1)
                    {
                        chkpayment.Checked  = true;
                       
                    }

                    if (sales == 1)
                    {
                        chksales.Checked  = true;
                      

                    }
                    if (salesinv == 1)
                    {

                        chksalesinv.Checked  = true;
                      
                    }
                    if (retsaleinv == 1)
                    {
                        chkretsalesinv.Checked  = true;
                  
                    }

                    if (buy == 1)
                    {
                        chkbuy.Checked  = true;
                        

                    }
                    if (buyinv == 1)
                    {

                        chkbuyinv.Checked  = true;
                     

                    }
                    if (retbuyinv == 1)
                    {
                        chkretbuyinv.Checked  = true;
                        
                    }


                    if (hr == 1)
                    {

                        chkhr.Checked  = true;

                    }
                    if (hrsetup == 1)
                    {
                        chkhrsettings.Checked  = true;

                    }

                    if (empfiles == 1)
                    {
                        chkempfiles.Checked  = true;

                    }
                    if (salaries == 1)
                    {

                        chksalaries.Checked  = true;

                    }
                    if (holidaysandleaves == 1)
                    {
                        chkholandleaves.Checked = true; 

                    }


                    if (reports == 1)
                    {
                        chkreports.Checked  = true;
                      

                    }
                    if (statmentaccount == 1)
                    {

                        chkstatofacc.Checked  = true;
                    


                    }
                    if (generalreports == 1)
                    {
                        chkgenreports.Checked  = true;
                      
                      
                    }



                    if (buyreports == 1)
                    {
                        chkbuyrep.Checked  = true;
                      

                    }
                    if (salesreports == 1)
                    {

                        chksalesrep.Checked  = true;
                     

                    }
                    if (hrreports == 1)
                    {
                        chkhrreport.Checked  = true;
                      
                    }


                    if (acctransreports == 1)
                    {
                        chkacctransrep.Checked  = true;
                     

                    }
                    if (storesreports == 1)
                    {

                        chkstoresrep.Checked  = true;
                      

                    }
                    if (accbalance == 1)
                    {
                        chkaccbalance.Checked  = true;
                   

                    }
                   
                    if (updatecancelstores == 1)
                    {
                        chkupdatecancelstores.Checked = true;


                    }
                    if (updatecanceltrans == 1)
                    {
                        chkupdatecanceltrans.Checked = true;


                    }
                    if (updatecancelsales == 1)
                    {
                        chkupdatecancelsales.Checked = true;


                    }

                    if (updatecancelbuy == 1)
                    {
                        chkupdatecancelbuy.Checked = true;


                    }





                }
                else
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnclear.PerformClick();
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txt_userid.Clear();
            int y = s.FindMax(table, 0);
            int f = s.FindMax(table, 1);
            int r = s.FindMax(table, 2);
            allusers.Text = (y - 1).ToString();
            activeusers.Text = (f - 1).ToString();
            notactiveusers.Text = (r - 1).ToString();
            txt_userid.Text = y.ToString();
            txt_username.Clear();
            txt_pass.Clear();
            cbo_userid.Focus();
            txtemail.Clear();
            userStatus.Text = "حالة المستخدم";

            chksyssetup.Checked = false;
            chkTree.Checked = false;
            chkStores.Checked = false;
            chkacctrans.Checked = false;
            chksales.Checked = false;
            chkbuy.Checked = false;
            chkhr.Checked = false;
            chkreports.Checked = false;
            chkadmin.Checked = false; 


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string user_name = "";
            int syssetup = 0;
            int sysinfo = 0;
            int users = 0;
            int invsetup = 0;
            int userslog = 0;
            int newyear = 0;
            int sendsmsemail = 0;
            int AccTree = 0;
            int mainacc = 0;
            int subacc = 0;
            int cusven = 0;
            int linkacc = 0;
            int Stores = 0;
            int setupstores = 0;
            int instore = 0;
            int outstore = 0; 
            int acctrans = 0;
            int voucher = 0;
            int recive = 0;
            int payment = 0;
            int sales = 0;
            int salesinv = 0;
            int retsaleinv = 0;
            int buy = 0;
            int buyinv = 0;
            int retbuyinv = 0;
            int hr = 0;
            int hrsetup = 0;
            int empfiles = 0;
            int salaries= 0;
            int holidaysandleaves = 0;
            int reports = 0;
            int generalreports = 0;
            int statmentaccount = 0;
            int storesreports = 0;
            int hrreports = 0;
            int salesreports = 0;
            int buyreports = 0;
            int acctransreports = 0;
            int accbalance = 0;
            int IsDeleted = 0;
            int admin = 0;
            int updatecancelstores = 0;
            int updatecanceltrans = 0;
            int updatecancelsales = 0;
            int updatecancelbuy = 0;

            if (chkadmin.Checked == true)
            {
                admin = 1;

            }

            if (chkadmin.Checked == true)
            {
              
                 syssetup = 1;
                 sysinfo = 1;
                 users = 1;
                 invsetup = 1;
                 userslog = 1;
                 newyear = 1;
                 sendsmsemail = 1;
                 AccTree = 1;
                 mainacc = 1;
                 subacc = 1;
                 cusven = 1;
                 linkacc = 1;
                 Stores = 1;
                 setupstores = 1;
                 instore = 1;
                 outstore = 1;
                acctrans = 1;
                 voucher = 1;
                 recive = 1;
                 payment = 1;
                 sales = 1;
                 salesinv = 1;
                 retsaleinv = 1;
                 buy = 1;
                 buyinv = 1;
                 retbuyinv = 1;
                 hr = 1;
                 hrsetup = 1;
                 empfiles = 1;
                 salaries = 1;
                 holidaysandleaves = 1;
                 reports = 1;
                 generalreports = 1;
                 statmentaccount = 1;
                 storesreports = 1;
                 hrreports = 1;
                 salesreports = 1;
                 buyreports = 1;
                 acctransreports = 1;
                 accbalance = 1;
                 IsDeleted = 1;
                 admin = 1;
                 updatecancelstores = 1;
                 updatecanceltrans = 1;
                 updatecancelsales = 1;
                 updatecancelbuy = 1;

            }

            if (chksysinfo.Checked == true)
            {
                syssetup = 1;
                sysinfo = 1;

            }

            if (chkinvsetup.Checked == true)
            {
                syssetup = 1;
                invsetup = 1; 

            }
            if (chkuserslog.Checked == true)
            {
                syssetup = 1;
                userslog = 1; 

            }
            if (chkusers.Checked == true)
            {
                syssetup = 1;
                users = 1; 

            }
            if (chksmsemail.Checked == true)
            {
                syssetup = 1;
                sendsmsemail = 1;

            }
            if (chknewyear.Checked == true)
            {
                syssetup = 1;
                newyear = 1; 

            }

            if (chkmainacc.Checked == true)
            {
                mainacc = 1;
                AccTree = 1;

            }
            if (chksubacc.Checked == true)
            {
                subacc = 1;
                AccTree = 1;

            }
            if (chkcusven.Checked == true)
            {
                cusven = 1;
                AccTree = 1;

            }
            if (chklinkacc.Checked == true)
            {
                linkacc = 1;
                AccTree = 1;

            }


            ////////////


            if (chkstorein.Checked == true)
            {
                instore = 1;
                Stores = 1;

            }
            if (chkstoreout.Checked == true)
            {
                outstore = 1;
                Stores = 1;

            }
            if (chkStoresSettings.Checked == true)
            {
                setupstores = 1;
                 acctrans = 1;

            }

            if (chkupdatecancelstores.Checked == true)
            {
                setupstores = 1;
                updatecancelstores = 1;

            }



            if (chkvoucher.Checked == true)
            {
                voucher = 1;
                acctrans = 1;

            }
            if (chkrecive.Checked == true)
            {
                recive = 1;
                acctrans = 1;

            }
            if (chkpayment.Checked == true)
            {
                payment = 1;
                acctrans = 1;

            }

            if (chkupdatecanceltrans.Checked == true)
            {
                payment = 1;
                updatecanceltrans = 1;

            }



            if (chksalesinv.Checked == true)
            {
                salesinv = 1;
                sales = 1;

            }
            if (chkretsalesinv.Checked == true)
            {
                retsaleinv = 1;
                sales = 1;

            }

            if (chkupdatecancelsales.Checked == true)
            {
              updatecancelsales = 1;
                sales = 1;

            }

            if (chkbuyinv.Checked == true)
            {
                buyinv = 1;
                buy = 1;

            }
            if (chkretbuyinv.Checked == true)
            {
                retbuyinv = 1;
                buy = 1;

            }

            if (chkupdatecancelbuy.Checked == true)
            {
                updatecancelbuy = 1;
                buy = 1;

            }


            if (chkhrsettings.Checked == true)
            {
                hrsetup = 1;
                hr = 1;

            }
            if (chkempfiles.Checked == true)
            {
                empfiles = 1;
                hr = 1;
            }

            if (chksalaries.Checked == true)
            {
                salaries = 1;
                hr = 1;

            }
            if (chkholandleaves.Checked == true)
            {
                holidaysandleaves = 1;
                hr = 1;
            }

            ////////////

            if (chkgenreports.Checked == true)
            {
                generalreports = 1;
                reports = 1;

            }
            if (chkstatofacc.Checked == true)
            {
                statmentaccount = 1;
                reports = 1;
            }

            if (chkbuyrep.Checked == true)
            {
                buyreports = 1;
                reports = 1;

            }
            if (chksalesrep.Checked == true)
            {
                salesreports = 1;
                reports = 1;
            }
            if (chkstoresrep.Checked == true)
            {
                storesreports = 1;
                reports = 1;

            }
            if (chkhrreport.Checked == true)
            {
                hrreports = 1;
                reports = 1;
            }

            if (chkacctransrep.Checked == true)
            {
                acctransreports = 1;
                reports = 1;

            }
            if (chkaccbalance.Checked == true)
            {
                accbalance = 1;
                reports = 1;
            }



            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {

                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int userid = int.Parse(txt_userid.Text);
                string username = txt_username.Text;
                string password = txt_pass.Text;
                string email = txtemail.Text;
                int isbuiltin = 0; 
                int add = db.AddUser(userid, username, password, 0, email , isbuiltin);
                if (add > 0)
                {

                    XtraMessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);

            db.AddUserPer(userid, username,  syssetup, sysinfo, users, invsetup, userslog, newyear, sendsmsemail, AccTree, mainacc
           , subacc   , cusven, linkacc  , Stores     , setupstores  , instore , outstore   , acctrans  , voucher , recive   , payment    , sales
           , salesinv , retsaleinv
           , buy, buyinv , retbuyinv   , hr , hrsetup , empfiles  , salaries , holidaysandleaves, reports , generalreports ,
           statmentaccount , storesreports , hrreports  , salesreports  , buyreports  , acctransreports , accbalance, 0 , admin , updatecancelstores , updatecanceltrans , updatecancelsales , updatecancelbuy);
                    btnclear.PerformClick();
                    db.UserLogTransactions(DataBase.Username.ToString(), " اضافة مستخدم جديد" + "("+ username.ToString() +")", DateTime.Now, Environment.MachineName);

                }
                else if (add <= 0)
                {
                    XtraMessageBox.Show(Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Hand);
                    btnclear.PerformClick();
                }

            }
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {

            DialogResult result = XtraMessageBox.Show("سيتم تفعيل المستخدم ؟ متأكد ؟  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int num = int.Parse(txt_userid.Text);
                string un = txt_username.Text; 

                int rest = db.ActivateOrDeactivate(num, un,  20);
                if (string.IsNullOrEmpty(txt_userid.Text))
                    XtraMessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);

                else

                if (rest > 0)
                {

                    XtraMessageBox.Show("تم التفعيل", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                //    db.ActivateDeActivatePermissions(num, 20);
                    btnclear.PerformClick();
                }
                else if (rest <= 0)
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, 0, MessageBoxIcon.Error);

                }




            }

            else if (result == DialogResult.No)
            {
                XtraMessageBox.Show(Resources.CancelByUser, Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
                btnclear.PerformClick();
            }
        }

        private void btndeactivaete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("سيتم الغاء تفعيل المستخدم ؟ متأكد ؟  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int num = int.Parse(txt_userid.Text);
                string un = txt_username.Text;

                int rest = db.ActivateOrDeactivate(num, un,  10);
                if (string.IsNullOrEmpty(txt_userid.Text))
                    XtraMessageBox.Show(Resources.invalidData , Resources.MessageTitle, 0, MessageBoxIcon.Warning);

                else

                if (rest > 0)
                {

                    XtraMessageBox.Show("تم الغاء التفعيل", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                  //  db.ActivateDeActivatePermissions(num, 10);
                    btnclear.PerformClick();
                }
                else if (rest <= 0)
                {
                    XtraMessageBox.Show(Resources.notExist, Resources.MessageTitle, 0, MessageBoxIcon.Error);

                }




            }

            else if (result == DialogResult.No)
            {
                XtraMessageBox.Show(Resources.CancelByUser, Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
                btnclear.PerformClick();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
          
        
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {

                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int userid = int.Parse(txt_userid.Text);
                string username = txt_username.Text;
                string password = txt_pass.Text;
                string email = txtemail.Text;
                
                int add = db.UpdateUserinfoadmin(userid, username, password , email);
                if (add > 0)
                {

                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    XtraMessageBox.Show("يرجى العلم بأن التعديل يشمل فقط معلومات المستخدم بدون الصلاحيات ", Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
                    db.UserLogTransactions(DataBase.Username.ToString(), " تحديث بيانات المستخدم " + "(" + username.ToString() + ")", DateTime.Now, Environment.MachineName);
                    db.UpdateUserinfoadminper(userid , username );
                    btnclear.PerformClick();


                }
                else if (add ==-150)
                {
                    XtraMessageBox.Show(Resources.Exist , Resources.MessageTitle, 0, MessageBoxIcon.Hand);
                    btnclear.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Hand);
                    
                }

            }



        }

        private void frmUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void chksyssetup_CheckedChanged(object sender, EventArgs e)
        {
            if (chksyssetup.Checked)
            {
                chksysinfo.Checked = true;
                chkinvsetup.Checked = true;
                chknewyear.Checked = true;
                chkuserslog.Checked = true;
                chkusers.Checked = true;
                chksmsemail.Checked = true;


            }
            if (chksyssetup.Checked == false)
            {
                chksysinfo.Checked = false;
                chkinvsetup.Checked = false;
                chknewyear.Checked = false;
                chkuserslog.Checked = false;
                chkusers.Checked = false;
                chksmsemail.Checked = false;


            }
        }

        private void chkadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkadmin.Checked)
            {

                chksyssetup.Checked = true;
                chkTree.Checked = true;
                chkStores.Checked = true;
                chkacctrans.Checked = true;
                chksales.Checked = true;
                chkbuy.Checked = true;
                chkhr.Checked = true;
                chkreports.Checked = true;

            }
            if (chkadmin.Checked == false)
            {
                chksyssetup.Checked = false;
                chkTree.Checked = false;
                chkStores.Checked = false ;
                chkacctrans.Checked = false;
                chksales.Checked = false;
                chkbuy.Checked = false;
                chkhr.Checked = false;
                chkreports.Checked = false;




            }
        }

        private void chkTree_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTree.Checked)
            {
                chkmainacc.Checked = true;
                chksubacc.Checked = true;
                chkcusven.Checked = true;
                chklinkacc.Checked = true;
            


            }
            if (chkTree.Checked == false)
            {
                chkmainacc.Checked = false;
                chksubacc.Checked = false;
                chkcusven.Checked = false;
                chklinkacc.Checked = false;


            }
        }

        private void chkStores_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStores.Checked)
            {
                chkStoresSettings.Checked = true;
                chkstorein.Checked = true;
                chkstoreout.Checked = true;
                chkupdatecancelstores.Checked = true;
         


            }
            if (chkTree.Checked == false)
            {
                chkStoresSettings.Checked = false;
                chkstorein.Checked = false;
                chkstoreout.Checked = false;
                chkupdatecancelstores.Checked = false;



            }
        }

        private void chkacctrans_CheckedChanged(object sender, EventArgs e)
        {
            if (chkacctrans.Checked)
            {
                chkvoucher.Checked = true;
                chkrecive.Checked = true;
                chkpayment.Checked = true;
                chkupdatecanceltrans.Checked = true; 



            }
            if (chkacctrans.Checked == false)
            {
                chkvoucher.Checked = false;
                chkrecive.Checked = false;
                chkpayment.Checked = false;
                chkupdatecanceltrans.Checked = false;



            }
        }

        private void chksales_CheckedChanged(object sender, EventArgs e)
        {
            if (chksales.Checked)
            {
                chksalesinv.Checked = true;
                chkretsalesinv.Checked = true;
                chkupdatecancelsales.Checked = true; 
             



            }
            if (chksales.Checked == false)
            {

                chksalesinv.Checked = false;
                chkretsalesinv.Checked = false;
                chkupdatecancelsales.Checked = false;

            }
        }

        private void chkbuy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbuy.Checked)
            {
                chkbuyinv.Checked = true;
                chkretbuyinv.Checked = true;
                chkupdatecancelbuy.Checked = true;




            }
            if (chkbuy.Checked == false)
            {

                chkbuyinv.Checked = false;
                chkretbuyinv.Checked = false;
                chkupdatecancelbuy.Checked = false;


            }
        }

        private void chkhr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhr.Checked)
            {
                chkhrsettings.Checked = true;
                chkempfiles.Checked = true;
                chksalaries.Checked = true;
                chkholandleaves.Checked = true;



            }
            if (chkhr.Checked == false)
            {
                chkhrsettings.Checked = false;
                chkempfiles.Checked = false;
                chksalaries.Checked = false;
                chkholandleaves.Checked = false;


            }
        }

        private void chkreports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkreports.Checked)
            {
                chkgenreports.Checked = true;
                chkstatofacc.Checked = true;
                chkbuyrep.Checked = true;
                chksalesrep.Checked = true;
                chkhrreport.Checked = true;
                chkacctransrep.Checked = true;
                chkaccbalance.Checked = true;
                chkstoresrep.Checked = true;


            }
            if (chkreports.Checked == false)
            {
                chkgenreports.Checked = false;
                chkstatofacc.Checked = false;
                chkbuyrep.Checked = false;
                chksalesrep.Checked = false;
                chkhrreport.Checked = false;
                chkacctransrep.Checked = false;
                chkaccbalance.Checked = false;
                chkstoresrep.Checked = false;


            }
        }
    }
}
