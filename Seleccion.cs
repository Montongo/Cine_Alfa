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
    public partial class Seleccion : Form
    {
        public Seleccion()
        {
            InitializeComponent();
        }




        Form4 panta4 = new Form4();

        int totalClicks = 0; // Lleva el conteo de clics
        int maxClicks;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 setr = new Form3();
            setr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panta4.SetSillaText(Silla.Text);
            panta4.Show();
            this.Hide();


        }

        private void elegido_Click(object sender, EventArgs e)
        {

        }

        int n1 = Nota.n1, n2 = Nota.n2, n3 = Nota.n3;

        public void Asientos()
        {

            elegido.Text = "Total de asientos: " + (n1 + n2 + n3);
            Sala.Text = "Sala: " + Nota.sal;
        }



        private void Seleccion_Load(object sender, EventArgs e)
        {
           
            maxClicks = n1 + n2 + n3;
            Asientos();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button1.Enabled)
            {
                button1.BackColor = Color.Red;

                button1.Enabled = false;
                totalClicks++;
                Silla.Text += "A6, ";


            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button2.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button2.BackColor = Color.Red;

                button2.Enabled = false;
                totalClicks++; Silla.Text += "A7, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button45.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button45.BackColor = Color.Red;

                button45.Enabled = false;
                totalClicks++;
                Silla.Text += "A12, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button3.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button3.BackColor = Color.Red;

                button3.Enabled = false;
                totalClicks++;
                Silla.Text += "B4, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button4.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button4.BackColor = Color.Red;

                button4.Enabled = false;
                totalClicks++;
                Silla.Text += "B5, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button5.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button5.BackColor = Color.Red;

                button5.Enabled = false;
                totalClicks++; Silla.Text += "B6, ";


            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button6.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button6.BackColor = Color.Red;

                button6.Enabled = false;
                totalClicks++;
                Silla.Text += "B7, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button7.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button7.BackColor = Color.Red;

                button7.Enabled = false;
                totalClicks++;
                Silla.Text += "B8, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button8.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button8.BackColor = Color.Red;

                button8.Enabled = false;
                totalClicks++;
                Silla.Text += "B9, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button9.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button9.BackColor = Color.Red;

                button9.Enabled = false;
                totalClicks++;
                Silla.Text += "B10, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button10.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button10.BackColor = Color.Red;

                button10.Enabled = false;
                totalClicks++;
                Silla.Text += "B11, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button11.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button11.BackColor = Color.Red;

                button11.Enabled = false;
                totalClicks++;
                Silla.Text += "B12, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button37.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button37.BackColor = Color.Red;

                button37.Enabled = false;
                totalClicks++;
                Silla.Text += "C2, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button39.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button39.BackColor = Color.Red;

                button39.Enabled = false;
                totalClicks++;
                Silla.Text += "C3, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button40.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button40.BackColor = Color.Red;

                button40.Enabled = false;
                totalClicks++;
                Silla.Text += "C4, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button41.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button41.BackColor = Color.Red;

                button41.Enabled = false;
                totalClicks++;
                Silla.Text += "C11";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button46.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button46.BackColor = Color.Red;

                button46.Enabled = false;
                totalClicks++;
                Silla.Text += "C12, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button42.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button42.BackColor = Color.Red;

                button42.Enabled = false;
                totalClicks++;
                Silla.Text += "D12, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button12.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button12.BackColor = Color.Red;

                button12.Enabled = false;
                totalClicks++;
                Silla.Text += "E5, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button13.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button13.BackColor = Color.Red;

                button13.Enabled = false;
                totalClicks++;
                Silla.Text += "E6, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button16.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button16.BackColor = Color.Red;

                button16.Enabled = false;
                totalClicks++;
                Silla.Text += "E7, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button44.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button44.BackColor = Color.Red;

                button44.Enabled = false;
                totalClicks++;
                Silla.Text += "E8, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button15.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button15.BackColor = Color.Red;

                button15.Enabled = false;
                totalClicks++;
                Silla.Text += "E9, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button14.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button14.BackColor = Color.Red;

                button14.Enabled = false;
                totalClicks++;
                Silla.Text += "E11, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button43.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button43.BackColor = Color.Red;

                button43.Enabled = false;
                totalClicks++;
                Silla.Text += "E12, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }

        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button57.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button57.BackColor = Color.Red;

                button57.Enabled = false;
                totalClicks++;
                Silla.Text += "C6, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button56.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button56.BackColor = Color.Red;

                button56.Enabled = false;
                totalClicks++;
                Silla.Text += "C7, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button55.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button55.BackColor = Color.Red;

                button55.Enabled = false;
                totalClicks++;
                Silla.Text += "C8, ";


            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button54.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button54.BackColor = Color.Red;

                button54.Enabled = false;
                totalClicks++;
                Silla.Text += "C9, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button53.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button53.BackColor = Color.Red;

                button53.Enabled = false;
                totalClicks++;
                Silla.Text += "C10, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button49.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button49.BackColor = Color.Red;

                button49.Enabled = false;
                totalClicks++;
                Silla.Text += "K12, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button58.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button58.BackColor = Color.Red;

                button58.Enabled = false;
                totalClicks++;
                Silla.Text += "E10, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button125_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button125.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button125.BackColor = Color.Red;

                button125.Enabled = false;
                totalClicks++;
                Silla.Text += "F1, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button124_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button124.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button124.BackColor = Color.Red;

                button124.Enabled = false;
                totalClicks++;
                Silla.Text += "F11, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button123_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button123.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button123.BackColor = Color.Red;

                button123.Enabled = false;
                totalClicks++;
                Silla.Text += "F12, ";
            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button126_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button126.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button126.BackColor = Color.Red;

                button126.Enabled = false;
                totalClicks++;
                Silla.Text += "G1, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button127_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button127.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button127.BackColor = Color.Red;

                button127.Enabled = false;
                totalClicks++;
                Silla.Text += "G2, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button128_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button128.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button128.BackColor = Color.Red;

                button128.Enabled = false;
                totalClicks++;
                Silla.Text += "H1, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button129_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button129.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button129.BackColor = Color.Red;

                button129.Enabled = false;
                totalClicks++;
                Silla.Text += "H2, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button130_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button130.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button130.BackColor = Color.Red;

                button130.Enabled = false;
                totalClicks++;
                Silla.Text += "H3, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button122_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button122.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button122.BackColor = Color.Red;

                button122.Enabled = false;
                totalClicks++;
                Silla.Text += "H12, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button131_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button131.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button131.BackColor = Color.Red;

                button131.Enabled = false;
                totalClicks++;
                Silla.Text += "I2, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button132_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button132.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button132.BackColor = Color.Red;

                button132.Enabled = false;
                totalClicks++;
                Silla.Text += "F3, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button134_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button58.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button58.BackColor = Color.Red;

                button58.Enabled = false;
                totalClicks++;
                Silla.Text += "J11, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void button133_Click(object sender, EventArgs e)
        {
            if (totalClicks < maxClicks && button133.Enabled) // Verifica si aún hay clics permitidos y el botón no ha sido presionado antes
            {
                button133.BackColor = Color.Red;

                button133.Enabled = false;
                totalClicks++;
                Silla.Text += "J12, ";

            }
            else
            {
                MessageBox.Show("!!Ya no tienes mas boletos!¿si necesitas mas retrocede y adquiere?");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Silla_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
