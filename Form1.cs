using System;
using System.Windows.Forms;
using MySqlConnector; 

namespace VSTracki
{
    public partial class admin_login : Form
    {

        private string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";

        public admin_login()
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

                var homeForm = new Home();
                homeForm.Show();
                this.Hide();
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
            bool isValid = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM admin_register WHERE Username = @username AND TRIM(Password) = TRIM(@password)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform5 = new admin_login();
            this.Hide();
            newform5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform6 = new admin_register();
            this.Hide();
            newform6.Show();
        }
    }
}
