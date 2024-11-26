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
    public partial class Play4 : Form
    {
        public Play4()
        {
            InitializeComponent();
        }

        private void atras3_Click(object sender, EventArgs e)
        {
            Catalogo ca = new Catalogo();
            ca.Show();
            this.Hide();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Form3 setr = new Form3();
            setr.Show();
            this.Hide();
        }
    }
}
