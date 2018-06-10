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
    public partial class FORM_VIEW_USER : Form
    {
        //Create Admin Object
        private Admin admin;

        public FORM_VIEW_USER(Admin adminObj)
        {
            InitializeComponent();
            admin = adminObj;
            this.dgvAdmin.DataSource = admin.view_Users("","Admin");
            this.dgvSeller.DataSource = admin.view_Users("", "Seller");
            this.dgvBidder.DataSource = admin.view_Users("", "Bidder");
        }

        private void close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            this.dgvAdmin.DataSource = admin.view_Users(txtSearchAdmin.Text, "Admin");
        }

        private void txtSearchSeller_TextChanged(object sender, EventArgs e)
        {
            this.dgvSeller.DataSource = admin.view_Users(txtSearchSeller.Text, "Seller");
        }

        private void txtSearchBidder_TextChanged(object sender, EventArgs e)
        {
            this.dgvBidder.DataSource = admin.view_Users(txtSearchBidder.Text, "Bidder");
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Admin !","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (admin.getUserName() == dgvAdmin.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Can not Delete Your Self !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                admin.delete_Users(dgvAdmin.CurrentRow.Cells[0].Value.ToString(),"Admin");
                MessageBox.Show("Deleted Successfully !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvAdmin.DataSource = admin.view_Users("", "Admin");
            }
        }

        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Seller !", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                admin.delete_Users(dgvSeller.CurrentRow.Cells[0].Value.ToString(), "Seller");
                MessageBox.Show("Deleted Successfully !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvSeller.DataSource = admin.view_Users("", "Seller");
            }
        }

        private void btnDeleteBidder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Bidder !", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                admin.delete_Users(dgvBidder.CurrentRow.Cells[0].Value.ToString(), "Bidder");
                MessageBox.Show("Deleted Successfully !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvBidder.DataSource = admin.view_Users("", "Bidder");
            }
        }
    }
}
