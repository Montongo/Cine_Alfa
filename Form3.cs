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
            int valor1 = comboBox1.SelectedIndex + 1;
            int valor2 = comboBox2.SelectedIndex + 1;
            int valor3 = comboBox3.SelectedIndex + 1;

            if (valor1 > 10 || valor2 > 10 || valor3 > 10)
            {
                MessageBox.Show("Selecciona números del 1 al 10 en cada comboBox.");
                return;
            }

            // Calcular el total
            int total = valor1 + valor2 + valor3;

            // Validar el total
            if (total > 11)
            {
                MessageBox.Show("Boletos insuficientes. Vuelve a seleccionar boletos.", "Advertencia");
            }
            else
            {




            }
            Seleccion se = new Seleccion();
            se.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void atras3_Click(object sender, EventArgs e)
        {
            Form2 de = new Form2();
            de.Show();
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
    }
}
