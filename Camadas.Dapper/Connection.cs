using System.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Camadas.DapperSqlServer
{
    public class Connection<T> : IConnection<T>
        where T : class
    {
        public SqlConnection Connect { get; set; }
        private const string StrConn = "Server=.\\SqlExpress;Database=Db;User Id=sa;Password=senha;MultipleActiveResultSets=true;";
        public Connection()
        {                                   
            Connect = new SqlConnection(StrConn);                          
        }      
        public long Insert(T entity)            
        {               
            return Connect.Insert(entity);
        }  
        public bool Update(T entity)            
        {
            return Connect.Update(entity);
        }
        public bool Delete(T entity)            
        {
            return Connect.Delete(entity);
        }                  
        public T Find<TKey>(TKey id)            
        {
            return Connect.Get<T>(id);
        }                  
        public IList<T> All()            
        {
            return Connect.GetAll<T>()
                .AsList();
        }
    }
}
