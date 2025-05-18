using MySqlConnector;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Org.BouncyCastle.Crypto.Macs;

namespace VSTracki
{
    public partial class Passenger_Input : Form
    {
        private string connectionString = "Server=localhost;Database=vs tracki;User ID=root;Password=;";

        public Passenger_Input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var P_Name = p_name.Text;
            var P_Email = p_email.Text;
            var P_Username = p_username.Text;
            var P_password = p_password.Text;

            var hashedPassword = HashPassword(P_password);

            string query = "INSERT INTO passenger_details (Name, Username, Password, Email) " + "VALUES (@P_Name, @P_Username, @P_password, @P_Email)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@P_Name", P_Name);
                        cmd.Parameters.AddWithValue("@P_Username", P_Username);
                        cmd.Parameters.AddWithValue("@P_password", hashedPassword);
                        cmd.Parameters.AddWithValue("@P_Email", P_Email);

                        cmd.ExecuteNonQuery();
                    }

                  
                    string getIdQuery = "SELECT LAST_INSERT_ID()";
                    using (MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, connection))
                    {
                        int passengerId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                      
                        SendSummaryEmail(P_Email, P_Name, P_Username, passengerId);
                    }
                    MessageBox.Show("Inserted the passenger successfully and email sent.");

                    var form78 = new passenger_login();
                    this.Hide();
                    form78.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting passenger: " + ex.Message);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void SendSummaryEmail(string toEmail, string name, string username, int passengerId)
        {
            string subject = "VS Tracki - Registration Summary";
            string body = "Hello name," + "Thank you for registering with VS Tracki.\n\n" +
                          "Here are your registration details:" + "Passenger ID: {passengerId}\n" + "Username: username" + "Email: {toEmail}\n\n" +
                          "We're excited to have you with us!" + "Best regards,\nVS Tracki Team";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("e2320174@bit.uom.lk"); 
            mail.To.Add(toEmail);
            mail.Subject = subject;
            mail.Body = body;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("e2320174@bit.uom.lk", "vaisnavynityanantham@1"); 
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
