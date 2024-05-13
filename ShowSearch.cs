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
   
    public partial class ShowSearch : Form
    {
        private string productName;
        private string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"; // Replace with your actual connection string

        public ShowSearch(string productName)
        {
            InitializeComponent();
            this.productName = productName;
           // LoadSearchResults();
        }
    }
}
