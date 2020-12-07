using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.DAL
{
    public sealed class PepeShopContextDesignFactory : IDesignTimeDbContextFactory<PepeShopContext>
    {
        public PepeShopContext CreateDbContext(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environment}.json", true)
                .Build();

            var pepeOptions = configuration.GetSection(nameof(PepeShopOptions)).Get<PepeShopOptions>();

            var options = Options.Create(pepeOptions);

            return new PepeShopContext(options);
        }
    }
}
