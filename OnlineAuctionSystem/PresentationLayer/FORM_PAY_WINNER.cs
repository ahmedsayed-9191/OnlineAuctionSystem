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
    public partial class FORM_PAY_WINNER : Form
    {
        //session ID and winner Id
        private int _sessionID;
        private int _bidderID;

        //create Object validation
        Validation validation = new Validation();


        public FORM_PAY_WINNER(int sessionID , int bidderID)
        {
            InitializeComponent();
            _sessionID = sessionID;
            _bidderID = bidderID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtCCnumber.Text == string.Empty)
            {
                MessageBox.Show("Please Enter The CC Number !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check mobile Correctness
            bool checkCCNumberCorrectness;
            checkCCNumberCorrectness = validation.IsIntNumber(txtCCnumber.Text);
            if (checkCCNumberCorrectness == false)
            {
                MessageBox.Show("Enter a Correct CC Number !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Bidder Object to Pay
            Bidder bidder = new Bidder();
            Invoice invoice = bidder.pay(_sessionID, _bidderID, int.Parse(txtCCnumber.Text));
            this.Close();
            FORM_INVOICE formInvoice = new FORM_INVOICE(invoice);
            formInvoice.ShowDialog();
        }
    }
}
