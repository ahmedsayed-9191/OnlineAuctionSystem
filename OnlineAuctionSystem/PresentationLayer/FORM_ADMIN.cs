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
    public partial class FORM_ADMIN : Form
    {
        //AdminObject  
        private Admin _adminObject;

        public FORM_ADMIN(Admin admin)
        {
            InitializeComponent();
            //get admin object for login form sent as a parameter
            _adminObject = admin;
            lblUserName.Text = "Welcome : " + _adminObject.getUserName();

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            FORM_VIEW_USER viewUsers = new FORM_VIEW_USER(_adminObject);
            viewUsers.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_ADD_ADMIN add_admin = new FORM_ADD_ADMIN();
            add_admin.ShowDialog();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FORM_EDIT_PROFILE editProfile = new FORM_EDIT_PROFILE(_adminObject);
            editProfile.ShowDialog();
        }

        private void btnCreateSession_Click(object sender, EventArgs e)
        {
            FORM_CEATE_SESSION createSession = new FORM_CEATE_SESSION();
            createSession.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORM_VIEW_SESSIONS_ADMIN viewSession = new FORM_VIEW_SESSIONS_ADMIN();
            viewSession.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FORM_REPORT_SESSION_RESULTS viewReport = new FORM_REPORT_SESSION_RESULTS();
            viewReport.ShowDialog();
        }
    }
}
