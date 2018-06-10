using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OnlineAuctionSystem.BussinessLogicLayer
{
   public class Bidder:User
    {
        //Function to Register Register
        public void Register(string UserName, string Password, string Email, string Adrress, string Mobile)
        {
            Admin Delegator = new Admin();
            Delegator.add_Admin(UserName, Password, Email, Adrress , Mobile , "Bidder");
        }

        //Function to Bid 
        public void submit_Bid(Bid bid)
        {
            Bid BID = bid;

            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@sessionID", SqlDbType.Int);
            param[0].Value = BID.get_SessionID();

            param[1] = new SqlParameter("@bidderID", SqlDbType.Int);
            param[1].Value = BID.get_bidderID();

            param[2] = new SqlParameter("@BidValue", SqlDbType.Float);
            param[2].Value = BID.get_BidValue();


            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_SubmitBid", param);
            dataBaseHelperL.Close();

           
        }

        //Function to View Notify
        public DataTable view_NotificationStartedSessions()
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();

            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_View_Started_Session_Bidder", null);
            dataBaseHelperL.Close();

            return Dt;
        }

        //Function To View Session Details
        public DataTable view_Session_Deatails(int Session_Id)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@sessionID", SqlDbType.Int);
            param[0].Value = Session_Id;


            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_View_Session_Details_Bidder", param);
            dataBaseHelperL.Close();

            return Dt;
        }


        //Function To View Notifiction With Winner
        public DataTable view_NotificationWithWinner(int bidder_ID)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@bidderID", SqlDbType.Int);
            param[0].Value = bidder_ID;


            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_ResultWinner", param);
            dataBaseHelperL.Close();

            return Dt;
        }

        //Function To View Notifiction With Result Winner Or not 
        public DataTable view_NotificationWithSessionsResult()
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();

            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_Result", null);
            dataBaseHelperL.Close();

            return Dt;
        }


        //Function to pay
        public Invoice pay(int sessionID , int bidderID ,int CCNumber)
        {
            Bayment bay = new Bayment();

            bay.set_bidder_Id (bidderID);
            bay.set_credit_Number(CCNumber);


            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
           
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@sessionID", SqlDbType.Int);
            param[0].Value = sessionID;


            dataBaseHelperL.Open();
            dataBaseHelperL.ExecuteCommand("SP_pay", param);
            dataBaseHelperL.Close();

  
           Invoice invoice = bay.GenerateInvoice(sessionID);

           return invoice;

        }


    }
}
