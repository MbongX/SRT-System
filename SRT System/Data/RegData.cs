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
        
        List<string> d2 = new List<string>() { "", "", "", "", "", "", "", "" };
        List<string> d3 = new List<string>() { "", "", "", "", "", "", "", "" };

        List<string> b2 = new List<string>() { "", "", "", "", "", "", "", "" };
        List<string> b3 = new List<string>() { "", "", "", "", "", "", "", "" };


        public RegData() 
        {
            citizenship = new List<string>() { "South African","Other Natioanlity" };
            //course = new List<string>() { "DIT", "BSC" };
            //specialization = new List<string>(4) { "Business Analyst","Software Developer(Programming oriented)","Software Engineering" };
            year = new List<int>() { 1, 2, 3 };

            HCIT = new List<string>() {"ECM511","ITC500","IWT500","SSW500","BCM500","ECM512","IIT500" }; //FIRST 4 -> S1
            Dit = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            Bsc = new List<string>() { "WBT511", "IS511", "MAT511", "PRO511", "NET511", "WBT512", "IS512", "MAT512", "PRO512", "NET512" };

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
        }

    }
}
