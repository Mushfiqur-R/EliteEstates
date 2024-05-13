using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            DisplaySellerBalance();
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

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            login back=new login();
            back.Show();
            this.Hide();
        }

        private void sendcomplaintbtn_Click(object sender, EventArgs e)
        {
            SendComplaint send = new SendComplaint(sellerId,sellerUsername);
            send.Show();
            this.Hide();
        }

        private void Currentbalance_Click(object sender, EventArgs e)
        {

        }
        public void DisplaySellerBalance()
        {
            string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SellerAmount FROM SellerBalance WHERE SellerId = @SellerId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SellerId", sellerId); // Assuming you have the sellerId variable defined elsewhere
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value) // Check for null or DBNull.Value
                        {
                            // Convert result to decimal and set label text to balance value
                            decimal balance = Convert.ToDecimal(result);
                            Currentbalance.Text = balance.ToString(); // Display only the balance value
                        }
                        else
                        {
                            Currentbalance.Text = "0.00"; // Default to 0 if balance is not found
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching seller balance: " + ex.Message);
                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string productName = sellersearchbartxt.Text;

            if (!string.IsNullOrEmpty(productName))
            {
                ShowSearch showSearchForm = new ShowSearch(productName);
                showSearchForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter a product name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

