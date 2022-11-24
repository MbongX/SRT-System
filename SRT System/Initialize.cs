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

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = Constants.SOURCE;
                builder.UserID = Constants.ID;
                builder.Password = Constants.KEYS;
                builder.InitialCatalog = Constants.DATABASE_NAME;
                builder.Encrypt = Constants.ENCRYPT_STATUS;
                builder.TrustServerCertificate = Constants.TRUST_SERVER_CERTIFICATE;
                builder.HostNameInCertificate = Constants.H_NAME_CERTIFICATE;
                builder.ConnectTimeout = Constants.CON_TIMEOUT;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");
                    String Username = textBox1.Text;
                    String Password = textBox2.Text;
                    String HPassword = Locker.HashIt(Password);
                    String sql = "SELECT * FROM dummyLogin";

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
                       
                            if (Username.Equals(user) && HPassword.Equals(pass))
                            {
                                MessageBox.Show("Connected", "Good");
                                Close();
                                connection.Close();

                            }
                            else if ((Username.Equals(user) || HPassword.Equals(pass)))
                            {
                                MessageBox.Show("Cima Member", "Wrong Creds");
                            }
                            else {
                                MessageBox.Show("Connection Error", "Database error");
                            }
                        }
                    }
                    //builder.
                }
        }
            catch (Exception exe)
            {
                WriteLine(exe.Message);
                MessageBox.Show("Login Failed","Connection Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
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