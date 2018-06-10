using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OnlineAuctionSystem.BussinessLogicLayer;
using System.IO;

namespace OnlineAuctionSystem.PresentationLayer
{
    public partial class FORM_VIEW_BID_DETAILS_END_SESSION : Form
    {
        //Session Id
        private int _SessionID;
        private Admin _admin = new Admin();

        public FORM_VIEW_BID_DETAILS_END_SESSION(int Session_ID)
        {
            InitializeComponent();
            _SessionID = Session_ID;


            //Get Bid Details
            DataTable Dt = new DataTable();
            Dt = _admin.View_Bid_Details(_SessionID);

            txtItemName.Text = Dt.Rows[0]["Name"].ToString();
            txtItemDes.Text = Dt.Rows[0]["Description"].ToString();
            txtLastBid.Text = Dt.Rows[0]["FinalPrice"].ToString();
            picItemPicture.Image = Image.FromStream(new MemoryStream((byte[])Dt.Rows[0]["Image"]));

        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure To End Session !", "start", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                _admin.End_AuctionSession(_SessionID);
                MessageBox.Show("Session Ended Successfully", "Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEnd.Enabled = false;
            }
        }
    }
}
