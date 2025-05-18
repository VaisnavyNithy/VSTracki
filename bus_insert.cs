using System;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class bus_insert : Form
    {
       
        string connectionString = "Server=localhost;Database=vs tracki;Username=root;Password=;";

        public bus_insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            var Bus_no = bus_no.Text.Trim();
            var departure = Departure.Text.Trim();
            var arrival = Arrival.Text.Trim();
            var Driver_ID = driver_id.Text.Trim();

           
            if (string.IsNullOrEmpty(Bus_no) || string.IsNullOrEmpty(departure) ||
                string.IsNullOrEmpty(arrival) || string.IsNullOrEmpty(Driver_ID))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO bus (Bus_No, Departure, Arrival, Driver_ID) " +
                           "VALUES (@Bus_no, @Departure, @Arrival, @Driver_ID)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@Bus_no", Bus_no);
                        cmd.Parameters.AddWithValue("@Departure", departure);
                        cmd.Parameters.AddWithValue("@Arrival", arrival);
                        cmd.Parameters.AddWithValue("@Driver_ID", Driver_ID);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bus inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert bus. Please check your data.", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    
        private void ClearFields()
        {
            bus_no.Clear();

            driver_id.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form22 = new bus_insert();
            this.Hide();
            form22.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form21 = new Buses_Home();
            this.Hide();
            form21.ShowDialog();
        }
    }
}
