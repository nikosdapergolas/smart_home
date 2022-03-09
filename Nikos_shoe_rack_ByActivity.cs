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
    public partial class Nikos_shoe_rack_ByActivity : Form
    {
        public Nikos_shoe_rack_ByActivity()
        {
            InitializeComponent();
        }
        Random rand = new Random(Guid.NewGuid().GetHashCode());

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

        private void Nikos_shoe_rack_ByActivity_Load(object sender, EventArgs e)
        {

        }
    }
}
