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
    public partial class Nikos_heat_control : Form
    {
        public static string room_name;
        public static string heat_program;
        public static int temperature = 0;
        public static int working_hours = 0;
        public static string last_checked_room;

        public static string previous_program;
        public static string previous_temperature;
        public static string previous_working_hours;


        public Nikos_heat_control(string room, string prev_program, string prev_temperature, string prev_working_hours)
        {
            // Passing through the constructor the name of the room that is being clicked

            room_name = room;
            previous_program = prev_program;
            previous_temperature = prev_temperature;
            previous_working_hours = prev_working_hours;
            InitializeComponent();
        }

        private void Nikos_heat_control_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(room_name);
            label2.Text = room_name;
            heat_program = previous_program;

            temperature = Int32.Parse(previous_temperature.Substring(0, previous_temperature.Length - 2));

            working_hours = Int32.Parse(previous_working_hours.Substring(0, previous_working_hours.Length - 5));
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // While this form is active, the user cannot click again
            // to interract with the current room. So when the user
            // leaves this form, he is reenabling the ability to click
            // this room again
            if (room_name == "Υπνοδωμάτιο 1")
            {
                if (Nikos_heat.bedroom1_heat_is_on == true)
                {
                    if (temperature < 20 || temperature > 39)
                    {
                        MessageBox.Show("Λανθασμένη τιμή θερμοκρασίας!!\nΟι τιμές πρέπει να κυμαίνονται απο 20°C έως 39°C");
                    }
                    else if (working_hours < 1 || working_hours > 24)
                    {
                        MessageBox.Show("Λανθασμένη επιλογή ωρών!!\nΟι τιμές πρέπει να κυμαίνονται απο 1 έως 24 ώρες");
                    }
                    else
                    {   /*
                        temperature.ToString()+"°C", previous_temperature , working_hours.ToString() ,previous_working_hours.ToString() + " ώρες"
                        MessageBox.Show(heat_program,previous_program);
                        MessageBox.Show(temperature.ToString() + "°C", previous_temperature);
                        MessageBox.Show(working_hours.ToString() + " ώρες", previous_working_hours.ToString());
                        */

                        // Confirmation message
                        if (heat_program != previous_program || temperature.ToString() + "°C" != previous_temperature || working_hours.ToString() + " ώρες" != previous_working_hours.ToString())
                        {
                            MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν με επιτυχία!");
                        }

                        Nikos_heat.heat_panel_is_active = false;
                        this.Close();
                    }
                }
                else
                {
                    Nikos_heat.heat_panel_is_active = false;
                    this.Close();
                }
            }
            if (room_name == "Σαλόνι")
            {
                if (Nikos_heat.living_room_heat_is_on == true)
                {
                    if (temperature < 20 || temperature > 39)
                    {
                        MessageBox.Show("Λανθασμένη τιμή θερμοκρασίας!!\nΟι τιμές πρέπει να κυμαίνονται απο 20°C έως 39°C");
                    }
                    else if (working_hours < 1 || working_hours > 24)
                    {
                        MessageBox.Show("Λανθασμένη επιλογή ωρών!!\nΟι τιμές πρέπει να κυμαίνονται απο 1 έως 24 ώρες");
                    }
                    else
                    {   /*
                        temperature.ToString()+"°C", previous_temperature , working_hours.ToString() ,previous_working_hours.ToString() + " ώρες"
                        MessageBox.Show(heat_program,previous_program);
                        MessageBox.Show(temperature.ToString() + "°C", previous_temperature);
                        MessageBox.Show(working_hours.ToString() + " ώρες", previous_working_hours.ToString());
                        */

                        // Confirmation message
                        if (heat_program != previous_program || temperature.ToString() + "°C" != previous_temperature || working_hours.ToString() + " ώρες" != previous_working_hours.ToString())
                        {
                            MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν με επιτυχία!");
                        }

                        Nikos_heat.heat_panel_is_active = false;
                        this.Close();
                    }
                }
                else
                {
                    Nikos_heat.heat_panel_is_active = false;
                    this.Close();
                }
            }
            if (room_name == "Κουζίνα")
            {
                if (Nikos_heat.kitchen_heat_is_on == true)
                {
                    if (temperature < 20 || temperature > 39)
                    {
                        MessageBox.Show("Λανθασμένη τιμή θερμοκρασίας!!\nΟι τιμές πρέπει να κυμαίνονται απο 20°C έως 39°C");
                    }
                    else if (working_hours < 1 || working_hours > 24)
                    {
                        MessageBox.Show("Λανθασμένη επιλογή ωρών!!\nΟι τιμές πρέπει να κυμαίνονται απο 1 έως 24 ώρες");
                    }
                    else
                    {   /*
                        temperature.ToString()+"°C", previous_temperature , working_hours.ToString() ,previous_working_hours.ToString() + " ώρες"
                        MessageBox.Show(heat_program,previous_program);
                        MessageBox.Show(temperature.ToString() + "°C", previous_temperature);
                        MessageBox.Show(working_hours.ToString() + " ώρες", previous_working_hours.ToString());
                        */

                        // Confirmation message
                        if (heat_program != previous_program || temperature.ToString() + "°C" != previous_temperature || working_hours.ToString() + " ώρες" != previous_working_hours.ToString())
                        {
                            MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν με επιτυχία!");
                        }

                        Nikos_heat.heat_panel_is_active = false;
                        this.Close();
                    }
                }
                else
                {
                    Nikos_heat.heat_panel_is_active = false;
                    this.Close();
                }
            }
            if (room_name == "Τουαλέτα")
            {
                if (Nikos_heat.toilet_heat_is_on == true)
                {
                    if (temperature < 20 || temperature > 39)
                    {
                        MessageBox.Show("Λανθασμένη τιμή θερμοκρασίας!!\nΟι τιμές πρέπει να κυμαίνονται απο 20°C έως 39°C");
                    }
                    else if (working_hours < 1 || working_hours > 24)
                    {
                        MessageBox.Show("Λανθασμένη επιλογή ωρών!!\nΟι τιμές πρέπει να κυμαίνονται απο 1 έως 24 ώρες");
                    }
                    else
                    {   /*
                        temperature.ToString()+"°C", previous_temperature , working_hours.ToString() ,previous_working_hours.ToString() + " ώρες"
                        MessageBox.Show(heat_program,previous_program);
                        MessageBox.Show(temperature.ToString() + "°C", previous_temperature);
                        MessageBox.Show(working_hours.ToString() + " ώρες", previous_working_hours.ToString());
                        */

                        // Confirmation message
                        if (heat_program != previous_program || temperature.ToString() + "°C" != previous_temperature || working_hours.ToString() + " ώρες" != previous_working_hours.ToString())
                        {
                            MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν με επιτυχία!");
                        }

                        Nikos_heat.heat_panel_is_active = false;
                        this.Close();
                    }
                }
                else
                {
                    Nikos_heat.heat_panel_is_active = false;
                    this.Close();
                }
            }
            if (room_name == "Μπάνιο")
            {
                if (Nikos_heat.bathroom_heat_is_on == true)
                {
                    if (temperature < 20 || temperature > 39)
                    {
                        MessageBox.Show("Λανθασμένη τιμή θερμοκρασίας!!\nΟι τιμές πρέπει να κυμαίνονται απο 20°C έως 39°C");
                    }
                    else if (working_hours < 1 || working_hours > 24)
                    {
                        MessageBox.Show("Λανθασμένη επιλογή ωρών!!\nΟι τιμές πρέπει να κυμαίνονται απο 1 έως 24 ώρες");
                    }
                    else
                    {   /*
                        temperature.ToString()+"°C", previous_temperature , working_hours.ToString() ,previous_working_hours.ToString() + " ώρες"
                        MessageBox.Show(heat_program,previous_program);
                        MessageBox.Show(temperature.ToString() + "°C", previous_temperature);
                        MessageBox.Show(working_hours.ToString() + " ώρες", previous_working_hours.ToString());
                        */

                        // Confirmation message
                        if (heat_program != previous_program || temperature.ToString() + "°C" != previous_temperature || working_hours.ToString() + " ώρες" != previous_working_hours.ToString())
                        {
                            MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν με επιτυχία!");
                        }

                        Nikos_heat.heat_panel_is_active = false;
                        this.Close();
                    }
                }
                else
                {
                    Nikos_heat.heat_panel_is_active = false;
                    this.Close();
                }
            }
            if (room_name == "Υπνοδωμάτιο 2")
            {
                if (Nikos_heat.bedroom2_heat_is_on == true)
                {
                    if (temperature < 20 || temperature > 39)
                    {
                        MessageBox.Show("Λανθασμένη τιμή θερμοκρασίας!!\nΟι τιμές πρέπει να κυμαίνονται απο 20°C έως 39°C");
                    }
                    else if (working_hours < 1 || working_hours > 24)
                    {
                        MessageBox.Show("Λανθασμένη επιλογή ωρών!!\nΟι τιμές πρέπει να κυμαίνονται απο 1 έως 24 ώρες");
                    }
                    else
                    {   /*
                        temperature.ToString()+"°C", previous_temperature , working_hours.ToString() ,previous_working_hours.ToString() + " ώρες"
                        MessageBox.Show(heat_program,previous_program);
                        MessageBox.Show(temperature.ToString() + "°C", previous_temperature);
                        MessageBox.Show(working_hours.ToString() + " ώρες", previous_working_hours.ToString());
                        */

                        // Confirmation message
                        if (heat_program != previous_program || temperature.ToString() + "°C" != previous_temperature || working_hours.ToString() + " ώρες" != previous_working_hours.ToString())
                        {
                            MessageBox.Show("Οι αλλαγές πραγματοποιήθηκαν με επιτυχία!");
                        }

                        Nikos_heat.heat_panel_is_active = false;
                        this.Close();
                    }
                }
                else
                {
                    Nikos_heat.heat_panel_is_active = false;
                    this.Close();
                }
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Changing the text and the color of the open/close button
            // depending on if the room has its heaT ON or OFF

            if (room_name == "Υπνοδωμάτιο 1")
            {
                if (Nikos_heat.bedroom1_heat_is_on)
                {
                    button5.Text = "Κλείσιμο θέρμανσης";
                    button5.BackColor = Color.DarkRed;
                    label5.Text = "Άνοιχτή";
                    label5.ForeColor = Color.LightGreen;
                }
                else
                {                    
                    button5.Text = "Άνοιγμα θέρμανσης";
                    button5.BackColor = Color.LightGreen;
                    label5.Text = "Κλειστή";
                    label5.ForeColor = Color.DarkRed;
                }
            }
            if (room_name == "Σαλόνι")
            {
                if (Nikos_heat.living_room_heat_is_on)
                {
                    button5.Text = "Κλείσιμο θέρμανσης";
                    button5.BackColor = Color.DarkRed;
                    label5.Text = "Άνοιχτή";
                    label5.ForeColor = Color.LightGreen;
                }
                else
                {
                    button5.Text = "Άνοιγμα θέρμανσης";
                    button5.BackColor = Color.LightGreen;
                    label5.Text = "Κλειστή";
                    label5.ForeColor = Color.DarkRed;
                }
            }
            if (room_name == "Κουζίνα")
            {
                if (Nikos_heat.kitchen_heat_is_on)
                {
                    button5.Text = "Κλείσιμο θέρμανσης";
                    button5.BackColor = Color.DarkRed;
                    label5.Text = "Άνοιχτή";
                    label5.ForeColor = Color.LightGreen;
                }
                else
                {
                    button5.Text = "Άνοιγμα θέρμανσης";
                    button5.BackColor = Color.LightGreen;
                    label5.Text = "Κλειστή";
                    label5.ForeColor = Color.DarkRed;
                }
            }
            if (room_name == "Τουαλέτα")
            {
                if (Nikos_heat.toilet_heat_is_on)
                {
                    button5.Text = "Κλείσιμο θέρμανσης";
                    button5.BackColor = Color.DarkRed;
                    label5.Text = "Άνοιχτή";
                    label5.ForeColor = Color.LightGreen;
                }
                else
                {
                    button5.Text = "Άνοιγμα θέρμανσης";
                    button5.BackColor = Color.LightGreen;
                    label5.Text = "Κλειστή";
                    label5.ForeColor = Color.DarkRed;
                }
            }
            if (room_name == "Μπάνιο")
            {
                if (Nikos_heat.bathroom_heat_is_on)
                {
                    button5.Text = "Κλείσιμο θέρμανσης";
                    button5.BackColor = Color.DarkRed;
                    label5.Text = "Άνοιχτή";
                    label5.ForeColor = Color.LightGreen;
                }
                else
                {
                    button5.Text = "Άνοιγμα θέρμανσης";
                    button5.BackColor = Color.LightGreen;
                    label5.Text = "Κλειστή";
                    label5.ForeColor = Color.DarkRed;
                }
            }
            if (room_name == "Υπνοδωμάτιο 2")
            {
                if (Nikos_heat.bedroom2_heat_is_on)
                {
                    button5.Text = "Κλείσιμο θέρμανσης";
                    button5.BackColor = Color.DarkRed;
                    label5.Text = "Άνοιχτή";
                    label5.ForeColor = Color.LightGreen;
                }
                else
                {
                    button5.Text = "Άνοιγμα θέρμανσης";
                    button5.BackColor = Color.LightGreen;
                    label5.Text = "Κλειστή";
                    label5.ForeColor = Color.DarkRed;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (room_name == "Υπνοδωμάτιο 1")
            {
                
                if (Nikos_heat.bedroom1_heat_is_on == true)
                {
                    Nikos_heat.bedroom1_heat_is_on = false;
                }
                else
                {
                    Nikos_heat.bedroom1_heat_is_on = true;
                }
            }
            if (room_name == "Σαλόνι")
            {

                if (Nikos_heat.living_room_heat_is_on == true)
                {
                    Nikos_heat.living_room_heat_is_on = false;
                }
                else
                {
                    Nikos_heat.living_room_heat_is_on = true;
                }
            }
            if (room_name == "Κουζίνα")
            {

                if (Nikos_heat.kitchen_heat_is_on == true)
                {
                    Nikos_heat.kitchen_heat_is_on = false;
                }
                else
                {
                    Nikos_heat.kitchen_heat_is_on = true;
                }
            }
            if (room_name == "Τουαλέτα")
            {

                if (Nikos_heat.toilet_heat_is_on == true)
                {
                    Nikos_heat.toilet_heat_is_on = false;
                }
                else
                {
                    Nikos_heat.toilet_heat_is_on = true;
                }
            }
            if (room_name == "Μπάνιο")
            {

                if (Nikos_heat.bathroom_heat_is_on == true)
                {
                    Nikos_heat.bathroom_heat_is_on = false;
                }
                else
                {
                    Nikos_heat.bathroom_heat_is_on = true;
                }
            }
            if (room_name == "Υπνοδωμάτιο 2")
            {

                if (Nikos_heat.bedroom2_heat_is_on == true)
                {
                    Nikos_heat.bedroom2_heat_is_on = false;
                }
                else
                {
                    Nikos_heat.bedroom2_heat_is_on = true;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Άνοιχτή")
            {
                panel1.Visible = true;
                panel1.Location = new Point(104, 200);
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else
            {
                MessageBox.Show("Η θέρμανση πρέπει να είναι ανοιχτή πρωτού προβείτε σε αλλαγές. \nΠαρακαλώ ενεργοποιήστε την πρώτα και μετά ξαναπροσπαθήστε");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Άνοιχτή")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                panel2.Location = new Point(89, 198);
            }
            else
            {
                MessageBox.Show("Η θέρμανση πρέπει να είναι ανοιχτή πρωτού προβείτε σε αλλαγές. \nΠαρακαλώ ενεργοποιήστε την πρώτα και μετά ξαναπροσπαθήστε");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Άνοιχτή")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
                panel3.Location = new Point(89, 198);
            }
            else
            {
                MessageBox.Show("Η θέρμανση πρέπει να είναι ανοιχτή πρωτού προβείτε σε αλλαγές. \nΠαρακαλώ ενεργοποιήστε την πρώτα και μετά ξαναπροσπαθήστε");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Άνοιχτή")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
                panel4.Location = new Point(91, 182);
            }
            else
            {
                MessageBox.Show("Η θέρμανση πρέπει να είναι ανοιχτή πρωτού προβείτε σε αλλαγές. \nΠαρακαλώ ενεργοποιήστε την πρώτα και μετά ξαναπροσπαθήστε");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            heat_program = "Γρήγορη θέρμανση";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            heat_program = "Σταδιακά αυξανόμενη θέρμανση";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Assigning the value of the 1st numericUpDown to the
            // global variable about the temperature
            temperature = ((int)numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Assigning the value of the 2nd numericUpDown to the
            // global variable about the working hours
            working_hours = ((int)numericUpDown2.Value);
        }
    }
}
