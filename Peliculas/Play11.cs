using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Alfa.Peliculas
{
    public partial class Play11 : Form
    {
        public Play11()
        {
            InitializeComponent();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Horarios horarios = new Horarios();
            horarios.Show();
            horarios.Poner_img(11);
            this.Hide();
        }

        private void atras3_Click(object sender, EventArgs e)
        {
            Catalogo ca = new Catalogo();
            ca.Show();
            this.Hide();
        }
    }
}
