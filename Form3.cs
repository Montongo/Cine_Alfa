using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Alfa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void atras3_Click(object sender, EventArgs e)
        {
            Catalogo ca = new Catalogo();
            ca.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }
        int n = 0;
        int n2 = 0;
        int n3 = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            n = n + 1;
            adulto.Text = n.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (n == 0)
            {
                n = 0;
            }
            else
            {
                n = n - 1;
                adulto.Text = n.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n2 = n2 + 1;
            infante.Text = n2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (n2 == 0)
            {
                n2 = 0;
            }
            else
            {
                n2 = n2 - 1;
                infante.Text = n2.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n3 = n3 + 1;
            tercera.Text = n3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (n3 == 0)
            {
                n3 = 0;
            }
            else
            {
                n3 = n3 - 1;
                tercera.Text = n3.ToString();
            }
        }
    }
}
