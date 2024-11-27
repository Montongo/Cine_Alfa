using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Cine_Alfa
{
    internal class restaurar_contra
    {
        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ds;Integrated Security=True;TrustServerCertificate=True;");

        public void restaurar(string usuario, string contraseña)
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
                        
                        query = "UPDATE usuarios SET contraseña = @nuevaContraseña WHERE n_usuario = @user;";

                        
                        cmd.CommandText = query;
                        cmd.Parameters.Clear(); 
                        cmd.Parameters.AddWithValue("@nuevaContraseña", contraseña);
                        cmd.Parameters.AddWithValue("@user", usuario);



                        int filasActualizadas = cmd.ExecuteNonQuery();

                        if (filasActualizadas > 0)
                        {
                            MessageBox.Show("Contraseña actualizada con éxito");
                            Form1 form1 = new Form1();
                            form1.Show();

                            restore_contra restore = new restore_contra();
                            restore.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la contraseña");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                }
            }
        }
    }
}
