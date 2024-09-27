using Domain.Entity.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configers.Config
{
    public class Config_public_charConfiger : IEntityTypeConfiguration<Config_public_char>
    {
        public void Configure(EntityTypeBuilder<Config_public_char> builder)
        {
            builder.ToTable(nameof(Config_public_char));

            builder.HasKey(e => e.Pbc_id);
            builder.Property(e => e.Attribute_kind).HasColumnType("varchar()").HasMaxLength(60);
            builder.Property(e => e.Attribute_name).HasColumnType("varchar()").HasMaxLength(60);

            builder.HasData(new Config_public_char()
            {
                Pbc_id = 1,
                Attribute_kind = "国籍",
                Attribute_name = "中国",

            });
        }
    }
}
