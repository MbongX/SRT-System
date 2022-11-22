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
            CenterToScreen();
            Visible = true;
            init.ShowDialog();
        }
    }
}
