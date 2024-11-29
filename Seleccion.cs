using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Alfa
{
    public partial class Seleccion : Form
    {
        public Seleccion()
        {
            InitializeComponent();
        }





        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 setr = new Form3();
            setr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 set = new Form4();
            set.Show();
            this.Hide();
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {

        }
    }
}
