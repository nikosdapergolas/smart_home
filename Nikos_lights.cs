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
            Nikos_lights_bedroom1 bedroom1 = new Nikos_lights_bedroom1();
            bedroom1.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Nikos_lights_living_room living_room = new Nikos_lights_living_room();
            living_room.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Nikos_lights_kitchen kitchen = new Nikos_lights_kitchen();
            kitchen.Show();
        }
    }
}
