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
    public partial class driver_edit : Form
    {
        private string connectionString = "server=localhost;username=root;password=;database=vs tracki;";

        public driver_edit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string driveridtosearch = driver_id.Text;
            Driver driver = SearchDriver(driveridtosearch);
            if (driver != null)
            {
                driver_name.Text = driver.Name;
                bus_no.Text = driver.BusNo;
                salary.Text = driver.Salary;
            }
            else
            {
                MessageBox.Show("Driver not found.");
            }
        }

        public Driver SearchDriver(string driveridtosearch)
        {
            string query = "SELECT name, bus_no, salary FROM driver WHERE driver_id = @driver_id LIMIT 1";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@driver_id", driveridtosearch);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Driver(
                                reader.GetString("name"),
                                reader.GetString("bus_no"),
                                reader.GetString("salary")
                            );
                        }
                    }
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u_name = driver_name.Text;
            string u_bus_no = bus_no.Text;
            string u_salary = salary.Text;
            string driverid = driver_id.Text;

            string query = "UPDATE driver SET name = @u_name, bus_no = @u_bus_no, salary = @u_salary WHERE driver_id = @driver_id";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@u_name", u_name);
                    cmd.Parameters.AddWithValue("@u_bus_no", u_bus_no);
                    cmd.Parameters.AddWithValue("@u_salary", u_salary);
                    cmd.Parameters.AddWithValue("@driver_id", driverid);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The records were updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the Driver ID and try again.");
                    }
                }
            }
        }

        public class Driver
        {
            public string Name { get; set; }
            public string BusNo { get; set; }
            public string Salary { get; set; }

            public Driver(string name, string busNo, string salary)
            {
                Name = name;
                BusNo = busNo;
                Salary = salary;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form12 = new driver_edit();
            this.Hide();
            form12.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form13 = new Driver_home();
            this.Hide();
            form13.ShowDialog();
        }

      
    }
}
