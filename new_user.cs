﻿using System;
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
    public partial class new_user : Form
    {
        public new_user()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ingresa_nombre.Text) || string.IsNullOrWhiteSpace(ingresa_contra.Text) || string.IsNullOrWhiteSpace(confirma_contra.Text) || string.IsNullOrWhiteSpace(ingresa_user.Text))
            {
                MessageBox.Show("llena todos los datos solicitados");
            }

            else
            {
                if (ingresa_contra.Text.Equals(confirma_contra.Text))
                {
                    user_nuevo us_nuevo = new user_nuevo();
                    us_nuevo.crear_user(ingresa_nombre.Text, ingresa_user.Text, ingresa_contra.Text);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }
    }
}