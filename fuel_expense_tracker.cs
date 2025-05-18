using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class fuel_expense_tracker : Form
    {
        string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";

        public fuel_expense_tracker()
        {
            InitializeComponent();
            LoadFuelData();
            CalculateMonthlyTotal();
        }

        private void LoadFuelData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT date, liters, price_per_liter, total FROM fuel_expense ORDER BY date DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    fuel_expense.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }



        private void CalculateMonthlyTotal()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string monthTotalQuery = @"SELECT SUM(total) FROM fuel_expense 
                                               WHERE MONTH(date) = @month AND YEAR(date) = @year";
                    MySqlCommand cmd = new MySqlCommand(monthTotalQuery, conn);
                    cmd.Parameters.AddWithValue("@month", DateTime.Now.Month);
                    cmd.Parameters.AddWithValue("@year", DateTime.Now.Year);

                    object result = cmd.ExecuteScalar();
                    decimal totalSpent = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    fuel_summary_total.Text = "Monthly Total: Rs. " + totalSpent.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating monthly total: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!decimal.TryParse(fuel_litre.Text.Trim(), out decimal liters) ||
               !decimal.TryParse(fuel_price.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please enter valid numeric values for liters and price.");
                return;
            }

            decimal total = liters * price;
            DateTime date = fuel_date.Value.Date;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO fuel_expense (date, liters, price_per_liter, total) " +
                                         "VALUES (@date, @liters, @price, @total)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@liters", liters);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fuel expense added successfully!");
                    LoadFuelData();
                    CalculateMonthlyTotal();

                    fuel_litre.Clear();
                    fuel_price.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding data: " + ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form89 = new Home();
            this.Hide();
            form89.ShowDialog();
        }
    }
}
