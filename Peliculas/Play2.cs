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
    public partial class Play2 : Form
    {
        public Play2()
        {
            InitializeComponent();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Nota.dato1(2);
            Hora_random hora_Random = new Hora_random();
            DateTime horaInicial = hora_Random.GenerarHoraAleatoria();
            Nota.dato2(horaInicial.ToString("HH:mm"), horaInicial.AddMinutes(80).ToString("HH:mm"), horaInicial.AddMinutes(160).ToString("HH:mm"), horaInicial.AddMinutes(240).ToString("HH:mm"));
            Horarios horarios = new Horarios();
            char sal = Hora_random.Sala();
            Nota.dato5(sal);
            horarios.Show();
            this.Hide();
        }

        private void atras3_Click(object sender, EventArgs e)
        {
            Catalogo ca = new Catalogo();
            ca.Show();
            this.Hide();
        }

        private void Play2_Load(object sender, EventArgs e)
        {

        }
    }
}
