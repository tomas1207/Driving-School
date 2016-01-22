using System;
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
    public partial class Secretaria : Form
    {
        public Secretaria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            Rcarro rc = new Rcarro();
            rc.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LRegisto lr = new LRegisto();
            lr.Show();
            this.Hide();
        }
    }
}
