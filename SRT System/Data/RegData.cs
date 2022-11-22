using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRT_System.Data
{
    public class RegData
    {
        public List<string> citizenship;
        public List<string> modules;
        public List<string> specialization;
        public List<int> year;
        public List<string> course = new List<string>() { ""};

        public List<string> HCIT;
        public List<string> Dit;
        public List<string> Bsc;
        //public List<string> Dit = new List<string>() { "1","2","3","4","5","6","7","8","9","10"};
        //public List<string> Bsc = new List<string>() { "WBT511","IS511","MAT511","PRO511","NET511","WBT512","IS512","MAT512","PRO512","NET512"};
        
        List<string> Dit2 = new List<string>(10) { "", "", "", "", "", "", "", "" };
        List<string> Dit3 = new List<string>(10) { "", "", "", "", "", "", "", "" ,"",""};

        List<string> Bsc2 = new List<string>(10) { "", "", "", "", "", "", "", "" ,"",""};
        List<string> Bsc3 = new List<string>(10) { "", "", "", "", "", "", "", "","","" };


        public RegData() 
        {
            citizenship = new List<string>() { "South African","Other Natioanlity" };
            //course = new List<string>() { "DIT", "BSC" };
            //specialization = new List<string>(4) { "Business Analyst","Software Developer(Programming oriented)","Software Engineering" };
            year = new List<int>() { 1, 2, 3 };

            HCIT = new List<string>(10) {"ECM511","ITC500","IWT500","SSW500","n/a","BCM500","ECM512","IIT500","n/a","n/a" }; //FIRST 4 -> S1
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
                    course = new List<string>() { "HCIT", "DIT", "BSC" };
                    break;
                case 1:
                    course = new List<string>() { "DIT", "BSC" };
                    break;
                case 2:
                    course = new List<string>() { "DIT", "BSC" };
                    break;
            }

        }
        public void spLoader() 
        {
            specialization = new List<string>() { "Business Analyst", "Software Developer(Programming oriented)", "Software Engineering" };
        }

        public void moduleLoader(int study, int course, int spec)
        { 
        //logic pending
        if (study == 0 && course == 0 && spec == 0) //DIT 2nd yr SD
        {
            
        }
        }

    }
}
