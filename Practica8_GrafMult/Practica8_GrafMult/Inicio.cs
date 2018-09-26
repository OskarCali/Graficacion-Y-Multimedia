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
    }
}
