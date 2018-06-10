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
using System.Data.SqlClient;

namespace OnlineAuctionSystem.PresentationLayer
{
    public partial class FORM_VIEW_NOTIFICATION_SESSIONS_RESULTS : Form
    {
        //bidder ID
        private int _bidderID;
        private string _bidderUserName;


        public FORM_VIEW_NOTIFICATION_SESSIONS_RESULTS(int bidder_id ,string bidder_username)
        {
            InitializeComponent();
            _bidderID = bidder_id;
            _bidderUserName = bidder_username;
            DataTable DT = new Bidder().view_NotificationWithSessionsResult();
            dgvResult.DataSource = DT;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
