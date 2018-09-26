using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Practica8_GrafMult.Properties;

namespace Practica8_GrafMult
{
    public partial class FormGaleria : Form
    {
        private readonly List<Image> imagenes = new List<Image>
        {
            Resources._1, Resources._2, Resources._3, Resources._4, Resources._5, Resources._6, Resources._7,
            Resources._8, Resources._9, Resources._10, Resources._11, Resources._12, Resources._13, Resources._14,
            Resources._15, Resources._16, Resources._17, Resources._18, Resources._19, Resources._20, Resources._21,
            Resources._22, Resources._23, Resources._24, Resources._25
        };

        public FormGaleria()
        {
            InitializeComponent();
        }

        private void FormGaleria_Load(object sender, EventArgs e)
        {
            timerPresentacion.Interval = 10000;
            Presentacion();
        }

        public void aleatorio()
        {
            var random = new Random();
            var img = random.Next(0, 24);

            pictureBoxGaleria.BackgroundImage = imagenes[img];
        }

        public void Presentacion()
        {
            timerPresentacion.Stop();
            timerPresentacion.Start();
        }

        private void timerPresentacion_Tick(object sender, EventArgs e)
        {
            aleatorio();
        }

        private void buttonPresentacion_Click(object sender, EventArgs e)
        {
            Presentacion();
        }

        private void buttonOtra_Click(object sender, EventArgs e)
        {
            timerPresentacion.Stop();
            aleatorio();
        }
    }
}