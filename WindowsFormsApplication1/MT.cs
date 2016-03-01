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
        string uDn, uEmail, uMorada, uContacto, uCartac, uCategoria, uTipo, uPass, id;


        public MT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carro = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        
        }

        private void MT_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogicLayer.BLL.Carros.Load();
            dataGridView2.DataSource = BusinessLogicLayer.BLL.Registo.Load();
   

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
         uDn = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
         uEmail = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
         uMorada = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
         uContacto = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
         uCartac =  dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
         uCategoria = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
         uTipo =  dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            uPass =  dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
         id = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();

        }
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            
            Nome = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            uDn = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            uEmail = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            uMorada = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            uContacto = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            uCartac = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            uCategoria = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            uTipo = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            uPass = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           BusinessLogicLayer.BLL.Registo.UpdateRegisto(Nome, uDn, uEmail, uMorada, uContacto, uCartac, uCategoria, uTipo, uPass,id);
        }


    
    }
}
