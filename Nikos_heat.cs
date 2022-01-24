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
            MessageBox.Show("Καλωσορίσατε στο υπμοδωμάτιο 1");
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
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bedroom 1
            richTextBox2.Visible = false;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the living room
            richTextBox3.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the living room
            richTextBox3.Visible = false;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the kitchen
            richTextBox4.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the kitchen
            richTextBox4.Visible = false;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the toilet
            richTextBox5.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the toilet
            richTextBox5.Visible = false;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the bathroom
            richTextBox6.Visible = true;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bathroom
            richTextBox6.Visible = false;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the bedroom 2
            richTextBox1.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bedroom 2
            richTextBox1.Visible = false;
        }
    }
}
