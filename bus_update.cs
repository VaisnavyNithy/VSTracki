using System;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class bus_update : Form
    {
        
        string connectionString = "Server=localhost;Database=vs tracki;Username=root;Password=;";

        public bus_update()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string busNoToSearch = bus_no.Text.Trim();
            if (string.IsNullOrEmpty(busNoToSearch))
            {
                MessageBox.Show("Please enter a bus number to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bus bus = SearchBusByNumber(busNoToSearch);
            if (bus != null)
            {
                Departure.Text = bus.Departure;
                Arrival.Text = bus.Arrival;
                Driver_ID.Text = bus.Driver_ID;
            }
            else
            {
                MessageBox.Show("No matching bus found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        public Bus SearchBusByNumber(string bus_no)
        {
            string query = "SELECT Departure, Arrival, Driver_ID FROM bus WHERE Bus_No = @bus_no";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@bus_no", bus_no);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Bus(
                                    reader.GetString("Departure"),
                                    reader.GetString("Arrival"),
                                    reader.GetString("Driver_ID")
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching bus details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

  
        public class Bus
        {
            public string Departure { get; set; }
            public string Arrival { get; set; }
            public string Driver_ID { get; set; }

            public Bus(string departure, string arrival, string driver_id)
            {
                Departure = departure;
                Arrival = arrival;
                Driver_ID = driver_id;
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string bus_no_update = bus_no.Text.Trim();
            string u_departure = Departure.Text.Trim();
            string u_arrival = Arrival.Text.Trim();
            string u_driver_id = Driver_ID.Text.Trim();

        
            if (string.IsNullOrEmpty(bus_no_update) || string.IsNullOrEmpty(u_departure) ||
                string.IsNullOrEmpty(u_arrival) || string.IsNullOrEmpty(u_driver_id))
            {
                MessageBox.Show("Please fill in all fields before updating.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE bus SET Departure = @departure, Arrival = @arrival, Driver_ID = @driver_id WHERE Bus_No = @bus_no";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@bus_no", bus_no_update);
                        cmd.Parameters.AddWithValue("@departure", u_departure);
                        cmd.Parameters.AddWithValue("@arrival", u_arrival);
                        cmd.Parameters.AddWithValue("@driver_id", u_driver_id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The records were updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check the Bus Number.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating bus details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form22 = new bus_update();
            this.Hide();
            form22.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form21 = new Buses_Home();
            this.Hide();
            form21.ShowDialog();
        }
    }
}
