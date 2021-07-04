using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYSimpleAcc.Class
{
    class Shared
    {


        public DataTable SelctData(string tablename, int parx, string condition)
        {
            int x = parx;
            //Add Check Exist

            string begqry = "select * from ";
            string table_name = tablename;
            string qrycondition = condition;
            string qry = "";


            if (x == 0)
            {
                //Only For Select * 
                qry = "select * from " + table_name;
            }
            else if (x == 1)
            {
                //For Conditional Select 
                qry = begqry + table_name + " where " +  qrycondition ;
            }
            else if (x==2)
            {
                qry = "select ISNULL(Max(CusVenID) , 0 ) as CusVenID  from " + table_name + " where CusOrVen='C'";
            }
            else if (x == 3)
            {
                qry = "select ISNULL(Max(CusVenID) , 0 ) as CusVenID from " + table_name + " where CusOrVen='V'";
            }
            else if (x == 4)
            {
                qry = "select *  from " + table_name + " where CusOrVen='C'";
            }
            else if (x == 5)
            {
                qry = "select * from " + table_name + " where CusOrVen='V'";
            }
            else if (x == 6)
            {
                qry = "select ISNULL(Max(ItemID) , 0 ) as ItemID from " + table_name + " where ItemCategoryID="+int.Parse(condition);
            }




            SqlConnection con = new SqlConnection(DataBase.connstring);
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data base



            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }



        public bool isDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;//contain char 

            }

            return true; // does not contain char
        }



        public int FindMax(string table_name , int d)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);
            string qry = "";


            if (d == 0 )
            {
                 qry = "select * from " + table_name;
            }

            if (d== 1 )
            {
                qry = "select * from " + table_name + " where IsDeleted=0";
            }

            if (d == 2)
            {
                qry = "select * from " + table_name + " where IsDeleted=1";
            }
         



            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@t_name", table_name);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count + 1;

        }


        
        
    }
}
