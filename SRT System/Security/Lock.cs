using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRT_System.Security
{
    class Locker
    {
        public static string HashIt(string hvalue)
        {
            
            string hashed = string.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(hvalue));

                foreach (byte x in hashValue) {
                    hashed += $"{x:X2}";
                }
            }
            return hashed;
        }
    }
}
