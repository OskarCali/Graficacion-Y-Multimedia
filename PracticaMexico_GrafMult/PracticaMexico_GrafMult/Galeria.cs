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
    public partial class formGaleria : Form
    {
        DB_Animal dbAnimal = new DB_Animal();

        public formGaleria()
        {
            InitializeComponent();
        }

        private void picBoxRegresar_Click(object sender, EventArgs e)
        {
            timerGaleria.Stop();
            Close();
        }

        private void formGaleria_Load(object sender, EventArgs e)
        {
            aleatorio();
            timerGaleria.Interval = 5000;
            presentacion();
        }

        private void presentacion()
        {
            timerGaleria.Start();
        }

        private void aleatorio()
        {
            int animalCount = dbAnimal.Animales.Count();
            var random = new Random().Next(1, animalCount);

            var animal = dbAnimal.Animales.FirstOrDefault(ani => ani.ID == random);

            lblNombre.Text = animal?.Nombre;
            lblCategoria.Text = animal?.Categoria;
            picBoxAnimal.BackgroundImage = Image.FromFile(animal.Imagen);
        }

        private void timerGaleria_Tick(object sender, EventArgs e)
        {
            aleatorio();
        }
    }
}
