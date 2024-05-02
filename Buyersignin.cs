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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EliteEstates
{
    public partial class Buyersignin : Form
    {
        public Buyersignin()
        {
            InitializeComponent();
        }

        private void backbtnbuyer_Click(object sender, EventArgs e)
        {
            login back=new login();
            back.Show();
            this.Hide();
        }

        private void Confirmsignbtnbuyer_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrWhiteSpace(usernametxtbuyer.Text))
                {
                    MessageBox.Show("Username required!!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(passwordtxtsbuyer.Text))
                {
                    MessageBox.Show("Please Provide Password!!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Emailtxtbuyer.Text))
                {
                    MessageBox.Show("Email required!!");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;"))
                {
                string query = @"INSERT INTO [dbo].[Buyer]
                ([Username], [Password], [Email])
                VALUES
                (@Username, @Password, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", usernametxtbuyer.Text);
                        cmd.Parameters.AddWithValue("@Email", Emailtxtbuyer.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordtxtsbuyer.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sign in Successful");
                    }
                }

                login back=new login(); 
                this.Hide();
                back.Show(this);
            }
        }
    }

