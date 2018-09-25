using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDB_GrafMult
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personaDataGridView.DataSource = personaBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataBase.Connection() != null)
            {
                MessageBox.Show("Conexion exitosa", "DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Conexion fallida", "DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = textBoxNombre.Text;
            persona.apellido = textBoxApellido.Text;
            persona.edad = Convert.ToInt32(textBoxEdad.Text);

            if (DataBase.agregar(persona) == 0)
            {
                MessageBox.Show("Hubo un error al agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Agregado correctamente", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
