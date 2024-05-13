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
    public partial class AdminDashboard : Form
    {
        private int adminId;
        public AdminDashboard(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            Displayadminbalance();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)//admin balance show label
        {

        }

        private void transectionbtnadmin_Click(object sender, EventArgs e)
        {
            TransectionHistory see=new TransectionHistory(adminId);
            see.Show();
            this.Hide();
        }
        public void Displayadminbalance()
        {
            string connectionString = "Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Balance FROM AdminBalance WHERE AdminId = @AdminId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdminId", adminId);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value) // Check for null or DBNull.Value
                        {
                            // Convert result to decimal and set label text to balance value
                            decimal balance = Convert.ToDecimal(result);
                            label3.Text = balance.ToString(); // Display only the balance value
                        }
                        else
                        {
                            label3.Text = "0.00"; // Default to 0 if balance is not found
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching admin balance: " + ex.Message);
                }
            }
        }

        private void seecomplainbtnadmin_Click(object sender, EventArgs e)
        {
            SeeComplain see=new SeeComplain(adminId);
            see.Show();
            this.Hide();
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            login back=new login();
            back.Show();
            this.Hide();
        }
    }
}
