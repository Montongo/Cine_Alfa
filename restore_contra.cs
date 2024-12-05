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
    public partial class restore_contra : Form
    {
        public restore_contra()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ingresar_usuario.Text) || string.IsNullOrWhiteSpace(ingresar_contra.Text) || string.IsNullOrWhiteSpace(confirmar_contra.Text))
            {
                MessageBox.Show("Ingresa todos los datos solicitados");
            }
            else
            {
                if (ingresar_contra.Text.Equals(confirmar_contra.Text))
                {
                    restaurar_contra restore = new restaurar_contra();
                    restore.restaurar(ingresar_usuario.Text, ingresar_contra.Text);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 panta1 = new Form1();
            panta1.Show();
            this.Hide();
        }
    }
}
