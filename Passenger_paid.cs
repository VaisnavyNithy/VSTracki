using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class Passenger_paid : Form
    {
        private string connectionString = "Server=localhost;Database=vs tracki;Username=root;Password=;Allow User Variables=true;";

        public Passenger_paid()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            var passenger_departure = p_departure.Text.Trim();
            var passenger_arrival = p_arrival.Text.Trim();
            var booking_id = p_id.Text.Trim();
            var passenger_status = p_status.Text.Trim();

            if (string.IsNullOrWhiteSpace(passenger_departure) || string.IsNullOrWhiteSpace(passenger_arrival) || string.IsNullOrWhiteSpace(booking_id))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string fareQuery = "SELECT Fare FROM fare_details WHERE Departure LIKE @departure AND Arrival LIKE @arrival";

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string fare = null;

                    using (var cmd = new MySqlCommand(fareQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@departure", "%" + passenger_departure + "%");
                        cmd.Parameters.AddWithValue("@arrival", "%" + passenger_arrival + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fare = reader.GetString("Fare");
                                p_fare.Text = fare;
                            }
                            else
                            {
                                MessageBox.Show("No matching fare found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }

                 
                    string insertQuery = "INSERT INTO passenger_payment (booking_id, Departure, Arrival, Fare, Status) " +
                                         "VALUES (@booking_id, @dep, @arr, @fare, @status)";

                    using (var insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@booking_id", booking_id);
                        insertCmd.Parameters.AddWithValue("@dep", passenger_departure);
                        insertCmd.Parameters.AddWithValue("@arr", passenger_arrival);
                        insertCmd.Parameters.AddWithValue("@fare", fare);
                        insertCmd.Parameters.AddWithValue("@status", passenger_status);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Passenger payment inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void view_payment_Click(object sender, EventArgs e)
        {
            var passenger_departure = p_departure.Text.Trim();
            var passenger_arrival = p_arrival.Text.Trim();

            if (string.IsNullOrWhiteSpace(passenger_departure) || string.IsNullOrWhiteSpace(passenger_arrival))
            {
                MessageBox.Show("Please enter both departure and arrival.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT Fare FROM fare_details WHERE Departure LIKE @departure AND Arrival LIKE @arrival";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@departure", "%" + passenger_departure + "%");
                        cmd.Parameters.AddWithValue("@arrival", "%" + passenger_arrival + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fare = reader.GetString("Fare");
                                p_fare.Text = fare;
                            }
                            else
                            {
                                MessageBox.Show("Fare not found for the selected route.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var refreshedForm = new Passenger_paid();
            refreshedForm.ShowDialog();
            this.Close();
        }

  
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var controlPanel = new Passenger_Control_Panel();
            controlPanel.ShowDialog();
        }
    }
}
