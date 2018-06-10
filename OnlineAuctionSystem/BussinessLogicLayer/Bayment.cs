using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnlineAuctionSystem.BussinessLogicLayer
{
    class Bayment
    {
        //attributes
        private int credit_Number;
        private int bidder_Id;

        //setters & Getters
        public void set_credit_Number(int creNo)
        {
            this.credit_Number = creNo;
        }

        public int get_credit_Number()
        {
            return credit_Number;
        }


        public void set_bidder_Id(int bNo)
        {
            this.bidder_Id = bNo;
        }

        public double get_bidder_Id()
        {
            return bidder_Id;
        }

        
        
        //Function Generate Invoice
        public Invoice GenerateInvoice(int SessionId)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@sessionID", SqlDbType.Int);
            param[0].Value = SessionId;


            dataBaseHelperL.Open();
            Dt = dataBaseHelperL.SelectData("SP_GetInvoice", param);
            dataBaseHelperL.Close();

            int id =int .Parse( Dt.Rows[0]["Inovice Number"].ToString() );
            string seller = Dt.Rows[0]["Seller Name"].ToString();
            string bidder = Dt.Rows[0]["Bidder Name"].ToString();
            string itemName = Dt.Rows[0]["Item Name"].ToString();
            string itemDes = Dt.Rows[0]["Item Description"].ToString();
            float price = float.Parse( Dt.Rows[0]["Price"].ToString());
            DateTime date = Convert.ToDateTime(Dt.Rows[0]["Date"].ToString());


            Invoice invoice = new Invoice();
            invoice.set_ID(id);
            invoice.set_Seller(seller);
            invoice.set_Buyer(bidder);
            invoice.set_ItemName(itemName);
            invoice.set_ItemDescription(itemDes);
            invoice.set_price(price);
            invoice.set_Date(date);


            return invoice;
        }



    }
}
