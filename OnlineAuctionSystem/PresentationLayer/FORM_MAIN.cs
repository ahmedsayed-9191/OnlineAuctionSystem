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
    public partial class FORM_MAIN : Form
    {
        public FORM_MAIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_LOGIN formLogin = new FORM_LOGIN();
            formLogin.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORM_REGISTER formRegister = new FORM_REGISTER();
            formRegister.ShowDialog();
        }
    }
}
