﻿using System;
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
    public partial class Page_1 : Form
    {
        public Page_1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var newform1 = new admin_login();
            this.Hide();
            newform1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform2 = new passenger_login();
            this.Hide();
            newform2.ShowDialog();
        }
    }
}
