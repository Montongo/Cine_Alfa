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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 setr = new Form3();
            setr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            panta4.Show();
            this.Hide();
            
            
        }

        private void elegido_Click(object sender, EventArgs e)
        {

        }

        int n1= Nota.n1, n2=Nota.n2, n3=Nota.n3;
        
        public void Asientos()
        {
            
            elegido.Text = "Total de asientos: " + (n1 + n2 + n3);
            Sala.Text = "Sala: " + Nota.sal;
        }

       

        private void Seleccion_Load(object sender, EventArgs e)
        {
            Asientos();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
