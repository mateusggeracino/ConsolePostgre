using ConsolePostgre.domain;

namespace ConsolePostgre.repository
{
    public interface IRepository<T> where T : Entity
    {
        T Insert(T obj);
        T Update(T obj);
        T Delete(T obj);
        T GetById(int id);
    }
}