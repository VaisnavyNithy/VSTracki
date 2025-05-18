using System;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;
using System.Security.Cryptography;

namespace VSTracki
{
    public partial class passenger_login : Form
    {
        private string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";

        public passenger_login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (IsValidUser(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                var new3 = new Passenger_Control_Panel();
                this.Hide();
                new3.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username.Clear();
                Password.Clear();
                Username.Focus();
            }
        }

        private bool IsValidUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Password FROM passenger_details WHERE Username = @username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        var storedHashedPassword = cmd.ExecuteScalar()?.ToString();

                        if (storedHashedPassword != null)
                        {
                            string hashedInputPassword = HashPassword(password);
                            return storedHashedPassword == hashedInputPassword;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new passenger_login();
            this.Close();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var form = new Passenger_Input();
            this.Hide();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form34 = new Page_1();
            this.Hide();
            form34.ShowDialog();

        }
    }
}
