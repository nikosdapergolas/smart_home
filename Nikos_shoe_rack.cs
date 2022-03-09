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
        public static int Ads;
        public Nikos_shoe_rack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if()
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
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the "Add a new plan" button
            
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
            this.Close();
            Nikos_shoe_rack_ViewShoesColor form2 = new Nikos_shoe_rack_ViewShoesColor();
            form2.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_shoe_rack_ShoeChoose form2 = new Nikos_shoe_rack_ShoeChoose();
            form2.Show();
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

        private void Nikos_shoe_rack_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_shoe_rack_ViewShoesKind form2 = new Nikos_shoe_rack_ViewShoesKind();
            form2.Show();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
