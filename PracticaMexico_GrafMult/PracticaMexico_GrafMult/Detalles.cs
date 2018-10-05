using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMexico_GrafMult
{
    public partial class formDetalles : Form
    {
        DB_Animal dbAnimal = new DB_Animal();
        Animal animal = new Animal();
        public string nombre;
        public string categoria;

        SoundPlayer player = new SoundPlayer();

        public formDetalles()
        {
            InitializeComponent();
        }

        private void picBoxRegresar_Click(object sender, EventArgs e)
        {
            player.Stop();
            Close();
        }

        private void formDetalles_Load(object sender, EventArgs e)
        {
            btnPDFImagen.Text = "";
            btnSonido.Text = "";
            btnVideo.Text = "";

            animal = dbAnimal.Animales.FirstOrDefault(ani => ani.Nombre == nombre && ani.Categoria == categoria);

            lblNombre.Text = animal.Nombre;
            acrobatReader.LoadFile(animal.PDF);
            picBoxAnimal.BackgroundImage = Image.FromFile(animal.Imagen);
            mostrar(btnSonido, animal.ExisteAudio);
        }

        private void mostrar(Button elemento, int existe)
        {
            if (existe == 1)
            {
                elemento.Visible = true;
                player.SoundLocation = animal.Audio;
            }
            else
            {
                elemento.Visible = false;
            }
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            player.Stop();

            formReproductor reproductor = new formReproductor();
            reproductor.url = animal.Video;
            reproductor.nombre = nombre;

            Hide();
            reproductor.ShowDialog(this);
            Show();
        }

        private void btnPDFImagen_Click(object sender, EventArgs e)
        {
            player.Stop();

            if (picBoxAnimal.Visible)
            {
                picBoxAnimal.Visible = false;
                acrobatReader.Visible = true;
                btnPDFImagen.BackgroundImage = Properties.Resources.Galeria;
            }
            else
            {
                picBoxAnimal.Visible = true;
                acrobatReader.Visible = false;
                btnPDFImagen.BackgroundImage = Properties.Resources.Lector;
            }
        }
    }
}
