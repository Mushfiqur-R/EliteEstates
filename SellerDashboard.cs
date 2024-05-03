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
            DisplaySellerProducts();//display method call for show data in gridview
        }

        //show data in gridview
        private void DisplaySellerProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT ProductID,ProductName, Price, TotalRoom, Size, Location, SellerID, SellerName FROM Product WHERE SellerID = @SellerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SellerID", sellerId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gridinsellerboard.Columns.Clear();

                        // Bind data to DataGridView
                        //gridinsellerboard.DataSource = dataTable.Tables[0];

                        // Bind the DataTable to the DataGridView
                       gridinsellerboard.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving seller's products: " + ex.Message);
            }
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
        //method is create here  //////////////
        public void CreateNewProduct(string productName, int price, int totalRoom, string size, string location)
        {
            try
            {
                int sellerId = GetSellerId(sellerUsername);
                string sellerName = GetSellerName(sellerUsername);

                InsertProductIntoDatabase(productName, price, totalRoom, size, location, sellerId, sellerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetSellerId(string sellerUsername)
        {
            int sellerId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT ID FROM Seller WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", sellerUsername);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            sellerId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving seller's ID: " + ex.Message);
            }

            return sellerId;
        }

        private string GetSellerName(string sellerUsername)
        {
            string sellerName = "";

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT Username FROM Seller WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", sellerUsername);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            sellerName = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving seller's name: " + ex.Message);
            }

            return sellerName;
        }

        private void InsertProductIntoDatabase(string productName, int price, int totalRoom, string size, string location, int sellerId, string sellerName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();

                    string query = @"INSERT INTO Product (ProductName, Price, TotalRoom, Size, Location, SellerID, SellerName) 
                                    VALUES (@ProductName, @Price, @TotalRoom, @Size, @Location, @SellerID, @SellerName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@TotalRoom", totalRoom);
                        command.Parameters.AddWithValue("@Size", size);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@SellerID", sellerId);
                        command.Parameters.AddWithValue("@SellerName", sellerName);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product created successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the product.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

