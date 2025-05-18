using System;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class driver_salary_insert : Form
    {
        string connectionString = "server=localhost;username=root;password=;database=vs tracki;Allow User Variables=True;";

        public driver_salary_insert()
        {
            InitializeComponent();
          
            BasicSalary.TextChanged += CalculateSalary;
            Overtime.TextChanged += CalculateSalary;
            Allowances.TextChanged += CalculateSalary;
            LoanDeductions.TextChanged += CalculateSalary;
            salaryadvance.TextChanged += CalculateSalary;
        }

        private void CalculateSalary(object sender, EventArgs e)
        {
            try
            {

                decimal basicSalaryValue = "Select salary from driver";
                decimal overtimeValue = string.IsNullOrEmpty(Overtime.Text) ? 0 : Convert.ToDecimal(Overtime.Text);
                decimal allowancesValue = string.IsNullOrEmpty(Allowances.Text) ? 0 : Convert.ToDecimal(Allowances.Text);
                decimal loanDeductionsValue = string.IsNullOrEmpty(LoanDeductions.Text) ? 0 : Convert.ToDecimal(LoanDeductions.Text);
                decimal salaryAdvanceValue = string.IsNullOrEmpty(salaryadvance.Text) ? 0 : Convert.ToDecimal(salaryadvance.Text);

          
                decimal totalAdditionsValue = basicSalaryValue + overtimeValue + allowancesValue;
                decimal epf8Value = basicSalaryValue * 0.08m;
                decimal epf12Value = basicSalaryValue * 0.12m;
                decimal etfValue = basicSalaryValue * 0.03m;
                decimal totalDeductionsValue = loanDeductionsValue + salaryAdvanceValue + epf8Value;
                decimal netSalaryValue = totalAdditionsValue - totalDeductionsValue;

       
                TotalAdditions.Text = totalAdditionsValue.ToString("0.00");
                epf8.Text = epf8Value.ToString("0.00");
                epf12.Text = epf12Value.ToString("0.00");
                etf.Text = etfValue.ToString("0.00");
                TotalDeductions.Text = totalDeductionsValue.ToString("0.00");
                NetSalary.Text = netSalaryValue.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in calculation: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO driver_salary " +
                                   "(Driver_id, `Basic Salary`, `Over Time`, Allowances, `Total Additions`, EPF8, `Loan Deductions`, `Salary Advance`, `Total Deductions`, `Net Salary`, EPF12, ETF) " +
                                   "VALUES (@Driver_Id, @BasicSalary, @Overtime, @Allowances, @TotalAdditions, @EPF8, @LoanDeductions, @SalaryAdvance, @TotalDeductions, @NetSalary, @EPF12, @ETF)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Driver_Id", driverid.Text);
                        cmd.Parameters.AddWithValue("@BasicSalary", Convert.ToDecimal(BasicSalary.Text));
                        cmd.Parameters.AddWithValue("@Overtime", Convert.ToDecimal(Overtime.Text));
                        cmd.Parameters.AddWithValue("@Allowances", Convert.ToDecimal(Allowances.Text));
                        cmd.Parameters.AddWithValue("@TotalAdditions", Convert.ToDecimal(TotalAdditions.Text));
                        cmd.Parameters.AddWithValue("@EPF8", Convert.ToDecimal(epf8.Text));
                        cmd.Parameters.AddWithValue("@LoanDeductions", Convert.ToDecimal(LoanDeductions.Text));
                        cmd.Parameters.AddWithValue("@SalaryAdvance", Convert.ToDecimal(salaryadvance.Text));
                        cmd.Parameters.AddWithValue("@TotalDeductions", Convert.ToDecimal(TotalDeductions.Text));
                        cmd.Parameters.AddWithValue("@NetSalary", Convert.ToDecimal(NetSalary.Text));
                        cmd.Parameters.AddWithValue("@EPF12", Convert.ToDecimal(epf12.Text));
                        cmd.Parameters.AddWithValue("@ETF", Convert.ToDecimal(etf.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Salary record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert salary record. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            driverid.Clear();
            BasicSalary.Clear();
            Overtime.Clear();
            Allowances.Clear();
            TotalAdditions.Clear();
            epf8.Clear();
            epf12.Clear();
            etf.Clear();
            LoanDeductions.Clear();
            salaryadvance.Clear();
            TotalDeductions.Clear();
            NetSalary.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form89 = new driver_salary();
            this.Hide();
            form89.ShowDialog();
        }
    }
}
