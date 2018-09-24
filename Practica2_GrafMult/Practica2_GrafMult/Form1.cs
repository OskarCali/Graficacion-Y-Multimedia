using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica2_GrafMult
{
    public partial class Practica2 : Form
    {
        public Practica2()
        {
            InitializeComponent();
        }

        private void Practica2_Load(object sender, EventArgs e)
        {
            pictureBoxCubo.Visible = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxCubo_VisibleChanged(object sender, EventArgs e)
        {
            if (pictureBoxCubo.Visible)
            {
                buttonVerOcultar.Text = "Ocultar Imagen";
                buttonVerOcultar.FlatAppearance.MouseOverBackColor = Color.Coral;
            }
            else
            {
                buttonVerOcultar.Text = "Ver Imagen";
                buttonVerOcultar.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            }
        }

        private void buttonVerOcultar_Click(object sender, EventArgs e)
        {
            if (pictureBoxCubo.Visible)
                pictureBoxCubo.Visible = false;
            else
                pictureBoxCubo.Visible = true;
        }
    }
}