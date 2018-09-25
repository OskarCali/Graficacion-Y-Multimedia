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
            personaDataGridView.DataSource = DataBase.Cargar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxApellido.Text != "" && textBoxEdad.Text != "")
            {
                Persona persona = new Persona();
                persona.nombre = textBoxNombre.Text;
                persona.apellido = textBoxApellido.Text;
                persona.edad = Convert.ToInt32(textBoxEdad.Text);

                if (DataBase.Agregar(persona) == 0)
                {
                    MessageBox.Show("Hubo un error al agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    personaDataGridView.DataSource = DataBase.Cargar();
                    MessageBox.Show("Agregado correctamente", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                personaDataGridView.DataSource = DataBase.Cargar();
            }
            else
            {
                MessageBox.Show("Todos los campos deben de estar llenos", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se busca los registro por edad (>=).\n\t¿Desea continuar?", "BUSCAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (textBoxEdad.Text != "")
                {
                    personaDataGridView.DataSource = DataBase.Buscar(Convert.ToInt32(textBoxEdad.Text));
                }
                else
                {
                    MessageBox.Show("La edad no puede ser vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxApellido.Text != "" && textBoxEdad.Text != "")
            {
                if (MessageBox.Show("Va a eliminar a " + textBoxNombre.Text + " " + textBoxApellido.Text + "\n\t¿Seguro que desea eliminarlo?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (DataBase.Eliminar(textBoxNombre.Text, textBoxApellido.Text, Convert.ToInt32(textBoxEdad.Text)) == 0)
                    {
                        MessageBox.Show("No se pudo eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        personaDataGridView.DataSource = DataBase.Cargar();
                        MessageBox.Show("Eliminado correctamente", "ELIMINAR", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben de estar llenos", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxApellido.Text != "" && textBoxEdad.Text != "")
            {
                if (MessageBox.Show("Va a actualiza la edad de " + textBoxNombre.Text + " " + textBoxApellido.Text + "\n\t¿Seguro que desea actualizar?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (DataBase.Actualizar(textBoxNombre.Text, textBoxApellido.Text, Convert.ToInt32(textBoxEdad.Text)) == 0)
                    {
                        MessageBox.Show("No se pudo actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        personaDataGridView.DataSource = DataBase.Cargar();
                        MessageBox.Show("Actualizado correctamente", "ACTUALIZAR", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben de estar llenos", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            personaDataGridView.DataSource = DataBase.Cargar();
        }
    }
}
