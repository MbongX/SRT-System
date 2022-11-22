
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRT_System.Data;
using static System.Console;

namespace SRT_System
{
    public partial class Initialize : Form
    {
        public Initialize()
        {
            InitializeComponent();
        }

        private void Initialze_load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text.ToString().Trim();
                string password = textBox2.Text.ToString().Trim();

                //db connection
                Data.DCon con = new DCon();
                //initialize connection
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
            Registration reg = new Registration();
            Initialize initialize = new Initialize();
            initialize.Visible= false;
            initialize.Hide();
            reg.ShowDialog();
            
        }
    }
}