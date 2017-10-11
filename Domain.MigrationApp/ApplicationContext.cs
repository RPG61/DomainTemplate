using Domain.Models.POCOs;
using Microsoft.EntityFrameworkCore;

namespace Domain.MigrationApp
{
    /// <summary>
    /// Development ApplicationContext
    /// </summary>
    public class ApplicationContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DomainTemplate;Trusted_Connection=True;");
    }
}

