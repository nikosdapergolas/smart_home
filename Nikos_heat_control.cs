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

        public Nikos_heat_control(string room)
        {
            // Passing through the constructor the name of the room that is being clicked

            room_name = room;
            InitializeComponent();
        }

        private void Nikos_heat_control_Load(object sender, EventArgs e)
        {
            label2.Text = room_name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // While this form is active, the user cannot click again
            // to interract with the current room. So when the user
            // leaves this form, he is reenabling the ability to click
            // this room again

            Nikos_heat.bedroom1_heat_panel_active = false;
            
            this.Close();
        }
    }
}
