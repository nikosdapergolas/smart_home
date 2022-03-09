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
    public partial class Nikos_shoe_suggest : Form
    {
        string today = Form1.day;
        int TimeNow = Form1.time;
        public Nikos_shoe_suggest()
        {
            InitializeComponent();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_shoe_rack rack = new Nikos_shoe_rack();
            rack.Show();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nikos_shoe_suggest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(today=="Monday")
            {


            }
            if (today == "Tuesday")
            {

            }
            if (today == "Wednesday")
            {

            }
            if (today == "Thursday")
            {

            }
            if (today == "Friday")
            {

            }
            if (today == "Saturday")
            {

            }
            if (today == "Sunday")
            {

            }
        }
    }
}
