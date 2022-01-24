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

        public Eva_AirCondition_Form()
        {
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
            button1.BackColor = Color.Silver;
        }

        private void Eva_AirCondition_Form_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Δεν μπορείτε να μεταβείτε σε θερμοκρασία μεγαλύτερη των 35°C");
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
                MessageBox.Show("Δεν μπορείτε να μεταβείτε σε θερμοκρασία μικρότερη των 18°C");
            }
            
        }
    }
}
