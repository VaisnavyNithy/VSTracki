using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class admin_register : Form
    {
        private string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";

        public admin_register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            string Name = name.Text;
            string Email = email.Text;
            string query = "INSERT INTO admin_register(Username,Password,Email,Name)" +
                "VALUES (@Username,@Password,@Email,@Name)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New Admin Inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            var form33 = new admin_login();
            this.Hide();
            form33.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form34 = new admin_register();
            this.Hide();
            form34.ShowDialog();

        }
    }
}
