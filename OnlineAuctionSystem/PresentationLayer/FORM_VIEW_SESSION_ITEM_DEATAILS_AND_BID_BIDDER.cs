using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineAuctionSystem.BussinessLogicLayer;
using System.IO;
namespace OnlineAuctionSystem.PresentationLayer
{
    public partial class FORM_VIEW_SESSION_ITEM_DEATAILS_AND_BID_BIDDER : Form
    {
        //Session ID
        private int _sessionId;
        //Bidder ID
        private int _bidderId;

        //Bid Object
        Bid _Bid = new Bid(); 


        public FORM_VIEW_SESSION_ITEM_DEATAILS_AND_BID_BIDDER(int Session_Id , int bidder_Id)
        {
            InitializeComponent();
            _sessionId = Session_Id;
            _bidderId = bidder_Id;

            DataTable Dt = new DataTable();
            Bidder bidder = new Bidder();

            Dt = bidder.view_Session_Deatails(_sessionId);

            txtItemName.Text = Dt.Rows[0]["Name"].ToString();
            txtItemDes.Text = Dt.Rows[0]["Description"].ToString();
            txtLastBid.Text = Dt.Rows[0]["FinalPrice"].ToString();
            picItemPicture.Image = Image.FromStream(new MemoryStream((byte[])Dt.Rows[0]["Image"]));

        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBid_Click(object sender, EventArgs e)
        {

            //Check Last bidder on this session
            DataTable dt = _Bid.checkLastBidderOnCurrentSession(_sessionId);

            if (dt.Rows.Count != 0)
            {
                int lastBidderID = int.Parse(dt.Rows[0]["BidderID"].ToString());

                if (lastBidderID == _bidderId)
                {
                    MessageBox.Show("Please Wait For Another Bidder Make him Bid ! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
   
            //create Object validation
            Validation validation = new Validation();

            if (txtBid.Text == string.Empty)
            {
                MessageBox.Show("Please enter A Bid ! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Check price Correctness
            bool checkPrice;
            checkPrice = (validation.IsPrice(txtBid.Text) );
            if (checkPrice == false)
            {
                MessageBox.Show("Please enter A Correct Price ! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Check price Correctness
            bool checkBid = true;
            if (Convert.ToSingle(txtBid.Text) <= Convert.ToSingle(txtLastBid.Text))
            {
                checkBid = false;
            }

            if (checkBid == false)
            {
                MessageBox.Show("Please enter A Bid  More than The Last Bid ! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Set  Bid state 
            float bid = Convert.ToSingle(txtBid.Text);

            _Bid.set_SessionID(_sessionId);
            _Bid.set_BidderID(_bidderId);
            _Bid.set_BidValue(bid);


            Bidder bidder = new Bidder();
            bidder.submit_Bid(_Bid);
            MessageBox.Show("Bid Success !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLastBid.Text = txtBid.Text;


        }
    }
}
