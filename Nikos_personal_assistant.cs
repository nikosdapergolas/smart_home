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
    public partial class Nikos_personal_assistant : Form
    {
        public Nikos_personal_assistant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_day_choosing day = new Nikos_assistant_day_choosing();
            day.Show();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_assistant_activities_showing activities = new Nikos_assistant_activities_showing();
            activities.Show();
        }

        private void Nikos_personal_assistant_Load(object sender, EventArgs e)
        {

        }
    }
}
