using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Smart_home
{
    public partial class Nikos_shoe_rack_ShoeChoose : Form
    {
        public static string kind;
        public static string color;
        string cone = "Shoe.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\Shoe.db";
       
        public Nikos_shoe_rack_ShoeChoose()
        {
            InitializeComponent();
        }
        void showdb()
        {
            var con = new SQLiteConnection(cone);
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
            
            
            bool check1 = false;
            bool check2 = false;
            
            if (radioButton1.Checked == true )
            {
                kind = radioButton1.Text;
                check1 = true;
            }
            if (radioButton2.Checked == true )
            {
                kind = radioButton2.Text;
                check1 = true;
            }
            if (radioButton3.Checked == true)
            {
                kind = radioButton3.Text;
                check1 = true;

            }
            
            //----------------------- 
            if (radioButton4.Checked == true )
            {
                color = radioButton4.Text;
                check2 = true;
            }
            if (radioButton5.Checked == true)
            {
                color = radioButton5.Text;
                check2 = true;
            }
            if ( radioButton10.Checked == true )
            {
               color = radioButton10.Text;
                check2 = true;

            }
            if (radioButton11.Checked == true )
            {
                color = radioButton11.Text;
                check2 = true;

            }
            if (radioButton12.Checked == true )
            {
                color = radioButton12.Text;
                check2 = true;

            }
            if (radioButton6.Checked == true)
            {
                color = radioButton6.Text;
                check2 = true;

            }
            
            //--------------------------------------------------
            
            //-----------------------

            if(check1==true &check2==true)// sql προσθήκη παπουτσιού και σύνδεση 
            {
                
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO Shoes(Activity,Color) VALUES(@Activity,@Color)";
                cmd.Parameters.AddWithValue("@Activity",kind);
                cmd.Parameters.AddWithValue("@Color", color);
                MessageBox.Show("Προστέθηκε επιτυχώς");
                con.Close();
                this.Close();
                Nikos_shoe_rack form2 = new Nikos_shoe_rack();
                form2.Show();

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
