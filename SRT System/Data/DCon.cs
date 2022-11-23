using System.Reflection.Metadata;
using Microsoft.Data.SqlClient;

namespace SRT_System.Data 
{
    internal class DCon
    {
        public DCon() 
        { //Console.ReadLine();
        }
        

        public void PerformLogin(string u,string p)
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
        }

        public void PerformRegistration()
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
        }
        //crud methods
        

    }
}
