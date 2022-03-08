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
        //-------------------------------------------------
        // Monday activities

        public static string monday1;
        public static string monday2;
        public static string monday3;
        public static string monday4;
        public static string monday5;
        public static string monday6;
        public static string monday7;
        public static string monday8;
        public static string monday9;
        public static string monday10;
        public static string monday11;
        public static string monday12;
        public static string monday13;
        public static string monday14;
        public static string monday15;
        public static string monday16;
        public static string monday17;
        public static string monday18;
        public static string monday19;
        public static string monday20;
        public static string monday21;
        public static string monday22;
        public static string monday23;
        public static string monday24;


        //-------------------------------------------------


        public static string day;
        public static int day_code;

        public Nikos_assistant_activities_choosing(string today,int dayCode)
        {
            day = today;
            InitializeComponent();
            day_code = dayCode;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To programma ypovlithike me epityxia");
            if(day_code == 1)
            {
                monday1 = textBox1.Text;
                monday2 = textBox2.Text;
                monday3 = textBox3.Text;
                monday4 = textBox4.Text;
                monday5 = textBox5.Text;
                monday6 = textBox6.Text;
                monday7 = textBox7.Text;
                monday8 = textBox8.Text;
                monday9 = textBox9.Text;
                monday10 = textBox10.Text;
                monday11 = textBox11.Text;
                monday12 = textBox12.Text;
                monday13 = textBox13.Text;
                monday14 = textBox14.Text;
                monday15 = textBox15.Text;
                monday16 = textBox16.Text;
                monday17 = textBox17.Text;
                monday18 = textBox18.Text;
                monday19 = textBox19.Text;
                monday20 = textBox20.Text;
                monday21 = textBox21.Text;
                monday22 = textBox22.Text;
                monday23 = textBox23.Text;
                monday24 = textBox24.Text;
            }
            
            this.Close();
            Nikos_personal_assistant assist = new Nikos_personal_assistant();
            assist.Show();
        }
    }
}
