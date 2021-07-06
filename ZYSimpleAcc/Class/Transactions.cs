using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYSimpleAcc.Class
{
    class Transactions
    {


        public int  NewStoreTransMaster(int id , DateTime date , string notes , float value , int rowscount , int storeid , string type)
        {
            string qry = "INSERT INTO StoreTransMaster (  TransID ,  TransDate ,  TransNotes ,  TransValue ,  TransRowCount , TransStoreID , TransType  ) VALUES( @TransID ,  @TransDate ,  @TransNotes ,  @TransValue ,  @TransRowCount , @TransStoreID , @TransType  )";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

           
            cmd.Parameters.Add(new SqlParameter("@TransID", id));//
            cmd.Parameters.Add(new SqlParameter("@TransDate", date));
            cmd.Parameters.Add(new SqlParameter("@TransNotes", notes));
            cmd.Parameters.Add(new SqlParameter("@TransValue", value));
            cmd.Parameters.Add(new SqlParameter("@TransRowCount", rowscount));
            cmd.Parameters.Add(new SqlParameter("@TransStoreID", storeid));
            cmd.Parameters.Add(new SqlParameter("@TransType", type));



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


    }
}
