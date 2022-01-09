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
        // A list that contains all the URLs of the pictures for the avatars
        List<String> assistantAvatar = new List<string>();

        // An integer that shows the current avatar in the list (by default it's the woman)
        int currentAvatar = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adding all the URLs of the assistant's pictures 
            assistantAvatar.Add("pictures/woman_assistant.jpg");
            assistantAvatar.Add("pictures/man_assistant.jpg");
            assistantAvatar.Add("pictures/robot_assistant.jpg");
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
    }
}
