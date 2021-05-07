using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using LoginLibrary.SecurityClasses.SecurityClasses;
using SupportLibrary;

namespace LoginLibrary.DataClasses
{
    namespace DataClasses
    {

        public class DataOperations : BaseExceptionProperties
        {
            public string ConnectionString;

            public DataOperations(byte[] pNameBytes, byte[] pPasswordBytes, string pServerName, string pCatalogName)
            {

                var secureOperations = new Encryption();

                ConnectionString =
                    $"Data Source={pServerName};Initial Catalog={pCatalogName};" +
                    $"User Id={secureOperations.Decrypt(pNameBytes, "111")};" +
                    $"Password={secureOperations.Decrypt(pPasswordBytes, "111")};" +
                    "Integrated Security=False";

                Console.WriteLine();
            }
        }
    }
}