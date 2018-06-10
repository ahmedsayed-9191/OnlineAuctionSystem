
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

namespace OnlineAuctionSystem.PresentationLayer
{
    public partial class FORM_VIEW_SESSIONS_SELLER : Form
    {
        //Create Seller Object 
        private Seller _Seller;

        public FORM_VIEW_SESSIONS_SELLER(Seller seller)
        {
            InitializeComponent();
            this._Seller = seller;
            //View Created Session To Subscribe one From them
            DataTable Dt1 = _Seller.ViewAvailableSessions("");
            this.dgvSubscribe.DataSource = Dt1;

            //view Subscribed Session To Add Item
            DataTable Dt2 =_Seller.ViewMySessions("",_Seller.getID());
            this.dgvMySession.DataSource = Dt2;

            //View Started Session To monitor Biding
            this.dgvMonitorBiding.DataSource = _Seller.ViewStartedSessions("", _Seller.getID());

            //View Session Result Session Results
            this.dgvSessionsResult.DataSource = _Seller.ViewSessionsResult("", _Seller.getID());



            //Check data Sources is empty
            if (Dt1.Rows.Count == 0)
            {
                btnSubscribe.Enabled = false;
            }

            if (Dt2.Rows.Count == 0)
            {
                btnAddItem.Enabled = false;
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchSubscribe_TextChanged(object sender, EventArgs e)
        {
            this.dgvSubscribe.DataSource = _Seller.ViewAvailableSessions(txtSearchSubscribe.Text);
        }


        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Subscribe this Session !", "Subscribe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //Get Session ID
                int Session_ID = Convert.ToInt32(  dgvSubscribe.CurrentRow.Cells[0].Value.ToString());

                //Subscribe Session
                _Seller.subscribe_Session(Session_ID , _Seller.getID());
                MessageBox.Show("Subscribed Successfully !", "Subscribed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvSubscribe.DataSource = _Seller.ViewAvailableSessions("") ;
                this.dgvMySession.DataSource = _Seller.ViewMySessions("", _Seller.getID()) ;
                btnAddItem.Enabled = true;
            }
        }

        private void txtMySession_TextChanged(object sender, EventArgs e)
        {
            this.dgvMySession.DataSource = _Seller.ViewMySessions(txtMySession.Text, _Seller.getID());
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Seller Id 
            int seller_id = _Seller.getID();
            
            //Selected Session Id
            int Session_ID = Convert.ToInt32(dgvMySession.CurrentRow.Cells[0].Value.ToString());

            //Check The Session Contain Item Or Not 
            DataTable Dt1 = new DataTable();
            //Database Instance
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Session_Id", SqlDbType.Int);
            param[0].Value = Session_ID;

            dataBaseHelperL.Open();
            Dt1 = dataBaseHelperL.SelectData("SP_ChekSessionNotContainItem", param);
            dataBaseHelperL.Close();
           
            
            //Session Not Contain Item
            if (Dt1.Rows.Count > 0)
            {
                FORM_ADD_ITEM_SELLER form_add_Item = new FORM_ADD_ITEM_SELLER(seller_id, Session_ID);
                form_add_Item.ShowDialog();
            }
            //Session  Contain Item
            else
            {
                MessageBox.Show("This Session Contain an Item !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void txtMonitorBiding_TextChanged(object sender, EventArgs e)
        {
            this.dgvMonitorBiding.DataSource = _Seller.ViewStartedSessions(txtMonitorBiding.Text, _Seller.getID());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchResult_TextChanged(object sender, EventArgs e)
        {
            this.dgvSessionsResult.DataSource = _Seller.ViewSessionsResult(txtSearchResult.Text, _Seller.getID());
        }
    }
}
