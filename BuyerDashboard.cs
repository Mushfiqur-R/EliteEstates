using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DisplayAllProducts();
        }
        private void DisplayAllProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT ProductID, ProductName, Price, TotalRoom, Size, Location, SellerID, SellerName FROM Product";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        buyergridview.Columns.Clear();
                        buyergridview.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving products: " + ex.Message);
            }
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
