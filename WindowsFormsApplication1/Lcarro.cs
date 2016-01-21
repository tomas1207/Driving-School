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
    public partial class Lcarro : Form
    {
        public Lcarro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loogin login = new Loogin();
            login.Show();
                this.Hide();
        }

        private void Lcarro_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogicLayer.BLL.Carros.Load();

        }
    }
}
