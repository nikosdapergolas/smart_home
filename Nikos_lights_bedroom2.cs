using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_home
{
    public partial class Nikos_lights_bedroom2 : Form
    {

        public static bool lightsOn;

        public Nikos_lights_bedroom2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_lights lights = new Nikos_lights();
            lights.Show();
        }

        private void Nikos_lights_bedroom2_Load(object sender, EventArgs e)
        {
            lightsOn = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lightsOn == true)
            {
                lightsOn = false;
                this.BackgroundImage = Properties.Resources.bedroom2_lights_off;
            }
            else
            {
                lightsOn = true;
                this.BackgroundImage = Smart_home.Properties.Resources.bedroom2_lights_on;
            }
        }
    }
}
