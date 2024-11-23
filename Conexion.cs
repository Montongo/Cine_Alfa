using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;



namespace Cine_Alfa
{
     class Conexion
    {

        

        public Conexion()
        {
            SqlConnection cnx;
            try 
            {
                
                    cnx = new SqlConnection("Data source= E\\SQLPRACTICE; Initial Catalog= Alfa_cine; User ID =sa; Password=12345678;Encrypt=False ");
                cnx.Open();
                MessageBox.Show("Conexion con exito", "chambea", MessageBoxButtons.OK);

                

                  
               
            }

            catch (Exception e) 
            {
                MessageBox.Show("Error:" + e.Message);
            }
              

        }

    }
}
