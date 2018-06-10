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
    public partial class FORM_SELLER : Form
    {
        //Seller Object  
        private Seller _sellerObject;

        public FORM_SELLER(Seller seller)
        {
            InitializeComponent();
            //get admin object for login form sent as a parameter
            _sellerObject = seller;
            lblUserName.Text = "Welcome : " + _sellerObject.getUserName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FORM_EDIT_PROFILE editProfile = new FORM_EDIT_PROFILE(_sellerObject);
            editProfile.ShowDialog();
        }

        private void btnViewSession_Click(object sender, EventArgs e)
        {
            FORM_VIEW_SESSIONS_SELLER form_viewSessions = new FORM_VIEW_SESSIONS_SELLER(_sellerObject);
            form_viewSessions.ShowDialog();

        }
    }
}
