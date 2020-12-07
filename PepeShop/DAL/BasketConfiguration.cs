using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.DAL
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder
                .ToTable("Basket")
                .HasKey(p => p.Id)
                ;

            builder
            .Property(p => p.Id)
            .UseIdentityColumn()
            ;
        }
    }
}
