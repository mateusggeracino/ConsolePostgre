using System.Data;
using ConsolePostgre.domain;
using ConsolePostgre.repository.context;
using Dapper.Contrib.Extensions;
using Npgsql;

namespace ConsolePostgre.repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected IDbConnection Conn => new NpgsqlConnection("server=35.247.228.110;database=DeveloperDB05;user id=developers;password=dev123DEV123");
        public T Insert(T obj)
        {
            throw new System.NotImplementedException();
        }

        public T Update(T obj)
        {
            throw new System.NotImplementedException();
        }

        public T Delete(T obj)
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            return Conn.Get<T>(id);
        }
    }
}