using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYSimpleAcc.Class
{
    class SystemSetup
    {


        public int AddAccount(string accNO , string accName , string accType , string accMaxBalance , int accStatus , string accCurrency , int IsParent  , string accParent  , string accParentName)
        {
            string qry = "INSERT INTO MainAccounts (  accNO ,  accName ,  accType ,  accMaxBalance ,  accStatus , accCurrency , IsParent ,accParent , accParentName ) VALUES(@accNO ,  @accName ,  @accType ,  @accMaxBalance ,  @accStatus , @accCurrency , @IsParent , @accParent , @accParentName)";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@accNO", accNO));
            cmd.Parameters.Add(new SqlParameter("@accName", accName));
            cmd.Parameters.Add(new SqlParameter("@accType", accType));//
            cmd.Parameters.Add(new SqlParameter("@accMaxBalance", accMaxBalance));
            cmd.Parameters.Add(new SqlParameter("@accStatus", accStatus));
            cmd.Parameters.Add(new SqlParameter("@accCurrency", accCurrency));
            cmd.Parameters.Add(new SqlParameter("@IsParent", IsParent));
            cmd.Parameters.Add(new SqlParameter("@accParent", accParent));
            cmd.Parameters.Add(new SqlParameter("@accParentName", accParentName));
       


              SystemSetup ss = new SystemSetup();
            con.Open();

            int x = ss.checkexist(accNO , accName);

             if(x > 0)
            {
                return -150; 
            }
             else 
            return cmd.ExecuteNonQuery();


        }

      
        public int AddCusOrVen(string CusVenAcc, string CusVenID , string CusVenName, string CusVenDetailedAddress, string CusVenMobile, string CusVenEmail, string CusVenMaxBalance, int CusVenStatus, string CusOrVen ,  string CusVenTaxNo)
        {
            string qry = "INSERT INTO CustomersAndVendors  ( CusVenAcc,  CusVenID,  CusVenName,  CusVenDetailedAddress,  CusVenMobile,  CusVenEmail,  CusVenMaxBalance,  CusVenStatus,  CusOrVen , CusVenTaxNo  ) VALUES(@CusVenAcc,  @CusVenID,  @CusVenName,  @CusVenDetailedAddress,  @CusVenMobile,  @CusVenEmail,  @CusVenMaxBalance,  @CusVenStatus,  @CusOrVen  , @CusVenTaxNo)";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@CusVenAcc", CusVenAcc));
            cmd.Parameters.Add(new SqlParameter("@CusVenID", CusVenID));
            cmd.Parameters.Add(new SqlParameter("@CusVenName", CusVenName));//
          
            cmd.Parameters.Add(new SqlParameter("@CusVenDetailedAddress", CusVenDetailedAddress));
           
            cmd.Parameters.Add(new SqlParameter("@CusVenMobile", CusVenMobile));
            cmd.Parameters.Add(new SqlParameter("@CusVenEmail", CusVenEmail));
            cmd.Parameters.Add(new SqlParameter("@CusVenMaxBalance", CusVenMaxBalance));
       
            cmd.Parameters.Add(new SqlParameter("@CusVenStatus", CusVenStatus));
            cmd.Parameters.Add(new SqlParameter("@CusOrVen", CusOrVen)); 
                  cmd.Parameters.Add(new SqlParameter("@CusVenTaxNo", CusVenTaxNo)); 


             SystemSetup ss = new SystemSetup();
            con.Open();

            int x = ss.checkexistcusven(CusVenID, CusVenName , 0);

            if (x > 0)
            {
                return -150;
            }
            else
                return cmd.ExecuteNonQuery();


        }


        public int AddNewArea(int AreaID, string AreaTitle)
        {
            string qry = "INSERT INTO Areas  (  AreaID,  AreaTitle  ) VALUES(@AreaID,  @AreaTitle)";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@AreaID", AreaID));
            cmd.Parameters.Add(new SqlParameter("@AreaTitle", AreaTitle));
       


            SystemSetup ss = new SystemSetup();
            con.Open();

                return cmd.ExecuteNonQuery();


        }

        public int AddNewStore(int StoreID, string StoreTitle)
        {
            string qry = "INSERT INTO Stores  (  StoreID, StoreTitle  ) VALUES(@StoreID,  @StoreTitle)";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@StoreID", StoreID));
            cmd.Parameters.Add(new SqlParameter("@StoreTitle", StoreTitle));



            SystemSetup ss = new SystemSetup();
            con.Open();

            return cmd.ExecuteNonQuery();


        }

        public int AddNewCat(int CatID, string CatTitle)
        {
            string qry = "INSERT INTO Categories  (  CatID, CatTitle  ) VALUES(@CatID,  @CatTitle)";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@CatID", CatID));
            cmd.Parameters.Add(new SqlParameter("@CatTitle", CatTitle));



            SystemSetup ss = new SystemSetup();
            con.Open();

            return cmd.ExecuteNonQuery();


        }

        public int AddNewService(int ServiceID, string ServiceDesc , float ServiceValue , float ServiceTaxPercentage)
        {
            string qry = "INSERT INTO Services  (   ServiceID,  ServiceDesc ,  ServiceValue ,  ServiceTaxPercentage  ) VALUES( @ServiceID,  @ServiceDesc ,  @ServiceValue ,  @ServiceTaxPercentage )";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@ServiceID", ServiceID));
            cmd.Parameters.Add(new SqlParameter("@ServiceDesc", ServiceDesc));
            cmd.Parameters.Add(new SqlParameter("@ServiceValue", ServiceValue));
            cmd.Parameters.Add(new SqlParameter("@ServiceTaxPercentage", ServiceTaxPercentage));



            SystemSetup ss = new SystemSetup();
            con.Open();

            return cmd.ExecuteNonQuery();


        }


        public int UpdateOrDeleteService(int ServiceID, string ServiceDesc, float ServiceValue, float ServiceTaxPercentage ,  int operation)
        {
            string qry = "";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            if (operation == 0)//if no items has thus unit
                qry = "update Services set ServiceDesc=@ServiceDesc , ServiceValue=@ServiceValue, ServiceTaxPercentage=@ServiceTaxPercentage  where ServiceID=@ServiceID";
            if (operation == 1)//if no items has thus unit 
                qry = "Delete from  Services  where ServiceID=@ServiceID";


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@ServiceID", ServiceID));
            cmd.Parameters.Add(new SqlParameter("@ServiceDesc", ServiceDesc));
            cmd.Parameters.Add(new SqlParameter("@ServiceValue", ServiceValue));
            cmd.Parameters.Add(new SqlParameter("@ServiceTaxPercentage", ServiceTaxPercentage));




            SystemSetup ss = new SystemSetup();
            con.Open();
            return cmd.ExecuteNonQuery();



        }

        public int AddNewCatTax(int CatID, float CatTaxValuePercent)
        {
            string qry = "INSERT INTO CatTax  (  CatID, CatTaxValuePercent  ) VALUES(@CatID,  @CatTaxValuePercent)";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@CatID", CatID));
            cmd.Parameters.Add(new SqlParameter("@CatTaxValuePercent", CatTaxValuePercent));



            SystemSetup ss = new SystemSetup();
            con.Open();

            return cmd.ExecuteNonQuery();


        }


        public int AddNewUnit(int UnitID,  string MainUnitName , int MainUnitValue , string SubUnitName ,int SubUnitValue)
        {
            string qry = "INSERT INTO Units  (  UnitID, MainUnitName ,  MainUnitValue , SubUnitName , SubUnitValue ) VALUES( @UnitID, @MainUnitName ,  @MainUnitValue , @SubUnitName , @SubUnitValue)";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@UnitID", UnitID));
            cmd.Parameters.Add(new SqlParameter("@MainUnitName", MainUnitName));
            cmd.Parameters.Add(new SqlParameter("@MainUnitValue", MainUnitValue));
            cmd.Parameters.Add(new SqlParameter("@SubUnitName", SubUnitName));
            cmd.Parameters.Add(new SqlParameter("@SubUnitValue", SubUnitValue));


            SystemSetup ss = new SystemSetup();
            con.Open();

            return cmd.ExecuteNonQuery();


        }

        public int UpdateOrDeleteUnit(int UnitID, string MainUnitName, int MainUnitValue, string SubUnitName, int SubUnitValue , int operation)
        {
            string qry = "";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            if (operation == 0)//if no items has thus unit
                qry = "update Units set MainUnitName=@MainUnitName , MainUnitValue=@MainUnitValue, SubUnitName=@SubUnitName, SubUnitValue=@SubUnitValue  where UnitID=@UnitID";
            if (operation == 1)//if no items has thus unit 
                qry = "Delete from  Units  where UnitID=@UnitID";


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@UnitID", UnitID));
            cmd.Parameters.Add(new SqlParameter("@MainUnitName", MainUnitName));
            cmd.Parameters.Add(new SqlParameter("@MainUnitValue", MainUnitValue));
            cmd.Parameters.Add(new SqlParameter("@SubUnitName", SubUnitName));
            cmd.Parameters.Add(new SqlParameter("@SubUnitValue", SubUnitValue));




            SystemSetup ss = new SystemSetup();
            con.Open();
            return cmd.ExecuteNonQuery();



        }




        public int checkexist(string accNo , string accName)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);

            SqlCommand cmd = new SqlCommand("select * from MainAccounts where accNo=@accNo or accName=@accName ", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@accNo", accNo);
            cmd.Parameters.AddWithValue("@accName", accName);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }

        public int checkitemexist(string itemID, string ItemName)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);

            SqlCommand cmd = new SqlCommand("select * from Items where itemID=@itemID or ItemName=@ItemName ", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@itemID", itemID);
            cmd.Parameters.AddWithValue("@ItemName", ItemName);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }



        public int checkexistcusven(string id, string name , int operation)
        {
            string qry = "";
            SqlConnection con = new SqlConnection(DataBase.connstring);

            if (operation ==0)
            {
                qry = "select * from CustomersAndVendors where CusVenID=@id or CusVenName=@name ";
            }

            if (operation == 1)
            {
                qry = "select * from CustomersAndVendors where CusVenName=@name";
            }

            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }

        public int checkexistandnotparent(string accNo)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);

            SqlCommand cmd = new SqlCommand("select * from MainAccounts where accNo=@accNo and accParent <> 'MainAccount'", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@accNo", accNo);
           

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }


        public int ActivateOrDeactivate(string  accNo, string accName , int trans )
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = null;
            if (trans == 10)
            {
                cmd = new SqlCommand("update MainAccounts set accStatus = 1 where accNo=@accNo ", con); // sql command to so get data from data bas
            }


            if (trans == 20)
            {
                cmd = new SqlCommand("update MainAccounts set accStatus = 0 where accNo=@accNo", con); // sql command to so get data from data bas
            }



            cmd.Parameters.Add(new SqlParameter("@accNo", accNo));
           


            SystemSetup ss = new SystemSetup();
            con.Open();


            int y = ss.checkexist(accNo , accName);
            if (y > 0)
                return cmd.ExecuteNonQuery();

            else
                return -1;




        }



        public int MakeAccountParent(string accNO , int IsParent )
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("update MainAccounts set IsParent=@IsParent  where accNo=@accNo", con); // sql command to so get data from data bas


            cmd.Parameters.Add(new SqlParameter("@accNO", accNO));
      
            cmd.Parameters.Add(new SqlParameter("@IsParent", IsParent));
            



            SystemSetup ss = new SystemSetup();
            con.Open();
            
                return cmd.ExecuteNonQuery();
            

        }

        public int UpdateOrDeleteArea(int AreaID, string AreaTitle , int operation)
        {
            string qry = "";
         
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            if (operation == 0)
                qry = "update Areas set AreaTitle=@AreaTitle  where AreaID=@AreaID";
            if (operation == 1 )
                qry = "Delete from  Areas  where AreaID=@AreaID";


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@AreaID", AreaID));

            cmd.Parameters.Add(new SqlParameter("@AreaTitle", AreaTitle));




            SystemSetup ss = new SystemSetup();
            con.Open();
            return  cmd.ExecuteNonQuery();
           


        }

        public int UpdateOrDeleteStore(int StoreID, string StoreTitle, int operation)
        {
            string qry = "";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            if (operation == 0)
                qry = "update Stores set StoreTitle=@StoreTitle  where StoreID=@StoreID";
            if (operation == 1)
                qry = "Delete from  Stores  where StoreID=@StoreID";


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@StoreID", StoreID));

            cmd.Parameters.Add(new SqlParameter("@StoreTitle", StoreTitle));




            SystemSetup ss = new SystemSetup();
            con.Open();
            return cmd.ExecuteNonQuery();



        }

        public int UpdateOrDeleteCat(int CatID, string CatTitle, int operation)
        {
            string qry = "";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            if (operation == 0)
                qry = "update Categories set CatTitle=@CatTitle  where CatID=@CatID";
            if (operation == 1)
                qry = "Delete from  Categories  where CatID=@CatID";


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@CatID", CatID));

            cmd.Parameters.Add(new SqlParameter("@CatTitle", CatTitle));




            SystemSetup ss = new SystemSetup();
            con.Open();
            return cmd.ExecuteNonQuery();



        }

        public int UpdateOrDeleteCatTax(int CatID, float CatTaxValuePercent, int operation)
        {
            string qry = "";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            if (operation == 0)
                qry = "update CatTax set CatTaxValuePercent=@CatTaxValuePercent  where CatID=@CatID";
            if (operation == 1)
                qry = "Delete from  CatTax  where CatID=@CatID";


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@CatID", CatID));

            cmd.Parameters.Add(new SqlParameter("@CatTaxValuePercent", CatTaxValuePercent));




            SystemSetup ss = new SystemSetup();
            con.Open();
            return cmd.ExecuteNonQuery();



        }


        public int UpdateAccount(string accNO, string accName, string accType, string accMaxBalance, int accStatus, string accCurrency, int IsParent, string accParent)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("update MainAccounts set accName=@accName , accType=@accType ,  accMaxBalance=@accMaxBalance , accCurrency=@accCurrency  where accNo=@accNo", con); // sql command to so get data from data bas

            
            cmd.Parameters.Add(new SqlParameter("@accNO", accNO));
            cmd.Parameters.Add(new SqlParameter("@accName", accName));
            cmd.Parameters.Add(new SqlParameter("@accType", accType));//
            cmd.Parameters.Add(new SqlParameter("@accMaxBalance", accMaxBalance));
            cmd.Parameters.Add(new SqlParameter("@accStatus", accStatus));
            cmd.Parameters.Add(new SqlParameter("@accCurrency", accCurrency));
            cmd.Parameters.Add(new SqlParameter("@IsParent", IsParent));
            cmd.Parameters.Add(new SqlParameter("@accParent", accParent));



            SystemSetup ss = new SystemSetup();
            con.Open();


            int y = ss.checkexist(accNO, accName);
            if (y > 0)
                return cmd.ExecuteNonQuery();

            else
                return -1;


        }


        public int UpdateCusOrVen( string CusVenID, string CusVenName, string CusVenDetailedAddress, string CusVenMobile, string CusVenEmail, string CusVenMaxBalance, int CusVenStatus, string CusVenTaxNo)
        {
            string qry = " Update CustomersAndVendors set CusVenName=@CusVenName ,  CusVenDetailedAddress=@CusVenDetailedAddress ,  CusVenMobile=@CusVenMobile,  CusVenEmail=@CusVenEmail,  CusVenMaxBalance=@CusVenMaxBalance, CusVenStatus=@CusVenStatus ,  CusVenTaxNo=@CusVenTaxNo where CusVenID=@CusVenID ";
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            
            cmd.Parameters.Add(new SqlParameter("@CusVenID", CusVenID));
            cmd.Parameters.Add(new SqlParameter("@CusVenName", CusVenName));

            cmd.Parameters.Add(new SqlParameter("@CusVenDetailedAddress", CusVenDetailedAddress));

            cmd.Parameters.Add(new SqlParameter("@CusVenMobile", CusVenMobile));
            cmd.Parameters.Add(new SqlParameter("@CusVenEmail", CusVenEmail));
            cmd.Parameters.Add(new SqlParameter("@CusVenMaxBalance", CusVenMaxBalance));

            cmd.Parameters.Add(new SqlParameter("@CusVenStatus", CusVenStatus));
       
            cmd.Parameters.Add(new SqlParameter("@CusVenTaxNo", CusVenTaxNo));


            SystemSetup ss = new SystemSetup();
            con.Open();

            int x = ss.checkexistcusven(CusVenID, CusVenName , 1 );

            if (x > 0)
            {
                return -150;
            }
            else

                return cmd.ExecuteNonQuery();

        }
            

        public int DeletAccount(string accNo)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);

            SystemSetup ss = new SystemSetup();
            int used = ss.IsUsedinSpecilzedAccount(accNo);

            if (used <= 0)
            {
                SqlCommand cmd = new SqlCommand("delete from MainAccounts where accNo=@accNo ", con); // sql command to so get data from data base


                cmd.Parameters.AddWithValue("@accNo", accNo);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                con.Open();


                return dt.Rows.Count;
            }

            else if (used > 0)
                return -150;

            else
                return -250;

         

        }


        public int IsUsedinSpecilzedAccount(string accNo )
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);

            SqlCommand cmd = new SqlCommand("select * from SpecializedAcc where SalesAcc=@accNo or RetSalesAcc=@accNo or BuyAcc=@accNo or RetBuyAcc=@accNo or TaxAcc=@accNo or SalariesAcc=@accNo or  ExpAcc=@accNo ", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@accNo", accNo);
            

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }

        public int IsUsedItem(int itemType, string itemValue)
        {



            return 0;
        }

        public int AddNewItem(string ItemID, string ItemName, int ItemCategoryID, string ItemCategoryName,
            int ItemSupplierID, string ItemSupplierName, string ItemBarCode, float ItemBuyPriceMainUnit,
            float ItemBuyPriceSubUnit, float ItemSellPriceMainUnit, float ItemSellPriceSubUnit, 
            float ItemTaxPercentValue, int ItemStatus, int ItemUnitID, int ItemMainUnitValue, string ItemMainUnitName,
            int ItemSubUnitValue, string ItemSubUnitName )
        {
            string qry = "INSERT INTO Items ( ItemID,  ItemName,  ItemCategoryID,  ItemCategoryName,ItemSupplierID,  ItemSupplierName,  ItemBarCode,  ItemBuyPriceMainUnit,  ItemBuyPriceSubUnit,  ItemSellPriceMainUnit,  ItemSellPriceSubUnit,  ItemTaxPercentValue,  ItemStatus,  ItemUnitID,  ItemMainUnitValue,  ItemMainUnitName, ItemSubUnitValue ,ItemSubUnitName) VALUES(@ItemID,@ItemName,@ItemCategoryID,@ItemCategoryName,@ItemSupplierID,@ItemSupplierName,@ItemBarCode,@ItemBuyPriceMainUnit,@ItemBuyPriceSubUnit,@ItemSellPriceMainUnit,@ItemSellPriceSubUnit,@ItemTaxPercentValue,@ItemStatus,@ItemUnitID,@ItemMainUnitValue,@ItemMainUnitName,@ItemSubUnitValue,@ItemSubUnitName)";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

         
            cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));
            cmd.Parameters.Add(new SqlParameter("@ItemName", ItemName));
            cmd.Parameters.Add(new SqlParameter("@ItemCategoryID", ItemCategoryID));
            cmd.Parameters.Add(new SqlParameter("@ItemCategoryName", ItemCategoryName));
            cmd.Parameters.Add(new SqlParameter("@ItemSupplierID", ItemSupplierID));
            cmd.Parameters.Add(new SqlParameter("@ItemSupplierName", ItemSupplierName));
            cmd.Parameters.Add(new SqlParameter("@ItemBarCode", ItemBarCode));
            cmd.Parameters.Add(new SqlParameter("@ItemBuyPriceMainUnit", ItemBuyPriceMainUnit));
            cmd.Parameters.Add(new SqlParameter("@ItemBuyPriceSubUnit", ItemBuyPriceSubUnit));
            cmd.Parameters.Add(new SqlParameter("@ItemSellPriceMainUnit", ItemSellPriceMainUnit));
            cmd.Parameters.Add(new SqlParameter("@ItemSellPriceSubUnit", ItemSellPriceSubUnit));
            cmd.Parameters.Add(new SqlParameter("@ItemTaxPercentValue", ItemTaxPercentValue));
            cmd.Parameters.Add(new SqlParameter("@ItemStatus", ItemStatus));
            cmd.Parameters.Add(new SqlParameter("@ItemUnitID", ItemUnitID));
            cmd.Parameters.Add(new SqlParameter("@ItemMainUnitValue", ItemMainUnitValue));
            cmd.Parameters.Add(new SqlParameter("@ItemMainUnitName", ItemMainUnitName));
            cmd.Parameters.Add(new SqlParameter("@ItemSubUnitValue", ItemSubUnitValue));
            cmd.Parameters.Add(new SqlParameter("@ItemSubUnitName", ItemSubUnitName));



            SystemSetup ss = new SystemSetup();
            con.Open();

            int x = ss.checkitemexist(ItemID, ItemName);

            if (x > 0)
            {
                return -150;
            }
            else
                return cmd.ExecuteNonQuery();


        }

        public int UpdateOrDeleteItem(string ItemID, string ItemName, int ItemCategoryID, string ItemCategoryName,
            int ItemSupplierID, string ItemSupplierName, string ItemBarCode, float ItemBuyPriceMainUnit,
            float ItemBuyPriceSubUnit, float ItemSellPriceMainUnit, float ItemSellPriceSubUnit,
            float ItemTaxPercentValue, int ItemStatus, int ItemUnitID, int ItemMainUnitValue, string ItemMainUnitName,
            int ItemSubUnitValue, string ItemSubUnitName , int operation)
        {
            string qry = "";

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            if (operation == 0)
                qry = "update Items set  ItemName=@ItemName,  ItemCategoryID=@ItemCategoryID,  ItemCategoryName=@ItemCategoryName ,ItemSupplierID=@ItemSupplierID, ItemSupplierName=@ItemSupplierName,  ItemBarCode=@ItemBarCode,  ItemBuyPriceMainUnit=@ItemBuyPriceMainUnit,  ItemBuyPriceSubUnit=@ItemBuyPriceSubUnit,  ItemSellPriceMainUnit=@ItemSellPriceMainUnit,  ItemSellPriceSubUnit=@ItemSellPriceSubUnit,  ItemTaxPercentValue=@ItemTaxPercentValue,  ItemStatus=@ItemStatus,  ItemUnitID=@ItemUnitID,  ItemMainUnitValue=@ItemMainUnitValue,  ItemMainUnitName=@ItemMainUnitName, ItemSubUnitValue=@ItemSubUnitValue ,ItemSubUnitName=@ItemSubUnitName  where itemID=@itemID";
            if (operation == 1)
                qry = "Delete from  Items  where itemID=@itemID";


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));
            cmd.Parameters.Add(new SqlParameter("@ItemName", ItemName));
            cmd.Parameters.Add(new SqlParameter("@ItemCategoryID", ItemCategoryID));
            cmd.Parameters.Add(new SqlParameter("@ItemCategoryName", ItemCategoryName));
            cmd.Parameters.Add(new SqlParameter("@ItemSupplierID", ItemSupplierID));
            cmd.Parameters.Add(new SqlParameter("@ItemSupplierName", ItemSupplierName));
            cmd.Parameters.Add(new SqlParameter("@ItemBarCode", ItemBarCode));
            cmd.Parameters.Add(new SqlParameter("@ItemBuyPriceMainUnit", ItemBuyPriceMainUnit));
            cmd.Parameters.Add(new SqlParameter("@ItemBuyPriceSubUnit", ItemBuyPriceSubUnit));
            cmd.Parameters.Add(new SqlParameter("@ItemSellPriceMainUnit", ItemSellPriceMainUnit));
            cmd.Parameters.Add(new SqlParameter("@ItemSellPriceSubUnit", ItemSellPriceSubUnit));
            cmd.Parameters.Add(new SqlParameter("@ItemTaxPercentValue", ItemTaxPercentValue));
            cmd.Parameters.Add(new SqlParameter("@ItemStatus", ItemStatus));
            cmd.Parameters.Add(new SqlParameter("@ItemUnitID", ItemUnitID));
            cmd.Parameters.Add(new SqlParameter("@ItemMainUnitValue", ItemMainUnitValue));
            cmd.Parameters.Add(new SqlParameter("@ItemMainUnitName", ItemMainUnitName));
            cmd.Parameters.Add(new SqlParameter("@ItemSubUnitValue", ItemSubUnitValue));
            cmd.Parameters.Add(new SqlParameter("@ItemSubUnitName", ItemSubUnitName));



            SystemSetup ss = new SystemSetup();
            con.Open();
            return cmd.ExecuteNonQuery();



        }



        public DataTable SerachCusVen(string keyword)
        {
          
            SqlConnection con = new SqlConnection(DataBase.connstring);
            string qry = "Select * from CustomersAndVendors where [CusVenName] + [CusVenID] + [CusVenMobile] +[CusVenEmail] + [CusVenDetailedAddress] + [CusVenMaxBalance] + [CusVenTaxNo] like '%' + " + "'" +  keyword  + "'"+ "+'%'";

            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@keyword", keyword));
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;
        }


        public DataTable SerachItems(string keyword , int operation )
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);
            string qry = "";
            if (operation == 0 )
           qry = "Select ItemID , ItemName , ItemCategoryName ,ItemSupplierName , ItemBarCode  , ItemTaxPercentValue , ItemMainUnitName , ItemMainUnitValue   from Items where [ItemID] + [ItemName] + [ItemCategoryName] +[ItemSupplierName] + [ItemBarCode]  like '%' + " + "'" + keyword + "'" + "+'%'  and ItemStatus = 1";

            else if (operation == 1 )
                qry = "Select ItemID , ItemName , ItemCategoryName ,ItemSupplierName , ItemBarCode , ItemTaxPercentValue , ItemMainUnitName , ItemMainUnitValue   from Items  where ItemStatus = 1";

            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@keyword", keyword));

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;
        }




    }
}
