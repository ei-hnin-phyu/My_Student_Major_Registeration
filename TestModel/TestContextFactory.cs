using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public abstract class DesignTimeDbContextFactoryBase<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : DbContext
    {
        public TContext CreateDbContext(string[] args)
        {
            var environmentName =
               Environment.GetEnvironmentVariable(
                   "ASPNETCORE_ENVIRONMENT");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .Build();
            var connStr = configuration.GetConnectionString("default");
            var optionsBuilder = new DbContextOptionsBuilder<TContext>().UseSqlServer(connStr);
            return CreateNewInstance(optionsBuilder.Options);
        }

        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);
    }
    public class QSSContextFactory : DesignTimeDbContextFactoryBase<QSSDBContext>
    {
        protected override QSSDBContext CreateNewInstance(DbContextOptions<QSSDBContext> options)
        {
            return new QSSDBContext(options);
        }
    }
}
