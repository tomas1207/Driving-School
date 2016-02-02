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
    public partial class MT : Form
    {
        string Nome, carro;

        public MT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carro = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].ToString();
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[3].ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[4].ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[5].ToString();
        }

        private void MT_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogicLayer.BLL.Carros.Load();
            dataGridView2.DataSource = BusinessLogicLayer.BLL.Registo.Load();
            panel1.Hide();
            panel2.Hide();


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL.Carros.deletecarro(carro);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL.Registo.deletregisto(Nome);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nome = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void updateDaBaseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL.Carros.UpdateCarro(carro,textBox1.Text, textBox2.Text, textBox3.Text , textBox4.Text, textBox5.Text);
            panel2.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

    
    }
}
