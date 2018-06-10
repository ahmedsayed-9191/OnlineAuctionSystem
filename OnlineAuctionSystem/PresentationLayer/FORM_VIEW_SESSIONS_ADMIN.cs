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
    public partial class FORM_VIEW_SESSIONS_ADMIN : Form
    {
        //create Admin object 
        Admin admin = new Admin();

        public FORM_VIEW_SESSIONS_ADMIN()
        {
            InitializeComponent();
            //View Session Created with status id 1 (Created)
        
            this.dgvSessionCreated.DataSource = admin.View_Sessions("",1);

            //View Session Created with status id 2 (Subscribed)
            DataTable Dt1 = admin.View_Sessions("", 2);
            this.dgvSubscribedSession.DataSource = Dt1 ;

            //View Session Started with status id 3 (started)
            DataTable Dt2 = admin.View_Sessions("", 3);
            this.dgvStartedSsesions.DataSource = Dt2;

            //Check data Sources is empty
            if (Dt1.Rows.Count == 0)
            {
                btnViewSessionDeatils.Enabled = false;
            }

            if (Dt2.Rows.Count == 0)
            {
                btnViewBidDeatils.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_CEATE_SESSION createSession = new FORM_CEATE_SESSION();
            createSession.ShowDialog();
            this.dgvSessionCreated.DataSource = admin.View_Sessions("", 1);
        }

        private void txtSeachCreated_TextChanged(object sender, EventArgs e)
        {
            this.dgvSessionCreated.DataSource = admin.View_Sessions(txtSeachCreated.Text, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchSubscribed_TextChanged(object sender, EventArgs e)
        {
            this.dgvSubscribedSession.DataSource = admin.View_Sessions(txtSearchSubscribed.Text, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Get Select Session ID
            int Session_Id = Convert.ToInt32(dgvSubscribedSession.CurrentRow.Cells[0].Value.ToString());

            //Check Session Contaion Item Or Not 
            DataTable Dt1 = new DataTable();
            //Database Instance
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Session_Id", SqlDbType.Int);
            param[0].Value = Session_Id;

            dataBaseHelperL.Open();
            Dt1 = dataBaseHelperL.SelectData("SP_ChekSessionNotContainItem", param);
            dataBaseHelperL.Close();


            //Session Not Contain Item
            if (Dt1.Rows.Count > 0)
            {
                MessageBox.Show("Please Wait No Item Added !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Session  Contain Item
            else
            {
                FORM_VIEW_SUB_SESSION_DETAILS formViewSubSess = new FORM_VIEW_SUB_SESSION_DETAILS(Session_Id);
                formViewSubSess.ShowDialog();
                this.dgvSubscribedSession.DataSource = admin.View_Sessions("", 2);
                this.dgvStartedSsesions.DataSource = admin.View_Sessions("", 3);
            }



        }

        private void txtSearchStarted_TextChanged(object sender, EventArgs e)
        {
            this.dgvStartedSsesions.DataSource = admin.View_Sessions(txtSearchStarted.Text, 3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Get Select Session ID
            int Session_Id = Convert.ToInt32(dgvStartedSsesions.CurrentRow.Cells[0].Value.ToString());

            //Check Bidder Make A bid on This Session
            Bid bid = new Bid();
            DataTable Dt = bid.checkLastBidderOnCurrentSession(Session_Id);

            if (Dt.Rows.Count == 0)
            {
                MessageBox.Show("Wait no one  Make A bid !", "Wait",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
            else
            {
                FORM_VIEW_BID_DETAILS_END_SESSION formViewBid = new FORM_VIEW_BID_DETAILS_END_SESSION(Session_Id);
                formViewBid.ShowDialog();

                this.dgvSubscribedSession.DataSource = admin.View_Sessions("", 2);
                this.dgvStartedSsesions.DataSource = admin.View_Sessions("", 3);


            }
        }


        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
