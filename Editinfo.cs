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
    public partial class Editinfo : Form
    {
        private int buyerId;
        public Editinfo(int buyerId)
        {
            InitializeComponent();
            this.buyerId = buyerId;
             DisplayCurrentUserInfo();
        }

        private void backbtneditinfo_Click(object sender, EventArgs e)
        {
            BuyerDashboard back = new BuyerDashboard(buyerId);
            back.Show();
            this.Hide();
        }

        private void changenamebtn_Click(object sender, EventArgs e)
        {
            string newUsername = changenametxtbox.Text.Trim();

            // Perform validation on the new username if needed
            if (!string.IsNullOrWhiteSpace(newUsername))
            {
                try
                {
                    string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";

                    // Establishing connection to the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Constructing SQL command to update the username
                        string updateQuery = "UPDATE Buyer SET Username = @NewUsername WHERE ID = @BuyerId";

                        // Creating SQL command object
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Adding parameters to the SQL command
                            command.Parameters.AddWithValue("@NewUsername", newUsername);
                            command.Parameters.AddWithValue("@BuyerId", buyerId);

                            // Executing the SQL command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Checking if any rows were affected
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Username changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to change username. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e) // update password confirm button
        {
            string newPassword = changepasstxtbox.Text.Trim();

            // Perform validation on the new password if needed
            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                try
                {
                    string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";

                    // Establishing connection to the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Constructing SQL command to update the password
                        string updateQuery = "UPDATE Buyer SET Password = @NewPassword WHERE ID = @BuyerId";

                        // Creating SQL command object
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Adding parameters to the SQL command
                            command.Parameters.AddWithValue("@NewPassword", newPassword);
                            command.Parameters.AddWithValue("@BuyerId", buyerId);

                            // Executing the SQL command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Checking if any rows were affected
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to change password. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCurrentUserInfo()
        {
            try
            {
                string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Username, Password, Email FROM Buyer WHERE ID = @BuyerId";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BuyerId", buyerId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display the current username in the text field
                                changenametxtbox.Text = reader["Username"].ToString();

                                // Display the current password in the text field
                                changepasstxtbox.Text = reader["Password"].ToString();

                                // Display the current email in the text field
                                changeemailtxt.Text = reader["Email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeemailbtn_Click(object sender, EventArgs e)
        {
            string newEmail = changeemailtxt.Text.Trim();

            // Perform validation on the new email if needed
            if (!string.IsNullOrWhiteSpace(newEmail) && IsValidEmail(newEmail))
            {
                try
                {
                    string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";

                    // Establishing connection to the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Constructing SQL command to update the email
                        string updateQuery = "UPDATE Buyer SET Email = @NewEmail WHERE ID = @BuyerId";

                        // Creating SQL command object
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Adding parameters to the SQL command
                            command.Parameters.AddWithValue("@NewEmail", newEmail);
                            command.Parameters.AddWithValue("@BuyerId", buyerId);

                            // Executing the SQL command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Checking if any rows were affected
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Email changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to change email. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to validate email address format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}