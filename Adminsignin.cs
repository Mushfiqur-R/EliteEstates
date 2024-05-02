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
    public partial class Adminsignin : Form
    {
        public Adminsignin()
        {
            InitializeComponent();
        }

        private void backbtnadmin_Click(object sender, EventArgs e)
        {
            login back=new login();
            back.Show();
            this.Hide();
        }

        private void Confirmsignbtnadmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxtsadmin.Text))
            {
                MessageBox.Show("Username required!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordtxtsadmin.Text))
            {
                MessageBox.Show("Please Provide Password!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(Emailtxtadmin.Text))
            {
                MessageBox.Show("Email required!!");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;"))
            {
                string query = @"INSERT INTO [dbo].[Admin]
                ([Username], [Password], [Email])
                VALUES
                (@Username, @Password, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", usernametxtsadmin.Text);
                    cmd.Parameters.AddWithValue("@Email", Emailtxtadmin.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordtxtsadmin.Text);

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

