using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaAudioVideo_GrafMult
{
    public partial class PracticaReproductor : Form
    {
        public PracticaReproductor()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Abrir";
            abrir.ShowDialog();

            mediaPlayer.URL = abrir.FileName;
            mediaPlayer.Ctlcontrols.play();
        }
    }
}
