using System;
using System.CodeDom;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRT_System.Data
{
    internal class Constants
    {
        public const String SOURCE = "srts.database.windows.net";
        public const String ID = "MbongXD";
        public const String KEYS = "Magwegwe203@";
        public const String DATABASE_NAME = "DevTestsRevamped";
        public const bool ENCRYPT_STATUS = true;
        public const bool TRUST_SERVER_CERTIFICATE = false;
        public const String H_NAME_CERTIFICATE = "*.database.windows.net";
        public const Int32 CON_TIMEOUT = 30;

    }
}
