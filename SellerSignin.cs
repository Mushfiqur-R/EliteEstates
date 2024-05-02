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
                string query = @"INSERT INTO [dbo].[Seller]
                ([Username], [Password], [Email])
                VALUES
                (@Username, @Password, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", usernametxtsseller.Text);
                    cmd.Parameters.AddWithValue("@Email", Emailtxtseller.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordtxtsseller.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign in Successful");
                }
            }

            login back = new login();
            this.Hide();
            back.Show(this);
        }
    }
    }

