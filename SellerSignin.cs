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
    public partial class SellerSignin : Form
    {
        public SellerSignin()
        {
            InitializeComponent();
        }

        private void backbtnseller_Click(object sender, EventArgs e)
        {
            login back=new login();
            back.Show();
            this.Hide();
        }
    }
}
