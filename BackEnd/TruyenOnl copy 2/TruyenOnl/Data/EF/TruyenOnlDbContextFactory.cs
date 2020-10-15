using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TruyenOnl.Data.EF
{
    public class TruyenOnlDbContextFactory : IDesignTimeDbContextFactory<TruyenOnlDbContext>
    {
        public TruyenOnlDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("TruyenOnlDbContext");


            var optionsBuilder = new DbContextOptionsBuilder<TruyenOnlDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TruyenOnlDbContext(optionsBuilder.Options);
        }
    }
}
