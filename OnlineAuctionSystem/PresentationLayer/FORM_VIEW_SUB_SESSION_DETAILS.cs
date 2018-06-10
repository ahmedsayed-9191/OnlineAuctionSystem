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
    public partial class FORM_VIEW_SUB_SESSION_DETAILS : Form
    {
        //Session Id
        private int _SessionID;
        private Admin _admin = new Admin();

        public FORM_VIEW_SUB_SESSION_DETAILS(int sessionId)
        {
            InitializeComponent();

            this._SessionID = sessionId;

            DataTable _Dt = new DataTable();
            _Dt = _admin.View_Session_Details(_SessionID);

            //Get Session Detail 
            txtSessionNum.Text = _Dt.Rows[0]["ID"].ToString();
            txtSessionName.Text = _Dt.Rows[0]["Session_Name"].ToString();
            txtSellerName.Text = _Dt.Rows[0]["Seller_Name"].ToString();
            txtItemName.Text = _Dt.Rows[0]["Item_Name"].ToString();
            txtDescription.Text = _Dt.Rows[0]["Description"].ToString();
            txtprice.Text = String.Format("{0:0.##}",Convert.ToSingle( _Dt.Rows[0]["Initial_Price"].ToString())) ;
            picItemPicture.Image = Image.FromStream(new MemoryStream(  (byte[])_Dt.Rows[0]["Image"] )) ;     





        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure To start Session !", "start", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                _admin.Start_AuctionSession(_SessionID);
                MessageBox.Show("Session Started Successfully", "Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStart.Enabled = false;
            }

        }
    }
}
