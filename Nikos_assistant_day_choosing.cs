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
    public partial class Nikos_assistant_day_choosing : Form
    {
        public Nikos_assistant_day_choosing()
        {
            InitializeComponent();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_personal_assistant assistant = new Nikos_personal_assistant();
            assistant.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_choosing activity = new Nikos_assistant_activities_choosing(button1.Text,1);
            activity.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_choosing activity = new Nikos_assistant_activities_choosing(button2.Text,2);
            activity.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_choosing activity = new Nikos_assistant_activities_choosing(button3.Text,3);
            activity.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_choosing activity = new Nikos_assistant_activities_choosing(button4.Text,4);
            activity.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_choosing activity = new Nikos_assistant_activities_choosing(button5.Text,5);
            activity.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_choosing activity = new Nikos_assistant_activities_choosing(button6.Text,6);
            activity.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_choosing activity = new Nikos_assistant_activities_choosing(button7.Text,7);
            activity.Show();
        }

        private void Nikos_assistant_day_choosing_Load(object sender, EventArgs e)
        {
            
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://we.tl/t-RRnMcJTG8u");
        }
    }
}
