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
    public partial class AdminDashboard : Form
    {
        private int adminId;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void transectionbtnadmin_Click(object sender, EventArgs e)
        {
            TransectionHistory see=new TransectionHistory();
            see.Show();
            this.Hide();
        }

        private void seecomplainbtnadmin_Click(object sender, EventArgs e)
        {
            SeeComplain see=new SeeComplain();
            see.Show();
            this.Hide();
        }
    }
}
