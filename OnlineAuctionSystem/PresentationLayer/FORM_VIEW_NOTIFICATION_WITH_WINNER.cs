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
    public partial class FORM_VIEW_NOTIFICATION_WITH_WINNER : Form
    {
        private int _bidderID;
        DataTable DT = new DataTable();

        public FORM_VIEW_NOTIFICATION_WITH_WINNER(int bidder_ID)
        {
            InitializeComponent();
            _bidderID = bidder_ID;

           
            DT = new Bidder().view_NotificationWithWinner(_bidderID);

            dgvWinner.DataSource = DT;

            if (DT.Rows.Count == 0)
            {
                btnPay.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            int sesionId = int.Parse(dgvWinner.CurrentRow.Cells[0].Value.ToString());

            FORM_PAY_WINNER formPay = new FORM_PAY_WINNER(sesionId, _bidderID);
            formPay.ShowDialog();


            DT = new Bidder().view_NotificationWithWinner(_bidderID);
            dgvWinner.DataSource = DT;

            if (DT.Rows.Count == 0)
            {
                btnPay.Enabled = false;
            }

        }
    }
}
