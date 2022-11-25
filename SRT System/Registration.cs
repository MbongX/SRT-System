using Microsoft.Data.SqlClient;
using SRT_System.Data;
using SRT_System.Security.;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Data.SqlClient;
using static System.Console;

namespace SRT_System
{
    public partial class Registration : Form
    {
        int stdNumber, id_pass_number, Year, x, y, z;

        string Firstname = "",
            Surname = "",
            Citizen = "",
            Password = "",
            RepeatPasword = "",
            Email = "",
            AltEmail = "",
            Course = "",
            Specialize = "";

        string stdModule1 = "",
            stdModule2 = "",
            stdModule3 = "",
            stdModule4 = "",
            stdModule5 = "",
            stdModule6,
            stdModule7 = "",
            stdModule8 = "",
            stdModule9 = "",
            stdModule10 = "";

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private List<string> queryRes;

        public List<string> _queryRes {
            get { return queryRes; }
            set { queryRes = value; }
        }

        public Registration()
        {
            InitializeComponent();
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            //clear all fields
            stdNum.Clear();
            stdFirstname.Clear();
            stdLastname.Clear();
            Citizenship.SelectedIndex = -1; ;
            IdNumber.Clear();
            stdPassword.Clear();
            stdRepeatPass.Clear();
            StdEmail.Clear();
            stdAltEmail.Clear();

            //modules
            YearList.SelectedIndex = -1;
            CourseList.SelectedIndex = -1;
            SpecializeList.SelectedIndex = -1;
            Module1.SelectedIndex = -1;
            Module2.SelectedIndex = -1;
            Module3.SelectedIndex = -1;
            Module4.SelectedIndex = -1;
            Module5.SelectedIndex = -1;
            Module6.SelectedIndex = -1;
            Module7.SelectedIndex = -1;
            Module8.SelectedIndex = -1;
            Module9.SelectedIndex = -1;
            Module10.SelectedIndex = -1;
            //DYNAMIC LABEL
            Id_Passport_NumberLbl.Text = "";
            IdNumber.Visible = false;

            //Module.cont
            clearModules();

        }

        public void clearModules()
        {
            Module1.Items.Clear();
            Module2.Items.Clear();
            Module3.Items.Clear();
            Module4.Items.Clear();
            Module5.Items.Clear();
            Module6.Items.Clear();
            Module7.Items.Clear();
            Module8.Items.Clear();
            Module9.Items.Clear();
            Module10.Items.Clear();

        }

        public void Registration_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            IdNumber.Visible = false;
            CourseLbl.Visible = false;
            SpLbl.Visible = false;
            CourseList.Visible = false;
            SpecializeList.Visible = false;


            RegData data = new RegData();

            for (int i = 0; i < data.citizenship.Count; i++)
            {
                Citizenship.Items.Add(data.citizenship[i]);
            }

            for (int i = 0; i < data.year.Count; i++)
            {
                YearList.Items.Add(data.year[i]);
            }

        }

