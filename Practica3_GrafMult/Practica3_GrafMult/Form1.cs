using System;
using System.Media;
using System.Windows.Forms;

namespace Practica3_GrafMult
{
    public partial class Home : Form
    {
        private readonly SoundPlayer player = new SoundPlayer("C:/Users/Oskar Cali/Music/ringtone_01.wav");

        public Home()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}