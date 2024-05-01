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
    public partial class Frontpage : Form
    {
        public Frontpage()
        {
            InitializeComponent();
        }

        private void Adminsigninbtn_Click(object sender, EventArgs e)
        {
            Adminsignin adminsignin = new Adminsignin();
            adminsignin.Show();
            this.Hide();
        }

        private void sellersigninbtn_Click(object sender, EventArgs e)
        {
            SellerSignin sellerSignin = new SellerSignin();
            sellerSignin.Show();
            this.Hide();
        }

        private void buyersignnbtn_Click(object sender, EventArgs e)
        {
            Buyersignin buyersignin = new Buyersignin();
            buyersignin.Show();
            this.Hide();
        }
    }
}
