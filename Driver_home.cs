using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySqlConnector;

namespace VSTracki
{
    public partial class Driver_home : Form
    {
        string connectionString = "server=localhost;username=root;password=;database=vs tracki;";
        private DataTable dataTable;
        private PrintDocument printDocument = new PrintDocument();
        private int currentRow = 0;

        public Driver_home()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;

            
            Print_Button.Click += Print_Button_Click;
        }

        private void Driver_home_Load(object sender, EventArgs e)
        {
            LoadDriverData();
        }

        private void LoadDriverData()
        {
            string query = "SELECT Driver_Id, Name, Bus_No, Salary FROM driver";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data available to print.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentRow = 0;
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 100;
            int y = 100;
            int rowHeight = 25;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            if (currentRow == 0)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    e.Graphics.DrawString(dataTable.Columns[col].ColumnName, font, brush, x + col * 150, y);
                }
                y += rowHeight;
            }

            while (currentRow < dataTable.Rows.Count)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    string value = dataTable.Rows[currentRow][col].ToString();
                    e.Graphics.DrawString(value, font, brush, x + col * 150, y);
                }

                currentRow++;
                y += rowHeight;

                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form19 = new driver_insert();
            this.Hide();
            form19.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form20 = new driver_edit();
            this.Hide();
            form20.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form21 = new driver_salary();
            this.Hide();
            form21.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form22 = new Home();
            this.Hide();
            form22.ShowDialog();
        }
    }
}
