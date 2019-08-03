using System.IO;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace ConsolePostgre.repository.context
{
    public static class Connection
    {
        public static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return config.GetConnectionString("DefaultConnection");
        }
    }
}