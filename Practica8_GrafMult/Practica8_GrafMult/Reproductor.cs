using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using Practica8_GrafMult.Properties;
using WMPLib;

namespace Practica8_GrafMult
{
    public partial class FormReproductor : Form
    {
        public FormReproductor()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Abrir";
            file.Filter = "Archivo MP4 (*.mp4) |*.mp4";
            file.ShowDialog();

            if (file.FileName != "")
            {
                mediaPlayer.URL = file.FileName;
                mediaPlayer.Ctlcontrols.play();

                buttonStop.Visible = true;
                buttonPlayPause.Visible = true;
            }
        }

        private void FormReproductor_Load(object sender, EventArgs e)
        {
            buttonAbrir.Text = "";
            buttonPlayPause.Text = "";
            buttonStop.Text = "";
            buttonStop.Visible = false;
            buttonPlayPause.Visible = false;
            buttonAbrir.BackgroundImage = Resources.Abrir;
            buttonStop.BackgroundImage = Resources.stop;
        }

        private void buttonPlayPause_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
                mediaPlayer.Ctlcontrols.pause();
            else
                mediaPlayer.Ctlcontrols.play();
        }

        private void mediaPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
                buttonPlayPause.BackgroundImage = Resources.pause;
            else
                buttonPlayPause.BackgroundImage = Resources.play;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
        }
    }
}
