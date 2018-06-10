using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAuctionSystem.BussinessLogicLayer
{
    class AuctionSession
    {
        //Attributes
        private int ID;
        private int Status;
        private int Seller_ID;
        private Item Item;


        //Setter & getter
        public void set_ID(int id)
        {
            this.ID = id;
        }

        public int get_ID()
        {
            return ID;
        }

        public void set_Seller_ID(int sid)
        {
            this.Seller_ID = sid;
        }

        public int get_Seller_ID()
        {
            return Seller_ID;
        }

        public void set_Status(int status)
        {
            this.Status = status;
        }

        public int get_Status()
        {
            return Status ;
        }

        public void  set_Item(Item itemm)
        {
            this.Item = itemm;
        }

        public Item get_Item()
        {
            return this.Item;
        }
            
    }
}
