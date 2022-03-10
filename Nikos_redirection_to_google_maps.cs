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
    public partial class Nikos_redirection_to_google_maps : Form
    {

        public static int choice;

        public Nikos_redirection_to_google_maps(int ch)
        {
            choice = ch;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if(progressBar1.Value == 100)
            {
                this.Close();
                Nikos_google_maps go = new Nikos_google_maps();
                go.Show();
            }
        }

        private void Nikos_redirection_to_google_maps_Load(object sender, EventArgs e)
        {
            if(choice == 1)
            {
                label3.Text = "google maps";
            }
            else
            {
                label3.Text = "greekWeather.gr";
            }
        }
    }
}
