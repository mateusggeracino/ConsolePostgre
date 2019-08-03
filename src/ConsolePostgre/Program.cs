using System;
using ConsolePostgre.domain;
using ConsolePostgre.repository;
using GenFu;

namespace ConsolePostgre
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository<Client>();
            var client = A.New<Client>();

            var insert = repository.Insert(client);
            var update = repository.Update(client);
            var getById = repository.GetById(client.Id);
            var delete = repository.Delete(client);

            Console.ReadKey();
        }
    }
}
