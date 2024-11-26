using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Cine_Alfa
{
    internal class user_nuevo
    {
        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ds;Integrated Security=True;TrustServerCertificate=True;");
        
        public  void crear_user(string nombre, string usuario, string contra)
        {
            using( SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO usuarios (nombre, n_usuario, contraseña) VALUES (@nombre, @usuario, @contra);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contra", contra);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usario creado con éxito");

                        Form1 panta1 = new Form1();
                        panta1.Show();

                        new_user us = new new_user();
                        us.Hide();
                    }

                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
