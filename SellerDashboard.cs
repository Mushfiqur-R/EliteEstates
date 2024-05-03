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
    public partial class SellerDashboard : Form
    {
        private int sellerId;
        private string sellerUsername;
        
        public SellerDashboard(int sellerId,string sellerUsername)
        {
            InitializeComponent();
            this.sellerId = sellerId;
            this.sellerUsername=sellerUsername;
            snamelbl.Text = sellerUsername; 
        }

        private void Addbtns_Click(object sender, EventArgs e)
        {
            Add_Product add=new Add_Product(sellerId,sellerUsername);
            add.Show();
            this.Hide();


        }

        private void snamelbl_Click(object sender, EventArgs e)
        {
           
        }
    }
}
