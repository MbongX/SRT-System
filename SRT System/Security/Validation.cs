using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRT_System.Security
{
    internal class Validation
    {
        public static bool IsEmailValid(string e)
        { 
            var trimmedEmail = e.Trim();
            if (e.EndsWith("."))
                {
                return false;
                }
            try
            {
                var addr = new System.Net.Mail.MailAddress(e);
                return addr.Address == trimmedEmail;
            }
            catch {
                return false;
            }
        }
    }
}
