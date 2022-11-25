﻿using SRT_System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace SRT_System
{
    public partial class Review_System : Form
    {
        public List<String> ModuleID = new List<String>();
        public List<String> ModuleName = new List<String>();
        public List<String> LectureID = new List<String>();
        public int c = 0;
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
            String moduleLoad = "";
            String ModID;
            int c = 000;
            

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

                    String sql = "SELECT * FROM Modules";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Console.WriteLine("{0} :: {1}", reader.GetInt32(0), reader.GetString(1));
                                // moduleLoad = ("Module Code : {0}, Module name : {1}, LectureID(Assuigned Lecture) : {2}",reader.GetString(0), reader.GetString(1), reader.GetString(2));
                                moduleLoad = "Module Code : " + reader.GetString(0) + ", Module name : " + reader.GetString(1) + ", Assigned LectureID : " + reader.GetString(2) + "";
                                ModuleID.Add(reader.GetString(0));
                                ModuleName.Add(reader.GetString(1));
                                LectureID.Add(reader.GetString(2));
                                comboBox1.Items.Add(moduleLoad.ToString());
                                
                            }

                            /*  if (Username.ToString().Equals(user.ToString()) && HPassword.Equals(pass))
                              {
                                  MessageBox.Show("Login Successful", "Login status : Successful");
                                  Close();
                                  connection.Close();

                              }
                              else if (!(Username.ToString().Equals(user.ToString()) && HPassword.Equals(pass)))
                              {
                                  MessageBox.Show("Invalid Username/Password, Please try again!!", "Login Status : Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                              }
                              else
                              {
                                  MessageBox.Show("Could not establish a connection to the server, Please check your internet connection and try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              }*/
                        }
                        connection.Close();
                    }
                    //builder.
                }
            }

            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
                MessageBox.Show(exe.Message, "Login Attempt Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

    /* try
     {

         String sql = "SELECT * FROM  Models ";

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
                     MessageBox.Show("Invalid Username/Password, Please try again!!", "Login Status : Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 else
                 {
                     MessageBox.Show("Could not establish a connection to the server, Please check your internet connection and try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
         }

         SqlConnection connection = new SqlConnection(Constants.CON_STRING_HOME);
          connection.Open();
          SqlCommand command = new SqlCommand("Select * From Models", connection);
          using (SqlDataReader reader = command.ExecuteReader())
          {
              while (reader.Read())
              {
                  //Console.WriteLine("{0} :: {1}", reader.GetInt32(0), reader.GetString(1));
                  moduleLoad = "Module Code : " + reader.GetString(0) + ", Module name : " + reader.GetString(1) + ", Assigned LectureID : " + reader.GetString(2) + "";
                  comboBox1.Items.Add(moduleLoad);
              }

              if (Username.ToString().Equals(user.ToString()) && HPassword.Equals(pass))
              {
                  MessageBox.Show("Login Successful", "Login status : Successful");
                  Close();
                  connection.Close();

              }
              else if (!(Username.ToString().Equals(user.ToString()) && HPassword.Equals(pass)))
              {
                  MessageBox.Show("Invalid Username/Password, Please try again!!", "Login Status : Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
              else
              {
                  MessageBox.Show("Could not establish a connection to the server, Please check your internet connection and try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }*/
//}
  //          }
    //        catch (Exception ex) { }
     //c   }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Tutoring_System tut = new Tutoring_System();
            tut.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusLbl.Text = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EvalText.Text = "";
            SugText.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string r, ev, sg,l, m;
            //int c = 000;
            int index = comboBox1.SelectedIndex;
            c++;
            r = ("Rev" + c);
            ev = EvalText.Text.ToString().Trim();
            l = LectureID[index].ToString();
            m = ModuleID[index].ToString();
            sg = SugText.Text.ToString();

 
            try
            {
                SqlConnection connection = new SqlConnection(Constants.CON_STRING_HOME);
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO LectureReview (Rev_ID,Review_Description,Review_Suggestions_Complaints,Lecture_ID,ModulesID) VALUES (@R_ID,@Eval,@Sugg,@Lecture,@Module)", connection);
                command.Parameters.AddWithValue("@R_ID", r);
                command.Parameters.AddWithValue("@Eval", ev);
                command.Parameters.AddWithValue("@Sugg", sg);
                command.Parameters.AddWithValue("@Lecture", l);
                command.Parameters.AddWithValue("@Module", m);



                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New Review " + r + ", successfully Submitted", "Review Evaluation Status : successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EvalText.Text = "";
                SugText.Text = "";
                comboBox1.SelectedIndex = -1;
                
                // using (var commands = new SqlCommand("", connection)) { }
            }
            catch(Exception ex) { MessageBox.Show("New Review " + r + ", was nsuccessful ", "Review Evaluation Status : Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);Console.WriteLine(ex.Message); }
        }
    }
}
