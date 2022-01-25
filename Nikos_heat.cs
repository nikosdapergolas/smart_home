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
    public partial class Nikos_heat : Form
    {
        public static bool bedroom1_heat_panel_active = false;

        public Nikos_heat()
        {
            InitializeComponent();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // Opening the heat control panel and passing through
            // the constructor the name of the room

            Nikos_heat_control heat_panel = new Nikos_heat_control("Υπνοδωμάτιο 1");
            heat_panel.Show();
            bedroom1_heat_panel_active = true;
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλωσορίσατε στο σαλόνι");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλωσορίσατε στην κουζίνα");
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλωσορίσατε στην τουαλέτα");
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλωσορίσατε στο μπάνιο");
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλωσορίσατε στο υπμοδωμάτιο 2");
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the bedroom 1
            richTextBox2.Visible = true;
            richTextBox8.Visible = true;
            richTextBox9.Visible = true;
            richTextBox10.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bedroom 1
            richTextBox2.Visible = false;
            richTextBox8.Visible = false;
            richTextBox9.Visible = false;
            richTextBox10.Visible = false;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the living room
            richTextBox3.Visible = true;
            richTextBox11.Visible = true;
            richTextBox12.Visible = true;
            richTextBox13.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the living room
            richTextBox3.Visible = false;
            richTextBox11.Visible = false;
            richTextBox12.Visible = false;
            richTextBox13.Visible = false;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the kitchen
            richTextBox4.Visible = true;
            richTextBox20.Visible = true;
            richTextBox21.Visible = true;
            richTextBox22.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the kitchen
            richTextBox4.Visible = false;
            richTextBox20.Visible = false;
            richTextBox21.Visible = false;
            richTextBox22.Visible = false;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the toilet
            richTextBox5.Visible = true;
            richTextBox23.Visible = true;
            richTextBox24.Visible = true;
            richTextBox25.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the toilet
            richTextBox5.Visible = false;
            richTextBox23.Visible = false;
            richTextBox24.Visible = false;
            richTextBox25.Visible = false;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the bathroom
            richTextBox6.Visible = true;
            richTextBox17.Visible = true;
            richTextBox18.Visible = true;
            richTextBox19.Visible = true;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bathroom
            richTextBox6.Visible = false;
            richTextBox17.Visible = false;
            richTextBox18.Visible = false;
            richTextBox19.Visible = false;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the bedroom 2
            richTextBox1.Visible = true;
            richTextBox14.Visible = true;
            richTextBox15.Visible = true;
            richTextBox16.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bedroom 2
            richTextBox1.Visible = false;
            richTextBox14.Visible = false;
            richTextBox15.Visible = false;
            richTextBox16.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the info icon
            richTextBox7.Visible = true;
            label1.Visible = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the info icon
            richTextBox7.Visible = false;
            label1.Visible = true;
        }

        private void richTextBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This timer controls at every tick, what happens every second
            // in this form. 
            // To be honest i just put it here so i can see whether some forms
            // are open or not 

            if (bedroom1_heat_panel_active)
            {
                panel1.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
            }
        }
    }
}
