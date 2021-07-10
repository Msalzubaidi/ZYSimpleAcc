using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYSimpleAcc.Class
{
    class Transactions
    {


        public int  NewStoreTransMaster(int id , DateTime date , string notes , float value , int storeid , string type , int IsCancelled )
        {
            string qry = "INSERT INTO StoreTransMaster (  TransID ,  TransDate ,  TransNotes ,  TransValue  , TransStoreID , TransType , IsCancelled  ) VALUES( @TransID ,  @TransDate ,  @TransNotes ,  @TransValue  , @TransStoreID , @TransType , @IsCancelled )";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

           
            cmd.Parameters.Add(new SqlParameter("@TransID", id));//
            cmd.Parameters.Add(new SqlParameter("@TransDate", date));
            cmd.Parameters.Add(new SqlParameter("@TransNotes", notes));
            cmd.Parameters.Add(new SqlParameter("@TransValue", value));
           
            cmd.Parameters.Add(new SqlParameter("@TransStoreID", storeid));
            cmd.Parameters.Add(new SqlParameter("@TransType", type));
            cmd.Parameters.Add(new SqlParameter("@IsCancelled", IsCancelled));



            Transactions t = new Transactions();
            con.Open();

            int x = t.checkexist(id , type);

            if (x > 0)
            {
                return -150;
            }
            else
                return cmd.ExecuteNonQuery();


        }

        public int NewStoreTransDetails(int TransID , int TransStoreID,  string TransType, DateTime TransDate , string ItemID , string ItemName , float ItemQty ,  float ItemEnteredUnitPrice , string ItemEnteredUnitName , float taxpercent, float taxvalue, float transValue)
        {
            string qry = "INSERT INTO StoreTransDetails (  TransID ,  TransStoreID  ,  TransType ,  TransDate  , ItemID , ItemName , ItemQty , ItemEnteredUnitPrice , ItemEnteredUnitName , taxpercent, taxvalue , transValue ) VALUES(  @TransID ,  @TransStoreID  ,  @TransType ,  @TransDate  , @ItemID , @ItemName , @ItemQty , @ItemEnteredUnitPrice , @ItemEnteredUnitName  ,  @taxpercent, @taxvalue , @transValue )";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas


            cmd.Parameters.Add(new SqlParameter("@TransID", TransID));//
            cmd.Parameters.Add(new SqlParameter("@TransDate", TransDate));//
            cmd.Parameters.Add(new SqlParameter("@TransType", TransType));
            cmd.Parameters.Add(new SqlParameter("@ItemName", ItemName));
            cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));
            cmd.Parameters.Add(new SqlParameter("@TransStoreID", TransStoreID));
            cmd.Parameters.Add(new SqlParameter("@ItemQty", ItemQty));
            cmd.Parameters.Add(new SqlParameter("@ItemEnteredUnitPrice", ItemEnteredUnitPrice));
            cmd.Parameters.Add(new SqlParameter("@ItemEnteredUnitName", ItemEnteredUnitName));
            cmd.Parameters.Add(new SqlParameter("@taxpercent", taxpercent));
            cmd.Parameters.Add(new SqlParameter("@taxvalue", taxvalue));
            cmd.Parameters.Add(new SqlParameter("@transValue", transValue));
            




            con.Open();
            return cmd.ExecuteNonQuery();


        }

        public int CancelStoreDetailsTransaction(int TransID)
        {
            string qry = "Delete from  StoreTransDetails where TransID=@TransID ";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@TransID", TransID));

            Transactions t = new Transactions();

            con.Open();
            return cmd.ExecuteNonQuery(); 



        }



        public int CancelStoreMasterTransaction(int TransID)
        {
            string qry = "Update StoreTransMaster set IsCancelled=1 where TransID=@TransID";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas
            
            cmd.Parameters.Add(new SqlParameter("@TransID", TransID));

            Transactions t = new Transactions();
            DataTable dt  = t.checkState(TransID);
            int state  = int.Parse(dt.Rows[0]["IsCancelled"].ToString());


            con.Open();
            if (state == 0 )
            {
                t.CancelStoreDetailsTransaction(TransID);
                return cmd.ExecuteNonQuery(); 
            }
            else if(state == 1)
            {
                return -150; // AlreadCancelled or NOt Exist 
            }
            else
            {
                return - 250; 
            }
            
          
        }


        public int checkexist(int TransID, string TransType)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);

            SqlCommand cmd = new SqlCommand("select * from StoreTransMaster where TransID=@TransID and TransType=@TransType ", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@TransID", TransID);
            cmd.Parameters.AddWithValue("@TransType", TransType);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }

        public DataTable checkState(int TransID )
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);

            SqlCommand cmd = new SqlCommand("select *  from StoreTransMaster where TransID=@TransID", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@TransID", TransID);
           
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }
       
        

    }
}
