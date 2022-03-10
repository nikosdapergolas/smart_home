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
    public partial class Nikos_shoe_rack_ViewShoesColor : Form
    {
        public Nikos_shoe_rack_ViewShoesColor()
        {
            InitializeComponent();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nikos_shoe_rack_ViewShoesColor_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void Nikos_shoe_rack_ViewShoesColor_MouseLeave(object sender, EventArgs e)
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
