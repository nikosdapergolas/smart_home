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
    public partial class Nikos_shoe_rack_eshop : Form
    {
        public Nikos_shoe_rack_eshop()
        {
            InitializeComponent();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_shoe_rack r = new Nikos_shoe_rack();
            r.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιτυχής Αγορά");
            this.Close();
            Nikos_shoe_rack r = new Nikos_shoe_rack();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιτυχής Αγορά");
            this.Close();
            Nikos_shoe_rack r = new Nikos_shoe_rack();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιτυχής Αγορά");
            this.Close();
            Nikos_shoe_rack r = new Nikos_shoe_rack();
            r.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false ;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://we.tl/t-RRnMcJTG8u");
        }
    }
}
