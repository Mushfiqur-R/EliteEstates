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
    public partial class Showsearchbuyer : Form
    {
        private string productName;
        private string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True";
        public Showsearchbuyer(string productName)
        {
            InitializeComponent();
            this.productName = productName;
            LoadSearchResultsbuyer();
        }
        private void LoadSearchResultsbuyer()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT [Productname], [Price], [Totalroom], [Size], [Location], [ProductID], [SellerID], [Sellername]
                                     FROM [dbo].[Product]
                                     WHERE [Productname] LIKE @ProductName";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", "%" + productName + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    searchitemgridbuyer.Columns.Clear();

                    searchitemgridbuyer.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading search results: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

