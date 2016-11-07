using System;
using System.Data.SqlClient;
namespace Camadas.DapperSqlServer
{
    public class Connection        
    {
        private static SqlConnection instance;
        private static object syncRoot = new object();
        private static string StrConn = "Server=.\\SqlExpress;Database=Db;User Id=sa;Password=senha;MultipleActiveResultSets=true;";
        public static SqlConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SqlConnection(StrConn);
                        }
                    }
                }
                return instance;
            }
        }                                                 
    }
}
