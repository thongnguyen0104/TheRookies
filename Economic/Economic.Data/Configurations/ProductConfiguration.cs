﻿using Economic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(10, 2)");
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(0);
        }
    }
}
