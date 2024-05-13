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
        private int buyerId;
        private string buyerName;
        public BuyerDashboard(int buyerId, string buyerName)
        {
            InitializeComponent();
            this.buyerId = buyerId;
            DisplayAllProducts();
            Displaybalance();
            this.buyerName = buyerName;
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
            SendComplaint send = new SendComplaint(buyerId,buyerName);
            send.Show();
            this.Hide();
        }

        private void logoutbtnbuyer_Click(object sender, EventArgs e)
        {
            login back = new login();
            back.Show();
            this.Hide();
        }

        private void Addcash_Click(object sender, EventArgs e)
        {
            Inputcashammount insert=new Inputcashammount(buyerId, buyerName);
            insert.Show();  
            this.Hide();
        }

        private void Currentbalancebuyer_Click(object sender, EventArgs e)
        {
            /* string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";
             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 try
                 {
                     connection.Open();

                     string query = "SELECT Balance FROM BuyerBalance WHERE BuyerID = @BuyerID";
                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         command.Parameters.AddWithValue("@BuyerID", buyerId);
                         object result = command.ExecuteScalar();

                         if (result != null && result != DBNull.Value) // Check for null or DBNull.Value
                         {
                             // Convert result to decimal and set label text to balance value
                             decimal balance = Convert.ToDecimal(result);
                             Currentbalancebuyer.Text = balance.ToString(); // Display only the balance value
                         }
                         else
                         {
                             Currentbalancebuyer.Text = "0.00"; // Default to 0 if balance is not found
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error fetching balance: " + ex.Message);
                 }*/
            Displaybalance();
        
            }
        
        private void Displaybalance()
        {
            string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Balance FROM BuyerBalance WHERE BuyerID = @BuyerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BuyerID", buyerId);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value) // Check for null or DBNull.Value
                        {
                            // Convert result to decimal and set label text to balance value
                            decimal balance = Convert.ToDecimal(result);
                            Currentbalancebuyer.Text = balance.ToString(); // Display only the balance value
                        }
                        else
                        {
                            Currentbalancebuyer.Text = "0.00"; // Default to 0 if balance is not found
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching balance: " + ex.Message);
                }
            }
        }

        private void editbtnbuyer_Click(object sender, EventArgs e)
        {
            Editinfo edit=new Editinfo(buyerId, buyerName);
            edit.Show();
            this.Hide();
        }

        private void buybtn_Click(object sender, EventArgs e)
        {
            Buyitem buyitem = new Buyitem(buyerId, buyerName);
            buyitem.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
        }
    }
    }
    
