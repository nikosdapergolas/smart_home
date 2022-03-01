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
    public partial class Nikos_lights_living_room : Form
    {
        public static bool lightsOn;
        public Nikos_lights_living_room()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lightsOn == true)
            {
                lightsOn = false;
                this.BackgroundImage = Properties.Resources.living_room_lights_off;
            }
            else
            {
                lightsOn = true;
                this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on;
            }
        }

        private void Nikos_lights_living_room_Load(object sender, EventArgs e)
        {
            lightsOn = true;
        }
    }
}
