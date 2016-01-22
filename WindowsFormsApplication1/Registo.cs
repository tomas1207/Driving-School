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
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {

            //registo de Utilizdor
            int ret = BusinessLogicLayer.BLL.Registo.insertRegisto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text , textBox8.Text, textBox9.Text);
            //dataGridView1.DataSource = BusinessLogicLayer.BLL.Registo.Load();
            Loogin fm1 = new Loogin();

            fm1.Show();
            this.Close();


        }

        private void Registo_Load(object sender, EventArgs e)
        {

            Loogin fm1 = new Loogin();
            fm1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LRegisto lr = new LRegisto();
            lr.Show();
            this.Hide();
        }
    }
}
