﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_rental
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiclereg v = new Vehiclereg();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rental r = new rental();
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Returncar re = new Returncar();
            re.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
         

        }
    }
}
