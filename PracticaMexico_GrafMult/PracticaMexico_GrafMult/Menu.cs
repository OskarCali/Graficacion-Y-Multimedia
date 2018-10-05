using System;
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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void picBoxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxAcerca_Click(object sender, EventArgs e)
        {
            formAcercaDe acercaDe = new formAcercaDe();
            Hide();
            acercaDe.ShowDialog(this);
            Show();
        }

        private void lblGaleria_Click(object sender, EventArgs e)
        {
            formGaleria galeria = new formGaleria();
            Hide();
            galeria.ShowDialog(this);
            Show();
        }

        private void picBoxPeligro_Click(object sender, EventArgs e)
        {
            formExtincion extincion = new formExtincion();
            Hide();
            extincion.ShowDialog(this);
            Show();
        }

        private void picBoxDesierto_Click(object sender, EventArgs e)
        {
            formDesierto desierto = new formDesierto();
            Hide();
            desierto.ShowDialog(this);
            Show();
        }

        private void picBoxSelva_Click(object sender, EventArgs e)
        {
            formMarino marino = new formMarino();
            Hide();
            marino.ShowDialog(this);
            Show();
        }

        private void picBoxMar_Click(object sender, EventArgs e)
        {
            formSelva selva = new formSelva();
            Hide();
            selva.ShowDialog(this);
            Show();
        }
    }
}
