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
            Conexion c = new Conexion();


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
            Form2 form = new Form2();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            terminos te = new terminos();
            te.Show();
            this.Hide();
        }
    }
}
