using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cine_Alfa
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Ingresa_usuario.Text) && string.IsNullOrWhiteSpace(Ingresa_password.Text))
            {
                MessageBox.Show("llena todos los datos solicitados");
            }

            else
            {
                verificar_user veri = new verificar_user();
                veri.verificar(Ingresa_usuario.Text, Ingresa_password.Text);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            terminos te = new terminos();
            te.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new_user panta_nuevo_usuario = new new_user();
            panta_nuevo_usuario.Show();
            this.Hide();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            restore_contra restore = new restore_contra();
            restore.Show();
        }
    }
}
