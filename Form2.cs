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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the top label
            richTextBox1.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the the top label
            richTextBox1.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the heat button
            richTextBox3.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the the heat button
            richTextBox3.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the lights button
            richTextBox2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the the lights button
            richTextBox2.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the air condition button
            richTextBox4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the the air condition button
            richTextBox4.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the television button
            richTextBox5.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the the television button
            richTextBox5.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the shoe rack button
            richTextBox6.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the the television button
            richTextBox6.Visible = false;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the smart feeder button
            richTextBox7.Visible = true;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the the smart feeder button
            richTextBox7.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the information icon
            richTextBox8.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the the information icon
            richTextBox8.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // The image that is loaded everytime i open this form
            // and it represents the "help" icon (maybe change later)
            pictureBox1.ImageLocation = "pictures/info.png";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_shoe_rack shoe_rack = new Nikos_shoe_rack();
            shoe_rack.Show();

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eva_AirCondition_Form air_condition = new Eva_AirCondition_Form();
            air_condition.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_heat heat = new Nikos_heat();
            heat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_lights lights = new Nikos_lights();
            lights.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Nikos_personal_assistant personal_assistant = new Nikos_personal_assistant();
            personal_assistant.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            manakos_smart_feeder h = new manakos_smart_feeder();
          

            h.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            manakos_tv_activity personal_assistant = new manakos_tv_activity();
            personal_assistant.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
     
}
    
