using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class Buses_Home : Form
    {
        public Buses_Home()
        {
            InitializeComponent();
        }

        private void Buses_Home_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";
            string query = "SELECT Bus_No, Departure, Arrival, Driver_id FROM bus";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                   
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);

               
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form7 = new bus_insert();
            this.Hide();
            form7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form8 = new bus_update();
            this.Hide();
            form8.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form9 = new Home();
            this.Hide();
            form9.ShowDialog();
        }
    }
}
