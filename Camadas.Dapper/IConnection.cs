using System.Collections.Generic;

namespace Camadas.DapperSqlServer
{
    public interface IConnection<T>
    {
        IList<T> All();
        bool Delete(T entity);
        T Find<TKey>(TKey id);
        long Insert(T entity);
        bool Update(T entity);
    }
}