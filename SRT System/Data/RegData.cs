namespace SRT_System.Data
{
    public class RegData
    {
        public List<string> citizenship;
        public List<string> modules;
        public List<string> specialization;
        public List<int> year;
        public List<string> course = new List<string> { ""};

        public List<string> HCIT;
        public List<string> Dit;
        public List<string> Bsc;
        //public List<string> Dit = new List<string>() { "1","2","3","4","5","6","7","8","9","10"};
        //public List<string> Bsc = new List<string>() { "WBT511","IS511","MAT511","PRO511","NET511","WBT512","IS512","MAT512","PRO512","NET512"};
        
        public List<string> Dit2;
        public List<string> Dit3;

        public List<string> Bsc2;
        public List<string> Bsc3;


        public RegData() 
        {
            citizenship = new List<string> { "South African","Other Natioanlity" };
            //course = new List<string>() { "DIT", "BSC" };
            //specialization = new List<string>(4) { "Business Analyst","Software Developer(Programming oriented)","Software Engineering" };
            year = new List<int> { 1, 2, 3 };

            HCIT = new List<string>(10) {"ITC500","SSW500","ECM511","IWT500","N\\A","IIT500","ECM512","BCM500","N\\A","N\\A" }; //FIRST 4 -> S1
            Dit = new List<string>(10) { "SDT500", "INS511", "PRO511", "WBT511", "NET511", "BCM500", "INS512", "PRO512", "WBT512", "NET512" };
            Bsc = new List<string>(10) { "WBT511", "IS511", "MAT511", "PRO511", "NET511", "WBT512", "IS512", "MAT512", "PRO512", "NET512" };

            Dit2 = new List<string>(10) { "MCM512", "NS621", "PRO621", "DBS521", "sp1", "MCM522", "INS622", "PRO622","DBS522","sp2" };
            Dit3 = new List<string>(10) { "QTS600", "IPM600", "SEM600", "HCI600", "sp1", "OPS600", "ITP600", "MIS600" ,"PRO632","sp2"};
            
            Bsc2 = new List<string>(10) { "INS621", "PRO621", "DBS600", "CCP600", "sp1", "INS622", "PRO622", "BDI600" ,"MCI600","sp2"};
            Bsc3 = new List<string>(10) { "IPM700", "PRO731", "CBS700", "MAD700", "sp1", "ITP700", "PRO732", "AFI700" ,"WIL700","sp2"};
            
        }
        public void courseloader(int index)
        {
            switch (index)
            {
                case 0:
                    course = new List<string> { "HCIT", "DIT", "BSC" };
                    break;
                case 1:
                    course = new List<string> { "DIT", "BSC" };
                    break;
                case 2:
                    course = new List<string> { "DIT", "BSC" };
                    break;
            }

        }
        public void spLoader() 
        {
            specialization = new List<string> { "Business Analyst", "Software Developer(Programming oriented)", "Software Engineering" };
        }

        public void moduleLoader(int study, int course, int spec)
        { 
            //logic pending
            if (study == 1 && course == 0 && spec == 0) //DIT 2nd yr BA , SD, SE
            {
                //Dit2.RemoveAt(4);
                //Dit2.RemoveAt(8);
                Dit2[4] = "BSM621";
                Dit2[9] = "BSM622";
            }else if (study == 1 && course == 0 && spec == 1)//SD
            {
                Dit2[4] = "IPR621";
                Dit2[9] = "IPR622";
            }
            else if (study == 1 && course == 0 && spec == 2)//SE
            {
                Dit2[4] = "NET621";
                Dit2[9] = "NET622";
            }
            //3rd year 
            if (study == 2 && course == 0 && spec == 0)//BA
            {
                Dit3[4] = "BAS631";
                Dit3[9] = "BAS632";
            }
            else if (study == 2 && course == 0 && spec == 1)//SD
            {
                Dit3[4] = "PRO631";
                Dit3[9] = "PRO632";
            }
            else if (study == 2 && course == 0 && spec == 2)//SE
            {
                Dit3[4] = "NET631";
                Dit3[9] = "NET632";
            }
            //
            //2ND YEAR
            else if (study == 1 && course == 1 && spec == 0) //bsc BA
            {
                Bsc2[4] = "BAS621";
                Bsc2[9] = "BAS622";
            }

            else if (study == 1 && course == 1 && spec == 1)
            {
                Bsc2[4] = "IPR621";
                Bsc2[9] = "IPR622";
            }
            else if (study == 1 && course == 1 && spec == 2)
            {
                Bsc2[4] = "CAT600";
                Bsc2[9] = "STN600";
            }
            //
            else if (study == 2 && course == 1 && spec == 0) //Ba
            {
                Bsc3[4] = "ISM731";
                Bsc3[9] = "ISM732";
            }
            else if (study == 2 && course == 1 && spec == 1)
            {
                Bsc3[4] = "PRO731";
                Bsc3[9] = "PRO732";
            }
            else if (study == 2 && course == 1 && spec == 2)
            {
                Bsc3[4] = "SEM700";
                Bsc3[9] = "SAM700";
            }
        }

    }
}
