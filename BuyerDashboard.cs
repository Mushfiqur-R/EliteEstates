using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteEstates
{
    public partial class BuyerDashboard : Form
    {
        public BuyerDashboard()
        {
            InitializeComponent();
        }

        private void sendcomplaintbtnbuyer_Click(object sender, EventArgs e)
        {
            SendComplaint send=new SendComplaint(); 
            send.Show();
            this.Hide();
        }

        private void logoutbtnbuyer_Click(object sender, EventArgs e)
        {
            login back=new login();
            back.Show();
            this.Hide();    
        }
    }
}
