﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRT_System
{
    public partial class Review_System : Form
    {
        public Review_System()
        {
            InitializeComponent();
        }

        private void Review_System_Load(object sender, EventArgs e)
        {
            Initialize init = new Initialize();
            this.CenterToScreen();
            this.Visible = true;
            init.ShowDialog();
        }
    }
}