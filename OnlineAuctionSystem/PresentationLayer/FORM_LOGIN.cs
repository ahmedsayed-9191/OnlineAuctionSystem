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
    public partial class FORM_LOGIN : Form
    {
        //create Object validation
        BussinessLogicLayer.Validation validation = new BussinessLogicLayer.Validation();

        public FORM_LOGIN()
        {
            InitializeComponent();
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Copmlete logining data ! ","Complete",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // Check If username exist in admin
            bool checkinAdmin;
            checkinAdmin = validation.IsUserName_ExistInAdmin(txtUserName.Text);

            // Check If username exist in admin
            bool checkinBidder;
            checkinBidder = validation.IsUserName_ExistInBidder(txtUserName.Text);

            // Check If username exist in admin
            bool checkinSeller;
            checkinSeller = validation.IsUserName_ExistInSeller(txtUserName.Text);

            //Admin
            if (checkinAdmin == true)
            {
                BussinessLogicLayer.Admin adminObj = new BussinessLogicLayer.Admin();
                DataTable Dt = adminObj.LOGIN(txtUserName.Text, txtPassword.Text, "Admin");

                if (Dt.Rows.Count > 0)
                {
                    // fetch admin data 
                    int id = 0;
                    string username="";
                    string password="";
                    string email = "";
                    string address = "";
                    string mobile = "";
                    string userType = "Admin";

                    foreach (DataRow row in Dt.Rows)
                    {
                        id = Convert.ToInt32(row["ID"].ToString());
                        username = row["UserName"].ToString();
                        password = row["Password"].ToString();
                        email = row["Email"].ToString();
                        address = row["Address"].ToString();
                        mobile = row["Mobile"].ToString();
                    }

                    // fill admin object
                    adminObj.setID(id);
                    adminObj.setUserName(username);
                    adminObj.setPassword(password);
                    adminObj.setEmail(email);
                    adminObj.setAddress(address);
                    adminObj.setMobile(mobile);
                    adminObj.setUserType(userType);
                    //Close login Form And Open Admin Form
                    this.Hide();
                    this.Close();
                    FORM_ADMIN form_Admin = new FORM_ADMIN(adminObj);
                    form_Admin.ShowDialog();

                    return;

                }
                else
                {
                    MessageBox.Show("InCorrect Password !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Bidder
            else if (checkinBidder == true)
            {
                BussinessLogicLayer.Bidder bidderObj = new BussinessLogicLayer.Bidder();
                DataTable Dt = bidderObj.LOGIN(txtUserName.Text, txtPassword.Text, "Bidder");

                if (Dt.Rows.Count > 0)
                {
                    // fetch bidder data 
                    int id = 0;
                    string username = "";
                    string password = "";
                    string email = "";
                    string address = "";
                    string mobile = "";
                    string userType = "Bidder";
                    foreach (DataRow row in Dt.Rows)
                    {
                        id = Convert.ToInt32(row["ID"].ToString());
                        username = row["UserName"].ToString();
                        password = row["Password"].ToString();
                        email = row["Email"].ToString();
                        address = row["Address"].ToString();
                        mobile = row["Mobile"].ToString();
                    }

                    // fill Bidder object
                    bidderObj.setID(id);
                    bidderObj.setUserName(username);
                    bidderObj.setPassword(password);
                    bidderObj.setEmail(email);
                    bidderObj.setAddress(address);
                    bidderObj.setMobile(mobile);
                    bidderObj.setUserType(userType);

                    //Close login Form And Open Admin Form
                    this.Hide();
                    this.Close();
                    FORM_BIDDER form_Admin = new FORM_BIDDER(bidderObj);
                    form_Admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("InCorrect Password !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            //Seller
            else if (checkinSeller == true)
            {
                BussinessLogicLayer.Seller sellerObj = new BussinessLogicLayer.Seller();
                DataTable Dt = sellerObj.LOGIN(txtUserName.Text, txtPassword.Text, "Seller");

                if (Dt.Rows.Count > 0)
                {
                    // fetch Seller data 
                    int id = 0;
                    string username = "";
                    string password = "";
                    string email = "";
                    string address = "";
                    string mobile = "";
                    string userType = "Seller";

                    foreach (DataRow row in Dt.Rows)
                    {
                        id = Convert.ToInt32(row["ID"].ToString());
                        username = row["UserName"].ToString();
                        password = row["Password"].ToString();
                        email = row["Email"].ToString();
                        address = row["Address"].ToString();
                        mobile = row["Mobile"].ToString();
                    }

                    // fill admin object
                    sellerObj.setID(id);
                    sellerObj.setUserName(username);
                    sellerObj.setPassword(password);
                    sellerObj.setEmail(email);
                    sellerObj.setAddress(address);
                    sellerObj.setMobile(mobile);
                    sellerObj.setUserType(userType);

                    //Close login Form And Open Admin Form
                    this.Hide();
                    this.Close();
                    FORM_SELLER form_Admin = new FORM_SELLER(sellerObj);
                    form_Admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("InCorrect Password !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("InCorrect UserName ! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
