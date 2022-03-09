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
    public partial class Nikos_assistant_activities_showing : Form
    {

        public static int day_code = 1;

        public Nikos_assistant_activities_showing()
        {
            InitializeComponent();
        }

        private void Nikos_assistant_activities_showing_Load(object sender, EventArgs e)
        {
            panel1.BackColor = button1.BackColor;

            show_monday();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_personal_assistant personal = new Nikos_personal_assistant();
            personal.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            day_code = 1;
            panel1.BackColor = button1.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            day_code = 2;
            panel1.BackColor = button2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            day_code = 3;
            panel1.BackColor = button3.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            day_code = 4;
            panel1.BackColor = button4.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            day_code = 5;
            panel1.BackColor = button5.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            day_code = 6;
            panel1.BackColor = button6.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            day_code = 7;
            panel1.BackColor = button7.BackColor;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            richTextBox3.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox3.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox4.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox6.Visible = false;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            richTextBox7.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox7.Visible = false;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            richTextBox8.Visible = true;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            richTextBox8.Visible = false;
        }

        public void show_monday()
        {
            label1.Text = Nikos_assistant_activities_choosing.monday6;
            label2.Text = Nikos_assistant_activities_choosing.monday7;
            label3.Text = Nikos_assistant_activities_choosing.monday8;
            label4.Text = Nikos_assistant_activities_choosing.monday9;
            label5.Text = Nikos_assistant_activities_choosing.monday10;
            label6.Text = Nikos_assistant_activities_choosing.monday11;
            label7.Text = Nikos_assistant_activities_choosing.monday12;
            label8.Text = Nikos_assistant_activities_choosing.monday13;
            label9.Text = Nikos_assistant_activities_choosing.monday14;
            label10.Text = Nikos_assistant_activities_choosing.monday15;
            label11.Text = Nikos_assistant_activities_choosing.monday16;
            label12.Text = Nikos_assistant_activities_choosing.monday17;
            label13.Text = Nikos_assistant_activities_choosing.monday18;
            label14.Text = Nikos_assistant_activities_choosing.monday19;
            label15.Text = Nikos_assistant_activities_choosing.monday20;
            label16.Text = Nikos_assistant_activities_choosing.monday21;
            label17.Text = Nikos_assistant_activities_choosing.monday22;

            label18.Text = Nikos_assistant_activities_choosing.monday_activity_type6;
            label19.Text = Nikos_assistant_activities_choosing.monday_activity_type7;
            label20.Text = Nikos_assistant_activities_choosing.monday_activity_type8;
            label21.Text = Nikos_assistant_activities_choosing.monday_activity_type9;
            label22.Text = Nikos_assistant_activities_choosing.monday_activity_type10;
            label23.Text = Nikos_assistant_activities_choosing.monday_activity_type11;
            label24.Text = Nikos_assistant_activities_choosing.monday_activity_type12;
            label25.Text = Nikos_assistant_activities_choosing.monday_activity_type13;
            label26.Text = Nikos_assistant_activities_choosing.monday_activity_type14;
            label27.Text = Nikos_assistant_activities_choosing.monday_activity_type15;
            label28.Text = Nikos_assistant_activities_choosing.monday_activity_type16;
            label29.Text = Nikos_assistant_activities_choosing.monday_activity_type17;
            label30.Text = Nikos_assistant_activities_choosing.monday_activity_type18;
            label31.Text = Nikos_assistant_activities_choosing.monday_activity_type19;
            label32.Text = Nikos_assistant_activities_choosing.monday_activity_type20;
            label33.Text = Nikos_assistant_activities_choosing.monday_activity_type21;
            label34.Text = Nikos_assistant_activities_choosing.monday_activity_type22;

            label35.Text = Nikos_assistant_activities_choosing.monday_transport6;
            label36.Text = Nikos_assistant_activities_choosing.monday_transport7;
            label37.Text = Nikos_assistant_activities_choosing.monday_transport8;
            label38.Text = Nikos_assistant_activities_choosing.monday_transport9;
            label39.Text = Nikos_assistant_activities_choosing.monday_transport10;
            label40.Text = Nikos_assistant_activities_choosing.monday_transport11;
            label41.Text = Nikos_assistant_activities_choosing.monday_transport12;
            label42.Text = Nikos_assistant_activities_choosing.monday_transport13;
            label43.Text = Nikos_assistant_activities_choosing.monday_transport14;
            label44.Text = Nikos_assistant_activities_choosing.monday_transport15;
            label45.Text = Nikos_assistant_activities_choosing.monday_transport16;
            label46.Text = Nikos_assistant_activities_choosing.monday_transport17;
            label47.Text = Nikos_assistant_activities_choosing.monday_transport18;
            label48.Text = Nikos_assistant_activities_choosing.monday_transport19;
            label49.Text = Nikos_assistant_activities_choosing.monday_transport20;
            label50.Text = Nikos_assistant_activities_choosing.monday_transport21;
            label51.Text = Nikos_assistant_activities_choosing.monday_transport22;
        }
    }
}
