﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMexico_GrafMult
{
    public partial class formMarino : Form
    {
        formDetalles detalles = new formDetalles();

        public formMarino()
        {
            InitializeComponent();
        }

        private void picBoxRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Marino_Load(object sender, EventArgs e)
        {
            detalles.categoria = "Marinos";
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            detalles.nombre = lbl1.Text;
            Hide();
            detalles.ShowDialog(this);
            Show();
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            detalles.nombre = lbl2.Text;
            Hide();
            detalles.ShowDialog(this);
            Show();
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            detalles.nombre = lbl3.Text;
            Hide();
            detalles.ShowDialog(this);
            Show();
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            detalles.nombre = lbl4.Text;
            Hide();
            detalles.ShowDialog(this);
            Show();
        }
    }
}
