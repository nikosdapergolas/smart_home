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

        public static bool monday_has_plan = false;
        public static bool tuesday_has_plan = false;
        public static bool wednesday_has_plan = false;
        public static bool thursday_has_plan = false;
        public static bool friday_has_plan = false;
        public static bool saturday_has_plan = false; // Ftiaxnw code na allazei autes edw
        public static bool sunday_has_plan = false;

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
            //eafserf
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://we.tl/t-RRnMcJTG8u");
        }
    }
}
