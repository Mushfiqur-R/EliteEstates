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
    public partial class SeeComplain : Form
    {
        private int adminId;
        public SeeComplain(int adminId)
        {
            InitializeComponent();
            DisplayComplain();
            this.adminId = adminId;
        }
        private void DisplayComplain()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT [ID]\r\n      ,[Complain]\r\n      ,[Sender ID]\r\n      ,[Date]\r\n  FROM [dbo].[complain]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Complaingrid.Columns.Clear();
                        Complaingrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving products: " + ex.Message);
            }
        }

        private void backbtncomplain_Click(object sender, EventArgs e)
        {
            AdminDashboard back=new AdminDashboard(adminId);
            back.Show();
            this.Hide();
        }
    }
}
