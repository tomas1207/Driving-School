﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ir para a form de reisto de carros
            Rcarro carros = new Rcarro();
            carros.Show();

                this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Registo reg = new Registo();
            reg.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MT mt = new MT();
            mt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HR hr = new HR();
            hr.Show();

        }
    }
}
