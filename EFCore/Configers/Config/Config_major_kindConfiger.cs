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
    public class Config_major_kindConfiger : IEntityTypeConfiguration<Config_major_kind>
    {
        public void Configure(EntityTypeBuilder<Config_major_kind> builder)
        {
            builder.ToTable(nameof(Config_major_kind));

            builder.HasKey(e => e.Mfk_id);
            builder.Property(e => e.Major_kind_id).HasColumnType("char()").IsRequired(false).HasMaxLength(2);
            builder.Property(e => e.Major_kind_name).HasColumnType("varchar()").IsRequired(false).HasMaxLength(60);

            builder.HasData(new Config_major_kind()
            {
                Mfk_id = 1,
                Major_kind_id = "01",
                Major_kind_name = "销售",

            });
        }
    }
}
