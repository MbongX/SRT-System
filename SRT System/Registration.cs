using SRT_System.Data;
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

        public Registration()
        {
            InitializeComponent();
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
                label5.Text = "ID Number";
                IdNumber.Visible = true;
            }
            else
            {
                label5.Text = "Passport Number";
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
                for (int i = 0; i < 4; i++)
                {
                    //S1
                    Module1.Items.Add(data.HCIT[i]);
                    Module2.Items.Add(data.HCIT[i]);
                    Module3.Items.Add(data.HCIT[i]);
                    Module4.Items.Add(data.HCIT[i]);

                }

                data.HCIT.RemoveRange(0, 4);
                for (int i = 0; i < 3; i++)
                {
                    //S2
                    Module5.Items.Add(data.HCIT[i]);
                    Module6.Items.Add(data.HCIT[i]);
                    Module7.Items.Add(data.HCIT[i]);
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
                     SpecializeList.SelectedIndex == 0) //2nd yr dit
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
                     SpecializeList.SelectedIndex == 1) //2nd yr dit
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
                     SpecializeList.SelectedIndex == 2) //2nd yr dit
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
                     SpecializeList.SelectedIndex == 0) //2nd yr bsc
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

                data.Bsc2.RemoveRange(0, 5);
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
                     SpecializeList.SelectedIndex == 1) //2nd yr bsc
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

                data.Bsc2.RemoveRange(0, 5);
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
                     SpecializeList.SelectedIndex == 2) //2nd yr bsc
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

                data.Bsc2.RemoveRange(0, 5);
                for (int i = 0; i < 5; i++)
                {
                    Module6.Items.Add(data.Dit2[i]);
                    Module7.Items.Add(data.Dit2[i]);
                    Module8.Items.Add(data.Dit2[i]);
                    Module9.Items.Add(data.Dit2[i]);
                    Module10.Items.Add(data.Dit2[i]);

                }
            }
            else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 0 &&
                     SpecializeList.SelectedIndex == 0) //3rd yr dit
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

                    data.Bsc2.RemoveRange(0, 5);
                    for (int i = 0; i < 5; i++)
                    {
                        Module6.Items.Add(data.Dit2[i]);
                        Module7.Items.Add(data.Dit2[i]);
                        Module8.Items.Add(data.Dit2[i]);
                        Module9.Items.Add(data.Dit2[i]);
                        Module10.Items.Add(data.Dit2[i]);

                    }
                }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 0 &&
                         SpecializeList.SelectedIndex == 1) //3rd yr dit
                {
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

                    data.Bsc2.RemoveRange(0, 5);
                    for (int i = 0; i < 5; i++)
                    {
                        Module6.Items.Add(data.Dit2[i]);
                        Module7.Items.Add(data.Dit2[i]);
                        Module8.Items.Add(data.Dit2[i]);
                        Module9.Items.Add(data.Dit2[i]);
                        Module10.Items.Add(data.Dit2[i]);

                    }
                }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 0 &&
                         SpecializeList.SelectedIndex == 2) //3rd yr dit
                {
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

                    data.Bsc2.RemoveRange(0, 5);
                    for (int i = 0; i < 5; i++)
                    {
                        Module6.Items.Add(data.Dit2[i]);
                        Module7.Items.Add(data.Dit2[i]);
                        Module8.Items.Add(data.Dit2[i]);
                        Module9.Items.Add(data.Dit2[i]);
                        Module10.Items.Add(data.Dit2[i]);

                    }
                }




                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 1 &&
                         SpecializeList.SelectedIndex == 0) //3rd yr bsc
                {
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

                    data.Bsc2.RemoveRange(0, 5);
                    for (int i = 0; i < 5; i++)
                    {
                        Module6.Items.Add(data.Dit2[i]);
                        Module7.Items.Add(data.Dit2[i]);
                        Module8.Items.Add(data.Dit2[i]);
                        Module9.Items.Add(data.Dit2[i]);
                        Module10.Items.Add(data.Dit2[i]);

                    }
                }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 1 &&
                         SpecializeList.SelectedIndex == 1) //3rd yr bsc
                {
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

                    data.Bsc2.RemoveRange(0, 5);
                    for (int i = 0; i < 5; i++)
                    {
                        Module6.Items.Add(data.Dit2[i]);
                        Module7.Items.Add(data.Dit2[i]);
                        Module8.Items.Add(data.Dit2[i]);
                        Module9.Items.Add(data.Dit2[i]);
                        Module10.Items.Add(data.Dit2[i]);

                    }
                }
                else if (YearList.SelectedIndex == 2 && CourseList.SelectedIndex == 1 &&
                         SpecializeList.SelectedIndex == 2) //3rd yr bsc
                {
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

                    data.Bsc2.RemoveRange(0, 5);
                    for (int i = 0; i < 5; i++)
                    {
                        Module6.Items.Add(data.Dit2[i]);
                        Module7.Items.Add(data.Dit2[i]);
                        Module8.Items.Add(data.Dit2[i]);
                        Module9.Items.Add(data.Dit2[i]);
                        Module10.Items.Add(data.Dit2[i]);

                    }
                }
            }

            private void Module1_SelectedIndexChanged(object sender, EventArgs e)
            {


            }

            private void btnRegister_Click(object sender, EventArgs e)
            {
                //validate and sterilize the data before sending it to db

                //retrieve all data supplied by user
                stdNumber = Int32.Parse(stdNum.Text.Trim());
                Firstname = stdFirstname.Text.Trim();
                Surname = stdLastname.Text.Trim();
                Citizen = Citizenship.SelectedItem.ToString();
                id_pass_number = Int32.Parse(IdNumber.Text.Trim());
                Password = stdPassword.Text.Trim();
                RepeatPasword = stdRepeatPass.Text.Trim();
                Email = StdEmail.Text.Trim();
                AltEmail = stdAltEmail.Text.Trim();
                Year = Int32.Parse(YearList.SelectedItem.ToString());
                Course = CourseList.SelectedItem.ToString();
                Specialize = SpecializeList.SelectedItem.ToString();
                //
                if (CourseList.Visible = false)
                {
                    Specialize = "";
                }
                else
                {
                    Specialize = SpecializeList.SelectedItem.ToString();
                }

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
                if (String.IsNullOrEmpty(Firstname) || String.IsNullOrEmpty(Surname) || String.IsNullOrEmpty(Citizen) ||
                    (id_pass_number == 0) || String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(RepeatPasword) ||
                    String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(AltEmail) || (Year == 0) ||
                    String.IsNullOrEmpty(Course) || String.IsNullOrEmpty(stdModule1) ||
                    String.IsNullOrEmpty(stdModule2) || String.IsNullOrEmpty(stdModule3) ||
                    String.IsNullOrEmpty(stdModule4) || String.IsNullOrEmpty(stdModule5) ||
                    String.IsNullOrEmpty(stdModule6) || String.IsNullOrEmpty(stdModule7) ||
                    String.IsNullOrEmpty(stdModule8) || String.IsNullOrEmpty(stdModule9) ||
                    String.IsNullOrEmpty(stdModule10))
                {
                    WriteLine("");
                }
                else
                {
                }
            }
        }
    }

