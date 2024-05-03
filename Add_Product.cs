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

        private void confirmbtnaddproduct_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = setnametxt.Text;
                int price = Convert.ToInt32(setpricetxt.Text); // Assuming price is stored as int in database
                int totalRoom = Convert.ToInt32(setroomnumtxt.Text);
                string size = setsizetxt.Text;
                string location = locationtxtbox.Text;

                SellerDashboard sellerDashboard = new SellerDashboard(sellerId, sellerUsername);
                sellerDashboard.CreateNewProduct(productName, price, totalRoom, size, location);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
