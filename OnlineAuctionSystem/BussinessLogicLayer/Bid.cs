using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnlineAuctionSystem.BussinessLogicLayer
{
    public class Bid
    {
        //Attributes 
        private int ID;
        private int bidderID;
        private int SessionID;
        private float BidValue;

        //Setter & Getter 
        public void set_ID(int id)
        {
            this.ID = id;
        }

        public int get_ID()
        {
            return ID;
        }

        public void set_BidderID(int bidderid)
        {
            this.bidderID = bidderid;
        }

        public int get_bidderID()
        {
            return bidderID;
        }

        public void set_SessionID(int sessionID)
        {
            this.SessionID = sessionID;
        }

        public int get_SessionID()
        {
            return SessionID;
        }


        public void set_BidValue(float bidValue)
        {
            this.BidValue = bidValue;
        }

        public float get_BidValue()
        {
            return BidValue;
        }


        //function to Check Bid 
        public DataTable checkLastBidderOnCurrentSession(int SessionId)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Session_Id", SqlDbType.Int);
            param[0].Value = SessionId;


            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_LastBidder", param);
            dataBaseHelperL.Close();

            return Dt;
        }



    }
}
