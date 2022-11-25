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
                    int Username = Int32.Parse(textBox1.Text.ToString().Trim());
                    String Password = textBox2.Text.ToString().Trim();
                    String HPassword = Locker.HashIt(Password);
                    String sql = "SELECT Std_Number,Std_Password FROM Students ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        string pass = "";
                        long user = 0;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} :: {1}", reader.GetInt32(0), reader.GetString(1));
                                user = reader.GetInt32(0);
                                pass = reader.GetString(1);
                            }
                       
                            if (Username.ToString().Equals(user.ToString()) && HPassword.Equals(pass))
                            {
                                MessageBox.Show("Login Successful", "Login status : Successful");
                                Close();
                                connection.Close();

                            }
                            else if (!(Username.ToString().Equals(user.ToString()) && HPassword.Equals(pass)))
                            {
                                MessageBox.Show("Invalid Username/Password, Please try again!!", "Login Status : Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                            else {
                                MessageBox.Show("Could not establish a connection to the server, Please check your internet connection and try again", "Connection Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                    }
                    //builder.
                }
        }
            catch (Exception exe)
            {
                WriteLine(exe.Message);
                MessageBox.Show(exe.Message,"Login Attempt Failed",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
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