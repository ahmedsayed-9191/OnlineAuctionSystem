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
    public partial class FORM_CEATE_SESSION : Form
    {
        //create Object validation
        Validation validation = new Validation();

        public FORM_CEATE_SESSION()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Valdiate Session Name
            if (txtSessionName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Session Name !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSessionName.Text.Count() >= 50)
            {
                MessageBox.Show("Please Enter a Correct Session Name !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check User Name Correctness
            bool checkNameCorrectness;
            checkNameCorrectness = validation.IsUserName(txtSessionName.Text);
            if (checkNameCorrectness == false)
            {
                MessageBox.Show("Please enter a correct Name !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check SessionName  Existence
            bool checkSessionName;
            checkSessionName = validation.IsSessionNameExist(txtSessionName.Text);
            if (checkSessionName == true ||txtSessionName.Text.Count()>=50)
            {
                MessageBox.Show("Please Enter Another Session Name!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSessionName.Focus();
                return;
            }



            //Create Session 
            Admin admin = new Admin();
            admin.create_AuctionSession(txtSessionName.Text);
            MessageBox.Show("Created Successfully !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSessionName.Clear();
            txtSessionName.Focus();
        }
    }
}
