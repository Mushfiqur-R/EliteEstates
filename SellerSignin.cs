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
    public partial class SellerSignin : Form
    {
        public SellerSignin()
        {
            InitializeComponent();
        }

        private void backbtnseller_Click(object sender, EventArgs e)
        {
            login back=new login();
            back.Show();
            this.Hide();
        }

        private int GetSellerIdFromUsername(String username)
        {
            int sellerId = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "SELECT ID FROM Seller WHERE Username = @username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
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

        private void Confirmsignbtnseller_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxtsseller.Text))
            {
                MessageBox.Show("Username required!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordtxtsseller.Text))
            {
                MessageBox.Show("Please Provide Password!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(Emailtxtseller.Text))
            {
                MessageBox.Show("Email required!!");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;"))
            {
                con.Open();
                string query = @"INSERT INTO [dbo].[Seller]
                ([Username], [Password], [Email])
                VALUES
                (@Username, @Password, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", usernametxtsseller.Text);
                    cmd.Parameters.AddWithValue("@Email", Emailtxtseller.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordtxtsseller.Text);

                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Sign in Successful");
                }

                string balanceQuery = @"INSERT INTO SellerBalance (SellerId, SellerAmount) 
                VALUES (@SellerId, @SellerAmount);";
                using (SqlCommand cmd2 = new SqlCommand(balanceQuery, con))
                {
                    cmd2.Parameters.AddWithValue("@SellerId", GetSellerIdFromUsername(usernametxtsseller.Text));
                    cmd2.Parameters.AddWithValue("@SellerAmount", 0);

                    int val = cmd2.ExecuteNonQuery();

                    MessageBox.Show("Sign in Successful");
                }



            }

            login back = new login();
            this.Hide();
            back.Show(this);
        }
    }
    }

