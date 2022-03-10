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
    public partial class Nikos_google_maps : Form
    {
        public Nikos_google_maps()
        {
            InitializeComponent();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_showing s = new Nikos_assistant_activities_showing();
            s.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nikos_google_maps_Load(object sender, EventArgs e)
        {
            if(Nikos_redirection_to_google_maps.choice == 1)
            {
                pictureBox1.ImageLocation = "pictures/google_maps.png";
            }
            else
            {
                pictureBox1.ImageLocation = "pictures/weather.jpg";
            }
        }
    }
}
