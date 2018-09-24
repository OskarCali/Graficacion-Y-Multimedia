using System;
using System.Windows.Forms;
using AxWMPLib;
using Practica4_GrafMult.Properties;
using WMPLib;

namespace Practica4_GrafMult
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            buttonPlayPause.Text = "";
            buttonStop.Text = "";
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