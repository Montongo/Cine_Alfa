using Cine_Alfa.Peliculas;
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
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
        }

        

        int op = Nota.op;
        public void Poner_img()
        {
            

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
        }
        private void Hora1_Click(object sender, EventArgs e)
        {

            Nota.dato3(1);
            Form3 panta3 = new Form3();
            panta3.Show();
            this.Hide();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");



            Hora1.Text = Nota.hora1;
            Hora2.Text = Nota.hora2;
            Hora3.Text = Nota.hora3;
            Hora4.Text = Nota.hora4;

            Poner_img();

        }
        

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Hora2_Click(object sender, EventArgs e)
        {

            
            
            Nota.dato3(2);
            Form3 panta3 = new Form3();
            panta3.Show();
            this.Hide();
        }

        private void Hora3_Click(object sender, EventArgs e)
        {

            
            
            Nota.dato3(3);
            Form3 panta3 = new Form3();
            panta3.Show();
            this.Hide();
        }

        private void Hora4_Click(object sender, EventArgs e)
        {

            Nota.dato3(4);
            Form3 panta3 = new Form3();
            panta3.Show();
            
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    Play1 play1 = new Play1();
                    play1.Show();
                    this.Hide();
                    break;
                case 2:
                    Play2 play2 = new Play2();
                    play2.Show();
                    this.Hide();
                    break;
                case 3:
                    Play3 play3 = new Play3();
                    play3.Show();
                    this.Hide();
                    break;
                case 4:
                    Play4 play4 = new Play4();
                    play4.Show();
                    this.Hide();
                    break;
                case 5:
                    Play5 play5 = new Play5();
                    play5.Show();
                    this.Hide();
                    break;
                case 6:
                    Play6 play6 = new Play6();
                    play6.Show();
                    this.Hide();
                    break;
                case 7:
                    Play7 play7 = new Play7();
                    play7.Show();
                    this.Hide();
                    break;
                case 8:
                    Play8 play8 = new Play8();
                    play8.Show();
                    this.Hide();
                    break;
                case 9:
                    Play9 play9 = new Play9();
                    play9.Show();
                    this.Hide();
                    break;
                case 10:
                    Play10 play10 = new Play10();
                    play10.Show();
                    this.Hide();
                    break;
                case 11:
                    Play11 play11 = new Play11();
                    play11.Show();
                    this.Hide();
                    break;
                case 12:
                    Play12 play12 = new Play12();
                    play12.Show();
                    this.Hide();
                    break;
                case 13:
                    Play13 play13 = new Play13();
                    play13.Show();
                    this.Hide();
                    break;
                case 14:
                    Play14 play14 = new Play14();
                    play14.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
