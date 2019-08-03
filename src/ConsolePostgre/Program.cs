using System;
using ConsolePostgre.domain;
using ConsolePostgre.repository;

namespace ConsolePostgre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var teste = new Repository<Client>();

            var mateus = teste.GetById(1);
        }
    }
}
