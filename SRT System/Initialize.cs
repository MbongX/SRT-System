using System.Collections.Immutable;
using Microsoft.Data.SqlClient;
using SRT_System.Data;
using SRT_System.Security;
using static System.Console;

namespace SRT_System
{
    public partial class Initialize : Form
    {
        List<string> temp;
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
                password = Locker.HashIt(password);

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "srts.database.windows.net";
                builder.UserID = "MbongXD";
                builder.Password = "Magwegwe203@";
                builder.InitialCatalog = "Student Review And Tutoring";
                builder.Encrypt = true;
                builder.TrustServerCertificate = false;
                builder.HostNameInCertificate = "*.database.windows.net";
                builder.ConnectTimeout = 30;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");
                    String Username = textBox1.Text;
                    String Password = textBox2.Text;
                    String HPassword = Locker.HashIt(Password);
                    String sql = "SELECT * FROM test";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        string user = "", pass = "";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                                user = reader.GetString(0);
                                pass = reader.GetString(1);
                            }
                            Console.WriteLine("Username : {0}, Password : {1}", user, pass);
                            if (Username.Equals(user) && HPassword.Equals(pass))
                            {
                                MessageBox.Show("Connected", "Good");
                            }
                            else {
                                MessageBox.Show("Cima Member","Wrong Creds");
                            }
                        }
                    }
                    //builder.
                }
            }
            catch (Exception exe)
            {
                WriteLine(exe.Message);
                MessageBox.Show("Connection lost","Error");
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