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
    public partial class FORM_REPORT_SESSION_RESULTS : Form
    {
        public FORM_REPORT_SESSION_RESULTS()
        {
            InitializeComponent();
            dgvResult.DataSource = new Admin().view_Report();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
