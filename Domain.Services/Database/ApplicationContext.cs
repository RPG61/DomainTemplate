using Domain.Models.POCOs;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Database
{
    /// <summary>
    /// Production ApplicationContext
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Enables passing options from ConfigureSevices in Startup class
        /// </summary>
        /// <param name="options"></param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> User { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=DomainTemplate;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}

