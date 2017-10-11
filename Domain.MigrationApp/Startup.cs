using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Domain.MigrationApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("contextSettings.json");

            configuration = builder.Build();
        }
    }
}
