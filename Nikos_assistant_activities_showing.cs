﻿using System;
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
    public partial class Nikos_assistant_activities_showing : Form
    {
        public Nikos_assistant_activities_showing()
        {
            InitializeComponent();
        }

        private void Nikos_assistant_activities_showing_Load(object sender, EventArgs e)
        {
            label1.Text = Nikos_assistant_activities_choosing.monday1;
            label2.Text = Nikos_assistant_activities_choosing.monday2;
            label3.Text = Nikos_assistant_activities_choosing.monday3;
        }
    }
}
