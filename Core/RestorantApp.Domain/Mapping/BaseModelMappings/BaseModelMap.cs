using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestorantApp.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp.Domain.Mapping.BaseModelMappings
{
    public class BaseModelMap : IEntityTypeConfiguration<BaseModel>
    {
        public void Configure(EntityTypeBuilder<BaseModel> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.CreatedDate).IsRequired();
            builder.Property(b => b.UpdatedDate).IsRequired();
            
        }
    }
}
