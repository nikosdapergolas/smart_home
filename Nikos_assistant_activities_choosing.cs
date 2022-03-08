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


        //-------------------------------------------------
        // tuesday activities

        public static string tuesday6;
        public static string tuesday7;
        public static string tuesday8;
        public static string tuesday9;
        public static string tuesday10;
        public static string tuesday11;
        public static string tuesday12;
        public static string tuesday13;
        public static string tuesday14;
        public static string tuesday15;
        public static string tuesday16;
        public static string tuesday17;
        public static string tuesday18;
        public static string tuesday19;
        public static string tuesday20;
        public static string tuesday21;
        public static string tuesday22;


        //-------------------------------------------------
        // wednesday activities

        public static string wednesday6;
        public static string wednesday7;
        public static string wednesday8;
        public static string wednesday9;
        public static string wednesday10;
        public static string wednesday11;
        public static string wednesday12;
        public static string wednesday13;
        public static string wednesday14;
        public static string wednesday15;
        public static string wednesday16;
        public static string wednesday17;
        public static string wednesday18;
        public static string wednesday19;
        public static string wednesday20;
        public static string wednesday21;
        public static string wednesday22;


        //-------------------------------------------------
        // thursday activities

        public static string thursday6;
        public static string thursday7;
        public static string thursday8;
        public static string thursday9;
        public static string thursday10;
        public static string thursday11;
        public static string thursday12;
        public static string thursday13;
        public static string thursday14;
        public static string thursday15;
        public static string thursday16;
        public static string thursday17;
        public static string thursday18;
        public static string thursday19;
        public static string thursday20;
        public static string thursday21;
        public static string thursday22;


        //-------------------------------------------------
        // friday activities

        public static string friday6;
        public static string friday7;
        public static string friday8;
        public static string friday9;
        public static string friday10;
        public static string friday11;
        public static string friday12;
        public static string friday13;
        public static string friday14;
        public static string friday15;
        public static string friday16;
        public static string friday17;
        public static string friday18;
        public static string friday19;
        public static string friday20;
        public static string friday21;
        public static string friday22;


        //-------------------------------------------------
        // saturday activities

        public static string saturday6;
        public static string saturday7;
        public static string saturday8;
        public static string saturday9;
        public static string saturday10;
        public static string saturday11;
        public static string saturday12;
        public static string saturday13;
        public static string saturday14;
        public static string saturday15;
        public static string saturday16;
        public static string saturday17;
        public static string saturday18;
        public static string saturday19;
        public static string saturday20;
        public static string saturday21;
        public static string saturday22;


        //-------------------------------------------------
        // sunday activities

        public static string sunday6;
        public static string sunday7;
        public static string sunday8;
        public static string sunday9;
        public static string sunday10;
        public static string sunday11;
        public static string sunday12;
        public static string sunday13;
        public static string sunday14;
        public static string sunday15;
        public static string sunday16;
        public static string sunday17;
        public static string sunday18;
        public static string sunday19;
        public static string sunday20;
        public static string sunday21;
        public static string sunday22;


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
            MessageBox.Show("Το πρόγραμμα της ημέρας υποβλήθηκε με επιτυχία");
            if (day_code == 1)
            {
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
            }
            if (day_code == 2)
            {
                tuesday6 = textBox6.Text;
                tuesday7 = textBox7.Text;
                tuesday8 = textBox8.Text;
                tuesday9 = textBox9.Text;
                tuesday10 = textBox10.Text;
                tuesday11 = textBox11.Text;
                tuesday12 = textBox12.Text;
                tuesday13 = textBox13.Text;
                tuesday14 = textBox14.Text;
                tuesday15 = textBox15.Text;
                tuesday16 = textBox16.Text;
                tuesday17 = textBox17.Text;
                tuesday18 = textBox18.Text;
                tuesday19 = textBox19.Text;
                tuesday20 = textBox20.Text;
                tuesday21 = textBox21.Text;
                tuesday22 = textBox22.Text;
            }
            if (day_code == 3)
            {
                wednesday6 = textBox6.Text;
                wednesday7 = textBox7.Text;
                wednesday8 = textBox8.Text;
                wednesday9 = textBox9.Text;
                wednesday10 = textBox10.Text;
                wednesday11 = textBox11.Text;
                wednesday12 = textBox12.Text;
                wednesday13 = textBox13.Text;
                wednesday14 = textBox14.Text;
                wednesday15 = textBox15.Text;
                wednesday16 = textBox16.Text;
                wednesday17 = textBox17.Text;
                wednesday18 = textBox18.Text;
                wednesday19 = textBox19.Text;
                wednesday20 = textBox20.Text;
                wednesday21 = textBox21.Text;
                wednesday22 = textBox22.Text;
            }
            if (day_code == 4)
            {
                thursday6 = textBox6.Text;
                thursday7 = textBox7.Text;
                thursday8 = textBox8.Text;
                thursday9 = textBox9.Text;
                thursday10 = textBox10.Text;
                thursday11 = textBox11.Text;
                thursday12 = textBox12.Text;
                thursday13 = textBox13.Text;
                thursday14 = textBox14.Text;
                thursday15 = textBox15.Text;
                thursday16 = textBox16.Text;
                thursday17 = textBox17.Text;
                thursday18 = textBox18.Text;
                thursday19 = textBox19.Text;
                thursday20 = textBox20.Text;
                thursday21 = textBox21.Text;
                thursday22 = textBox22.Text;
            }
            if (day_code == 5)
            {
                friday6 = textBox6.Text;
                friday7 = textBox7.Text;
                friday8 = textBox8.Text;
                friday9 = textBox9.Text;
                friday10 = textBox10.Text;
                friday11 = textBox11.Text;
                friday12 = textBox12.Text;
                friday13 = textBox13.Text;
                friday14 = textBox14.Text;
                friday15 = textBox15.Text;
                friday16 = textBox16.Text;
                friday17 = textBox17.Text;
                friday18 = textBox18.Text;
                friday19 = textBox19.Text;
                friday20 = textBox20.Text;
                friday21 = textBox21.Text;
                friday22 = textBox22.Text;
            }
            if (day_code == 6)
            {
                saturday6 = textBox6.Text;
                saturday7 = textBox7.Text;
                saturday8 = textBox8.Text;
                saturday9 = textBox9.Text;
                saturday10 = textBox10.Text;
                saturday11 = textBox11.Text;
                saturday12 = textBox12.Text;
                saturday13 = textBox13.Text;
                saturday14 = textBox14.Text;
                saturday15 = textBox15.Text;
                saturday16 = textBox16.Text;
                saturday17 = textBox17.Text;
                saturday18 = textBox18.Text;
                saturday19 = textBox19.Text;
                saturday20 = textBox20.Text;
                saturday21 = textBox21.Text;
                saturday22 = textBox22.Text;
            }
            if (day_code == 7)
            {
                sunday6 = textBox6.Text;
                sunday7 = textBox7.Text;
                sunday8 = textBox8.Text;
                sunday9 = textBox9.Text;
                sunday10 = textBox10.Text;
                sunday11 = textBox11.Text;
                sunday12 = textBox12.Text;
                sunday13 = textBox13.Text;
                sunday14 = textBox14.Text;
                sunday15 = textBox15.Text;
                sunday16 = textBox16.Text;
                sunday17 = textBox17.Text;
                sunday18 = textBox18.Text;
                sunday19 = textBox19.Text;
                sunday20 = textBox20.Text;
                sunday21 = textBox21.Text;
                sunday22 = textBox22.Text;
            }

            this.Close();
            Nikos_personal_assistant assist = new Nikos_personal_assistant();
            assist.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
