using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSTracki
{
    public partial class Passenger_Control_Panel : Form
    {
        public Passenger_Control_Panel()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            var form45 = new booking();
            this.Hide();
            form45.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form46 = new View_Passenger();
            this.Hide();
            form46.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form89 = new passenger_login();
            this.Hide();
            form89.ShowDialog();

        }
    }
}
