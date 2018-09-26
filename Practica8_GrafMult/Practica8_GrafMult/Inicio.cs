using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica8_GrafMult
{
    public partial class FormInicio : System.Windows.Forms.Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonGaleria_Click(object sender, EventArgs e)
        {
            FormGaleria galeria = new FormGaleria();
            galeria.ShowDialog(this);
        }

        private void buttonReproductor_Click(object sender, EventArgs e)
        {
            FormReproductor reproductor = new FormReproductor();
            reproductor.ShowDialog(this);
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            FormPDF pdf = new FormPDF();
            pdf.ShowDialog(this);
        }

        private void buttonAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "La graficacion y multimedia son importantes ya que estas nos ayudan a comprender mejor " +
                "y de una manera mas facil algunas cosas.\n\nSe pueden tener varios elementos de apoyo como lo son:" +
                "\n• Imagenes\t• Videos\n• Textos\t\t• Hipervinculos\n• Etc...", "Acerca de...", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
