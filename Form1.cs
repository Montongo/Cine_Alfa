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

namespace Cine_Alfa
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection("Data source= E\\SQLPRACTICE; Initial Catalog= Alfa_cine; User ID =sa; Password=12345678;Encrypt=False ");
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
            
            if(string.IsNullOrWhiteSpace(Ingresa_usuario.Text) || string.IsNullOrWhiteSpace(Ingresa_password.Text))
            {
                MessageBox.Show("Ingresa todos los datos");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_cuen_Click(object sender, EventArgs e)
        {
            new_user panata_nuevo_usuario = new new_user();
            panata_nuevo_usuario.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            restore_contra rest_con = new restore_contra();
            rest_con.Show();
            this.Hide();
        }
    }
}
