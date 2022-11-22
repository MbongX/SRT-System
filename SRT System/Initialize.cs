using System.Collections.Immutable;
using Microsoft.Data.SqlClient;
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
            CenterToScreen();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();

                //db connection
                DCon con = new DCon();
                //initialize connection
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    builder.
                }
            }
            catch (Exception exe)
            {
                WriteLine(exe.Message);
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