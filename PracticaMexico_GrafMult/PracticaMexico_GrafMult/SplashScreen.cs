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
    public partial class formSplashScreen : Form
    {
        public int tiempo { get; set; }

        public formSplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            tiempo = 5;
            timerSplash.Interval = 1000;
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                --tiempo;
            }
            else
            {
                timerSplash.Stop();
                Hide();
                formMenu menu = new formMenu();
                menu.ShowDialog(this);
                Application.Exit();
            }
        }
    }
}
