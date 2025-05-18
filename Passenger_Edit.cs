using System;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class Passenger_Edit : Form
    {
        private string connectionString = "Server=localhost;Database=vs tracki;Username=root;Password=;";
        private Passenger selectedPassenger;

        public Passenger_Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameToSearch = passengername.Text.Trim();
            selectedPassenger = SearchPassengerByName(nameToSearch);

            if (selectedPassenger != null)
            {
                passenger_id.Text = selectedPassenger.Id.ToString();
                p_name.Text = selectedPassenger.Name;
                p_email.Text = selectedPassenger.Email;
                username.Text = selectedPassenger.Username;
                password.Text = selectedPassenger.Password; 
            }
            else
            {
                MessageBox.Show("Passenger not found.");
            }
        }

        public Passenger SearchPassengerByName(string name)
        {
            string query = "SELECT Id, Name, Email, Username, Password FROM passenger_details WHERE Username LIKE @username LIMIT 1";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", "%" + name + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Passenger(
                                    reader.GetInt32("Id"),
                                    reader.GetString("Name"),
                                    reader.GetString("Email"),
                                    reader.GetString("Username"),
                                    reader.GetString("Password")
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (selectedPassenger == null)
            {
                MessageBox.Show("No passenger selected. Please search first.");
                return;
            }

            string u_pname = p_name.Text.Trim();
            string u_pemail = p_email.Text.Trim();
            string u_pusername = username.Text.Trim();
            string u_ppassword = password.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(u_pname) || string.IsNullOrWhiteSpace(u_pemail) ||
                string.IsNullOrWhiteSpace(u_pusername) || string.IsNullOrWhiteSpace(u_ppassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "UPDATE passenger_details SET Name=@Name, Email=@Email, Username=@Username, Password=@Password WHERE Id=@Id";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", u_pname);
                        cmd.Parameters.AddWithValue("@Email", u_pemail);
                        cmd.Parameters.AddWithValue("@Username", u_pusername);
                        cmd.Parameters.AddWithValue("@Password", u_ppassword);
                        cmd.Parameters.AddWithValue("@Id", selectedPassenger.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The records were updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please try again.");
                        }
                    }
                }

                this.Hide();
                var form6 = new Passenger_Record();
                form6.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            
            var form6 = new Passenger_Edit();
            this.Hide();
            form6.ShowDialog();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            var form7 = new Home();
            this.Hide();
            form7.ShowDialog();
        }

        private void passenger_Click(object sender, EventArgs e)
        {
            
            var form6 = new Passenger_Record();
            this.Hide();
            form6.ShowDialog();
        
        }
    }

    public class Passenger
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Passenger(int id, string name, string email, string username, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Username = username;
            Password = password;
        }
    }
}
