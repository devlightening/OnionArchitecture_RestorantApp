using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestorantApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp.Domain.Mapping
{
    public class MenuItemMap : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasKey(mi => mi.Id);
            builder.Property(mi => mi.Name).IsRequired().HasMaxLength(100);
            builder.Property(mi => mi.Description).HasMaxLength(500);
            builder.Property(mi => mi.Price).IsRequired();     

        }
    }
}
