using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Cine_Alfa
{
    internal class user_nuevo(Form1 form1, new_user form2)
    {
        private Form form1 = form1;
        private Form form2 = form2;

        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ds;Integrated Security=True;TrustServerCertificate=True;");
        
        public  void crear_user(string nombre, string usuario, string contra)
        {

            string query = "SELECT * FROM usuarios WHERE n_usuario = @user;";

            using (SqlConnection cone = new SqlConnection(connection))
            {
                cone.Open();

                using (SqlCommand cmd = new SqlCommand(query, cone))
                {

                    cmd.Parameters.AddWithValue("@user", usuario);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("El nombre de usuario ya existe");
                        
                    }
                    else
                    {
                        query = "INSERT INTO usuarios (nombre, n_usuario, contraseña) VALUES (@nombre, @usuario, @contra);";

                        cmd.CommandText = query;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contra", contra);



                        int filasActualizadas = cmd.ExecuteNonQuery();

                        if (filasActualizadas > 0)
                        {
                            MessageBox.Show("Usario creado con éxito");
                            form1.Show();
                            form2.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error al crear usuario");
                        }
                    }
                    
                }
            }
        }
    }
}

