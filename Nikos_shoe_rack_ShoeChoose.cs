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
    public partial class Nikos_shoe_rack_ShoeChoose : Form
    {
        public Nikos_shoe_rack_ShoeChoose()
        {
            InitializeComponent();
        }

        private void Nikos_shoe_rack_ShoeChoose_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_shoe_rack form2 = new Nikos_shoe_rack();
            form2.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kind;
            string color;
            string gender;
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            if (radioButton1.Checked == true & radioButton2.Checked == false & radioButton3.Checked == false)
            {
                kind = radioButton1.Text;
                check1 = true;
            }
            if (radioButton1.Checked == false & radioButton2.Checked == true & radioButton3.Checked == false)
            {
                kind = radioButton2.Text;
                check1 = true;
            }
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == true)
            {
                kind = radioButton3.Text;
                check1 = true;

            }
            else
            {
                MessageBox.Show("Διάλεξε είδος παπουτσιού");
            }
            //----------------------- 
            if (radioButton4.Checked == true & radioButton5.Checked == false & radioButton10.Checked == false& radioButton11.Checked == false& radioButton12.Checked == false & radioButton6.Checked == false)
            {
                color = radioButton4.Text;
                check2 = true;
            }
            if (radioButton4.Checked == false & radioButton5.Checked == true & radioButton10.Checked == false & radioButton11.Checked == false & radioButton12.Checked == false & radioButton6.Checked == false)
            {
                color = radioButton5.Text;
                check2 = true;
            }
            if (radioButton4.Checked == false & radioButton5.Checked == false & radioButton10.Checked == true & radioButton11.Checked == false & radioButton12.Checked == false & radioButton6.Checked == false)
            {
               color = radioButton10.Text;
                check2 = true;

            }
            if (radioButton4.Checked == false & radioButton5.Checked == false & radioButton10.Checked == false & radioButton11.Checked == true & radioButton12.Checked == false & radioButton6.Checked == false)
            {
                color = radioButton11.Text;
                check2 = true;

            }
            if (radioButton4.Checked == false & radioButton5.Checked == false & radioButton10.Checked == false & radioButton11.Checked == false & radioButton12.Checked == true & radioButton6.Checked == false)
            {
                color = radioButton12.Text;
                check2 = true;

            }
            if (radioButton4.Checked == false & radioButton5.Checked == false & radioButton10.Checked == true & radioButton11.Checked == false & radioButton12.Checked == false & radioButton6.Checked == false)
            {
                color = radioButton6.Text;
                check2 = true;

            }
            else
            {
                MessageBox.Show("Διάλεξε χρώμα");
                check2 = false;
            }
            //--------------------------------------------------
            if(radioButton7.Checked==true)
            {
                gender = radioButton7.Text;
                check3 = true;
            }
            if (radioButton8.Checked == true)
            {
                gender = radioButton8.Text;
                check3 = true;
            }
            else
            {
                check2 = false;
            }
            //-----------------------

            if(check1==true &check2==true&check3==true)
            {

            }

        }
    }
}
