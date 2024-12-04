using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

        int op = Nota.op;
        int op2 = Nota.op2;
        public void Poner_img()
        {
            
         
            switch(op)
            {
                case 1:
                    pictureBox4.Image = Image.FromFile(@"C:\Users\jorge\source\repos\Cine_Alfa2.1\Resources\end_game.jpg");
                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources._3;
                    
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resources._4;
                    break ;
                case 4:
                    pictureBox4.Image = Properties.Resources._5;
                    
                    break;
                case 5:
                    pictureBox4.Image = Properties.Resources._6;
                    break ;
                case 6:
                    pictureBox4.Image = Properties.Resources._12;
                    break ;
                case 7:
                    pictureBox4.Image = Properties.Resources._13;
                    
                    break ;
                case 8:
                    pictureBox4.Image = Properties.Resources._7;
                    
                    break ;
                case 9:
                    pictureBox4.Image = Properties.Resources._8;
                    break ;
                case 10:
                    pictureBox4.Image = Properties.Resources._9;
                    
                    break ;
                case 11:
                    pictureBox4.Image = Properties.Resources._10;
                    break ;
                case 12:
                    pictureBox4.Image = Properties.Resources._11;
                    
                    break ;
                case 13:
                    pictureBox4.Image = Properties.Resources._14;
                    break ;
                case 14:
                    pictureBox4.Image = Properties.Resources._15;
                    break ;
            }

            if (op2 == 1)
            {
                label9.Text = "Hora: " + Nota.hora1;
                label10.Text = "Fecha: " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
            }
            if (op2 == 2)
            {
                label9.Text = "Hora: " + Nota.hora2;
                label10.Text = "Fecha: " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
            }
            if (op2 == 3)
            {
                label9.Text = "Hora: " + Nota.hora3;
                label10.Text = "Fecha: " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
            }
            if (op2 == 4)
            {
                label9.Text = "Hora: " + Nota.hora4;
                label10.Text = "Fecha: " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
            }


            

            Sala.Text = "Sala: " + Nota.sal.ToString();
            
        }

       
        private void Form3_Load(object sender, EventArgs e)
        {
            Poner_img();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            
            
            if(adulto.Text == "0" && tercera.Text == "0" && infante.Text == "0")
            {
                MessageBox.Show("Seleccione sus boletos");
            }

            else
            {
                if (adulto.Text == "0" && tercera.Text == "0")
                {
                    MessageBox.Show("Un menor no puede entrar solo a la sala de cine");
                }
                else {
                    
                    this.Hide();

                    int n1 = int.Parse(adulto.Text);
                    int n2 = int.Parse(infante.Text);
                    int n3 = int.Parse(tercera.Text);

                    Nota.dato4(n1, n2, n3);
                    Seleccion re = new Seleccion();
                    re.Show();
                }
            }

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Horarios horarios = new Horarios();
            horarios.Show();
            this.Hide();
        }

        
    }
}
