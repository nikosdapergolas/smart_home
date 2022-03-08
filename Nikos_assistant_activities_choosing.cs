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
    public partial class Nikos_assistant_activities_choosing : Form
    {
        public static string day;

        public Nikos_assistant_activities_choosing(string today)
        {
            day = today;
            InitializeComponent();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_day_choosing day = new Nikos_assistant_day_choosing();
            day.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nikos_assistant_activities_choosing_Load(object sender, EventArgs e)
        {
            label25.Text = day;
        }
    }
}
