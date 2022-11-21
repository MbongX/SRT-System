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