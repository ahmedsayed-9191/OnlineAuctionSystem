using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnlineAuctionSystem.BussinessLogicLayer
{
    public class Seller:User 
    {
        //Function Register
        public void Register(string UserName, string Password, string Email, string Adrress, string Mobile)
        {
            Admin Delegator = new Admin();
            Delegator.add_Admin(UserName, Password, Email, Adrress, Mobile, "Seller");
        }

        //Function to Join Session
        public void subscribe_Session(int Session_ID ,int Seller_ID)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Session_ID", SqlDbType.Int);
            param[0].Value = Session_ID;

            param[1] = new SqlParameter("@Seller_ID", SqlDbType.Int);
            param[1].Value = Seller_ID;

            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_SubscribeSession", param);
            dataBaseHelperL.Close();

        }

        //Function to Add Item 
        public void add_Item(Item item , int Session_ID)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param[0].Value = item.get_Name();

            param[1] = new SqlParameter("@Description", SqlDbType.VarChar, 200);
            param[1].Value = item.get_Description();

            param[2] = new SqlParameter("@Image", SqlDbType.Image);
            param[2].Value = item.get_Image();

            param[3] = new SqlParameter("@Initial_Price", SqlDbType.Float);
            param[3].Value = item.get_IntialPrice();

            param[4] = new SqlParameter("@Seller_ID", SqlDbType.Int);
            param[4].Value = item.get_Seller_ID();

            param[5] = new SqlParameter("@ID", SqlDbType.Int);
            param[5].Value = item.get_ID();

            param[6] = new SqlParameter("@Session_ID", SqlDbType.Int);
            param[6].Value = Session_ID;


            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_AddItem", param);
            dataBaseHelperL.Close();
        }

        //Function to View  Available Session
        public DataTable ViewAvailableSessions(string Search)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Search;


            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_ViewAvailableSessionsSeller", param);
            dataBaseHelperL.Close();

            return Dt;
        }


        //Function To view Subscribed Sessions of the Seller
        public DataTable ViewMySessions(string Search , int Seller_ID)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Search;

            param[1] = new SqlParameter("@Seller_ID", SqlDbType.Int);
            param[1].Value = Seller_ID;

            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_View_Subscribed_Session_Seller", param);
            dataBaseHelperL.Close();

            return Dt;
        }

        //Function To view Started Sessions of the Seller
        public DataTable ViewStartedSessions(string Search, int Seller_ID)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Search;

            param[1] = new SqlParameter("@Seller_ID", SqlDbType.Int);
            param[1].Value = Seller_ID;



            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_View_Started_Session_Seller", param);
            dataBaseHelperL.Close();

            return Dt;
        }


        //Function To view Started Sessions of the Seller
        public DataTable ViewSessionsResult(string Search, int Seller_ID)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Search;

            param[1] = new SqlParameter("@Seller_ID", SqlDbType.Int);
            param[1].Value = Seller_ID;



            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_View_Session_Result_Seller", param);
            dataBaseHelperL.Close();

            return Dt;
        }


    }
}
