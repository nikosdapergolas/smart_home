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
    public partial class Eva_AirCondition_Form : Form
    {
        public static int temperature = 20;
        public static int room_code;
        public static bool airConditionOn;

        public Eva_AirCondition_Form(int code)
        {
            room_code = code;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(room_code == 1)
            {
                
                if(airConditionOn == true)
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                    airConditionOn = false;
                }
                else
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                    airConditionOn = true;
                }
            }
            if (room_code == 2)
            {
                
                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                    airConditionOn = false;
                }
                else
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                    airConditionOn = true;
                }
            }
            if (room_code == 3)
            {
                
                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                    airConditionOn = false;
                }
                else
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                    airConditionOn = true;
                }
            }
        }

        private void Eva_AirCondition_Form_Load(object sender, EventArgs e)
        {
            label5.Text = temperature.ToString() + "°C";

            // If the user clicks on bedroom1
            if (room_code == 1)
            {
                temperature = Eva_AirCondition_choose.bedroom1_temperature;
                airConditionOn = Eva_AirCondition_choose.bedroom1_airCondition_isOn;

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                }
                else
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                }

                if(Eva_AirCondition_choose.bedroom1_program == "Κρύο")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                if(Eva_AirCondition_choose.bedroom1_fan_speed == "Χαμηλή ταχύτητα")
                {
                    radioButton3.Checked = true;
                }
                else if(Eva_AirCondition_choose.bedroom1_fan_speed == "Μεσαία ταχύτητα")
                {
                    radioButton4.Checked = true;
                }
                else if (Eva_AirCondition_choose.bedroom1_fan_speed == "Υψηλή ταχύτητα")
                {
                    radioButton5.Checked = true;
                }
            }

            // If the user clicks on living room
            if (room_code == 2)
            {
                temperature = Eva_AirCondition_choose.living_room_temperature;
                airConditionOn = Eva_AirCondition_choose.living_room_airCondition_isOn;

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                }
                else
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                }

                if (Eva_AirCondition_choose.living_room_program == "Κρύο")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                if (Eva_AirCondition_choose.living_room_fan_speed == "Χαμηλή ταχύτητα")
                {
                    radioButton3.Checked = true;
                }
                else if (Eva_AirCondition_choose.living_room_fan_speed == "Μεσαία ταχύτητα")
                {
                    radioButton4.Checked = true;
                }
                else if (Eva_AirCondition_choose.living_room_fan_speed == "Υψηλή ταχύτητα")
                {
                    radioButton5.Checked = true;
                }
            }

            // If the user clicks on bedroom2
            if (room_code == 3)
            {
                temperature = Eva_AirCondition_choose.bedroom2_temperature;
                airConditionOn = Eva_AirCondition_choose.bedroom2_airCondition_isOn;

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                }
                else
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                }

                if (Eva_AirCondition_choose.bedroom2_program == "Κρύο")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                if (Eva_AirCondition_choose.bedroom2_fan_speed == "Χαμηλή ταχύτητα")
                {
                    radioButton3.Checked = true;
                }
                else if (Eva_AirCondition_choose.bedroom2_fan_speed == "Μεσαία ταχύτητα")
                {
                    radioButton4.Checked = true;
                }
                else if (Eva_AirCondition_choose.bedroom2_fan_speed == "Υψηλή ταχύτητα")
                {
                    radioButton5.Checked = true;
                }
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the information icon
            richTextBox8.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the information icon
            richTextBox8.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (temperature < 35)
            {
                temperature++;
                label5.Text = temperature.ToString() + "°C";
            }
            else
            {
                MessageBox.Show("Δεν μπορείτε να μεταβείτε σε θερμοκρασία μεγαλύτερη των 35°C", "⚠️ Error!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (temperature > 18)
            {
                temperature--;
                label5.Text = temperature.ToString() + "°C";
            }
            else
            {
                MessageBox.Show("Δεν μπορείτε να μεταβείτε σε θερμοκρασία μικρότερη των 18°C", "⚠️ Error!");
            }
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Eva_AirCondition_choose ch = new Eva_AirCondition_choose();
            ch.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν με επιτυχία!");
            

            if (room_code == 1) 
            {
                Eva_AirCondition_choose.bedroom1_airCondition_isOn = airConditionOn;
                // Setting the room program
                if (radioButton1.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom1_program = "Κρύο";
                }
                else if(radioButton2.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom1_program = "Ζεστό";
                }

                // Setting the room fan speed for air condition
                if(radioButton3.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom1_fan_speed = "Χαμηλή ταχύτητα";
                }
                else if(radioButton4.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom1_fan_speed = "Μεσαία ταχύτητα";
                }
                else if (radioButton5.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom1_fan_speed = "Υψηλή ταχύτητα";
                }

                // Setting the room's temperature
                Eva_AirCondition_choose.bedroom1_temperature = temperature;

            }
            if (room_code == 2)
            {
                MessageBox.Show("airConditionOn = "+ airConditionOn.ToString());
                Eva_AirCondition_choose.living_room_airCondition_isOn = airConditionOn;
                // Setting the room program
                if (radioButton1.Checked == true)
                {
                    Eva_AirCondition_choose.living_room_program = "Κρύο";
                }
                else if (radioButton2.Checked == true)
                {
                    Eva_AirCondition_choose.living_room_program = "Ζεστό";
                }

                // Setting the room fan speed for air condition
                if (radioButton3.Checked == true)
                {
                    Eva_AirCondition_choose.living_room_fan_speed = "Χαμηλή ταχύτητα";
                }
                else if (radioButton4.Checked == true)
                {
                    Eva_AirCondition_choose.living_room_fan_speed = "Μεσαία ταχύτητα";
                }
                else if (radioButton5.Checked == true)
                {
                    Eva_AirCondition_choose.living_room_fan_speed = "Υψηλή ταχύτητα";
                }

                // Setting the room's temperature
                Eva_AirCondition_choose.living_room_temperature = temperature;

            }
            if (room_code == 3)
            {
                MessageBox.Show("airConditionOn = " + airConditionOn.ToString());
                Eva_AirCondition_choose.bedroom2_airCondition_isOn = airConditionOn;
                // Setting the room program
                if (radioButton1.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom2_program = "Κρύο";
                }
                else if (radioButton2.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom2_program = "Ζεστό";
                }

                // Setting the room fan speed for air condition
                if (radioButton3.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom2_fan_speed = "Χαμηλή ταχύτητα";
                }
                else if (radioButton4.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom2_fan_speed = "Μεσαία ταχύτητα";
                }
                else if (radioButton5.Checked == true)
                {
                    Eva_AirCondition_choose.bedroom2_fan_speed = "Υψηλή ταχύτητα";
                }

                // Setting the room's temperature
                Eva_AirCondition_choose.bedroom2_temperature = temperature;
            }
            this.Close();
            Eva_AirCondition_choose form = new Eva_AirCondition_choose();
            form.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
