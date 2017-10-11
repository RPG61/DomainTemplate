using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore;

namespace Domain.MigrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Seeder();
        }

        static void Seeder()
        {
            SeedData.SeedMovies();
            SeedData.SeedUsers();
        }
    }
}
