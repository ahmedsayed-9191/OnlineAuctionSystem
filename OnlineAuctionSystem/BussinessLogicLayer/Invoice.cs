using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAuctionSystem.BussinessLogicLayer
{
    public class Invoice
    {
        //Atrributes
        private int ID;
        private DateTime date;
        private string Seller;
        private string Buyer;
        private string ItemName;
        private string ItemDescription;
        private float Price;
        

        //Setter & Getter
        public void set_ID(int id)
        {
            this.ID = id;
        }

        public int  get_ID()
        {
            return ID;
        }

        public void set_ItemName(string ItemName)
        {
            this.ItemName = ItemName;
        }

        public string get_ItemName()
        {
            return ItemName;
        }

        public void set_Seller(string seller)
        {
            this.Seller = seller;
        }

        public string get_Seller()
        {
            return Seller;
        }

        public void set_Buyer(string buyer)
        {
            this.Buyer = buyer;
        }

        public string get_Buyer()
        {
            return Buyer;
        }

        public void set_ItemDescription(string itemDescription)
        {
            this.ItemDescription = itemDescription;
        }

        public string get_ItemDescription()
        {
            return ItemDescription;
        }

        public void set_price(float price)
        {
            this.Price = price;
        }

        public float get_Price()
        {
            return Price;
        }


        public void set_Date(DateTime date)
        {
            this.date = date;
        }

        public DateTime get_Date()
        {
            return date.Date;
        }

    }
}
