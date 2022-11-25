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
        public const String DATABASE_NAME = "Student Review And Tutoring System";
        public const bool ENCRYPT_STATUS = true;
        public const bool TRUST_SERVER_CERTIFICATE = false;
        public const String H_NAME_CERTIFICATE = "*.database.windows.net";
        public const Int32 CON_TIMEOUT = 30;

        public const String CON_STRING_REG = "Server=tcp:srts.database.windows.net,1433;Initial Catalog=Student Review And Tutoring System;Persist Security Info=False;User ID=MbongXD;Password=Magwegwe203@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    }
}
