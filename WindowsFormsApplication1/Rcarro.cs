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
    public partial class Rcarro : Form
    {
        public Rcarro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lista de carros
            Lcarro fm4 = new Lcarro();
            fm4.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //registo de carros

            int ret = BusinessLogicLayer.BLL.Carros.insertCarros(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

        }
    }
}
