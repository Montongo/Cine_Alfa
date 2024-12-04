using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Alfa
{
    public partial class pantalla_final : Form
    {
        public pantalla_final()
        {
            InitializeComponent();
        }

        private void pantalla_final_Load(object sender, EventArgs e)
        {
            Catch_datos();
        }

        string[] n_pelis = { "Endgame", "Infinty War", "Joker", "It", "John Wick 2", "Deadpool 2", "Spiderman: No way home", "Doctor Strange", "Thor", "Iron Man 2", "Guardianes de la galaxia", "Black Widow", "Ant-Man", "Deadpool & Wolverine" };
        int op = Nota.op;
        int op2 = Nota.op2, n1 = Nota.n1, n2 = Nota.n2, n3 = Nota.n3;
        public void Catch_datos()
        {

            Fecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            if (op2 == 1)
            {
                Hora.Text = "Hora: " + Nota.hora1;

            }
            if (op2 == 2)
            {
                Hora.Text = "Hora: " + Nota.hora2;

            }
            if (op2 == 3)
            {
                Hora.Text = "Hora: " + Nota.hora3;

            }
            if (op2 == 4)
            {
                Hora.Text = "Hora: " + Nota.hora4;

            }

            int total = (n1 * 90) + (n2 * 60) + (n3 * 60);
            Subtotal.Text = "" + total;
            Total.Text = "" + total;
            Sal.Text = Nota.sal.ToString();

            Pelicula.Text = n_pelis[op - 1];
            switch (op)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\jorge\source\repos\Cine_Alfa2.1\Resources\end_game.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._3;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._5;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._12;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._13;

                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._7;

                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._8;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._9;

                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources._10;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources._11;

                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources._14;
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources._15;
                    break;
            }

            if (n2 == 0 && n3 == 0)
            {
                Boletos.Text = "Adulto (" + n1 + ")";
            }
            if (n1 == 0 && n2 == 0)
            {
                Boletos.Text = "Tercera edad (" + n3 + ")";
            }
            if (n1 >= 1 && n3 >= 1)
            {
                if (n2 == 0)
                {
                    Boletos.Text = "Adulto (" + n1 + ")" + ", Tercera edad (" + n3 + ")";
                }
                else
                {
                    Boletos.Text = "Adulto (" + n1 + ")" + ", Niño (" + n2 + ")" + ", Tercera edad (" + n3 + ")";
                }
            }
            if (n1 >= 1 && n3 == 0)
            {
                if (n2 >= 1)
                {
                    Boletos.Text = "Adulto (" + n1 + ")" + ", Niño (" + n2 + ")";
                }
            }

            if (n3 >= 1 && n1 == 0)
            {
                if (n2 >= 1)
                {
                    Boletos.Text = "Tercera edad (" + n3 + ")" + ", Niño (" + n2 + ")";
                }
            }

        }

        int id_com;
        public void num_compra(int id)
        {
            id_com = id;
            label12.Text = id.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
