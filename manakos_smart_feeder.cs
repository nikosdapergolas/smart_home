using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Smart_home
{
    public partial class manakos_smart_feeder : Form
    {
        int food;
        int zimia;
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        
        public manakos_smart_feeder()
            {
                
                zimia = rand.Next(1, 60);

                Timer timer1 = new Timer();
                Timer timer2 = new Timer();

                timer1.Start();
            
                timer2.Start();
                InitializeComponent();
            
                
                label1.Visible = true;
                food = 100;
                while (food <= 100 && food > 0)
                {
                    label1.Visible = true;
                    label1.Text =  +food+ "%";
                    pictureBox1.Visible = true;
                    if (food <= 50)
                    {
                    
                        pictureBox1.BackgroundImage =Image.FromFile(@"white.jpg");
                        pictureBox4.Visible = true;
                        MessageBox.Show("Στάθμη τροφής στα 50%");
                    }
                    if (food <= 25)
                    {
                        pictureBox4.BackgroundImage = Image.FromFile(@"white.jpg");
                        pictureBox3.Visible = true;
                        MessageBox.Show("Στάθμη τροφής στα 25%");
                    }


            }
        }
        

        private void manakos_smart_feeder_Load(object sender, EventArgs e)
        {
            

        }

        private void time_tick(object sender, EventArgs e)
        {
            //evala to timer na xtipaei ana 8 ores, p kata meso oro trone ta katikidia 
            if (food <= 100 && food > 0)
            {
                food = food - 15;
                richTextBox1.Text = "Εναπόθεση τροφής ";
                SoundPlayer ding = new SoundPlayer(@"triangle.wav");
                ding.Play();

            }
        }

        private void activo_tick(object sender, EventArgs e)
        {
            if(zimia==20)
            {
                richTextBox1.Text = "Το ζωάκι έφαγε όλο το φαγητό του ";

            }
            if (zimia == 14)
            {
                richTextBox1.Text = "Το ζωάκι δεν έφαγε όλο το φαγητό του ";
            }
            if (zimia == 45)
            {
                richTextBox1.Text = "Το ζωάκι φάνηκε να τρέχει στο σπίτι στην περιοχή: Κουζίνα ";
            }
            if (zimia == 45)
            {
                richTextBox1.Text = "Το ζωάκι φάνηκε να τρέχει στο σπίτι στην περιοχή: Σαλόνι ";
            }

        }

        private void foodchoose(object sender, EventArgs e)
        {
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            textBox2.Text = "Ξηρά";
            button7.Visible = false;
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            textBox2.Text = "Υγρή";
            button7.Visible = false;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            food = 100;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            manakos_pet_activity manakos = new manakos_pet_activity();
            manakos.Show();
        }

    
    }
}
