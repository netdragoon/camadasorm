using System.Collections.Generic;

namespace Camadas.DapperSqlServer
{
    public interface IRepository<T> : System.IDisposable
        where T: class
    {
        IList<T> All();
        bool Delete(T entity);
        T Find<TKey>(TKey id);
        long Insert(T entity);
        bool Update(T entity);
    }
}
