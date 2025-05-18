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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void passenger_Click(object sender, EventArgs e)
        {
            var form1 = new Passenger_Record();
            this.Hide();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Driver_home();
            this.Hide();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form3 = new Buses_Home();
            this.Hide();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form7 = new fuel_expense_tracker();
            this.Hide();
            form7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form189 = new Page_1();
            this.Hide();
            form189.ShowDialog();
        }
    }
}
