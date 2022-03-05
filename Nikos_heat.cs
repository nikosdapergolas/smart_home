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
    public partial class Nikos_heat : Form
    {
        /*public static bool bedroom1_heat_panel_active = false;
        public static bool bedroom2_heat_panel_active = false;
        public static bool living_room_heat_panel_active = false;
        public static bool kitchen_heat_panel_active = false;
        public static bool toilet_heat_panel_active = false;
        public static bool bathroom_heat_panel_active = false;*/
        public static bool heat_panel_is_active = false;
        public static bool bedroom1_heat_is_on = false;
        public static bool bedroom2_heat_is_on = false;
        public static bool living_room_heat_is_on = false;
        public static bool kitchen_heat_is_on = true;
        public static bool toilet_heat_is_on = true;
        public static bool bathroom_heat_is_on = true;
        public static string heat_on_image = "pictures/hot.png";
        public static string heat_off_image = "pictures/not_hot.png";

        /*
        public static string value_assignment(int temperature, int working_hours, string program)
        {
            return temperature.ToString(),working_hours.ToString,program;
        }
        */


        public Nikos_heat()
        {
            InitializeComponent();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // Opening the heat control panel and passing through the constructor
            // the name of the room

            Nikos_heat_control heat_panel = new Nikos_heat_control("Υπνοδωμάτιο 1",richTextBox10.Text, richTextBox8.Text, richTextBox9.Text);
            heat_panel.Show();
            heat_panel_is_active = true;
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Καλωσορίσατε στο σαλόνι");
            // Opening the heat control panel and passing through the constructor
            // the name of the room

            Nikos_heat_control heat_panel = new Nikos_heat_control("Σαλόνι", richTextBox11.Text, richTextBox13.Text, richTextBox12.Text);
            heat_panel.Show();
            heat_panel_is_active = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Καλωσορίσατε στην Κουζίνα");
            // Opening the heat control panel and passing through the constructor
            // the name of the room

            Nikos_heat_control heat_panel = new Nikos_heat_control("Κουζίνα", richTextBox20.Text, richTextBox22.Text, richTextBox21.Text);
            heat_panel.Show();
            heat_panel_is_active = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Καλωσορίσατε στην Τουαλέτα");
            // Opening the heat control panel and passing through the constructor
            // the name of the room

            Nikos_heat_control heat_panel = new Nikos_heat_control("Τουαλέτα", richTextBox23.Text, richTextBox25.Text, richTextBox24.Text);
            heat_panel.Show();
            heat_panel_is_active = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Καλωσορίσατε στο Μπάνιο");
            // Opening the heat control panel and passing through the constructor
            // the name of the room

            Nikos_heat_control heat_panel = new Nikos_heat_control("Μπάνιο", richTextBox17.Text, richTextBox19.Text, richTextBox18.Text);
            heat_panel.Show();
            heat_panel_is_active = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Καλωσορίσατε στο Υπμοδωμάτιο 2");
            // Opening the heat control panel and passing through the constructor
            // the name of the room

            Nikos_heat_control heat_panel = new Nikos_heat_control("Υπνοδωμάτιο 2", richTextBox14.Text, richTextBox16.Text, richTextBox15.Text);
            heat_panel.Show();
            heat_panel_is_active = true;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the bedroom 1
            richTextBox2.Visible = true;
            richTextBox8.Visible = true;
            richTextBox9.Visible = true;
            richTextBox10.Visible = true;
            pictureBox6.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bedroom 1
            richTextBox2.Visible = false;
            richTextBox8.Visible = false;
            richTextBox9.Visible = false;
            richTextBox10.Visible = false;
            pictureBox6.Visible = false;

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the living room
            
            richTextBox3.Visible = true;
            richTextBox11.Visible = true;
            richTextBox12.Visible = true;
            richTextBox13.Visible = true;
            pictureBox7.Visible = true;

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the living room
            richTextBox3.Visible = false;
            richTextBox11.Visible = false;
            richTextBox12.Visible = false;
            richTextBox13.Visible = false;
            pictureBox7.Visible = false;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the kitchen
            richTextBox4.Visible = true;
            richTextBox20.Visible = true;
            richTextBox21.Visible = true;
            richTextBox22.Visible = true;
            pictureBox2.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the kitchen
            richTextBox4.Visible = false;
            richTextBox20.Visible = false;
            richTextBox21.Visible = false;
            richTextBox22.Visible = false;
            pictureBox2.Visible = false;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the toilet
            richTextBox5.Visible = true;
            richTextBox23.Visible = true;
            richTextBox24.Visible = true;
            richTextBox25.Visible = true;
            pictureBox3.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the toilet
            richTextBox5.Visible = false;
            richTextBox23.Visible = false;
            richTextBox24.Visible = false;
            richTextBox25.Visible = false;
            pictureBox3.Visible = false;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the bathroom
            richTextBox6.Visible = true;
            richTextBox17.Visible = true;
            richTextBox18.Visible = true;
            richTextBox19.Visible = true;
            pictureBox4.Visible = true;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bathroom
            richTextBox6.Visible = false;
            richTextBox17.Visible = false;
            richTextBox18.Visible = false;
            richTextBox19.Visible = false;
            pictureBox4.Visible = false;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the bedroom 2
            richTextBox1.Visible = true;
            richTextBox14.Visible = true;
            richTextBox15.Visible = true;
            richTextBox16.Visible = true;
            pictureBox5.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the bedroom 2
            richTextBox1.Visible = false;
            richTextBox14.Visible = false;
            richTextBox15.Visible = false;
            richTextBox16.Visible = false;
            pictureBox5.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the info icon
            richTextBox7.Visible = true;
            label1.Visible = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the info icon
            richTextBox7.Visible = false;
            label1.Visible = true;
        }

        private void richTextBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This timer controls at every tick, what happens every second
            // in this form. 
            // To be honest i just put it here so i can see whether some forms
            // are open or not 
            // and to control the images and the colors of the indicators

            if (heat_panel_is_active)
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel6.Enabled = false;

            }
            else
            {
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
                panel4.Enabled = true;
                panel5.Enabled = true;
                panel6.Enabled = true;
            }
            
            if (bedroom1_heat_is_on)
            {
                // bedroom1 heat indicators will not be visible if the
                // heat is not on

                richTextBox8.BackColor = Color.Green;
                richTextBox9.BackColor = Color.Green;
                richTextBox10.BackColor = Color.Green;

                pictureBox6.ImageLocation = heat_on_image;
            }
            else
            {
                richTextBox8.BackColor = Color.Gray;
                richTextBox9.BackColor = Color.Gray;
                richTextBox10.BackColor = Color.Gray;

                pictureBox6.ImageLocation = heat_off_image;
            }


            // living_room heat indicators will  be different color if the
            // heat is not on 

            if (living_room_heat_is_on)
            {
                // living room heat indicators will not be visible if the
                // heat is not on

                richTextBox11.BackColor = Color.Green;
                richTextBox12.BackColor = Color.Green;
                richTextBox13.BackColor = Color.Green;

                pictureBox7.ImageLocation = heat_on_image;
            }
            else
            {
                richTextBox11.BackColor = Color.Gray;
                richTextBox12.BackColor = Color.Gray;
                richTextBox13.BackColor = Color.Gray;

                pictureBox7.ImageLocation = heat_off_image;
            }

            // kitchen heat indicators will not be visible if the
            // heat is not on

            if (kitchen_heat_is_on)
            {
                // kitchen heat indicators will not be visible if the
                // heat is not on

                richTextBox20.BackColor = Color.Green;
                richTextBox21.BackColor = Color.Green;
                richTextBox22.BackColor = Color.Green;

                pictureBox2.ImageLocation = heat_on_image;
            }
            else
            {
                richTextBox20.BackColor = Color.Gray;
                richTextBox21.BackColor = Color.Gray;
                richTextBox22.BackColor = Color.Gray;

                pictureBox2.ImageLocation = heat_off_image;
            }

            // toilet heat indicators will not be visible if the
            // heat is not on

            if (toilet_heat_is_on)
            {
                // toilet heat indicators will not be visible if the
                // heat is not on

                richTextBox23.BackColor = Color.Green;
                richTextBox24.BackColor = Color.Green;
                richTextBox25.BackColor = Color.Green;

                pictureBox3.ImageLocation = heat_on_image;
            }
            else
            {
                richTextBox23.BackColor = Color.Gray;
                richTextBox24.BackColor = Color.Gray;
                richTextBox25.BackColor = Color.Gray;

                pictureBox3.ImageLocation = heat_off_image;
            }

            // bathroom heat indicators will not be visible if the
            // heat is not on

            if (bathroom_heat_is_on)
            {
                // bathroom heat indicators will not be visible if the
                // heat is not on

                richTextBox17.BackColor = Color.Green;
                richTextBox18.BackColor = Color.Green;
                richTextBox19.BackColor = Color.Green;

                pictureBox4.ImageLocation = heat_on_image;
            }
            else
            {
                richTextBox17.BackColor = Color.Gray;
                richTextBox18.BackColor = Color.Gray;
                richTextBox19.BackColor = Color.Gray;

                pictureBox4.ImageLocation = heat_off_image;
            }

            // bedroom 2 heat indicators will not be visible if the
            // heat is not on

            if (bedroom2_heat_is_on)
            {
                // bedroom 2 heat indicators will not be visible if the
                // heat is not on

                richTextBox14.BackColor = Color.Green;
                richTextBox15.BackColor = Color.Green;
                richTextBox16.BackColor = Color.Green;

                pictureBox5.ImageLocation = heat_on_image;
            }
            else
            {
                richTextBox14.BackColor = Color.Gray;
                richTextBox15.BackColor = Color.Gray;
                richTextBox16.BackColor = Color.Gray;

                pictureBox5.ImageLocation = heat_off_image;
            }

            // Trying to take the numbers from the "control panel"
            if (heat_panel_is_active == false)
            {
                if (Nikos_heat_control.room_name == "Υπνοδωμάτιο 1")
                {
                    richTextBox8.Text = Nikos_heat_control.temperature.ToString() + "°C";
                    richTextBox9.Text = Nikos_heat_control.working_hours.ToString() + " ώρες";
                    richTextBox10.Text = Nikos_heat_control.heat_program;
                }
                if (Nikos_heat_control.room_name == "Σαλόνι")
                {
                    richTextBox13.Text = Nikos_heat_control.temperature.ToString() + "°C";
                    richTextBox12.Text = Nikos_heat_control.working_hours.ToString() + " ώρες";
                    richTextBox11.Text = Nikos_heat_control.heat_program;
                }
                if (Nikos_heat_control.room_name == "Κουζίνα")
                {
                    richTextBox22.Text = Nikos_heat_control.temperature.ToString() + "°C";
                    richTextBox21.Text = Nikos_heat_control.working_hours.ToString() + " ώρες";
                    richTextBox20.Text = Nikos_heat_control.heat_program;
                }
                if (Nikos_heat_control.room_name == "Τουαλέτα")
                {
                    richTextBox25.Text = Nikos_heat_control.temperature.ToString() + "°C";
                    richTextBox24.Text = Nikos_heat_control.working_hours.ToString() + " ώρες";
                    richTextBox23.Text = Nikos_heat_control.heat_program;
                }
                if (Nikos_heat_control.room_name == "Μπάνιο")
                {
                    richTextBox19.Text = Nikos_heat_control.temperature.ToString() + "°C";
                    richTextBox18.Text = Nikos_heat_control.working_hours.ToString() + " ώρες";
                    richTextBox17.Text = Nikos_heat_control.heat_program;
                }
                if (Nikos_heat_control.room_name == "Υπνοδωμάτιο 2")
                {
                    richTextBox16.Text = Nikos_heat_control.temperature.ToString() + "°C";
                    richTextBox15.Text = Nikos_heat_control.working_hours.ToString() + " ώρες";
                    richTextBox14.Text = Nikos_heat_control.heat_program;
                }
            }
        }

        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nikos_heat_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(bedroom1_heat_is_on.ToString());
        }

        

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
