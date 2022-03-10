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
    public partial class Form1 : Form
    {
        public static int time;
        public static string day;
        public static int day_code;



        // A list that contains all the URLs of the pictures for the avatars
        List<String> assistantAvatar = new List<string>();
        List<String> daysList = new List<string>();

        // An integer that shows the current avatar in the list (by default it's the woman)
        int currentAvatar = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daysList.Add("Monday");
            daysList.Add("Tuesday");
            daysList.Add("Wednesday");
            daysList.Add("Thursday");
            daysList.Add("Friday");
            daysList.Add("Saturday");
            daysList.Add("Sunday");

            Random rand = new Random(Guid.NewGuid().GetHashCode());
            time = rand.Next(6, 25);
            int x;
            x = rand.Next(1,8);
            day_code = x;
            if(x == 1)
            {
                day = "Monday";
            }
            else if(x == 2)
            {
                day = "Tuesday";
            }
            else if (x == 3)
            {
                day = "Wednesday";
            }
            else if (x == 4)
            {
                day = "Thursday";
            }
            else if (x == 5)
            {
                day = "Friday";
            }
            else if (x == 6)
            {
                day = "Saturday";
            }
            else if (x == 7)
            {
                day = "Sunday";
            }

            label1.Text = time.ToString();
            label2.Text = day;

            // Adding all the URLs of the assistant's pictures 
            /*assistantAvatar.Add("pictures/woman_assistant.jpg");
            assistantAvatar.Add("pictures/man_assistant.jpg");
            assistantAvatar.Add("pictures/robot_assistant.jpg");*/
            pictureBox1.ImageLocation = "pictures/cute.png";
            // Adding all the URLs of the assistant's pictures 
            assistantAvatar.Add("pictures/cute.png");
            assistantAvatar.Add("pictures/walter_white.png");
            assistantAvatar.Add("pictures/woman3.png");
            assistantAvatar.Add("pictures/homer2_assistant.png");
            assistantAvatar.Add("pictures/man2_assistant.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Checking if i have reached the end of the list
            // If not, then i show the next avatar on the list
            // else i show the first one
            if(currentAvatar != (assistantAvatar.Count - 1))
            {
                currentAvatar++;
                pictureBox1.ImageLocation = assistantAvatar[currentAvatar];
            }
            else
            {
                currentAvatar = 0;
                pictureBox1.ImageLocation = assistantAvatar[currentAvatar];
            }
            


            // Shows the number of items in the list 
            //MessageBox.Show(assistantAvatar.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 home = new Form2();
            home.Show();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if(time == 25)
            {
                time = 0;
                day_code++;
                if(day_code == 8)
                {
                    day_code = 1;
                }
                day = daysList[day_code - 1];
                label2.Text = day;
                Form2.day = day;
            }
            //time = time % 25;
            label1.Text = time.ToString();
            Form2.time = time;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://we.tl/t-RRnMcJTG8u");
        }
    }
}
