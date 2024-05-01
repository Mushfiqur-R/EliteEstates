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
    public partial class Adminsignin : Form
    {
        public Adminsignin()
        {
            InitializeComponent();
        }

        private void backbtnadmin_Click(object sender, EventArgs e)
        {
            login back=new login();
            back.Show();
            this.Hide();
        }
    }
}
