using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.DAL
{
    public class PepeShopContext : DbContext
    {
        private readonly PepeShopOptions _pepeOptions;

        public DbSet<Product> Products { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public PepeShopContext(IOptions<PepeShopOptions> options)
        {
            _pepeOptions = options?.Value ?? throw new ArgumentNullException(nameof(options));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_pepeOptions.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new ProductConfiguration())
                .ApplyConfiguration(new UserConfiguration())
                ;
            
        }
    }
}
