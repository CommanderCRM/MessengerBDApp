using System;
using System.Data.SqlClient;
using System.Security;
using LoginLibrary.SecurityClasses.SecurityClasses;
using LoginLibrary.SupportClasses.SupportClasses;

namespace LoginLibrary.DataClasses
{
    namespace DataClasses
    {

        public class DatabaseUser
        {
            private string serverName;
            private string catalogName;
            public DatabaseUser(string pServerName, string pCatalogName)
            {
                serverName = @"CRM\SQLEXPRESS";
                catalogName = "Messenger";
            }

            public SqlServerLoginResult SqlCredentialLogin(byte[] pNameBytes, byte[] pPasswordBytes)
            {
                var loginResult = new SqlServerLoginResult();
                var secureOperations = new Encryption();

                var userName = secureOperations.Decrypt(pNameBytes, "111");
                var userPassword = secureOperations.Decrypt(pPasswordBytes, "111");

                string connectionString = $"Data Source={serverName};" +
                                          $"Initial Catalog={catalogName};";


                var securePassword = new SecureString();

                foreach (var character in userPassword)
                {
                    securePassword.AppendChar(character);
                }

                securePassword.MakeReadOnly();

                var credentials = new SqlCredential(userName, securePassword);

                using (var cn = new SqlConnection { ConnectionString = connectionString })
                {
                    try
                    {
                        cn.Credential = credentials;
                        cn.Open();
                        loginResult.Success = true;
                    }

                    catch (SqlException failedLoginException) when (failedLoginException.Number == 18456)
                    {
                        loginResult.Success = false;
                        loginResult.GenericException = false;
                        loginResult.Message = "Не удалось получить доступ к данным.";
                    }
                    catch (SqlException genericSqlException)
                    {
                        loginResult.Success = false;
                        loginResult.GenericException = false;
                        loginResult.Message = "Не удалось получить доступ к данным.";
                    }
                    catch (Exception ex)
                    {
                        loginResult.Success = false;
                        loginResult.GenericException = true;
                        loginResult.Message = ex.Message;
                    }

                }

                return loginResult;

            }
        }
    }
}