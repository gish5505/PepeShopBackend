using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.DAL
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder
                .ToTable("OrderItems")
                .HasKey(p => new { p.Id });
            
            builder
                .Property(p => p.Id)
                .UseIdentityColumn()
           ;

            builder
                .HasOne(o => o.Product)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(o => o.ProductId);
                
        }
    }
}