        private void Citizen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Citizenship.SelectedIndex == 0)
            {
                Id_Passport_NumberLbl.Text = "ID Number";
                IdNumber.Visible = true;
            }
            else
            {
                Id_Passport_NumberLbl.Text = "Passport Number";
                IdNumber.Visible = true;
            }

        }

        private void YearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearList.SelectedIndex == 0)
            {
                RegData data = new RegData();
                //data.course.Clear();
                CourseList.Items.Clear();

                data.courseloader(0);
                for (int i = 0; i < data.course.Count; i++)
                {
                    CourseList.Items.Add(data.course[i]);
                }


                CourseList.Visible = true;
                CourseLbl.Visible = true;

                SpecializeList.Visible = false;
                SpLbl.Visible = false;
            }
            else if (YearList.SelectedIndex == 1)
            {
                RegData data = new RegData();
                data.course.Clear();
                //data.specialization.Clear();

                CourseList.Items.Clear();
                SpecializeList.Items.Clear();

                data.courseloader(1);
                data.spLoader();

                for (int i = 0; i < data.course.Count; i++)
                {
                    CourseList.Items.Add(data.course[i]);
                }

                for (int i = 0; i < data.specialization.Count; i++)
                {
                    SpecializeList.Items.Add(data.specialization[i]);
                }

                CourseList.Visible = true;
                CourseLbl.Visible = true;
                SpecializeList.Visible = true;
                SpLbl.Visible = true;

            }
            else if (YearList.SelectedIndex == 2)
            {
                RegData data = new RegData();
                data.course.Clear();
                CourseList.Items.Clear();
                SpecializeList.Items.Clear();

                data.courseloader(1);
                data.spLoader();

                for (int i = 0; i < data.course.Count; i++)
                {
                    CourseList.Items.Add(data.course[i]);
                }

                for (int i = 0; i < data.specialization.Count; i++)
                {
                    SpecializeList.Items.Add(data.specialization[i]);
                }

                CourseList.Visible = true;
                CourseLbl.Visible = true;

                SpLbl.Visible = true;
                SpecializeList.Visible = true;
            }
            else
            {
                CourseList.Visible = false;
                CourseLbl.Visible = false;
                SpLbl.Visible = false;
                SpecializeList.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

            if (YearList.SelectedIndex == 0 && CourseList.SelectedIndex == 0)
            {
                clearModules();
                RegData data = new RegData();
                for (int i = 0; i < 5; i++)
                {
                    //S1
                    Module1.Items.Add(data.HCIT[i]);
                    Module2.Items.Add(data.HCIT[i]);
                    Module3.Items.Add(data.HCIT[i]);
                    Module4.Items.Add(data.HCIT[i]);
                    Module5.Items.Add(data.HCIT[i]);

                }

                data.HCIT.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    //S2
                    Module6.Items.Add(data.HCIT[i]);
                    Module7.Items.Add(data.HCIT[i]);
                    Module8.Items.Add(data.HCIT[i]);
                    Module9.Items.Add(data.HCIT[i]);
                    Module10.Items.Add(data.HCIT[i]);
                }
            }
            else if (YearList.SelectedIndex == 0 && CourseList.SelectedIndex == 1) //DIT 1st yr
            {
                clearModules();
                RegData data = new RegData();
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Dit[i]);
                    Module2.Items.Add(data.Dit[i]);
                    Module3.Items.Add(data.Dit[i]);
                    Module4.Items.Add(data.Dit[i]);
                    Module5.Items.Add(data.Dit[i]);
                }

                data.Dit.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    //S2
                    Module6.Items.Add(data.Dit[i]);
                    Module7.Items.Add(data.Dit[i]);
                    Module8.Items.Add(data.Dit[i]);
                    Module9.Items.Add(data.Dit[i]);
                    Module10.Items.Add(data.Dit[i]);
                }
            }
            else if (YearList.SelectedIndex == 0 && CourseList.SelectedIndex == 2) //BSC 1st yr
            {
                clearModules();
                RegData data = new RegData();
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Bsc[i]);
                    Module2.Items.Add(data.Bsc[i]);
                    Module3.Items.Add(data.Bsc[i]);
                    Module4.Items.Add(data.Bsc[i]);
                    Module5.Items.Add(data.Bsc[i]);

                }

                data.Bsc.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    //S2
                    Module6.Items.Add(data.Bsc[i]);
                    Module7.Items.Add(data.Bsc[i]);
                    Module8.Items.Add(data.Bsc[i]);
                    Module9.Items.Add(data.Bsc[i]);
                    Module10.Items.Add(data.Bsc[i]);
                }
            }
            else if (YearList.SelectedIndex == 1 && CourseList.SelectedIndex == 0 &&
                     SpecializeList.SelectedIndex == 0) //2nd yr dit BA
            {
                clearModules();
                RegData data = new RegData();
                x = YearList.SelectedIndex;
                y = CourseList.SelectedIndex;
                z = SpecializeList.SelectedIndex;
                data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Dit2[i]);
                    Module2.Items.Add(data.Dit2[i]);
                    Module3.Items.Add(data.Dit2[i]);
                    Module4.Items.Add(data.Dit2[i]);
                    Module5.Items.Add(data.Dit2[i]);

                }

                data.Dit2.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Dit2[i]);
                    Module7.Items.Add(data.Dit2[i]);
                    Module8.Items.Add(data.Dit2[i]);
                    Module9.Items.Add(data.Dit2[i]);
                    Module10.Items.Add(data.Dit2[i]);

                }
            }
            else if (YearList.SelectedIndex == 1 && CourseList.SelectedIndex == 0 &&
                     SpecializeList.SelectedIndex == 1) //2nd yr dit SE
            {
                clearModules();
                RegData data = new RegData();
                x = YearList.SelectedIndex;
                y = CourseList.SelectedIndex;
                z = SpecializeList.SelectedIndex;
                data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Dit2[i]);
                    Module2.Items.Add(data.Dit2[i]);
                    Module3.Items.Add(data.Dit2[i]);
                    Module4.Items.Add(data.Dit2[i]);
                    Module5.Items.Add(data.Dit2[i]);

                }

                data.Dit2.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Dit2[i]);
                    Module7.Items.Add(data.Dit2[i]);
                    Module8.Items.Add(data.Dit2[i]);
                    Module9.Items.Add(data.Dit2[i]);
                    Module10.Items.Add(data.Dit2[i]);

                }
            }
            else if (YearList.SelectedIndex == 1 && CourseList.SelectedIndex == 0 &&
                     SpecializeList.SelectedIndex == 2) //2nd yr dit SE
            {
                clearModules();
                RegData data = new RegData();
                x = YearList.SelectedIndex;
                y = CourseList.SelectedIndex;
                z = SpecializeList.SelectedIndex;
                data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Dit2[i]);
                    Module2.Items.Add(data.Dit2[i]);
                    Module3.Items.Add(data.Dit2[i]);
                    Module4.Items.Add(data.Dit2[i]);
                    Module5.Items.Add(data.Dit2[i]);

                }

                data.Dit2.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Dit2[i]);
                    Module7.Items.Add(data.Dit2[i]);
                    Module8.Items.Add(data.Dit2[i]);
                    Module9.Items.Add(data.Dit2[i]);
                    Module10.Items.Add(data.Dit2[i]);

                }
            }
            else if (YearList.SelectedIndex == 1 && CourseList.SelectedIndex == 1 &&
                     SpecializeList.SelectedIndex == 0) //2nd yr bsc BA
            {
                clearModules();
                RegData data = new RegData();
                x = YearList.SelectedIndex;
                y = CourseList.SelectedIndex;
                z = SpecializeList.SelectedIndex;
                data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Bsc2[i]);
                    Module2.Items.Add(data.Bsc2[i]);
                    Module3.Items.Add(data.Bsc2[i]);
                    Module4.Items.Add(data.Bsc2[i]);
                    Module5.Items.Add(data.Bsc2[i]);

                }

                data.Bsc2.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Bsc2[i]);
                    Module7.Items.Add(data.Bsc2[i]);
                    Module8.Items.Add(data.Bsc2[i]);
                    Module9.Items.Add(data.Bsc2[i]);
                    Module10.Items.Add(data.Bsc2[i]);

                }
            }
            else if (YearList.SelectedIndex == 1 && CourseList.SelectedIndex == 1 &&
                     SpecializeList.SelectedIndex == 1) //2nd yr bsc SD
            {
                clearModules();
                RegData data = new RegData();
                x = YearList.SelectedIndex;
                y = CourseList.SelectedIndex;
                z = SpecializeList.SelectedIndex;
                data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Bsc2[i]);
                    Module2.Items.Add(data.Bsc2[i]);
                    Module3.Items.Add(data.Bsc2[i]);
                    Module4.Items.Add(data.Bsc2[i]);
                    Module5.Items.Add(data.Bsc2[i]);

                }

                data.Bsc2.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Bsc2[i]);
                    Module7.Items.Add(data.Bsc2[i]);
                    Module8.Items.Add(data.Bsc2[i]);
                    Module9.Items.Add(data.Bsc2[i]);
                    Module10.Items.Add(data.Bsc2[i]);

                }
            }
            else if (YearList.SelectedIndex == 1 && CourseList.SelectedIndex == 1 &&
                     SpecializeList.SelectedIndex == 2) //2nd yr bsc SE
            {
                clearModules();
                RegData data = new RegData();
                x = YearList.SelectedIndex;
                y = CourseList.SelectedIndex;
                z = SpecializeList.SelectedIndex;
                data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Bsc2[i]);
                    Module2.Items.Add(data.Bsc2[i]);
                    Module3.Items.Add(data.Bsc2[i]);
                    Module4.Items.Add(data.Bsc2[i]);
                    Module5.Items.Add(data.Bsc2[i]);

                }

                data.Bsc2.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Bsc2[i]);
                    Module7.Items.Add(data.Bsc2[i]);
                    Module8.Items.Add(data.Bsc2[i]);
                    Module9.Items.Add(data.Bsc2[i]);
                    Module10.Items.Add(data.Bsc2[i]);

                }
            }
            else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 0 &&
                     SpecializeList.SelectedIndex == 0) //3rd yr dit BA
                {
                    clearModules();
                    RegData data = new RegData();
                    x = YearList.SelectedIndex;
                    y = CourseList.SelectedIndex;
                    z = SpecializeList.SelectedIndex;
                    data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Dit3[i]);
                    Module2.Items.Add(data.Dit3[i]);
                    Module3.Items.Add(data.Dit3[i]);
                    Module4.Items.Add(data.Dit3[i]);
                    Module5.Items.Add(data.Dit3[i]);

                }

                data.Dit3.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Dit3[i]);
                    Module7.Items.Add(data.Dit3[i]);
                    Module8.Items.Add(data.Dit3[i]);
                    Module9.Items.Add(data.Dit3[i]);
                    Module10.Items.Add(data.Dit3[i]);

                }
            }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 0 &&
                         SpecializeList.SelectedIndex == 1) //3rd yr dit SD
                {
                clearModules();
                    RegData data = new RegData();
                    x = YearList.SelectedIndex;
                    y = CourseList.SelectedIndex;
                    z = SpecializeList.SelectedIndex;
                    data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Dit3[i]);
                    Module2.Items.Add(data.Dit3[i]);
                    Module3.Items.Add(data.Dit3[i]);
                    Module4.Items.Add(data.Dit3[i]);
                    Module5.Items.Add(data.Dit3[i]);

                }

                data.Dit3.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Dit3[i]);
                    Module7.Items.Add(data.Dit3[i]);
                    Module8.Items.Add(data.Dit3[i]);
                    Module9.Items.Add(data.Dit3[i]);
                    Module10.Items.Add(data.Dit3[i]);

                }
            }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 0 &&
                         SpecializeList.SelectedIndex == 2) //3rd yr dit SE
                {
                clearModules();
                    RegData data = new RegData();
                    x = YearList.SelectedIndex;
                    y = CourseList.SelectedIndex;
                    z = SpecializeList.SelectedIndex;
                    data.moduleLoader(x, y, z);
                    for (int i = 0; i < 5; i++)
                    {
                        Module1.Items.Add(data.Dit3[i]);
                        Module2.Items.Add(data.Dit3[i]);
                        Module3.Items.Add(data.Dit3[i]);
                        Module4.Items.Add(data.Dit3[i]);
                        Module5.Items.Add(data.Dit3[i]);

                    }

                    data.Dit3.RemoveRange(0, 5);
                    for (int i = 0; i < 5; i++)
                    {
                        Module6.Items.Add(data.Dit3[i]);
                        Module7.Items.Add(data.Dit3[i]);
                        Module8.Items.Add(data.Dit3[i]);
                        Module9.Items.Add(data.Dit3[i]);
                        Module10.Items.Add(data.Dit3[i]);

                    }
                }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 1 &&
                         SpecializeList.SelectedIndex == 0) //3rd yr bsc BA
                {
                    clearModules();
                    RegData data = new RegData();
                    x = YearList.SelectedIndex;
                    y = CourseList.SelectedIndex;
                    z = SpecializeList.SelectedIndex;
                    data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Bsc3[i]);
                    Module2.Items.Add(data.Bsc3[i]);
                    Module3.Items.Add(data.Bsc3[i]);
                    Module4.Items.Add(data.Bsc3[i]);
                    Module5.Items.Add(data.Bsc3[i]);

                }

                data.Bsc3.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Bsc3[i]);
                    Module7.Items.Add(data.Bsc3[i]);
                    Module8.Items.Add(data.Bsc3[i]);
                    Module9.Items.Add(data.Bsc3[i]);
                    Module10.Items.Add(data.Bsc3[i]);

                }
            }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 1 &&
                         SpecializeList.SelectedIndex == 1) //3rd yr bsc SD
                {
                clearModules();
                    RegData data = new RegData();
                    x = YearList.SelectedIndex;
                    y = CourseList.SelectedIndex;
                    z = SpecializeList.SelectedIndex;
                    data.moduleLoader(x, y, z);
                for (int i = 0; i < 5; i++)
                {
                    Module1.Items.Add(data.Bsc3[i]);
                    Module2.Items.Add(data.Bsc3[i]);
                    Module3.Items.Add(data.Bsc3[i]);
                    Module4.Items.Add(data.Bsc3[i]);
                    Module5.Items.Add(data.Bsc3[i]);

                }

                data.Bsc3.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Bsc3[i]);
                    Module7.Items.Add(data.Bsc3[i]);
                    Module8.Items.Add(data.Bsc3[i]);
                    Module9.Items.Add(data.Bsc3[i]);
                    Module10.Items.Add(data.Bsc3[i]);

                }
            }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 1 &&
                         SpecializeList.SelectedIndex == 2) //3rd yr bsc SE
                {
                    clearModules();
                    RegData data = new RegData();
                    x = YearList.SelectedIndex;
                    y = CourseList.SelectedIndex;
                    z = SpecializeList.SelectedIndex;
                    data.moduleLoader(x, y, z);
                    for (int i = 0; i < 5; i++)
                    {
                        Module1.Items.Add(data.Bsc3[i]);
                        Module2.Items.Add(data.Bsc3[i]);
                        Module3.Items.Add(data.Bsc3[i]);
                        Module4.Items.Add(data.Bsc3[i]);
                        Module5.Items.Add(data.Bsc3[i]);

                    }

                    data.Bsc3.RemoveRange(0, 5);
                    for (int i = 0; i < 5; i++)
                    {
                        Module6.Items.Add(data.Bsc3[i]);
                        Module7.Items.Add(data.Bsc3[i]);
                        Module8.Items.Add(data.Bsc3[i]); 
                        Module9.Items.Add(data.Bsc3[i]);
                        Module10.Items.Add(data.Bsc3[i]);

                }
                }
            }

            private void Module1_SelectedIndexChanged(object sender, EventArgs e)
            {


            }

            private void btnRegister_Click(object sender, EventArgs e)
            {
            try
            {

                if (String.IsNullOrEmpty(stdFirstname.Text.ToString()) || String.IsNullOrEmpty(stdLastname.Text.ToString()) || String.IsNullOrEmpty(Citizenship.SelectedItem.ToString()) ||
                    String.IsNullOrEmpty(IdNumber.Text.ToString()) || String.IsNullOrEmpty(stdPassword.Text.ToString()) || String.IsNullOrEmpty(stdRepeatPass.Text.ToString()) ||
                    String.IsNullOrEmpty(StdEmail.Text.ToString()) || String.IsNullOrEmpty(stdAltEmail.Text.ToString()) || String.IsNullOrEmpty(YearList.Text.ToString()) ||
                    String.IsNullOrEmpty(CourseList.Text.ToString()) || String.IsNullOrEmpty(Module1.Text.ToString()) ||
                    String.IsNullOrEmpty(Module2.Text.ToString()) || String.IsNullOrEmpty(Module3.Text.ToString()) ||
                    String.IsNullOrEmpty(Module4.Text.ToString()) || String.IsNullOrEmpty(Module5.Text.ToString()) ||
                    String.IsNullOrEmpty(Module6.Text.ToString()) || String.IsNullOrEmpty(Module7.Text.ToString()) ||
                    String.IsNullOrEmpty(Module8.Text.ToString()) || String.IsNullOrEmpty(Module9.Text.ToString()) ||
                    String.IsNullOrEmpty(Module10.Text.ToString()))
                {
                    MessageBox.Show("Please fill in all the fields to register","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {

                    //validate and sterilize the data before sending it to db

                    //retrieve all data supplied by user
                    //if (stdNum = String.Empty() || stdFirstname = String.Empty()) { }
                    stdNumber = Int32.Parse(stdNum.Text.Trim());
                    Firstname = stdFirstname.Text.Trim();
                    Surname = stdLastname.Text.Trim();
                    Citizen = Citizenship.SelectedItem.ToString();
                    id_pass_number = Int32.Parse(IdNumber.Text.Trim());
                    Password = stdPassword.Text.Trim();
                    RepeatPasword = stdRepeatPass.Text.Trim();
                    //pass validation
                    if (Password.Equals(RepeatPasword) && (Password.Length <= 8 && RepeatPasword.Length <= 8))
                    {
                        Password = Locker.HashIt(Password);
                    }
                    else {
                        MessageBox.Show("Passwords must match and be greater than 8 characters","Password Validation : Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }

                    Email = StdEmail.Text.Trim();
                    if (IsValid)
                    { 
                    
                    }
                    AltEmail = stdAltEmail.Text.Trim();
                    Year = Int32.Parse(YearList.SelectedItem.ToString());
                    Course = CourseList.SelectedItem.ToString();
                    Specialize = SpecializeList.SelectedItem.ToString();
                    //
                    stdModule1 = Module1.SelectedItem.ToString();
                    stdModule2 = Module2.SelectedItem.ToString();
                    stdModule3 = Module3.SelectedItem.ToString();
                    stdModule4 = Module4.SelectedItem.ToString();
                    stdModule5 = Module5.SelectedItem.ToString();
                    stdModule6 = Module6.SelectedItem.ToString();
                    stdModule7 = Module7.SelectedItem.ToString();
                    stdModule8 = Module8.SelectedItem.ToString();
                    stdModule9 = Module9.SelectedItem.ToString();
                    stdModule10 = Module10.SelectedItem.ToString();
                    //
                    //

                    //new DCon();
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

                            string sql = "INSERT INTO [dbo].[StudentsTest] (Std_Number,Std_Firstname,Std_Lastname,Std_Citizenship,Std_ID_Number,Std_password,Std_Email,std_Alternate_Email,Std_Study_Year,Std_Course,Std_Specialization,Module1,Module2,Module3,Module4,Module5,Module6,Module7,Module8,Module9,Module10) VALUES (@stdNumber,@Fname,@Lname,@citizenship,@idNumber,@Password,@stdEmail,@altEmail,@StudyYear,@Course,@Sp,@Mod1,@Mod2,@Mod3,@Mod4,@Mod5,@Mod6,@Mod7,@Mod8,@Mod9,@Mod10)";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                connection.Open();
                                //try
                                    //{ 
                                    command.Parameters.AddWithValue("@stdNumber", stdNumber);
                                    command.Parameters.AddWithValue("@Fname", Firstname);
                                    command.Parameters.AddWithValue("@Lname", Surname);
                                    command.Parameters.AddWithValue("@citizenship", Citizen);
                                    command.Parameters.AddWithValue("@idNumber", id_pass_number);
                                    command.Parameters.AddWithValue("@Password", Locker.HashIt(Password));
                                    command.Parameters.AddWithValue("@stdEmail", Email);
                                    command.Parameters.AddWithValue("@AltEmail", AltEmail);
                                    command.Parameters.AddWithValue("@StudyYear", Year);
                                    command.Parameters.AddWithValue("@Course", Course);
                                    command.Parameters.AddWithValue("@Sp", Specialize);
                                    command.Parameters.AddWithValue("@Mod1", stdModule1);
                                    command.Parameters.AddWithValue("@Mod2", stdModule2);
                                    command.Parameters.AddWithValue("@Mod3", stdModule3);
                                    command.Parameters.AddWithValue("@Mod4", stdModule4);
                                    command.Parameters.AddWithValue("@Mod5", stdModule5);
                                    command.Parameters.AddWithValue("@Mod6", stdModule6);
                                    command.Parameters.AddWithValue("@Mod7", stdModule7);
                                    command.Parameters.AddWithValue("@Mod8", stdModule8);
                                    command.Parameters.AddWithValue("@Mod9", stdModule9);
                                    command.Parameters.AddWithValue("@Mod10", stdModule10);

                                    command.ExecuteNonQuery();
                                    command.Dispose();
                                    //command = null;
                                    WriteLine("User registered");
                                    MessageBox.Show("New User : " + stdFirstname + " " + stdLastname + " Registered Successfully", "Registration Status : Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //}
                               // catch (Exception qEx)
                               // {
                                    //throw new Exception(qEx.ToString(), qEx);
                                //    MessageBox.Show("Registration Failed, please try again\nException : " + qEx.ToString + " ", "Registration Status : Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                              //  }


                            }

                        }
                        //builder.
                    }
                    //catch (Exception X)
                    //{
                    //    MessageBox.Show("Error Occured\n Details:" + X.ToString + "","error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}

                    catch (Exception exe)
                    {
                        WriteLine(exe.Message);
                        MessageBox.Show("Login Failed", "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }catch(Exception exe) 
            {
                          
            }


            //
          }
       }
    }

