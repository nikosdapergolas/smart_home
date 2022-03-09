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
    public partial class Nikos_shoe_rack_ViewShoesKind : Form
    {
        public static string converse_chill="Λευκό Converse";
        public static string lacoste_chill = "Χαλαρό Lacoste";
        public static string jays_black_active = "Μαύρα αθλητικά";
        public static string jays_grey_active = "Γκρι αθλητικά";
        public static string leather_black_good = "Δερμάτινο μαύρο επίσημο";

        public Nikos_shoe_rack_ViewShoesKind()
        {
            InitializeComponent();
        }

        private void Nikos_shoe_rack_ViewShoesKind_Load(object sender, EventArgs e)
        {

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

        private void Nikos_shoe_rack_ViewShoesKind_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void Nikos_shoe_rack_ViewShoesKind_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false; 
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }
    }
}
