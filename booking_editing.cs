using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class booking_editing : Form
    {
        private string connectionString = "server=localhost;database=vs tracki;User ID=root;password=;AllowZeroDateTime=True;ConvertZeroDateTime=True;";

        public booking_editing()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string idtosearch = p_id.Text.Trim();
            string nametosearch = p_name.Text.Trim();
            string query = "SELECT booking_id, name, departure, arrival, DATE_FORMAT(date, '%Y-%m-%d') AS date FROM bookings WHERE 1=1";

            if (!string.IsNullOrEmpty(idtosearch))
                query += " AND booking_id LIKE @id";
            if (!string.IsNullOrEmpty(nametosearch))
                query += " AND name LIKE @name";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection))
                    {
                        if (!string.IsNullOrEmpty(idtosearch))
                            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", "%" + idtosearch + "%");
                        if (!string.IsNullOrEmpty(nametosearch))
                            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" + nametosearch + "%");

                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            string bookingidtosearch = booking_id.Text.Trim();
            BookingModel Booking = searchbooking(bookingidtosearch);

            if (Booking != null)
            {
                departure.Text = Booking.Departure;
                arrival.Text = Booking.Arrival;
                date.Text = Booking.Date;
            }
            else
            {
                MessageBox.Show("Booking not found.");
            }
        }

        public BookingModel searchbooking(string bookingidtosearch)
        {
            string query = "SELECT departure, arrival, date FROM bookings WHERE booking_id = @bookingid LIMIT 1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@bookingid", bookingidtosearch);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new BookingModel
                            {
                                Departure = reader["departure"].ToString(),
                                Arrival = reader["arrival"].ToString(),
                                Date = Convert.ToDateTime(reader["date"]).ToString("yyyy-MM-dd")
                            };
                        }
                    }
                }
            }
            return null;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string up_id = p_id.Text.Trim();
            string up_name = p_name.Text.Trim();
            string u_departure = departure.Text.Trim();
            string u_arrival = arrival.Text.Trim();
            string u_date_raw = date.Text.Trim();

            if (!DateTime.TryParse(u_date_raw, out DateTime parsedDate))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date (e.g., 2025-05-15).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE bookings SET Name=@Name, Departure=@Departure, Arrival=@Arrival, Date=@Date WHERE booking_id=@ID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", up_id);
                        cmd.Parameters.AddWithValue("@Name", up_name);
                        cmd.Parameters.AddWithValue("@Departure", u_departure);
                        cmd.Parameters.AddWithValue("@Arrival", u_arrival);
                        cmd.Parameters.AddWithValue("@Date", parsedDate.ToString("yyyy-MM-dd"));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The records were updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check the Booking ID and try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form23 = new booking_editing();
            this.Hide();
            form23.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form24 = new booking_report();
            this.Hide();
            form24.ShowDialog();
        }
    }

    public class BookingModel
    {
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string Date { get; set; }
    }
}
