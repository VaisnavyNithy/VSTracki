using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class View_Passenger : Form
    {
        string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;AllowZeroDateTime=True;ConvertZeroDateTime=True;";

        public View_Passenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Passenger_name = passenger_name.Text.Trim();

            if (string.IsNullOrEmpty(Passenger_name))
            {
                MessageBox.Show("Please enter the Passenger Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string query = "SELECT booking_id,Name, Departure, Arrival, Date " +
                           "FROM bookings " +
                           "WHERE Name = @Passenger_name " +
                           "AND Date > '1000-01-01'";  

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Passenger_name", Passenger_name);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No booking records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                      
                        foreach (DataRow row in dataTable.Rows)
                        {
                            
                            if (row["Date"] == DBNull.Value || !DateTime.TryParse(row["Date"].ToString(), out _))
                            {
                                row["Date"] = DBNull.Value;  
                            }
                        }

                      
                        Booking_details.DataSource = dataTable;
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
            var form67 = new Passenger_Control_Panel();
            this.Hide();
            form67.ShowDialog();
        }
    }
}
