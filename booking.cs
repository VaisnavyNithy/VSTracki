using System;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class booking : Form
    {
        private string connectionString = "Server=localhost;Database=vs tracki;Username=root;Password=;";

        public booking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameToSearch = p_name.Text.Trim();

            if (string.IsNullOrEmpty(nameToSearch))
            {
                MessageBox.Show("Please enter a Name to search.");
                return;
            }

            string query = "SELECT Name, Email, Phone FROM Passenger_details WHERE Name LIKE @Name LIMIT 1";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + nameToSearch + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string passengerName = reader.GetString("Name");
                            string email = reader.GetString("Email");
                            string phone = reader.GetString("Phone");

                            p_Email.Text = email;

                        }
                        else
                        {
                            MessageBox.Show("Passenger not found.");
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p_departure = departure.Text;
            var p_arrival = arrival.Text;
            DateTime p_date = date.Value;

            if (string.IsNullOrEmpty(p_departure) || string.IsNullOrEmpty(p_arrival))
            {
                MessageBox.Show("Please provide departure and arrival details.");
                return;
            }

            string query = "INSERT INTO bookings (Name, Departure, Arrival, Date) VALUES (@p_name, @departure, @arrival, @date)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@p_name", p_name.Text);
                        cmd.Parameters.AddWithValue("@departure", p_departure);
                        cmd.Parameters.AddWithValue("@arrival", p_arrival);
                        cmd.Parameters.AddWithValue("@date", p_date);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Booking added successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in inserting booking: " + ex.Message);
                }
            }


            string selectQuery = "SELECT Departure, Arrival FROM bookings WHERE Name = @p_name LIMIT 1";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (var cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@p_name", p_name.Text);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string departure = reader.GetString("Departure");
                            string arrival = reader.GetString("Arrival");

                            this.departure.Text = departure;
                            this.arrival.Text = arrival;
                        }
                        else
                        {
                            MessageBox.Show("Booking not found.");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form8 = new Passenger_paid();
            this.Hide();
            form8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form10 = new booking();
            this.Hide();
            form10.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var form11 = new Passenger_Control_Panel();
            this.Hide();
            form11.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form12 = new Delete_booking();
            this.Hide();
            form12.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form13 = new Update_Payment();
            this.Hide();
            form13.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form14 = new booking_report();
            this.Hide();
            form14.ShowDialog();
        }
    }
}