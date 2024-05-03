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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void signinlink_Click(object sender, EventArgs e)
        {
            Frontpage go = new Frontpage();
            go.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True");

            if (usernametxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("Please Provide Username & Password");
            }
            else
            {
                string username = usernametxt.Text;
                string password = passwordtxt.Text;

                try
                {
                    string adminQuery = "SELECT * FROM Admin WHERE username = @Username AND password = @Password";
                    SqlDataAdapter adminAdapter = new SqlDataAdapter(adminQuery, con);
                    adminAdapter.SelectCommand.Parameters.AddWithValue("@Username", username);
                    adminAdapter.SelectCommand.Parameters.AddWithValue("@Password", password);
                    DataTable adminTable = new DataTable();
                    adminAdapter.Fill(adminTable);

                    // Check if the user exists in the buyer table
                    string buyerQuery = "SELECT * FROM Buyer WHERE username = @Username AND password = @Password";
                    SqlDataAdapter buyerAdapter = new SqlDataAdapter(buyerQuery, con);
                    buyerAdapter.SelectCommand.Parameters.AddWithValue("@Username", username);
                    buyerAdapter.SelectCommand.Parameters.AddWithValue("@Password", password);
                    DataTable buyerTable = new DataTable();
                    buyerAdapter.Fill(buyerTable);

                    // Check if the user exists in the seller table
                    string sellerQuery = "SELECT * FROM Seller WHERE username = @Username AND password = @Password";
                    SqlDataAdapter sellerAdapter = new SqlDataAdapter(sellerQuery, con);
                    sellerAdapter.SelectCommand.Parameters.AddWithValue("@Username", username);
                    sellerAdapter.SelectCommand.Parameters.AddWithValue("@Password", password);
                    DataTable sellerTable = new DataTable();
                    sellerAdapter.Fill(sellerTable);

                    // Determine the user type based on which table returned a result
                    if (buyerTable.Rows.Count > 0)
                    {
                        // Buyer login
                        BuyerDashboard buyerDashboard = new BuyerDashboard();
                        buyerDashboard.Show();
                        this.Hide();
                    }
                    /*  else if (sellerTable.Rows.Count > 0)
                      {
                          // Seller login
                          SellerDashboard sellerDashboard = new SellerDashboard();
                          sellerDashboard.Show();
                          this.Hide();
                      }*/
                    else if (sellerTable.Rows.Count > 0)
                    {
                        // Seller login
                        int sellerId = Convert.ToInt32(sellerTable.Rows[0]["ID"]);
                        string sellerUsername = sellerTable.Rows[0]["username"].ToString();//FOR USERNAME
                        SellerDashboard sellerDashboard = new SellerDashboard(sellerId,sellerUsername);
                        sellerDashboard.Show();
                        this.Hide();
                    }
                    else if (adminTable.Rows.Count > 0)
                    {
                        // Admin login
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username & Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }



        }
    }

}