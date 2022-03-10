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
    public partial class Nikos_assistant_activities_showing : Form
    {

        public static int day_code = 1;

        public Nikos_assistant_activities_showing()
        {
            InitializeComponent();
        }

        private void Nikos_assistant_activities_showing_Load(object sender, EventArgs e)
        {
            panel1.BackColor = button1.BackColor;

            show_monday();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_personal_assistant personal = new Nikos_personal_assistant();
            personal.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            day_code = 1;
            if(Nikos_personal_assistant.monday_has_plan == true)
            {
                panel1.BackColor = button1.BackColor;
                show_monday();
            }
            else
            {
                MessageBox.Show("There is no plan for monday.Go make one!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            day_code = 2;
            if (Nikos_personal_assistant.tuesday_has_plan == true)
            {
                panel1.BackColor = button2.BackColor;
                show_tuesday();
            }
            else
            {
                MessageBox.Show("There is no plan for tuesday.Go make one!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            day_code = 3;
            if (Nikos_personal_assistant.wednesday_has_plan == true)
            {
                show_wednesday();
                panel1.BackColor = button3.BackColor;
            }
            else
            {
                MessageBox.Show("There is no plan for wednesday.Go make one!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            day_code = 4;
            if (Nikos_personal_assistant.thursday_has_plan == true)
            {
                show_thursday();
                panel1.BackColor = button4.BackColor;
            }
            else
            {
                MessageBox.Show("There is no plan for thursday.Go make one!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            day_code = 5;
            if (Nikos_personal_assistant.friday_has_plan == true)
            {
                panel1.BackColor = button5.BackColor;
                show_friday();
            }
            else
            {
                MessageBox.Show("There is no plan for friday.Go make one!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            day_code = 6;
            if (Nikos_personal_assistant.saturday_has_plan == true)
            {
                show_saturday();
                panel1.BackColor = button6.BackColor;
            }
            else
            {
                MessageBox.Show("There is no plan for saturday.Go make one!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            day_code = 7;
            if (Nikos_personal_assistant.sunday_has_plan == true)
            {
                show_sunday();
                panel1.BackColor = button7.BackColor;
            }
            else
            {
                MessageBox.Show("There is no plan for sunday.Go make one!");
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            richTextBox3.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox3.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox4.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox6.Visible = false;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            richTextBox7.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox7.Visible = false;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            richTextBox8.Visible = true;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            richTextBox8.Visible = false;
        }

        public void show_monday()
        {
            label1.Text = Nikos_assistant_activities_choosing.monday6;
            label2.Text = Nikos_assistant_activities_choosing.monday7;
            label3.Text = Nikos_assistant_activities_choosing.monday8;
            label4.Text = Nikos_assistant_activities_choosing.monday9;
            label5.Text = Nikos_assistant_activities_choosing.monday10;
            label6.Text = Nikos_assistant_activities_choosing.monday11;
            label7.Text = Nikos_assistant_activities_choosing.monday12;
            label8.Text = Nikos_assistant_activities_choosing.monday13;
            label9.Text = Nikos_assistant_activities_choosing.monday14;
            label10.Text = Nikos_assistant_activities_choosing.monday15;
            label11.Text = Nikos_assistant_activities_choosing.monday16;
            label12.Text = Nikos_assistant_activities_choosing.monday17;
            label13.Text = Nikos_assistant_activities_choosing.monday18;
            label14.Text = Nikos_assistant_activities_choosing.monday19;
            label15.Text = Nikos_assistant_activities_choosing.monday20;
            label16.Text = Nikos_assistant_activities_choosing.monday21;
            label17.Text = Nikos_assistant_activities_choosing.monday22;

            label18.Text = Nikos_assistant_activities_choosing.monday_activity_type6;
            label19.Text = Nikos_assistant_activities_choosing.monday_activity_type7;
            label20.Text = Nikos_assistant_activities_choosing.monday_activity_type8;
            label21.Text = Nikos_assistant_activities_choosing.monday_activity_type9;
            label22.Text = Nikos_assistant_activities_choosing.monday_activity_type10;
            label23.Text = Nikos_assistant_activities_choosing.monday_activity_type11;
            label24.Text = Nikos_assistant_activities_choosing.monday_activity_type12;
            label25.Text = Nikos_assistant_activities_choosing.monday_activity_type13;
            label26.Text = Nikos_assistant_activities_choosing.monday_activity_type14;
            label27.Text = Nikos_assistant_activities_choosing.monday_activity_type15;
            label28.Text = Nikos_assistant_activities_choosing.monday_activity_type16;
            label29.Text = Nikos_assistant_activities_choosing.monday_activity_type17;
            label30.Text = Nikos_assistant_activities_choosing.monday_activity_type18;
            label31.Text = Nikos_assistant_activities_choosing.monday_activity_type19;
            label32.Text = Nikos_assistant_activities_choosing.monday_activity_type20;
            label33.Text = Nikos_assistant_activities_choosing.monday_activity_type21;
            label34.Text = Nikos_assistant_activities_choosing.monday_activity_type22;

            label35.Text = Nikos_assistant_activities_choosing.monday_transport6;
            label36.Text = Nikos_assistant_activities_choosing.monday_transport7;
            label37.Text = Nikos_assistant_activities_choosing.monday_transport8;
            label38.Text = Nikos_assistant_activities_choosing.monday_transport9;
            label39.Text = Nikos_assistant_activities_choosing.monday_transport10;
            label40.Text = Nikos_assistant_activities_choosing.monday_transport11;
            label41.Text = Nikos_assistant_activities_choosing.monday_transport12;
            label42.Text = Nikos_assistant_activities_choosing.monday_transport13;
            label43.Text = Nikos_assistant_activities_choosing.monday_transport14;
            label44.Text = Nikos_assistant_activities_choosing.monday_transport15;
            label45.Text = Nikos_assistant_activities_choosing.monday_transport16;
            label46.Text = Nikos_assistant_activities_choosing.monday_transport17;
            label47.Text = Nikos_assistant_activities_choosing.monday_transport18;
            label48.Text = Nikos_assistant_activities_choosing.monday_transport19;
            label49.Text = Nikos_assistant_activities_choosing.monday_transport20;
            label50.Text = Nikos_assistant_activities_choosing.monday_transport21;
            label51.Text = Nikos_assistant_activities_choosing.monday_transport22;
        }

        public void show_tuesday()
        {
            label1.Text = Nikos_assistant_activities_choosing.tuesday6;
            label2.Text = Nikos_assistant_activities_choosing.tuesday7;
            label3.Text = Nikos_assistant_activities_choosing.tuesday8;
            label4.Text = Nikos_assistant_activities_choosing.tuesday9;
            label5.Text = Nikos_assistant_activities_choosing.tuesday10;
            label6.Text = Nikos_assistant_activities_choosing.tuesday11;
            label7.Text = Nikos_assistant_activities_choosing.tuesday12;
            label8.Text = Nikos_assistant_activities_choosing.tuesday13;
            label9.Text = Nikos_assistant_activities_choosing.tuesday14;
            label10.Text = Nikos_assistant_activities_choosing.tuesday15;
            label11.Text = Nikos_assistant_activities_choosing.tuesday16;
            label12.Text = Nikos_assistant_activities_choosing.tuesday17;
            label13.Text = Nikos_assistant_activities_choosing.tuesday18;
            label14.Text = Nikos_assistant_activities_choosing.tuesday19;
            label15.Text = Nikos_assistant_activities_choosing.tuesday20;
            label16.Text = Nikos_assistant_activities_choosing.tuesday21;
            label17.Text = Nikos_assistant_activities_choosing.tuesday22;

            label18.Text = Nikos_assistant_activities_choosing.tuesday_activity_type6;
            label19.Text = Nikos_assistant_activities_choosing.tuesday_activity_type7;
            label20.Text = Nikos_assistant_activities_choosing.tuesday_activity_type8;
            label21.Text = Nikos_assistant_activities_choosing.tuesday_activity_type9;
            label22.Text = Nikos_assistant_activities_choosing.tuesday_activity_type10;
            label23.Text = Nikos_assistant_activities_choosing.tuesday_activity_type11;
            label24.Text = Nikos_assistant_activities_choosing.tuesday_activity_type12;
            label25.Text = Nikos_assistant_activities_choosing.tuesday_activity_type13;
            label26.Text = Nikos_assistant_activities_choosing.tuesday_activity_type14;
            label27.Text = Nikos_assistant_activities_choosing.tuesday_activity_type15;
            label28.Text = Nikos_assistant_activities_choosing.tuesday_activity_type16;
            label29.Text = Nikos_assistant_activities_choosing.tuesday_activity_type17;
            label30.Text = Nikos_assistant_activities_choosing.tuesday_activity_type18;
            label31.Text = Nikos_assistant_activities_choosing.tuesday_activity_type19;
            label32.Text = Nikos_assistant_activities_choosing.tuesday_activity_type20;
            label33.Text = Nikos_assistant_activities_choosing.tuesday_activity_type21;
            label34.Text = Nikos_assistant_activities_choosing.tuesday_activity_type22;

            label35.Text = Nikos_assistant_activities_choosing.tuesday_transport6;
            label36.Text = Nikos_assistant_activities_choosing.tuesday_transport7;
            label37.Text = Nikos_assistant_activities_choosing.tuesday_transport8;
            label38.Text = Nikos_assistant_activities_choosing.tuesday_transport9;
            label39.Text = Nikos_assistant_activities_choosing.tuesday_transport10;
            label40.Text = Nikos_assistant_activities_choosing.tuesday_transport11;
            label41.Text = Nikos_assistant_activities_choosing.tuesday_transport12;
            label42.Text = Nikos_assistant_activities_choosing.tuesday_transport13;
            label43.Text = Nikos_assistant_activities_choosing.tuesday_transport14;
            label44.Text = Nikos_assistant_activities_choosing.tuesday_transport15;
            label45.Text = Nikos_assistant_activities_choosing.tuesday_transport16;
            label46.Text = Nikos_assistant_activities_choosing.tuesday_transport17;
            label47.Text = Nikos_assistant_activities_choosing.tuesday_transport18;
            label48.Text = Nikos_assistant_activities_choosing.tuesday_transport19;
            label49.Text = Nikos_assistant_activities_choosing.tuesday_transport20;
            label50.Text = Nikos_assistant_activities_choosing.tuesday_transport21;
            label51.Text = Nikos_assistant_activities_choosing.tuesday_transport22;
        }

        public void show_wednesday() 
        {
            label1.Text = Nikos_assistant_activities_choosing.wednesday6;
            label2.Text = Nikos_assistant_activities_choosing.wednesday7;
            label3.Text = Nikos_assistant_activities_choosing.wednesday8;
            label4.Text = Nikos_assistant_activities_choosing.wednesday9;
            label5.Text = Nikos_assistant_activities_choosing.wednesday10;
            label6.Text = Nikos_assistant_activities_choosing.wednesday11;
            label7.Text = Nikos_assistant_activities_choosing.wednesday12;
            label8.Text = Nikos_assistant_activities_choosing.wednesday13;
            label9.Text = Nikos_assistant_activities_choosing.wednesday14;
            label10.Text = Nikos_assistant_activities_choosing.wednesday15;
            label11.Text = Nikos_assistant_activities_choosing.wednesday16;
            label12.Text = Nikos_assistant_activities_choosing.wednesday17;
            label13.Text = Nikos_assistant_activities_choosing.wednesday18;
            label14.Text = Nikos_assistant_activities_choosing.wednesday19;
            label15.Text = Nikos_assistant_activities_choosing.wednesday20;
            label16.Text = Nikos_assistant_activities_choosing.wednesday21;
            label17.Text = Nikos_assistant_activities_choosing.wednesday22;

            label18.Text = Nikos_assistant_activities_choosing.wednesday_activity_type6;
            label19.Text = Nikos_assistant_activities_choosing.wednesday_activity_type7;
            label20.Text = Nikos_assistant_activities_choosing.wednesday_activity_type8;
            label21.Text = Nikos_assistant_activities_choosing.wednesday_activity_type9;
            label22.Text = Nikos_assistant_activities_choosing.wednesday_activity_type10;
            label23.Text = Nikos_assistant_activities_choosing.wednesday_activity_type11;
            label24.Text = Nikos_assistant_activities_choosing.wednesday_activity_type12;
            label25.Text = Nikos_assistant_activities_choosing.wednesday_activity_type13;
            label26.Text = Nikos_assistant_activities_choosing.wednesday_activity_type14;
            label27.Text = Nikos_assistant_activities_choosing.wednesday_activity_type15;
            label28.Text = Nikos_assistant_activities_choosing.wednesday_activity_type16;
            label29.Text = Nikos_assistant_activities_choosing.wednesday_activity_type17;
            label30.Text = Nikos_assistant_activities_choosing.wednesday_activity_type18;
            label31.Text = Nikos_assistant_activities_choosing.wednesday_activity_type19;
            label32.Text = Nikos_assistant_activities_choosing.wednesday_activity_type20;
            label33.Text = Nikos_assistant_activities_choosing.wednesday_activity_type21;
            label34.Text = Nikos_assistant_activities_choosing.wednesday_activity_type22;

            label35.Text = Nikos_assistant_activities_choosing.wednesday_transport6;
            label36.Text = Nikos_assistant_activities_choosing.wednesday_transport7;
            label37.Text = Nikos_assistant_activities_choosing.wednesday_transport8;
            label38.Text = Nikos_assistant_activities_choosing.wednesday_transport9;
            label39.Text = Nikos_assistant_activities_choosing.wednesday_transport10;
            label40.Text = Nikos_assistant_activities_choosing.wednesday_transport11;
            label41.Text = Nikos_assistant_activities_choosing.wednesday_transport12;
            label42.Text = Nikos_assistant_activities_choosing.wednesday_transport13;
            label43.Text = Nikos_assistant_activities_choosing.wednesday_transport14;
            label44.Text = Nikos_assistant_activities_choosing.wednesday_transport15;
            label45.Text = Nikos_assistant_activities_choosing.wednesday_transport16;
            label46.Text = Nikos_assistant_activities_choosing.wednesday_transport17;
            label47.Text = Nikos_assistant_activities_choosing.wednesday_transport18;
            label48.Text = Nikos_assistant_activities_choosing.wednesday_transport19;
            label49.Text = Nikos_assistant_activities_choosing.wednesday_transport20;
            label50.Text = Nikos_assistant_activities_choosing.wednesday_transport21;
            label51.Text = Nikos_assistant_activities_choosing.wednesday_transport22;
        }
        public void show_thursday()
        {
            label1.Text = Nikos_assistant_activities_choosing.thursday6;
            label2.Text = Nikos_assistant_activities_choosing.thursday7;
            label3.Text = Nikos_assistant_activities_choosing.thursday8;
            label4.Text = Nikos_assistant_activities_choosing.thursday9;
            label5.Text = Nikos_assistant_activities_choosing.thursday10;
            label6.Text = Nikos_assistant_activities_choosing.thursday11;
            label7.Text = Nikos_assistant_activities_choosing.thursday12;
            label8.Text = Nikos_assistant_activities_choosing.thursday13;
            label9.Text = Nikos_assistant_activities_choosing.thursday14;
            label10.Text = Nikos_assistant_activities_choosing.thursday15;
            label11.Text = Nikos_assistant_activities_choosing.thursday16;
            label12.Text = Nikos_assistant_activities_choosing.thursday17;
            label13.Text = Nikos_assistant_activities_choosing.thursday18;
            label14.Text = Nikos_assistant_activities_choosing.thursday19;
            label15.Text = Nikos_assistant_activities_choosing.thursday20;
            label16.Text = Nikos_assistant_activities_choosing.thursday21;
            label17.Text = Nikos_assistant_activities_choosing.thursday22;

            label18.Text = Nikos_assistant_activities_choosing.thursday_activity_type6;
            label19.Text = Nikos_assistant_activities_choosing.thursday_activity_type7;
            label20.Text = Nikos_assistant_activities_choosing.thursday_activity_type8;
            label21.Text = Nikos_assistant_activities_choosing.thursday_activity_type9;
            label22.Text = Nikos_assistant_activities_choosing.thursday_activity_type10;
            label23.Text = Nikos_assistant_activities_choosing.thursday_activity_type11;
            label24.Text = Nikos_assistant_activities_choosing.thursday_activity_type12;
            label25.Text = Nikos_assistant_activities_choosing.thursday_activity_type13;
            label26.Text = Nikos_assistant_activities_choosing.thursday_activity_type14;
            label27.Text = Nikos_assistant_activities_choosing.thursday_activity_type15;
            label28.Text = Nikos_assistant_activities_choosing.thursday_activity_type16;
            label29.Text = Nikos_assistant_activities_choosing.thursday_activity_type17;
            label30.Text = Nikos_assistant_activities_choosing.thursday_activity_type18;
            label31.Text = Nikos_assistant_activities_choosing.thursday_activity_type19;
            label32.Text = Nikos_assistant_activities_choosing.thursday_activity_type20;
            label33.Text = Nikos_assistant_activities_choosing.thursday_activity_type21;
            label34.Text = Nikos_assistant_activities_choosing.thursday_activity_type22;

            label35.Text = Nikos_assistant_activities_choosing.thursday_transport6;
            label36.Text = Nikos_assistant_activities_choosing.thursday_transport7;
            label37.Text = Nikos_assistant_activities_choosing.thursday_transport8;
            label38.Text = Nikos_assistant_activities_choosing.thursday_transport9;
            label39.Text = Nikos_assistant_activities_choosing.thursday_transport10;
            label40.Text = Nikos_assistant_activities_choosing.thursday_transport11;
            label41.Text = Nikos_assistant_activities_choosing.thursday_transport12;
            label42.Text = Nikos_assistant_activities_choosing.thursday_transport13;
            label43.Text = Nikos_assistant_activities_choosing.thursday_transport14;
            label44.Text = Nikos_assistant_activities_choosing.thursday_transport15;
            label45.Text = Nikos_assistant_activities_choosing.thursday_transport16;
            label46.Text = Nikos_assistant_activities_choosing.thursday_transport17;
            label47.Text = Nikos_assistant_activities_choosing.thursday_transport18;
            label48.Text = Nikos_assistant_activities_choosing.thursday_transport19;
            label49.Text = Nikos_assistant_activities_choosing.thursday_transport20;
            label50.Text = Nikos_assistant_activities_choosing.thursday_transport21;
            label51.Text = Nikos_assistant_activities_choosing.thursday_transport22;
        }
        public void show_friday()
        {
            label1.Text = Nikos_assistant_activities_choosing.friday6;
            label2.Text = Nikos_assistant_activities_choosing.friday7;
            label3.Text = Nikos_assistant_activities_choosing.friday8;
            label4.Text = Nikos_assistant_activities_choosing.friday9;
            label5.Text = Nikos_assistant_activities_choosing.friday10;
            label6.Text = Nikos_assistant_activities_choosing.friday11;
            label7.Text = Nikos_assistant_activities_choosing.friday12;
            label8.Text = Nikos_assistant_activities_choosing.friday13;
            label9.Text = Nikos_assistant_activities_choosing.friday14;
            label10.Text = Nikos_assistant_activities_choosing.friday15;
            label11.Text = Nikos_assistant_activities_choosing.friday16;
            label12.Text = Nikos_assistant_activities_choosing.friday17;
            label13.Text = Nikos_assistant_activities_choosing.friday18;
            label14.Text = Nikos_assistant_activities_choosing.friday19;
            label15.Text = Nikos_assistant_activities_choosing.friday20;
            label16.Text = Nikos_assistant_activities_choosing.friday21;
            label17.Text = Nikos_assistant_activities_choosing.friday22;

            label18.Text = Nikos_assistant_activities_choosing.friday_activity_type6;
            label19.Text = Nikos_assistant_activities_choosing.friday_activity_type7;
            label20.Text = Nikos_assistant_activities_choosing.friday_activity_type8;
            label21.Text = Nikos_assistant_activities_choosing.friday_activity_type9;
            label22.Text = Nikos_assistant_activities_choosing.friday_activity_type10;
            label23.Text = Nikos_assistant_activities_choosing.friday_activity_type11;
            label24.Text = Nikos_assistant_activities_choosing.friday_activity_type12;
            label25.Text = Nikos_assistant_activities_choosing.friday_activity_type13;
            label26.Text = Nikos_assistant_activities_choosing.friday_activity_type14;
            label27.Text = Nikos_assistant_activities_choosing.friday_activity_type15;
            label28.Text = Nikos_assistant_activities_choosing.friday_activity_type16;
            label29.Text = Nikos_assistant_activities_choosing.friday_activity_type17;
            label30.Text = Nikos_assistant_activities_choosing.friday_activity_type18;
            label31.Text = Nikos_assistant_activities_choosing.friday_activity_type19;
            label32.Text = Nikos_assistant_activities_choosing.friday_activity_type20;
            label33.Text = Nikos_assistant_activities_choosing.friday_activity_type21;
            label34.Text = Nikos_assistant_activities_choosing.friday_activity_type22;

            label35.Text = Nikos_assistant_activities_choosing.friday_transport6;
            label36.Text = Nikos_assistant_activities_choosing.friday_transport7;
            label37.Text = Nikos_assistant_activities_choosing.friday_transport8;
            label38.Text = Nikos_assistant_activities_choosing.friday_transport9;
            label39.Text = Nikos_assistant_activities_choosing.friday_transport10;
            label40.Text = Nikos_assistant_activities_choosing.friday_transport11;
            label41.Text = Nikos_assistant_activities_choosing.friday_transport12;
            label42.Text = Nikos_assistant_activities_choosing.friday_transport13;
            label43.Text = Nikos_assistant_activities_choosing.friday_transport14;
            label44.Text = Nikos_assistant_activities_choosing.friday_transport15;
            label45.Text = Nikos_assistant_activities_choosing.friday_transport16;
            label46.Text = Nikos_assistant_activities_choosing.friday_transport17;
            label47.Text = Nikos_assistant_activities_choosing.friday_transport18;
            label48.Text = Nikos_assistant_activities_choosing.friday_transport19;
            label49.Text = Nikos_assistant_activities_choosing.friday_transport20;
            label50.Text = Nikos_assistant_activities_choosing.friday_transport21;
            label51.Text = Nikos_assistant_activities_choosing.friday_transport22;
        }
        public void show_saturday()
        {
            label1.Text = Nikos_assistant_activities_choosing.saturday6;
            label2.Text = Nikos_assistant_activities_choosing.saturday7;
            label3.Text = Nikos_assistant_activities_choosing.saturday8;
            label4.Text = Nikos_assistant_activities_choosing.saturday9;
            label5.Text = Nikos_assistant_activities_choosing.saturday10;
            label6.Text = Nikos_assistant_activities_choosing.saturday11;
            label7.Text = Nikos_assistant_activities_choosing.saturday12;
            label8.Text = Nikos_assistant_activities_choosing.saturday13;
            label9.Text = Nikos_assistant_activities_choosing.saturday14;
            label10.Text = Nikos_assistant_activities_choosing.saturday15;
            label11.Text = Nikos_assistant_activities_choosing.saturday16;
            label12.Text = Nikos_assistant_activities_choosing.saturday17;
            label13.Text = Nikos_assistant_activities_choosing.saturday18;
            label14.Text = Nikos_assistant_activities_choosing.saturday19;
            label15.Text = Nikos_assistant_activities_choosing.saturday20;
            label16.Text = Nikos_assistant_activities_choosing.saturday21;
            label17.Text = Nikos_assistant_activities_choosing.saturday22;

            label18.Text = Nikos_assistant_activities_choosing.saturday_activity_type6;
            label19.Text = Nikos_assistant_activities_choosing.saturday_activity_type7;
            label20.Text = Nikos_assistant_activities_choosing.saturday_activity_type8;
            label21.Text = Nikos_assistant_activities_choosing.saturday_activity_type9;
            label22.Text = Nikos_assistant_activities_choosing.saturday_activity_type10;
            label23.Text = Nikos_assistant_activities_choosing.saturday_activity_type11;
            label24.Text = Nikos_assistant_activities_choosing.saturday_activity_type12;
            label25.Text = Nikos_assistant_activities_choosing.saturday_activity_type13;
            label26.Text = Nikos_assistant_activities_choosing.saturday_activity_type14;
            label27.Text = Nikos_assistant_activities_choosing.saturday_activity_type15;
            label28.Text = Nikos_assistant_activities_choosing.saturday_activity_type16;
            label29.Text = Nikos_assistant_activities_choosing.saturday_activity_type17;
            label30.Text = Nikos_assistant_activities_choosing.saturday_activity_type18;
            label31.Text = Nikos_assistant_activities_choosing.saturday_activity_type19;
            label32.Text = Nikos_assistant_activities_choosing.saturday_activity_type20;
            label33.Text = Nikos_assistant_activities_choosing.saturday_activity_type21;
            label34.Text = Nikos_assistant_activities_choosing.saturday_activity_type22;

            label35.Text = Nikos_assistant_activities_choosing.saturday_transport6;
            label36.Text = Nikos_assistant_activities_choosing.saturday_transport7;
            label37.Text = Nikos_assistant_activities_choosing.saturday_transport8;
            label38.Text = Nikos_assistant_activities_choosing.saturday_transport9;
            label39.Text = Nikos_assistant_activities_choosing.saturday_transport10;
            label40.Text = Nikos_assistant_activities_choosing.saturday_transport11;
            label41.Text = Nikos_assistant_activities_choosing.saturday_transport12;
            label42.Text = Nikos_assistant_activities_choosing.saturday_transport13;
            label43.Text = Nikos_assistant_activities_choosing.saturday_transport14;
            label44.Text = Nikos_assistant_activities_choosing.saturday_transport15;
            label45.Text = Nikos_assistant_activities_choosing.saturday_transport16;
            label46.Text = Nikos_assistant_activities_choosing.saturday_transport17;
            label47.Text = Nikos_assistant_activities_choosing.saturday_transport18;
            label48.Text = Nikos_assistant_activities_choosing.saturday_transport19;
            label49.Text = Nikos_assistant_activities_choosing.saturday_transport20;
            label50.Text = Nikos_assistant_activities_choosing.saturday_transport21;
            label51.Text = Nikos_assistant_activities_choosing.saturday_transport22;
        }
        public void show_sunday()
        {
            label1.Text = Nikos_assistant_activities_choosing.sunday6;
            label2.Text = Nikos_assistant_activities_choosing.sunday7;
            label3.Text = Nikos_assistant_activities_choosing.sunday8;
            label4.Text = Nikos_assistant_activities_choosing.sunday9;
            label5.Text = Nikos_assistant_activities_choosing.sunday10;
            label6.Text = Nikos_assistant_activities_choosing.sunday11;
            label7.Text = Nikos_assistant_activities_choosing.sunday12;
            label8.Text = Nikos_assistant_activities_choosing.sunday13;
            label9.Text = Nikos_assistant_activities_choosing.sunday14;
            label10.Text = Nikos_assistant_activities_choosing.sunday15;
            label11.Text = Nikos_assistant_activities_choosing.sunday16;
            label12.Text = Nikos_assistant_activities_choosing.sunday17;
            label13.Text = Nikos_assistant_activities_choosing.sunday18;
            label14.Text = Nikos_assistant_activities_choosing.sunday19;
            label15.Text = Nikos_assistant_activities_choosing.sunday20;
            label16.Text = Nikos_assistant_activities_choosing.sunday21;
            label17.Text = Nikos_assistant_activities_choosing.sunday22;

            label18.Text = Nikos_assistant_activities_choosing.sunday_activity_type6;
            label19.Text = Nikos_assistant_activities_choosing.sunday_activity_type7;
            label20.Text = Nikos_assistant_activities_choosing.sunday_activity_type8;
            label21.Text = Nikos_assistant_activities_choosing.sunday_activity_type9;
            label22.Text = Nikos_assistant_activities_choosing.sunday_activity_type10;
            label23.Text = Nikos_assistant_activities_choosing.sunday_activity_type11;
            label24.Text = Nikos_assistant_activities_choosing.sunday_activity_type12;
            label25.Text = Nikos_assistant_activities_choosing.sunday_activity_type13;
            label26.Text = Nikos_assistant_activities_choosing.sunday_activity_type14;
            label27.Text = Nikos_assistant_activities_choosing.sunday_activity_type15;
            label28.Text = Nikos_assistant_activities_choosing.sunday_activity_type16;
            label29.Text = Nikos_assistant_activities_choosing.sunday_activity_type17;
            label30.Text = Nikos_assistant_activities_choosing.sunday_activity_type18;
            label31.Text = Nikos_assistant_activities_choosing.sunday_activity_type19;
            label32.Text = Nikos_assistant_activities_choosing.sunday_activity_type20;
            label33.Text = Nikos_assistant_activities_choosing.sunday_activity_type21;
            label34.Text = Nikos_assistant_activities_choosing.sunday_activity_type22;

            label35.Text = Nikos_assistant_activities_choosing.sunday_transport6;
            label36.Text = Nikos_assistant_activities_choosing.sunday_transport7;
            label37.Text = Nikos_assistant_activities_choosing.sunday_transport8;
            label38.Text = Nikos_assistant_activities_choosing.sunday_transport9;
            label39.Text = Nikos_assistant_activities_choosing.sunday_transport10;
            label40.Text = Nikos_assistant_activities_choosing.sunday_transport11;
            label41.Text = Nikos_assistant_activities_choosing.sunday_transport12;
            label42.Text = Nikos_assistant_activities_choosing.sunday_transport13;
            label43.Text = Nikos_assistant_activities_choosing.sunday_transport14;
            label44.Text = Nikos_assistant_activities_choosing.sunday_transport15;
            label45.Text = Nikos_assistant_activities_choosing.sunday_transport16;
            label46.Text = Nikos_assistant_activities_choosing.sunday_transport17;
            label47.Text = Nikos_assistant_activities_choosing.sunday_transport18;
            label48.Text = Nikos_assistant_activities_choosing.sunday_transport19;
            label49.Text = Nikos_assistant_activities_choosing.sunday_transport20;
            label50.Text = Nikos_assistant_activities_choosing.sunday_transport21;
            label51.Text = Nikos_assistant_activities_choosing.sunday_transport22;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            richTextBox9.Visible = true;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            richTextBox9.Visible = false;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            richTextBox10.Visible = true;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            richTextBox10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_redirection_to_google_maps google = new Nikos_redirection_to_google_maps(1);
            google.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_redirection_to_google_maps google = new Nikos_redirection_to_google_maps(2);
            google.Show();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://we.tl/t-RRnMcJTG8u");
        }
    }
}
