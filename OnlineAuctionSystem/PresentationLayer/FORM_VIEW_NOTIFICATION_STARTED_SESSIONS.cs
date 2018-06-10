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

namespace OnlineAuctionSystem.PresentationLayer
{
    public partial class FORM_VIEW_NOTIFICATION_STARTED_SESSIONS : Form
    {
        //use bidderid and sessionid fo bidding 
         
        private int _BidderrID;
        private int _SessionID;

        public FORM_VIEW_NOTIFICATION_STARTED_SESSIONS(int bidderId)
        {
            InitializeComponent();
            this._BidderrID = bidderId;
            DataTable DT = new Bidder().view_NotificationStartedSessions();
            this.dgvStartedSession.DataSource = DT;

            //Check If data Grid View Not Contain Data
            if (DT.Rows.Count== 0)
            {
                btnViewDetails.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            _SessionID = int.Parse(dgvStartedSession.CurrentRow.Cells[0].Value.ToString());

            FORM_VIEW_SESSION_ITEM_DEATAILS_AND_BID_BIDDER formViewSession = new FORM_VIEW_SESSION_ITEM_DEATAILS_AND_BID_BIDDER(_SessionID,_BidderrID);
            formViewSession.ShowDialog();
        }
    }
}
