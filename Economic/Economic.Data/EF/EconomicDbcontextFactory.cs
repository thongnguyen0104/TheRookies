using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Economic.Data.EF
{
    public class EconomicDbcontextFactory : IDesignTimeDbContextFactory<EconomicDbContext>
    {
        public EconomicDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("EconomicDb");

            var optionsBuilder = new DbContextOptionsBuilder<EconomicDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EconomicDbContext(optionsBuilder.Options);
        }
    }
}
