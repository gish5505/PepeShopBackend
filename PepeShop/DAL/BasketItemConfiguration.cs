using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.DAL
{
    public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
    {
        public void Configure(EntityTypeBuilder<BasketItem> builder)
        {
            builder
                .ToTable("BasketItem")
                .HasKey(p => new { p.BasketId, p.ProductId })
                ;

            //builder
            //.Property(p => p.Id)
            //.UseIdentityColumn()
            //;

            builder
                .HasOne(p => p.Basket)
                .WithMany(p => p.Items)
                .HasForeignKey(p => p.BasketId)                
            ;

            builder
                .HasOne(p => p.Product)
                .WithMany(p => p.BasketItems)
                .HasForeignKey(p => p.ProductId)
            ;
        }
    }
}
