using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAuctionSystem.BussinessLogicLayer
{
    //Immutable Class
    public class Item
    {
        //Attributes
        private int ID;
        private string Name;
        private string Description;
        private byte[] Image;
        private float IntialPrice;
        private int Seller_ID;


        //the Constructor Is the only place to set Item Data
        public Item(int id , string name , string description , byte[] image , float price , int Seller_id)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.IntialPrice = price;
            this.Seller_ID = Seller_id;
        }
       
        //getters
        
        public int get_ID()
        {
            return ID;
        }

        public string get_Name()
        {
            return Name;
        }

        public string get_Description()
        {
            return Description;
        }

        public byte[] get_Image()
        {
            return Image;
        }
        
        public float get_IntialPrice()
        {
            return IntialPrice;
        }

        public int get_Seller_ID()
        {
            return Seller_ID;
        }


    }
}
