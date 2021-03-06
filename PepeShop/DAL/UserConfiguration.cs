﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.DAL
{
    public class UserConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder
                .ToTable("Users")
                .HasKey(p => p.Id)
                ;

            builder
            .Property(p => p.Id)
            .UseIdentityColumn()
            ;

            builder
                .HasMany(u => u.Basket)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId)
                ;

            builder
                .HasMany(u => u.Orders)
                ;

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
