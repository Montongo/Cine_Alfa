using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cine_Alfa
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public void SetSillaText(string sillaText)
        {
            label8.Text = sillaText; // Asignar el texto recibido a Label8
        }

        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ds;Integrated Security=True;TrustServerCertificate=True;");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        int idCompra;
        int n1 = Nota.n1, n2 = Nota.n2, n3 = Nota.n3;
        int op2 = Nota.op2, total, cambio;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cantidad.Text))
            {
                MessageBox.Show("Ingrese una cantidad en efectivo");
            }
            else
            {
                if (int.Parse(cantidad.Text) < total)
                {
                    MessageBox.Show("Ingrese una cantidad mayor al total");
                }
                else
                {
                    MessageBox.Show("Su cambio es: $"+(int.Parse(cantidad.Text)-total));
                    pantalla_final panta_fin = new pantalla_final();
                    panta_fin.Show();
                    this.Hide();
                    

                    int id_tercera, id_adult, id_infan;

                    int id_u = Nota.id_u;


                    int id_sala=0;

                    if (Nota.sal == 'a')
                    {
                        id_sala = 1;
                    }
                    if (Nota.sal == 'b')
                    {
                        id_sala = 2;
                    }
                    if (Nota.sal == 'c')
                    {
                        id_sala = 3;
                    }
                    if (Nota.sal == 'd')
                    {
                        id_sala = 4;
                    }

                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        
                            conn.Open();
                        string query = @"INSERT INTO compra (id_cliente, id_pelicula, id_sala, Total, Efectivo, Cambio, fecha, hora) 
                                        VALUES (@id_us, @id_peli, @id_sal, @total, @efecti, @cam, @fecha, @hora);
                                        SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id_us", Nota.id_u);
                                cmd.Parameters.AddWithValue("@id_peli", Nota.op);
                                cmd.Parameters.AddWithValue("@id_sal", id_sala);
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.Parameters.AddWithValue("@efecti", cantidad.Text);
                                cmd.Parameters.AddWithValue("@cam", (int.Parse(cantidad.Text) - total));
                                cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("dddd, dd MMMM yyyy"));

                                if (op2 == 1)
                                {
                                    cmd.Parameters.AddWithValue("@hora", Nota.hora1);

                                }
                                if (op2 == 2)
                                {
                                    cmd.Parameters.AddWithValue("@hora", Nota.hora2);

                                }
                                if (op2 == 3)
                                {
                                    cmd.Parameters.AddWithValue("@hora", Nota.hora3);

                                }
                                if (op2 == 4)
                                {
                                    cmd.Parameters.AddWithValue("@hora", Nota.hora4);

                                }


                                idCompra = Convert.ToInt32(cmd.ExecuteScalar());


                                

                                MessageBox.Show("Pago realizado con éxito "+idCompra);

                                panta_fin.num_compra(idCompra);

                                
                                if (n1 > 0)
                                {
                                    id_adult = 1;
                                    query = "INSERT INTO Detallecompra (id_compra, id_boleto, Cantidad) VALUES (@id_com, @id_bol, @can);";
                                    cmd.CommandText = query;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@id_com", idCompra);
                                    cmd.Parameters.AddWithValue("@id_bol", id_adult);
                                    cmd.Parameters.AddWithValue("@can", n1);

                                    cmd.ExecuteNonQuery();

                                }
                                if (n2 > 0)
                                {
                                    id_infan = 2;
                                    query = "INSERT INTO Detallecompra (id_compra, id_boleto, Cantidad) VALUES (@id_com, @id_bol, @can);";
                                    cmd.CommandText = query;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@id_com", idCompra);
                                    cmd.Parameters.AddWithValue("@id_bol", id_infan);
                                    cmd.Parameters.AddWithValue("@can", n2);
                                    cmd.ExecuteNonQuery();
                                }
                                if (n3 > 0)
                                {
                                    id_tercera = 3;
                                    query = "INSERT INTO Detallecompra (id_compra, id_boleto, Cantidad) VALUES (@id_com, @id_bol, @can);";
                                    cmd.CommandText = query;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@id_com", idCompra);
                                    cmd.Parameters.AddWithValue("@id_bol", id_tercera);
                                    cmd.Parameters.AddWithValue("@can", n3);
                                    cmd.ExecuteNonQuery();

                                }
                                

                            }

                        
                       
                    }

                        

                    

                }
            }
        }


        private void label15_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            datos2();
            pelis();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Seleccion re = new Seleccion();
            re.Show();
            this.Hide();
        }

        private void Cine_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cambio_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        public void datos2()
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

            Sala.Text = Nota.sal.ToString();
            
            total = (n1 * 90) + (n2 * 60) + (n3 * 60);
            

            label12.Text = total.ToString();

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
            if (n1 >= 1 && n3==0)
            {
                if (n2 >= 1)
                {
                    Boletos.Text = "Adulto (" + n1 + ")" + ", Niño (" + n2 + ")";
                }
            }

            if (n3 >= 1 && n1==0)
            {
                if (n2 >= 1)
                {
                    Boletos.Text = "Tercera edad (" + n3 + ")" + ", Niño (" + n2 + ")";
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        int op = Nota.op;
        string[] n_pelis = { "Endgame", "Infinty War", "Joker", "It", "John Wick 2", "Deadpool 2" , "Spiderman: No way home", "Doctor Strange", "Thor" , "Iron Man 2", "Guardianes de la galaxia", "Black Widow" , "Ant-Man", "Deadpool & Wolverine"};
        
        public void pelis()
        {
            

            label1.Text = n_pelis[op - 1];
            switch (op)
            {
                case 1:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\jorge\source\repos\Cine_Alfa2.1\Resources\end_game.jpg");
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources._3;

                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources._4;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources._5;

                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources._6;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources._12;
                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources._13;

                    break;
                case 8:
                    pictureBox2.Image = Properties.Resources._7;

                    break;
                case 9:
                    pictureBox2.Image = Properties.Resources._8;
                    break;
                case 10:
                    pictureBox2.Image = Properties.Resources._9;

                    break;
                case 11:
                    pictureBox2.Image = Properties.Resources._10;
                    break;
                case 12:
                    pictureBox2.Image = Properties.Resources._11;

                    break;
                case 13:
                    pictureBox2.Image = Properties.Resources._14;
                    break;
                case 14:
                    pictureBox2.Image = Properties.Resources._15;
                    break;
            }

            
        }

        
    }
}

