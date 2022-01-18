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
    public partial class Nikos_shoe_rack : Form
    {
        public Nikos_shoe_rack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the "Show todays plan" button
            richTextBox5.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the "Show todays plan" button
            richTextBox5.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the "Add a new plan" button
            richTextBox2.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the "Add a new plan" button
            richTextBox2.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the " Add new shoe to the shoe rack" button
            richTextBox3.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the " Add new shoe to the shoe rack" button
            richTextBox3.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the "Show the number of owned shoes(per Category)" button
            richTextBox4.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the "Show the number of owned shoes(per Category)" button
            richTextBox4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the "Show the number of owned shoes(per Color)" button
            richTextBox6.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers over the "Show the number of owned shoes(per Color)" button
            richTextBox6.Visible = false;
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
