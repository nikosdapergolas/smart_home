﻿using System;
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
            trackBar1.Value = Nikos_lights.living_room_trackbar_value;
            lightsOn = Nikos_lights.living_room_lightsOn;
            if (lightsOn == true)
            {
                label3.Text = "Κλείσιμο";
                pictureBox1.Image = Properties.Resources.lightbulb_open;
                if (trackBar1.Value == 0)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_0;
                }
                else if (trackBar1.Value == 1)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_1;
                }
                else if (trackBar1.Value == 2)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_2;
                }
                else if (trackBar1.Value == 3)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_3;
                }
                else if (trackBar1.Value == 4)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_4;
                }
                else if (trackBar1.Value == 5)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_5;
                }
                else if (trackBar1.Value == 6)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_6;
                }
                else if (trackBar1.Value == 7)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_7;
                }
                else if (trackBar1.Value == 8)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_8;
                }
                else if (trackBar1.Value == 9)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_9;
                }
                else
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on;
                }

            }
            else
            {
                label3.Text = "Άνοιγμα";
                pictureBox1.Image = Properties.Resources.lightbulb_closed;
                this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_off;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Nikos_lights.living_room_trackbar_value = trackBar1.Value;
            Nikos_lights.living_room_lightsOn = lightsOn;
            this.Close();
            Nikos_lights lights = new Nikos_lights();
            lights.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (lightsOn == true)
            {
                lightsOn = false;
                pictureBox1.Image = Properties.Resources.lightbulb_closed;
                this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_off;
                label3.Text = "Άνοιγμα";
            }
            else
            {
                lightsOn = true;
                label3.Text = "Κλείσιμο";
                pictureBox1.Image = Properties.Resources.lightbulb_open;
                if (trackBar1.Value == 0)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_0;
                }
                else if (trackBar1.Value == 1)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_1;
                }
                else if (trackBar1.Value == 2)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_2;
                }
                else if (trackBar1.Value == 3)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_3;
                }
                else if (trackBar1.Value == 4)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_4;
                }
                else if (trackBar1.Value == 5)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_5;
                }
                else if (trackBar1.Value == 6)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_6;
                }
                else if (trackBar1.Value == 7)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_7;
                }
                else if (trackBar1.Value == 8)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_8;
                }
                else if (trackBar1.Value == 9)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_9;
                }
                else
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (lightsOn == true)
            {
                if (trackBar1.Value == 0)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_0;
                }
                else if (trackBar1.Value == 1)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_1;
                }
                else if (trackBar1.Value == 2)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_2;
                }
                else if (trackBar1.Value == 3)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_3;
                }
                else if (trackBar1.Value == 4)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_4;
                }
                else if (trackBar1.Value == 5)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_5;
                }
                else if (trackBar1.Value == 6)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_6;
                }
                else if (trackBar1.Value == 7)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_7;
                }
                else if (trackBar1.Value == 8)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_8;
                }
                else if (trackBar1.Value == 9)
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on_9;
                }
                else
                {
                    this.BackgroundImage = Smart_home.Properties.Resources.living_room_lights_on;
                }
            }
        }
    }
}
