using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Cine_Alfa
{
    internal class verificar_user
    {
        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ds;Integrated Security=True;TrustServerCertificate=True;");

        public void verificar(string usuario, string contra)
        {
            try
            {
                using (SqlConnection cone = new SqlConnection(connection))
                {
                    cone.Open();
                    string query = "SELECT n_usuario, contraseña FROM usuarios WHERE n_usuario = @n_usuario AND contraseña = @contraseña;";
                    using (SqlCommand cmd = new SqlCommand(query, cone))
                    {
                        // Asegúrate de que los nombres de los parámetros coincidan exactamente
                        cmd.Parameters.AddWithValue("@n_usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contra);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Bienvenido(a) " + usuario);
                            Form2 panta2 = new Form2();
                            panta2.Show();
                            Form1 panta1 = new Form1();
                            panta1.Close();

                           
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o contraseña incorrectos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
