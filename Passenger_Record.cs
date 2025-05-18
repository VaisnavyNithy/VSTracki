using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using System.Drawing.Printing;

namespace VSTracki
{
    public partial class Passenger_Record : Form
    {
        private PrintDocument printDocument;

        public Passenger_Record()
        {
            InitializeComponent();

           
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void Passenger_Record_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";

            
            string query = "SELECT Name, Email FROM passenger_details";  

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                   
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);

                   
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                 
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        private void printButton_Click(object sender, EventArgs e)
        {
         
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
               
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

            
            for (int col = 0; col < dataGridView1.Columns.Count; col++)
            {
                e.Graphics.DrawString(dataGridView1.Columns[col].HeaderText, font, brush, xPos + col * 150, yPos);
            }

            yPos += rowHeight;

           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    e.Graphics.DrawString(row.Cells[col].Value?.ToString(), font, brush, xPos + col * 150, yPos);
                }

                yPos += rowHeight;
            }

            e.HasMorePages = false;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Passenger_Edit();
            this.Hide();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form4 = new admin_login();
            this.Hide();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

     

        private void passenger_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var form5 = new passenger_delete();
            this.Hide();
            form5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form9 = new booking_report();
            this.Hide();
            form9.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form11 = new Home();
            this.Hide();
            form11.ShowDialog();
        }
    }
}
