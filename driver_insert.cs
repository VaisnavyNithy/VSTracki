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
    public partial class driver_insert : Form
    {
        
        string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";

        public driver_insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Driver_id = DriverID.Text;
            var Name = name.Text;
            var Bus_No = bus_no.Text;
            var salary = Salary.Text;

           
            string query = "INSERT INTO driver (Driver_id, Name, Bus_No, Salary) VALUES (@Driver_id, @Name, @Bus_No, @Salary)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@Driver_id", Driver_id);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Bus_No", Bus_No);
                        cmd.Parameters.AddWithValue("@Salary", salary);

                       
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Driver inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert driver. Please check your data.", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void ClearFields()
        {
            DriverID.Text = "";
            name.Text = "";
            bus_no.Text = "";
            Salary.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form32 = new driver_insert();
            this.Hide();
            form32.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form33 = new Driver_home();
            this.Hide();
            form33.ShowDialog();

        }
    }
}
