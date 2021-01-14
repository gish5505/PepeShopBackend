using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.DAL
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .ToTable("Orders")
                .HasKey(p => new { p.OrderId });

            builder
                .HasMany(o => o.OrderItems)
                .WithOne(b => b.Order)
                .HasForeignKey(b => b.OrderId)
                ;
        }
    }
}
