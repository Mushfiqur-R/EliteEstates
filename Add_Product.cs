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
    public partial class Add_Product : Form
    {
        private int sellerId;
        private string sellerUsername;

        public Add_Product(int sellerId, string sellerUsername)
        {
            InitializeComponent();
            this.sellerId = sellerId;
            this.sellerUsername = sellerUsername;
        }

        private void backbtnaddproduct_Click(object sender, EventArgs e)
        {
            SellerDashboard back=new SellerDashboard(sellerId,sellerUsername);
            back .Show();
            this.Hide();
        }
    }
}
