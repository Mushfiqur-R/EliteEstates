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
    public partial class TransectionHistory : Form
    {
        public TransectionHistory()
        {
            InitializeComponent();
            DisplayTransection();
        }
        private void DisplayTransection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT [BuyerID]\r\n      ,[SellerID]\r\n      ,[ProductPrice]\r\n      ,[Transectionnumber]\r\n      ,[TransectionID]\r\n      ,[ProductID]\r\n  FROM [dbo].[TransectionHistory]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        transecthistory.Columns.Clear();
                        transecthistory.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving products: " + ex.Message);
            }
        }

        private void backbtninputammount_Click(object sender, EventArgs e)
        {
            AdminDashboard back=new AdminDashboard();
            back.Show();    
            this.Close();
        }
    }
}
