using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Forms;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Shared s = new Shared();
        DataBase db = new DataBase();

        string systeminfotable = "SystemInfo";

        public static int instate = 0;
        public static int outstate = 0;
        public static int jlstate = 0; 


        private void frmMain_Load(object sender, EventArgs e)
        {
            DataTable datatable = s.SelctData(systeminfotable, 0, "");

            if (frmLogin.pass == "masterlogin")
                devmode.Visible = true;
            else
                devmode.Visible = false;

            string logedusername = DataBase.Username.ToString();
            DataTable userPermission = db.ViewUserper(logedusername);

            DateTime dt = DateTime.Parse(datatable.Rows[0]["licenceto"].ToString());
            DateTime dt1 = DateTime.Parse(datatable.Rows[0]["licencefrom"].ToString());
            string titleform = datatable.Rows[0]["name"].ToString();
            TimeSpan t = dt - dt1;
            double NrOfDays = t.TotalDays;
            string nl = "\r\n";

            if (userPermission.Rows.Count > 0)
            {
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


                if (syssetup == 0)
                {
                    mnuSetting.Visible = false;


                }
                if (sysinfo == 0)
                {
                    mnusysteminfo.Visible = false;

                }
                if (userslog == 0)
                {

                    mnusystemtrans.Visible = false;

                }
                if (users == 0)
                {

                    mnuusers.Visible = false;

                }

                if (sendsmsemail == 0)
                {

                    mnusendsmsemail.Visible = false;

                }

                if (newyear == 0)
                {

                    mnunewyear.Visible = false;

                }


                if (AccTree == 0)
                {
                    mnuAccTree.Visible = false;

                }

                if (mainacc == 0)
                {
                    mnumainAccounts.Visible = false;

                }
                if (subacc == 0)
                {
                    mnuchildAccounts.Visible = false;

                }
                if (cusven == 0)
                {
                    mnuCusVen.Visible = false;

                }

                if (linkacc == 0)
                {
                    mnuGeneralAcc.Visible = false;

                }
                if (Stores == 0)
                {
                    mnuStores.Visible = false;
                    mnuSubStores.Visible = false;

                }

                if (setupstores == 0)
                {
                    mnuStoreSettings.Visible = false;
                    mnusubstoresetup.Visible = false;

                }
                if (instore == 0)
                {

                    mnuinstore.Visible = false;
                    mnusubstorein.Visible = false;

                }
                if (outstore == 0)
                {
                    mnuoutstore.Visible = false;
                    mnusubstoreout.Visible = false;

                }

                if (updatecancelstores == 0)
                {
                   
                    updatecancelin.Visible = false;
                    updatecancelout.Visible = false;

                }

                if (acctrans == 0)
                {
                    mnuTrans.Visible = false;
                    mnuSubtrasns.Visible = false;


                }

                if (voucher == 0)
                {
                    mnuvoucher.Visible = false;
                    subacctransvoucher.Visible = false;

                }
                if (recive == 0)
                {

                    mnurecive.Visible = false;
                    subacctransrecive.Visible = false;
                }
                if (payment == 0)
                {
                    mnupayment.Visible = false;
                    subacctranspayment.Visible = false;

                }

                if (updatecanceltrans == 0)
                {

                    updatecancelvchr.Visible = false;
                    updatecancelpay.Visible = false;
                    updatecancelrecv.Visible = false;

                }

                if (sales == 0)
                {
                    mnuSales.Visible = false;
                    mnuSubSales.Visible = false;

                }
                if (salesinv == 0)
                {

                    mnusalesinv.Visible = false;
                    submnusalesinv.Visible = false;

                }
                if (retsaleinv == 0)
                {
                    mnuretsalesinv.Visible = false;
                    submnuretsalesinv.Visible = false;
                }

                if (updatecancelsales == 0)
                {
                    
                    updatecancelsalesinv.Visible = false;
                    updatecancelretsalesinv.Visible = false;
                }

                if (buy == 0)
                {
                    mnuBuy.Visible = false;
                    mnuSubBuy.Visible = false;

                }
                if (buyinv == 0)
                {

                    mnuBuyinv.Visible = false;
                    mnuSubBuyinv.Visible = false;

                }
                if (retbuyinv == 0)
                {
                    mnuretBuyinv.Visible = false;
                    mnuSubretBuyinv.Visible = false;
                }

                if (updatecancelbuy == 0)
                {

                    updatecancelbuyinv.Visible = false;
                    updatecancelretbuyinv.Visible = false;
                }


                if (hr == 0)
                {

                    mnuHR.Visible = false;

                }
                if (hrsetup == 0)
                {
                    mnuhrsetup.Visible = false;

                }

                if (empfiles == 0)
                {
                    mnuempfilles.Visible = false;

                }
                if (salaries == 0)
                {

                    mnusalaries.Visible = false;

                }
                if (holidaysandleaves == 0)
                {
                    mnuholidaysandleaves.Visible = false;

                }


                if (reports == 0)
                {
                    mnuReports.Visible = false;
                    mnuSubReports.Visible = false;

                }
                if (statmentaccount == 0)
                {

                    mnustatofacc.Visible = false;
                    mnusubstateofacc.Visible = false;


                }
                if (generalreports == 0)
                {
                    mnugeneralreport.Visible = false;
                    mnusubgeneralreport.Visible = false;

                }



                if (buyreports == 0)
                {
                    mnuBuyReport.Visible = false;
                    mnusubbuyreport.Visible = false;

                }
                if (salesreports == 0)
                {

                    mnuSalesREport.Visible = false;
                    mnusubsalesrep.Visible = false;

                }
                if (hrreports == 0)
                {
                    mnuhrreports.Visible = false;
                    mnusubhrreport.Visible = false;

                }


                if (acctransreports == 0)
                {
                    mnutransreport.Visible = false;
                    mnusubtransreport.Visible = false;

                }
                if (storesreports == 0)
                {

                    mnustoresrep.Visible = false;
                    mnusubstorereport.Visible = false;

                }
                if (accbalance == 0)
                {
                    mnuaccBalance.Visible = false;
                    mnusubaccbalance.Visible = false;

                }

            }
            else
            {
                mnuAccTree.Visible = false;
                mnuStores.Visible = false;
                mnuTrans.Visible = false;
                mnuSales.Visible = false;
                mnuBuy.Visible = false;
                mnuHR.Visible = false;

                mnuSubBuy.Visible = false;
                mnuSubSales.Visible = false;
                mnuSubStores.Visible = false;
                mnuSubtrasns.Visible = false;

                XtraMessageBox.Show("[ " + logedusername + " ]" + " لايوجد صلاحيات لهذا المستخدم ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

            if (NrOfDays > 30)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Azure;



                if (frmLogin.languagearabic == 1)
                {
                    lic.Text = Resources.Logo + " " + Resources.AppNameAr + " - نسخة مرخصة  ل ( " + " " + titleform.ToString() + " ) " + nl + "الرخصة فعالة لغاية  " + dt.ToShortDateString() + "  -  " + NrOfDays.ToString() + " " + "يوم"; ;

                }
                else
                {
                    lic.Text = Resources.Logo + " " + Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " ) " + nl + "License Active to " + dt.ToShortDateString() + "  -  " + NrOfDays.ToString() + " " + "Days";

                }

            }
            if (NrOfDays <= 30 && NrOfDays > 0)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Azure;

                if (frmLogin.languagearabic == 1)
                {
                    lic.Text = Resources.LogoAR + " " + Resources.AppNameAr + " - نسخة مرخصة ل ( " + " " + titleform.ToString() + " ) " + nl + "ستنتهي صلاحية الرخصة خلال " + "" + NrOfDays.ToString() + " " + "يوم";

                    XtraMessageBox.Show("ستنتهي صلاحية الرخصة خلال " + "" + NrOfDays.ToString() + " " + "يوم" + nl + "يرجى العمل على تجديد الرخصة في أقرب وقت لضمان استمرارية  الخدمة", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lic.Text = Resources.Logo + " " + Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " ) " + nl + "License will be Expired by " + "" + NrOfDays.ToString() + " " + "Days";
                    XtraMessageBox.Show("License will be Expired by " + "" + NrOfDays.ToString() + " " + "Days" + nl + "Please Renew Subscribe soon to warrant continu get Service", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);



                }




            }
            if (NrOfDays <= 0)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Red;


                if (frmLogin.languagearabic == 1)
                {
                    lic.Text = Resources.LogoAR + " " + Resources.AppNameAr + " - نسخة مرخصة ل  ( " + " " + titleform.ToString() + " )  " + nl + "انتهت صلاحية الرخصة في  " + "" + dt.ToShortDateString();
                    XtraMessageBox.Show("انتهت صلاحية الرخصة في  " + "" + dt.ToShortDateString() + nl + "يرجى العمل على تجديد الرخصة للحصول على الخدمة", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mnuAccTree.Visible = false;
                    mnuStores.Visible = false;
                    mnuTrans.Visible = false;
                    mnuSales.Visible = false;
                    mnuBuy.Visible = false;
                    mnuHR.Visible = false;

                    mnuSubBuy.Visible = false;
                    mnuSubSales.Visible = false;
                    mnuSubStores.Visible = false;
                    mnuSubtrasns.Visible = false;
                    XtraMessageBox.Show("نأسف لقد تم ايقاف النظام  " + nl + "يرجى العمل على تجديد الرخصة للحصول على الخدمة", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //db.DeActivaApp();
                }
                if (frmLogin.languagearabic == 0)
                {
                    lic.Text = Resources.Logo + " " + Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " )  " + nl + "License Expired in " + "" + dt.ToShortDateString();
                    XtraMessageBox.Show("License Expired in " + "" + dt.ToShortDateString() + nl + "Please Renew Subscribe To get Service", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mnuAccTree.Visible = false;
                    mnuStores.Visible = false;
                    mnuTrans.Visible = false;
                    mnuSales.Visible = false;
                    mnuBuy.Visible = false;
                    mnuHR.Visible = false;

                    mnuSubBuy.Visible = false;
                    mnuSubSales.Visible = false;
                    mnuSubStores.Visible = false;
                    mnuSubtrasns.Visible = false;


                    XtraMessageBox.Show("Sorry App Stopped " + nl + "Please Renew Subscribe To get Service", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //  db.DeActivaApp();

                }



            }
            else
            {

            }


            //bool isopen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "معلومات النظام")
            //    {
            //        isopen = true;
            //        f.BringToFront();
            //        break;
            //    }
            //}

            //if (isopen == false)
            //{
            //    frmAboutWhatsNew awn = new frmAboutWhatsNew();
            //    awn.Show();

            //}
        }
    


        private void mnuusers_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "المستخدمين وصلاحياتهم")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmUsers users = new frmUsers();
                users.Show();
            }
        }

        private void lic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void mnusysteminfo_Click(object sender, EventArgs e)
        {
         
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "معلومات النظام")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmSysteminfo si = new frmSysteminfo();
                si.Show();
            }
        }

        private void mnuinvoice_Click(object sender, EventArgs e)
        {
           
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "اعدادات الفواتير")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmInvoiceSetting inv = new frmInvoiceSetting();
                inv.Show();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
        
            
            DialogResult result = XtraMessageBox.Show(Resources.ExitPromt, Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

             
                Application.Exit();
                

            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void mnuSubExit_Click(object sender, EventArgs e)
        {
            mnuExit.PerformClick();
        }

        private void mnuGeneralAcc_Click(object sender, EventArgs e)
        {
         
          
        }

        private void mnusystemtrans_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "سجل حركات النظام")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmUserLogTransactions ult = new frmUserLogTransactions();
                ult.Show();
            }
        }

        private void mnuRequestSupport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:dev.mzubaidi@gmail.com");
        }

        private void mnuMyAcc_Click(object sender, EventArgs e)
        {
           
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "اعدادات حسابي")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmMyAccount myacc = new frmMyAccount();
                myacc.Show();
            }
        }

        private void mnusendsmsemail_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ارسال رسالة أو بريد")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmSendSMSEmail se = new frmSendSMSEmail();
                se.Show();
            }
        }

        private void mnuStoreSettings_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "اعدادات المستودعات")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmStoreSettings ss = new frmStoreSettings();
                ss.Show();
            }
        }

        private void ربطالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuGeneralAcc_Click_1(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "تخصيص الحسابات")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAccounts acc = new frmAccounts();
                acc.Show();
            }
        }

        private void devmode_Click(object sender, EventArgs e)
        {

        }

        private void mnunewyear_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "التدوير السنوي")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmYearlyPosting yp = new frmYearlyPosting();
                yp.Show();
            }
        }

        private void mnuWhatsNew_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "حول النظام")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAboutWhatsNew aw = new frmAboutWhatsNew();
                aw.Show();
            }
        }

        private void mnumainAccounts_Click(object sender, EventArgs e)
        {

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "الحسابات الرئيسية")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmMainAccounts ma = new frmMainAccounts();
                ma.Show();
            }
        }

        private void mnuchildAccounts_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "الحسابات الفرعية")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmChildAccounts ca = new frmChildAccounts();
                ca.Show();
            }
        }

        private void mnuCusVen_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "العملاء والموردين")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmCustomersAndVendors candv = new frmCustomersAndVendors();
                candv.Show();
            }
        }

        private void devmode_Click_1(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "الحسابات الرئيسية")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmDeveloper dev = new frmDeveloper();
                dev.Show();
            }
        }

        private void mnuinstore_Click(object sender, EventArgs e)
        {
            frmMain.instate = 0; 
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "سند ادخال")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmStoreIn sin = new frmStoreIn();
                sin.Show();
            }
        }

        private void mnuoutstore_Click(object sender, EventArgs e)
        {
            frmMain.outstate = 0;
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "سند إخراج")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmStoreOut sout = new frmStoreOut();
                sout.Show();
            }
        }

        private void updatecancelin_Click(object sender, EventArgs e)
        {
            frmMain.instate = 10;
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "سند ادخال")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {

                frmStoreIn sin = new frmStoreIn();
                sin.Show();
             
            }
        }

        private void updatecancelout_Click(object sender, EventArgs e)
        {
            frmMain.outstate = 20;
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "سند إخراج")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmStoreOut sout = new frmStoreOut();
                sout.Show();
              
            }
        }

        private void mnuvoucher_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            jlstate = 0;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "القيد")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmJournal jl = new frmJournal();
                jl.Show();
            }
        }

        private void updatecancelvchr_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            jlstate = 10;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "القيد")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmJournal jl = new frmJournal();
                jl.Show();
            }
        }

        private void mnustatofacc_Click(object sender, EventArgs e)
        {
            bool isopen = false;
          
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "كشف حساب")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmStatmentofAccountReport soa = new frmStatmentofAccountReport();
                soa.Show();
            }
        }
    }
}
