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
        string Nome;

        public MT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void MT_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogicLayer.BLL.Carros.Load();
            dataGridView2.DataSource = BusinessLogicLayer.BLL.Registo.Load();

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL.Registo.deletregisto(Nome);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nome = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
