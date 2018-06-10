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
    public partial class FORM_BIDDER : Form
    {
        //Bidder Object  
        private Bidder _bidderObject;

        public FORM_BIDDER(Bidder bidder)
        {
            InitializeComponent();
            //get admin object for login form sent as a parameter
            _bidderObject = bidder;
            lblUserName.Text = "Welcome : " + _bidderObject.getUserName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FORM_EDIT_PROFILE editProfile = new FORM_EDIT_PROFILE(_bidderObject);
            editProfile.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_VIEW_NOTIFICATION_STARTED_SESSIONS formNotificationStart = new FORM_VIEW_NOTIFICATION_STARTED_SESSIONS(_bidderObject.getID());
            formNotificationStart.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORM_VIEW_NOTIFICATION_SESSIONS_RESULTS formNotificationResult = new FORM_VIEW_NOTIFICATION_SESSIONS_RESULTS(_bidderObject.getID(),_bidderObject.getUserName());
            formNotificationResult.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FORM_VIEW_NOTIFICATION_WITH_WINNER formViewWinner = new FORM_VIEW_NOTIFICATION_WITH_WINNER(_bidderObject.getID());
            formViewWinner.ShowDialog();
        }
    }
}
