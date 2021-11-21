using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DataAccess;

namespace Songs
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(20));

            return new ApplicationContext(dbOptionsBuilder.Options);
        }
    }
}
