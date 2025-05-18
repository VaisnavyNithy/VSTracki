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
using System.Drawing.Printing;

namespace VSTracki
{
    public partial class driver_salary : Form
    {
        private PrintDocument printDocument;
        private int currentRow = 0;
        private DataTable dataTable;
        string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";

        public driver_salary()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data available for printing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                currentRow = 0;
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                e.HasMorePages = false;
                return;
            }

            int yPos = 100;
            int xPos = 100;
            int rowHeight = 20;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            int columnsCount = dataTable.Columns.Count;

          
            if (currentRow == 0)
            {
                for (int col = 0; col < columnsCount; col++)
                {
                    e.Graphics.DrawString(dataTable.Columns[col].ColumnName, font, brush, xPos + col * 150, yPos);
                }
                yPos += rowHeight;
            }

   
            for (; currentRow < dataTable.Rows.Count; currentRow++)
            {
                for (int col = 0; col < columnsCount; col++)
                {
                    string cellValue = dataTable.Rows[currentRow][col].ToString();
                    e.Graphics.DrawString(cellValue, font, brush, xPos + col * 150, yPos);
                }

                yPos += rowHeight;

                if (yPos + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void driver_salary_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM driver_salary";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    salarydata.DataSource = dataTable; // Ensure salarydata is your DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form20 = new driver_salary_update();
            this.Hide();
            form20.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form21 = new driver_salary_insert();
            this.Hide();
            form21.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form22 = new Driver_home();
            this.Hide();
            form22.ShowDialog();
        }
    }
}
