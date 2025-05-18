using System;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class passenger_delete : Form
    {
        private string connectionString = "Server=localhost;Database=vs tracki;Username=root;Password=;";

        public passenger_delete()
        {
            InitializeComponent();
        }

        // Event handler for the Search button click (Search by ID)
        private void button1_Click(object sender, EventArgs e)
        {
            string idToSearch = Passengername.Text;  // ID entered by the user

            // Call SearchPassengerById to find the passenger by ID
            Passenger passenger = SearchPassengerById(idToSearch);

            // Display the passenger details if found
            if (passenger != null)
            {
                // Update labels to show the found passenger's details
                p_id.Text = passenger.Id;
                p_name.Text = passenger.Name;
            }
            else
            {
                MessageBox.Show("Passenger not found.");
            }
        }

        // Method to search for a passenger by ID
        public Passenger SearchPassengerById(string id)
        {
            string query = "SELECT Id, Name FROM Passenger_details WHERE Id = @id LIMIT 1";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Passenger(
                                reader.GetString("Id"),    // ID from the database
                                reader.GetString("Name")   // Name from the database
                            );
                        }
                    }
                }
            }
            return null; // Return null if no passenger is found
        }

        // Method to delete a passenger by ID
        public bool DeletePassenger(string id)
        {
            string query = "DELETE FROM Passenger_details WHERE Id = @Id";  // Use Id instead of Name

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    // Pass the actual Id from the method parameter
                    cmd.Parameters.AddWithValue("@Id", id);

                    // Execute the query and check if any rows were deleted
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;  // Returns true if any rows were deleted
                }
            }
        }

        // Passenger class definition
        public class Passenger
        {
            public string Id { get; set; }
            public string Name { get; set; }

            // Constructor to initialize Passenger objects
            public Passenger(string id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        private void passenger_delete_Load(object sender, EventArgs e)
        {
            // Optional: Initialize any necessary logic when the form loads
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            string passengerId = p_id.Text; // Get the passenger ID from the label

            if (string.IsNullOrEmpty(passengerId))
            {
                MessageBox.Show("Please search for a passenger before attempting to delete.");
                return;
            }

            // Call DeletePassenger to remove the passenger by ID
            bool isDeleted = DeletePassenger(passengerId);

            if (isDeleted)
            {
                MessageBox.Show("Passenger deleted successfully.");
                // Optionally, clear the labels and textboxes
                p_id.Text = string.Empty;
                p_name.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error deleting passenger.");
            }
        }

        // Remove the unused Delete_Click method
    }
}
