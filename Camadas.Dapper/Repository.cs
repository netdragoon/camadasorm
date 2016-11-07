using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace Camadas.DapperSqlServer
{
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        protected IDbConnection _connection;
        public string TableName { get; private set; }
        public Repository(IDbConnection connection)
        {
            _connection = connection;
            DescribeTableName();
        }

        private void DescribeTableName()
        {                           
            T _model = Activator.CreateInstance<T>();

            TableAttribute tableAttribute = (TableAttribute)_model
                .GetType()
                .GetCustomAttributes(true)
                .Where(c => c.GetType() == typeof(TableAttribute))
                .FirstOrDefault();

            TableName = tableAttribute == null
                ? _model.GetType().Name
                : tableAttribute.Name;
              
            _model = null;
            tableAttribute = null;
        }

        public long Insert(T entity)
        {
            return _connection.Insert(entity);
        }
        public bool Update(T entity)
        {
            return _connection.Update(entity);
        }
        public bool Delete(T entity)
        {
            return _connection.Delete(entity);
        }
        public T Find<TKey>(TKey id)
        {
            return _connection.Get<T>(id);
        }
        public IList<T> All()
        {
            return _connection.GetAll<T>()
                .AsList();
        }    
        public void Dispose()
        {
            if (_connection != null)
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
                _connection.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public bool Delete<TKey>(TKey id, string primaryKeyName = "Id")
        {
            string sql = $"DELETE FROM {TableName} WHERE {primaryKeyName}=@Id";
            return (_connection.Execute(sql, new { Id = id }) > 0);
        }
    }
}
