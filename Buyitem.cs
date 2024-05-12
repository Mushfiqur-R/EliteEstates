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
    public partial class Buyitem : Form
    {
        private int buyerId;
        private decimal buyerBalance;
        private decimal adminCommission = 0.05m;
        public Buyitem(int buyerId)
        {
            InitializeComponent();
            this.buyerId = buyerId;
            LoadBuyerBalance();
        }
        private void LoadBuyerBalance()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "SELECT Balance FROM BuyerBalance WHERE BuyerId = @BuyerId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BuyerId", buyerId);
                        buyerBalance = (decimal)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving buyer balance: " + ex.Message);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)//confirm button in buyitem
        {
            int productId = int.Parse(selectitemforbuy.Text);
            decimal productPrice = GetProductPrice(productId);

            if (buyerBalance >= productPrice)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();

                        // Update buyer balance
                        string updateBuyerQuery = "UPDATE BuyerBalance SET Balance = Balance - @ProductPrice WHERE BuyerID = @BuyerId";
                        using (SqlCommand updateBuyerCommand = new SqlCommand(updateBuyerQuery, connection, transaction))
                        {
                            updateBuyerCommand.Parameters.AddWithValue("@ProductPrice", productPrice);
                            updateBuyerCommand.Parameters.AddWithValue("@BuyerId", buyerId);
                            int rowsAffected = updateBuyerCommand.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Error updating buyer balance.");
                                transaction.Rollback();
                                return;
                            }
                        }

                        // Update seller balance
                        int sellerId = GetSellerIdForProduct(productId);
                        Console.WriteLine(sellerId);
                        decimal sellerAmount = productPrice * (1 - adminCommission);
                        string updateSellerQuery = "UPDATE SellerBalance SET SellerAmount = SellerAmount + @SellerAmount WHERE SellerId = @SellerId";
                        using (SqlCommand updateSellerCommand = new SqlCommand(updateSellerQuery, connection, transaction))
                        {
                            updateSellerCommand.Parameters.AddWithValue("@SellerAmount", sellerAmount);
                            updateSellerCommand.Parameters.AddWithValue("@SellerId", sellerId);
                            int rowsAffected = updateSellerCommand.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Error updating seller balance.");
                                transaction.Rollback();
                                return;
                            }
                        }

                        // Update admin balance
                        decimal adminAmount = productPrice * adminCommission;
                        string updateAdminQuery = "UPDATE AdminBalance SET Balance = Balance + @AdminAmount WHERE AdminId = @AdminId";
                        using (SqlCommand updateAdminCommand = new SqlCommand(updateAdminQuery, connection, transaction))
                        {
                            updateAdminCommand.Parameters.AddWithValue("@AdminAmount", adminAmount);
                            updateAdminCommand.Parameters.AddWithValue("@AdminId", 20);
                            int rowsAffected = updateAdminCommand.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Error updating admin balance.");
                                transaction.Rollback();
                                return;
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Purchase successful!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing purchase: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Insufficient balance. Please deposit more funds.");
            }
        }
        private int GetSellerIdForProduct(int productId)
        {
            int sellerId = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "SELECT SellerID FROM Product WHERE ProductID = @ProductId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            sellerId = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving seller ID: " + ex.Message);
            }

            return sellerId;
        }

        

        private decimal GetProductPrice(int productId)
        {
            int productPrice = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "SELECT Price FROM Product WHERE ProductID = @ProductId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            productPrice = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving product price: " + ex.Message);
            }

            return productPrice;
        }
    }
}