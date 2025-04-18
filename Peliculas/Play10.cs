﻿using System;
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
    public partial class Play10 : Form
    {
        public Play10()
        {
            InitializeComponent();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Nota.dato1(10);
            Hora_random hora_Random = new Hora_random();
            DateTime horaInicial = hora_Random.GenerarHoraAleatoria();
            Nota.dato2(horaInicial.ToString("HH:mm"), horaInicial.AddMinutes(80).ToString("HH:mm"), horaInicial.AddMinutes(160).ToString("HH:mm"), horaInicial.AddMinutes(240).ToString("HH:mm"));
            char sal = Hora_random.Sala();
            Nota.dato5(sal);
            Horarios horarios = new Horarios();
            horarios.Show();
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
