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

    internal class verificar_user(Form1 form1, Catalogo form2) 
    {
        private Form form1 = form1;
        private Form form2 = form2;

        string connection = ("Server=LAPTOP-0045SGMV\\SQLEXPRESS;Database=proyecto_ds;Integrated Security=True;TrustServerCertificate=True;");

        public void verificar(string usuario, string contra)
        {
            try
            {
                using (SqlConnection cone = new SqlConnection(connection))
                {
                    cone.Open();
                    string query = "SELECT id FROM usuarios WHERE n_usuario = @n_usuario AND contraseña = @contraseña;";
                    using (SqlCommand cmd = new SqlCommand(query, cone))
                    {
                        
                        cmd.Parameters.AddWithValue("@n_usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contra);

                        object result = cmd.ExecuteScalar(); 

                        if (result != null)
                        {
                            int idUsuario = Convert.ToInt32(result); 
                            
                            Nota.id(idUsuario);
                            
                            MessageBox.Show("Bienvenido(a) " + usuario);
                          
                            form2.Show();
                            form1.Hide();
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
