﻿using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;

namespace Camadas.DapperSqlServer
{
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        protected IDbConnection _connection;
        public Repository(IDbConnection connection)
        {
            _connection = connection;
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
    }
}
