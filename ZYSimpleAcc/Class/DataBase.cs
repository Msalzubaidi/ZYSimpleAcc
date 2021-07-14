using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Class
{
    class DataBase
    {
       
        public static string servercon = Resources.servercon;
        public static string dbnamecon = Resources.dbnamecon;
        public static string usernamecon = Resources.usernamecon;
        public static string passwordcon = Resources.passwordcon;

      
   
        public static string MasterPassword = DateTime.Now.ToString("ddMMyyyy");
        public static string connstring = @"Data Source=" + servercon + ";Initial Catalog=" + dbnamecon + ";User ID=" + usernamecon + ";Password=" + passwordcon;
        string table_name { get; set; }
        public static string Username { get; set; }
        public static int Unum { get; set; }
        string password { get; set; }
        string new_pass { get; set; }



        SqlConnection con = new SqlConnection(connstring);


        public int Login(string username, string password )
        {

            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("select * from Users where (user_name=@un and password=@pass)and(IsDeleted=0) ", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@un", username); //store data in parameters to prevent sql injection (get from Password textbox)
            cmd.Parameters.AddWithValue("@pass", password);//store data in parameters to prevent sql injection (get from username textbox)
           

            
            DataBase.Username = username;
             
          
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            con.Open();
            return dt.Rows.Count;

        }



        public DataSet viewLogo(int id)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("select logo from SystemInfo", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@id", id); //store data in parameters to prevent sql injection (get from Password textbox)
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataSet dt = new System.Data.DataSet();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public int updatesysinfo(string id, string email, string mobile, string address, string tax , string emailpass , string passpass)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE SystemInfo SET email=@email , mobile=@phone , address=@adres , tax_no=@tax , passemail=@passemail , passpass=@passpass  where id=@id ", con); // sql command to so get data from data bas


            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@adres", address));
            cmd.Parameters.Add(new SqlParameter("@phone", mobile));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            cmd.Parameters.Add(new SqlParameter("@tax", tax));
            cmd.Parameters.Add(new SqlParameter("@passemail", emailpass));
            cmd.Parameters.Add(new SqlParameter("@passpass", passpass));



            con.Open();
            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewSysinfo(int id)
        {
            SqlConnection con = new SqlConnection(connstring);
            string qry = "select * from SystemInfo";
            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@id", id); //store data in parametageers to prevent sql injection (get from Password textbox)

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public int UploadLogo(string id, byte[] logo)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  

            SqlCommand cmd = new SqlCommand("update SystemInfo set logo = @logo where id =@id", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@logo", logo));
            cmd.Parameters.Add(new SqlParameter("@id", id));



            con.Open();

            return cmd.ExecuteNonQuery();
        }


        public int UserLogTransactions(string username , string TransDescryption, DateTime transDate, string ComputerName)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO UserLogTransactions ( Username , TransDescryption , transDate , ComputerName) VALUES( @username , @TransDescryption , @transDate , @ComputerName )", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@TransDescryption", TransDescryption));
            cmd.Parameters.Add(new SqlParameter("@transDate", transDate));//
            cmd.Parameters.Add(new SqlParameter("@ComputerName", ComputerName));



            con.Open();

            return cmd.ExecuteNonQuery();


        }


        public int ActivaApp()
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = null;

            cmd = new SqlCommand("update ActivationApp set Activated = 1", con);



            // sql command to so get data from data bas


            con.Open();

            return cmd.ExecuteNonQuery();





        }



        public int DeActivaApp()
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = null;

            cmd = new SqlCommand("update ActivationApp set Activated = 0", con);



            // sql command to so get data from data bas


            con.Open();

            return cmd.ExecuteNonQuery();





        }

        public int KeyAdd(string key)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("Update  ActivationApp set ActivationKey=@key", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@key", key));


            con.Open();

            return cmd.ExecuteNonQuery();
        }




        public int updateinvSettings(string invSymbol, string invNotes)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE InvoiceSettings SET invNotes=@invNotes , invSymbol=@invSymbol ", con); // sql command to so get data from data bas


            cmd.Parameters.Add(new SqlParameter("@invSymbol", invSymbol));
            cmd.Parameters.Add(new SqlParameter("@invNotes", invNotes));
         
           

            con.Open();
            return cmd.ExecuteNonQuery();
        }

        public int UpdateSpecAccounts(string sales , string rsales , string buy, string rbuy , string tax , string sal, string exp , int Confirmed , string CustAcc , string VendAcc)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE SpecializedAcc SET SalesAcc=@SalesAcc , RetSalesAcc=@RetSalesAcc , CustAcc=@CustAcc , VendAcc=@VendAcc ,  BuyAcc=@BuyAcc , RetBuyAcc=@RetBuyAcc ,TaxAcc=@TaxAcc , SalariesAcc=@SalariesAcc , ExpAcc=@ExpAcc , Saved=@Confirmed", con); // sql command to so get data from data bas


            cmd.Parameters.Add(new SqlParameter("@SalesAcc", sales));
            cmd.Parameters.Add(new SqlParameter("@RetSalesAcc", rsales));
            cmd.Parameters.Add(new SqlParameter("@BuyAcc", buy));
            cmd.Parameters.Add(new SqlParameter("@RetBuyAcc", rbuy));
            cmd.Parameters.Add(new SqlParameter("@TaxAcc", tax));
            cmd.Parameters.Add(new SqlParameter("@SalariesAcc", sal));
            cmd.Parameters.Add(new SqlParameter("@ExpAcc", exp));
            cmd.Parameters.Add(new SqlParameter("@Confirmed", Confirmed));
            cmd.Parameters.Add(new SqlParameter("@CustAcc", CustAcc));
            cmd.Parameters.Add(new SqlParameter("@VendAcc", VendAcc));



            con.Open();
            return cmd.ExecuteNonQuery();
        }


        public int checkexist(int unum , string user_name )
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("select * from users where user_id=@unum or user_name=@user_name ", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@unum", unum);
            cmd.Parameters.AddWithValue("@user_name", user_name);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }


        public int AddUser(int unum, string username, string password, int IsDeleted, string email , int builtinuser)
        {

            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("INSERT INTO users(user_id,user_name , password ,  IsDeleted , email , builtinuser  ) VALUES(@unum,@un,@psd , @IsDeleted , @email , @builtinuser)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@unum", unum));
            cmd.Parameters.Add(new SqlParameter("@un", username));
            cmd.Parameters.Add(new SqlParameter("@psd", password));
            cmd.Parameters.Add(new SqlParameter("@IsDeleted", IsDeleted));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            cmd.Parameters.Add(new SqlParameter("@builtinuser", builtinuser));






            con.Open();

            int y = this.checkexist(unum , username);
            if (y <= 0)
                return cmd.ExecuteNonQuery();

            else
                return -1;

        }



        public int ActivateOrDeactivate(int unum , string username,  int trans)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = null;
            if (trans == 10)
            {
                cmd = new SqlCommand("update Users set IsDeleted = 1 where user_id=@unum and builtinuser=0 ", con); // sql command to so get data from data bas
            }


            if (trans == 20)
            {
                cmd = new SqlCommand("update Users set IsDeleted = 0 where user_id=@unum and builtinuser=0", con); // sql command to so get data from data bas
            }



            cmd.Parameters.Add(new SqlParameter("@unum", unum));


            DataBase d = new DataBase();
            con.Open();


            int y = this.checkexist(unum , username);
            if (y > 0)
                return cmd.ExecuteNonQuery();

            else
                return -1;




        }

        public int ActivateDeActivatePermissions(int unum, int trans)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = null;
            if (trans == 10)
            {
                cmd = new SqlCommand("update User_permission set IsDeleted = 1 where user_id=@unum and builtinuser=0", con);
            }
            if (trans == 20)
            {
                cmd = new SqlCommand("update User_permission set IsDeleted = 0 where user_id=@unum and builtinuser=0", con);
            }


            // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@unum", unum));



            con.Open();

            return cmd.ExecuteNonQuery();





        }

        public DataTable ViewUserLogs(DateTime from, DateTime to, string transfilter, int newquery)
        {
            SqlConnection con = new SqlConnection(connstring);
            DataTable dt = new DataTable();
            string Qry = "";
            SqlCommand cmd = null;

            if (newquery == 55)
            {
                Qry = "select * from UserLogTransactions";
            }
            else
            {
                Qry = "select * from UserLogTransactions where transDate  >= @dtf  and transDate  <=@dtt and transType=@trans";
            }


            cmd = new SqlCommand(Qry, con);

            cmd.Parameters.AddWithValue("@dtf", from);
            cmd.Parameters.AddWithValue("@dtt", to);
            cmd.Parameters.AddWithValue("@trans", transfilter);



            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            con.Open();

            return dt;

        }


        public int UpdateUserinfo( string username, string password, string new_password)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE users set password=@new_pass where user_name=@uname and password=@password ", con); ; // sql command to so get data from data base


         
            cmd.Parameters.Add(new SqlParameter("@uname", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@new_pass", new_password));



            con.Open();

            return cmd.ExecuteNonQuery();
        }


        string adduserperqry = " INSERT INTO UsersPermissions (user_id, user_name ,  syssetup , sysinfo, users, invsetup, userslog , newyear, sendsmsemail , AccTree, mainacc , subacc , cusven, linkacc, Stores  , setupstores,instore , outstore ,  acctrans , voucher , recive, payment, sales, salesinv, retsaleinv, buy , buyinv  , retbuyinv , hr  , hrsetup  , empfiles   , salaries , holidaysandleaves , reports , generalreports , statmentaccount  , storesreports , hrreports  , salesreports   , buyreports , acctransreports , accbalance , IsDeleted , admin , updatecancelstores ,updatecanceltrans, updatecancelsales ,  updatecancelbuy ) VALUES (@user_id , @user_name ,@syssetup , @sysinfo   , @users  , @invsetup , @userslog   , @newyear   , @sendsmsemail    , @AccTree      , @mainacc      , @subacc   , @cusven , @linkacc , @Stores , @setupstores  , @instore , @outstore  , @acctrans   , @voucher   , @recive   , @payment  , @sales  , @salesinv   , @retsaleinv  , @buy , @buyinv , @retbuyinv  , @hr  , @hrsetup , @empfiles  , @salaries  , @holidaysandleaves     , @reports   , @generalreports   , @statmentaccount   , @storesreports     , @hrreports , @salesreports   , @buyreports , @acctransreports , @accbalance , @IsDeleted , @admin , @updatecancelstores ,@updatecanceltrans, @updatecancelsales ,  @updatecancelbuy)";

        
        public int AddUserPer(int user_id  , string user_name, int syssetup, int sysinfo, int users, int invsetup, int userslog, int newyear, int sendsmsemail, int AccTree , int mainacc
           , int subacc
           , int cusven
           , int linkacc
           , int Stores
           , int setupstores , 
int instore , int outstore
           , int acctrans
           , int voucher
           , int recive
           , int payment
           , int sales
           , int salesinv
           , int retsaleinv
           , int buy
           , int buyinv
           , int retbuyinv
           , int hr
           , int hrsetup
           , int empfiles
           , int salaries
           , int holidaysandleaves
           , int reports
           , int generalreports
           , int statmentaccount
           , int storesreports
           , int hrreports
           , int salesreports
           , int buyreports
           , int acctransreports
           , int accbalance , int IsDeleted , int admin , int updatecancelstores , int updatecanceltrans , int updatecancelsales , int updatecancelbuy )
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(adduserperqry , con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@user_id", user_id));
            cmd.Parameters.Add(new SqlParameter("@syssetup", syssetup));
            cmd.Parameters.Add(new SqlParameter("@sysinfo", sysinfo));
            cmd.Parameters.Add(new SqlParameter("@users" , users));
            cmd.Parameters.Add(new SqlParameter("@invsetup", invsetup));
            cmd.Parameters.Add(new SqlParameter("@userslog", userslog));
            cmd.Parameters.Add(new SqlParameter("@newyear", newyear));
            cmd.Parameters.Add(new SqlParameter("@sendsmsemail", sendsmsemail));
            cmd.Parameters.Add(new SqlParameter("@AccTree", AccTree));
            cmd.Parameters.Add(new SqlParameter("@mainacc", mainacc));
            cmd.Parameters.Add(new SqlParameter("@subacc", subacc));
            cmd.Parameters.Add(new SqlParameter("@cusven", cusven));
            cmd.Parameters.Add(new SqlParameter("@linkacc", linkacc));
            cmd.Parameters.Add(new SqlParameter("@Stores", Stores));
            cmd.Parameters.Add(new SqlParameter("@setupstores", setupstores));
            cmd.Parameters.Add(new SqlParameter("@acctrans", acctrans));

            cmd.Parameters.Add(new SqlParameter("@instore", instore));
            cmd.Parameters.Add(new SqlParameter("@outstore", outstore));

            cmd.Parameters.Add(new SqlParameter("@voucher", voucher));
            cmd.Parameters.Add(new SqlParameter("@recive", recive));
            cmd.Parameters.Add(new SqlParameter("@payment", payment));
            cmd.Parameters.Add(new SqlParameter("@sales", sales));
            cmd.Parameters.Add(new SqlParameter("@salesinv", salesinv));
            cmd.Parameters.Add(new SqlParameter("@retsaleinv", retsaleinv));
            cmd.Parameters.Add(new SqlParameter("@buy", buy));
            cmd.Parameters.Add(new SqlParameter("@buyinv", buyinv));
            cmd.Parameters.Add(new SqlParameter("@retbuyinv", retbuyinv));
            cmd.Parameters.Add(new SqlParameter("@hr" ,hr ));
            cmd.Parameters.Add(new SqlParameter("@hrsetup", hrsetup));
            cmd.Parameters.Add(new SqlParameter("@empfiles", empfiles));
            cmd.Parameters.Add(new SqlParameter("@salaries", salaries));
            cmd.Parameters.Add(new SqlParameter("@holidaysandleaves", holidaysandleaves));
            cmd.Parameters.Add(new SqlParameter("@reports", reports));
            cmd.Parameters.Add(new SqlParameter("@generalreports", generalreports));
            cmd.Parameters.Add(new SqlParameter("@statmentaccount", statmentaccount));
            cmd.Parameters.Add(new SqlParameter("@storesreports", storesreports));
            cmd.Parameters.Add(new SqlParameter("@hrreports", hrreports));
            cmd.Parameters.Add(new SqlParameter("@salesreports", salesreports));
            cmd.Parameters.Add(new SqlParameter("@buyreports", buyreports));
            cmd.Parameters.Add(new SqlParameter("@acctransreports", acctransreports));
            cmd.Parameters.Add(new SqlParameter("@accbalance", accbalance));
            cmd.Parameters.Add(new SqlParameter("@IsDeleted", IsDeleted)); 
                     cmd.Parameters.Add(new SqlParameter("@admin", admin)); 
                  cmd.Parameters.Add(new SqlParameter("@user_name", user_name));

            cmd.Parameters.Add(new SqlParameter("@updatecancelstores", updatecancelstores));
            cmd.Parameters.Add(new SqlParameter("@updatecanceltrans", updatecanceltrans));
            cmd.Parameters.Add(new SqlParameter("@updatecancelsales", updatecancelsales));
            cmd.Parameters.Add(new SqlParameter("@updatecancelbuy", updatecancelbuy));






            con.Open();

            return cmd.ExecuteNonQuery();
        }

        public int UpdateUserinfoadmin( int user_id,  string username, string password , string  email)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE users set password=@password , user_name=@uname   , email=@email where user_id=@user_id and builtinuser=0 ", con); ; // sql command to so get data from data base



            cmd.Parameters.Add(new SqlParameter("@uname", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@user_id", user_id));
            cmd.Parameters.Add(new SqlParameter("@email", email));

            

            con.Open();

            DataBase db = new DataBase();
           int rest =  db.checkexist(user_id , username);
            if (rest > 0)
                return -150; 
            else
                
            return cmd.ExecuteNonQuery();
        }


        public int UpdateUserinfoadminper(int user_id, string username)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE UsersPermissions set  user_name=@uname   where user_id=@user_id ", con); ; // sql command to so get data from data base



            cmd.Parameters.Add(new SqlParameter("@uname", username));
      
            cmd.Parameters.Add(new SqlParameter("@user_id", user_id));
            



            con.Open();

            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewUserper(string id)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("select * from UsersPermissions where user_name=@username", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@username", id); //store data in parametageers to prevent sql injection (get from Password textbox)

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }
    }
}
