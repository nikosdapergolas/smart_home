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
    public partial class Nikos_lights : Form
    {

        public static bool bedroom1_lightsOn = true;
        public static int bedroom1_trackbar_value = 10;
        public static bool living_room_lightsOn = true;
        public static int living_room_trackbar_value = 10;
        public static bool kitchen_lightsOn = true;
        public static int kitchen_trackbar_value = 10;
        public static bool toilet_lightsOn = true;
        public static int toilet_trackbar_value = 10;
        public static bool bathroom_lightsOn = true;
        public static int bathroom_trackbar_value = 10;
        public static bool bedroom2_lightsOn = true;
        public static int bedroom2_trackbar_value = 10;

        public Nikos_lights()
        {
            InitializeComponent();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            richTextBox3.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox3.Visible = false;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox4.Visible = false;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox6.Visible = false;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void Nikos_lights_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_lights_bedroom1 bedroom1 = new Nikos_lights_bedroom1();
            bedroom1.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_lights_living_room living_room = new Nikos_lights_living_room();
            living_room.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_lights_kitchen kitchen = new Nikos_lights_kitchen();
            kitchen.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_lights_toilet toilet = new Nikos_lights_toilet();
            toilet.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_lights_bathroom bathroom = new Nikos_lights_bathroom();
            bathroom.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_lights_bedroom2 bedroom2 = new Nikos_lights_bedroom2();
            bedroom2.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exitApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        https://we.tl/t-RRnMcJTG8u
        }
    }
}
