using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using System.Drawing.Printing;

namespace VSTracki
{
    public partial class payment_report : Form
    {
        private PrintDocument printDocument;
        private int currentRow = 0;  
        private DataTable dataTable;

        public payment_report()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        
        private void payment_report_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";
            string query = "SELECT Booking_Id, Departure, Arrival, Fare, Status FROM passenger_payment";

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

      
        private void button1_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            var form18 = new booking_report();
            this.Hide();
            form18.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form19 = new Update_Payment();
            this.Close();
            form19.ShowDialog();
        }
    }
}
