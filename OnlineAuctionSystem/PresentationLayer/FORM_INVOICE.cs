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
    public partial class FORM_INVOICE : Form
    {
        public FORM_INVOICE(Invoice invoice)
        {
            InitializeComponent();
            lblnum.Text = Convert.ToString( invoice.get_ID());
            lblSname.Text = invoice.get_Seller();
            lblBname.Text = invoice.get_Buyer();
            lblItemName.Text = invoice.get_ItemName();
            lblDesc.Text = invoice.get_ItemDescription();
            lblPrice.Text = Convert.ToString( invoice.get_Price() )+ " $";
            lbldate.Text = Convert.ToString(invoice.get_Date().ToString("dd / MM / yyyy"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
