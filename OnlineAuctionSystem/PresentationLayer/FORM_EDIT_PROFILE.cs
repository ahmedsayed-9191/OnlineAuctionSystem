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
    public partial class FORM_EDIT_PROFILE : Form
    {   
        // User Object
        private User _userObj;

        //create Object validation
        Validation validation = new Validation();

        public FORM_EDIT_PROFILE(User user)
        {
            InitializeComponent();
            _userObj = user;
            txtUserName.Text = _userObj.getUserName();
            txtPass.Text = _userObj.getPassword();
            txtConfirmpass.Text = _userObj.getPassword();
            txtEmail.Text = _userObj.getEmail();
            txtAddress.Text = _userObj.getAddress();
            txtMobile.Text = _userObj.getMobile();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty || txtPass.Text == string.Empty || txtConfirmpass.Text == string.Empty
                || txtEmail.Text == string.Empty || txtPass.Text == string.Empty || txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Complete Data !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check confirmation of the password
            if (txtPass.Text != txtConfirmpass.Text)
            {
                MessageBox.Show("Two Passowrd Not Identical", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check Email Existence if Changed
            if (_userObj.getEmail() != txtEmail.Text)
            {
                bool checkemail;
                checkemail = validation.IsEmail_Exist(txtEmail.Text);
                if (checkemail == true)
                {
                    MessageBox.Show("Please enter another Email !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
            }
            //Check Email Correctness
            bool checkemailCorrectness;
            checkemailCorrectness = validation.IsValidEmail(txtEmail.Text);
            if (checkemailCorrectness == false)
            {
                MessageBox.Show("Enter a Correct Email !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //Check Mobile Existence
            if (_userObj.getMobile() != txtMobile.Text)
            {
                bool checkMobile;
                checkMobile = validation.IsMobile_Exist(txtMobile.Text);
                if (checkMobile == true)
                {
                    MessageBox.Show("Please enter another Mobile Number !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMobile.Focus();
                    return;
                }
            }

            //Check mobile Correctness
            bool checkphoneCorrectness;
            checkphoneCorrectness = validation.IsIntNumber(txtMobile.Text);
            if (checkphoneCorrectness == false)
            {
                MessageBox.Show("Enter a Correct Mobile Number !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Check Address Correctness
            bool checkaddress;
            checkaddress = validation.IsAddres(txtAddress.Text);
            if (checkaddress == false)
            {
                MessageBox.Show("Enter a Correct Address !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //update data 

            _userObj.setPassword(txtPass.Text);
            _userObj.setEmail(txtEmail.Text);
            _userObj.setAddress(txtAddress.Text);
            _userObj.setMobile(txtMobile.Text);

            //call function EditProfile to Update
            _userObj.EditProfile(_userObj);

            MessageBox.Show("Updated Successfully !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
