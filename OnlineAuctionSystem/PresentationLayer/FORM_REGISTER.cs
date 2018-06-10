using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineAuctionSystem.PresentationLayer
{
    public partial class FORM_REGISTER : Form
    {
        //create Object validation
        BussinessLogicLayer.Validation validation = new BussinessLogicLayer.Validation();


        public FORM_REGISTER()
        {
            InitializeComponent();
            Dictionary<String, String> menuItems = new Dictionary<String, String>() { { "Seller", "Seller" }, { "Bidder", "Bidder" }};
            comboUserType.DataSource = new BindingSource(menuItems,  null );
            comboUserType.DisplayMember = "Value";
            comboUserType.ValueMember = "Key";
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

            //check User Name Correctness
            bool checkUserNameCorrectness;
            checkUserNameCorrectness = validation.IsUserName(txtUserName.Text);
            if (checkUserNameCorrectness == false)
            {
                MessageBox.Show("Please enter a correct UserName !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check username Existence
            bool checkusername;
            checkusername = validation.IsUserName_Exist(txtUserName.Text);
            if (checkusername == true)
            {
                MessageBox.Show("Please Enter Another UserName !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }

            

            //Check Email Existence
            bool checkemail;
            checkemail = validation.IsEmail_Exist(txtEmail.Text);
            if (checkemail == true)
            {
                MessageBox.Show("Please enter another Email !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
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
            bool checkMobile;
            checkMobile = validation.IsMobile_Exist(txtMobile.Text);
            if (checkMobile == true)
            {
                MessageBox.Show("Please enter another Mobile Number !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobile.Focus();
                return;
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


            //variable to hold UserType
            string usertype = Convert.ToString(comboUserType.SelectedValue);

            if (usertype == "Seller")
            {
                BussinessLogicLayer.Seller seller = new BussinessLogicLayer.Seller();
                seller.Register(txtUserName.Text, txtPass.Text, txtEmail.Text, txtAddress.Text, txtMobile.Text);
                MessageBox.Show("You Are Register Successfully !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                BussinessLogicLayer.Bidder bidder = new BussinessLogicLayer.Bidder();
                bidder.Register(txtUserName.Text, txtPass.Text, txtEmail.Text, txtAddress.Text, txtMobile.Text);
                MessageBox.Show("You Are Register Successfully !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
