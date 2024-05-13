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
    public partial class SendComplaint : Form
    {
        private int buyerId;
        private int sellerId;
        private string sellerUsername;
        private bool isSeller;
        private string buyerName;
        /*   public SendComplaint(int buyerId)
           {
               InitializeComponent();
               this.buyerId=buyerId;
               this.sellerId = 0;
           }
           public SendComplaint(int sellerId)
           {
               InitializeComponent();
               this.sellerId=sellerId;
               this.buyerId = 0;
           }*/
        public SendComplaint(int userId, string username, bool isSeller = false)
        {
            InitializeComponent();
            this.sellerUsername = username;
            this.buyerName = username;

            if (isSeller)
            {
                this.sellerId = userId;
                this.buyerId = 0;

            }
            else
            {
                this.buyerId = userId;
                this.sellerId = 0;
            }
        }

        private void Sendcomplaintbtn_Click(object sender, EventArgs e)
        {
            string complaintMessage = complaintboxtxt.Text;
            int senderId = buyerId == 0 ? sellerId : buyerId;

            // Create a SQL connection and command
            using (SqlConnection connection = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;"))
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                connection.Open();

                // Insert the complaint into the database
                command.CommandText = "INSERT INTO [dbo].[complain] ([Complain], [Sender ID], [Date]) VALUES (@Message, @SenderID, @Date)";
                command.Parameters.AddWithValue("@Message", complaintMessage);
                command.Parameters.AddWithValue("@SenderID", senderId);
                command.Parameters.AddWithValue("@Date", DateTime.Now);

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Complaint sent successfully.");
           // this.Close();
        }

        private void backbtnsendcomplaint_Click(object sender, EventArgs e)
        {
            // BuyerDashboard back = new BuyerDashboard(buyerId);
            /// back.Show();
            if (isSeller)
            {
                // Navigate back to the SellerDashboard
                SellerDashboard back = new SellerDashboard(sellerId, sellerUsername);
                back.Show();
                this.Hide(); // Hide the current form instead of closing it
            }
            else
            {
                // Navigate back to the BuyerDashboard
                BuyerDashboard back = new BuyerDashboard(buyerId, buyerName);
                back.Show();
                this.Close(); // Close the current form
            }
        }

    }
}

/*using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace EliteEstates
{
    public enum SendComplaintSource
    {
        BuyerDashboard,
        SellerDashboard
    }

    public partial class SendComplaint : Form
    {
        private int buyerId;
        private int sellerId;
        private string sellerUsername;
        private string buyerName;
        private SendComplaintSource source;

        public SendComplaint(int userId, string username, SendComplaintSource source)
        {
            InitializeComponent();
            this.sellerUsername = username;
            this.buyerName = username;
            this.source = source;

            switch (source)
            {
                case SendComplaintSource.BuyerDashboard:
                    this.buyerId = userId;
                    this.sellerId = 0;
                    break;
                case SendComplaintSource.SellerDashboard:
                    this.sellerId = userId;
                    this.buyerId = 0;
                    break;
            }
        }

        private void Sendcomplaintbtn_Click(object sender, EventArgs e)
        {
            string complaintMessage = complaintboxtxt.Text;
            int senderId = buyerId == 0 ? sellerId : buyerId;

            // Create a SQL connection and command
            using (SqlConnection connection = new SqlConnection("Data Source=USER\\\\SQLEXPRESS;Initial Catalog=EliteEstates;Integrated Security=True;"))
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                connection.Open();

                // Insert the complaint into the database
                command.CommandText = "INSERT INTO [dbo].[complain] ([Complain], [Sender ID], [Date]) VALUES (@Message, @SenderID, @Date)";
                command.Parameters.AddWithValue("@Message", complaintMessage);
                command.Parameters.AddWithValue("@SenderID", senderId);
                command.Parameters.AddWithValue("@Date", DateTime.Now);

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Complaint sent successfully.");
            this.Close();
        }

        private void backbtnsendcomplaint_Click(object sender, EventArgs e)
        {
            switch (source)
            {
                case SendComplaintSource.BuyerDashboard:
                    // Navigate back to the BuyerDashboard
                    BuyerDashboard buyerDashboard = new BuyerDashboard(buyerId, buyerName);
                    buyerDashboard.Show();
                    this.Close();
                    break;
                case SendComplaintSource.SellerDashboard:
                    // Navigate back to the SellerDashboard
                    SellerDashboard sellerDashboard = new SellerDashboard(sellerId, sellerUsername);
                    sellerDashboard.Show();
                    this.Hide();
                    break;
            }
        }
    }
}*/
