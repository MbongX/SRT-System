using System.Reflection.Metadata;
using System.Windows.Forms.VisualStyles;
using static System.Console;
using Microsoft.Data.SqlClient;
using SRT_System.Security;

namespace SRT_System.Data 
{
    internal class DCon
    {
        public bool Con_status = false;
        public DCon() 
        { 
        }
        

        public void PerformLogin(string u,string p)
        {
   /*         u = "";
            p = "";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Constants.SOURCE;
            builder.UserID = Constants.ID;
            builder.Password = Constants.KEYS;
            builder.InitialCatalog = Constants.DATABASE_NAME;
            builder.Encrypt = Constants.ENCRYPT_STATUS;
            builder.TrustServerCertificate = Constants.TRUST_SERVER_CERTIFICATE;
            builder.HostNameInCertificate = Constants.H_NAME_CERTIFICATE;
            builder.ConnectTimeout = Constants.CON_TIMEOUT;
            
            using (SqlConnection connection =  new SqlConnection(builder.ConnectionString))
            {
                WriteLine("Querying data from database...");
                String Username = u;
                String Passkeys = Locker.HashIt(p);
                String sql = "SELECT * FROM dummyLogin";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    String user = "", pass = "";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = reader.GetString(0);
                            pass = reader.GetString(1);
                        }

                        if (Username.Equals(user) && Passkeys.Equals(pass))
                        {
                            //Verification and authentication passed
                            MessageBox.Show("Logged in successfully","Login Status",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Form.ActiveForm.Close();
                            //connection.Close();
                            Con_status = true;
                        }else if (Username.Equals(user) || Passkeys.Equals(pass))
                        {
                            //incorrect creds offered
                            MessageBox.Show("Incorrect Username/Password","Login Status",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            Con_status = false; //focus on TextBox 1 and 2
                        }
                        else 
                        {
                            MessageBox.Show("Invalid credentials supplied, Please try again", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Con_status = false; //Focus on TextBox 1 and 2
                        }
                    }
                }

            }
*/
            ////
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
                    String Username = u.ToString();
                    String Password = p.ToString();
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
                               // Close();
                                connection.Close();

                            }
                            else if ((Username.Equals(user) || HPassword.Equals(pass)))
                            {
                                MessageBox.Show("Cima Member", "Wrong Creds");
                            }
                            else
                            {
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
                MessageBox.Show("Login Failed", "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }
        ////

    //}

        public void PerformRegistration()
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
        }
        //crud methods
        

    }
}
