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
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Phone).IsRequired().HasMaxLength(15);
            builder.Property(e => e.Address).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Position).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Salary).IsRequired();
            builder.Property(e => e.HireDate).IsRequired();

        }
    }
}
