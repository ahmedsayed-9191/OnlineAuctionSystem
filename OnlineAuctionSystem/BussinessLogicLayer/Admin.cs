using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnlineAuctionSystem.BussinessLogicLayer
{
    public class Admin:User 
    {
        //Function To Retrieve All Sessions
        public DataTable View_Sessions(string search, int status)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = search;

            param[1] = new SqlParameter("@Status", SqlDbType.Int);
            param[1].Value = status;

            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_ViewSessionAdmin", param);
            dataBaseHelperL.Close();

            return Dt;
        }


        public DataTable View_Session_Details(int Session_Id)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Session_Id", SqlDbType.Int);
            param[0].Value = Session_Id;


            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_View_Session_Details", param);
            dataBaseHelperL.Close();

            return Dt;
        }

        //Function to Create Auction Session
        public void create_AuctionSession(string Name)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Name", SqlDbType.VarChar ,50);
            param[0].Value = Name;

            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_Create_Session", param);
            dataBaseHelperL.Close();
        }

        //Function to Create Auction Session
        public void Start_AuctionSession(int sessionID)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Session_ID", SqlDbType.Int);
            param[0].Value = sessionID;

            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_StartSession", param);
            dataBaseHelperL.Close();
        }

        //Function To View Bid Details
        public DataTable View_Bid_Details(int Session_Id)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@sessionID", SqlDbType.Int);
            param[0].Value = Session_Id;


            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_ViewBid_Details", param);
            dataBaseHelperL.Close();

            return Dt;
        }

        //Function to End Auction Session
        public void End_AuctionSession(int sessionID)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Session_ID", SqlDbType.Int);
            param[0].Value = sessionID;

            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_EndSession", param);
            dataBaseHelperL.Close();
        }


        //Function to List All Users
        public DataTable view_Users(string Criterion , string UserType)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;

            param[1] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[1].Value = UserType;

            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_ViewUsers", param);
            dataBaseHelperL.Close();

            return Dt;
        }

        //Function to Delete  User
        public void delete_Users(string UserName , string UserType)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[1].Value = UserType;

            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_DeleteUser", param);
            dataBaseHelperL.Close();


        }

        //Function To Add Admin
        public void add_Admin(string UserName, string Password,string Email ,string Adrress ,string Mobile, string UserType="Admin")
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = Password;

            param[2] = new SqlParameter("@Email", SqlDbType.VarChar, 70);
            param[2].Value = Email;

            param[3] = new SqlParameter("@Address", SqlDbType.VarChar, 100);
            param[3].Value = Adrress;

            param[4] = new SqlParameter("@Mobile", SqlDbType.VarChar, 50);
            param[4].Value = Mobile;

            param[5] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[5].Value = UserType;

            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_REGISTER_ADD_ADMIN", param);
            dataBaseHelperL.Close();

        }

        //View Report
        public DataTable view_Report()
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();

            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_GetReport", null);
            dataBaseHelperL.Close();

            return Dt;
        }


    }
}
