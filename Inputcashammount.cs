using Guna.UI.WinForms;
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
    public partial class Inputcashammount : Form
    {

        private int buyerId;
        private string buyerName;
        public Inputcashammount(int buyerId, string buyerName)
        {
            InitializeComponent();
            this.buyerId = buyerId;
            this.buyerName = buyerName;
        }

        private void gunaButton1_Click(object sender, EventArgs e)//inter ammount confirm button
        {
            double enteredAmount;
            if (double.TryParse(selectammountdeposit.Text, out enteredAmount))
            {
                // Connect to the database
                string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the buyer record exists in the BuyerBalance table
                    string checkQuery = "SELECT COUNT(*) FROM BuyerBalance WHERE BuyerID = @BuyerID";
                    using (SqlCommand command = new SqlCommand(checkQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BuyerID", buyerId);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            // Update the existing record
                            string updateQuery = "UPDATE BuyerBalance SET Balance = Balance + @Amount WHERE BuyerID = @BuyerID";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@Amount", enteredAmount);
                                updateCommand.Parameters.AddWithValue("@BuyerID", buyerId);
                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cash deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to deposit cash. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            // Insert a new record
                            string insertQuery = "INSERT INTO BuyerBalance (BuyerID, Balance) VALUES (@BuyerID, @Balance)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@BuyerID", buyerId);
                                insertCommand.Parameters.AddWithValue("@Balance", enteredAmount);
                                int rowsAffected = insertCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cash deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to deposit cash. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid amount entered. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtninputammount_Click(object sender, EventArgs e)
        {
            BuyerDashboard back=new BuyerDashboard(buyerId,buyerName);
            back.Show();
            this.Hide();
        }
    }
}

