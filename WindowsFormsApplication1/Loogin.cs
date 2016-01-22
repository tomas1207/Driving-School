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
    public partial class Loogin : Form
    {
       
        public Loogin()
        {
             InitializeComponent();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Registo
            this.Hide();
           Registo fm2 = new Registo();
           fm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // login 
            DataTable dt = BusinessLogicLayer.BLL.Login.LoginSystem(textBox1.Text, textBox2.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][7].ToString() == "Admin")
                {
                    Admin ad = new Admin();
                    ad.Show();
                    this.Hide();

                }
                else if (dt.Rows[0][7].ToString() == "Secretaria") { Secretaria sc = new Secretaria(); sc.Show(); this.Hide(); }
            }
            else { MessageBox.Show("Login errado", "ERRO!" ); }
      
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
           
