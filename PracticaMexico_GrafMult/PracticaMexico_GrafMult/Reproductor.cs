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
    public partial class formReproductor : Form
    {
        public string url;
        public string nombre;

        public formReproductor()
        {
            InitializeComponent();
        }

        private void formReproductor_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            lblNombre.Text = nombre;
            mediaPlayer.URL = url;
            mediaPlayer.Ctlcontrols.play();
        }

        private void picBoxRegresar_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
            Close();
        }

        private void picBoxMaxMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
