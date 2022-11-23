using Microsoft.Data.SqlClient;

namespace SRT_System.Data 
{
    internal class DCon
    {
        public DCon() 
        {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "srts.database.windows.net";
                builder.UserID = "MbongXD";
                builder.Password = "Magwegwe203@";
                builder.InitialCatalog = "DevTestsRevamped";
                builder.Encrypt = true;
                builder.TrustServerCertificate = false;
                builder.HostNameInCertificate = "*.database.windows.net";
                builder.ConnectTimeout = 30;


            
            //Console.ReadLine();
        }

        public void PerformLogin(string u,string p)
        {
            
        }

        public void PerformRegistration()
        {
            
        }
        //crud methods
        

    }
}
