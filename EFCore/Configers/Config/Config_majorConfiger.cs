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
    internal class Config_majorConfiger : IEntityTypeConfiguration<Config_major>
    {
        public void Configure(EntityTypeBuilder<Config_major> builder)
        {
            builder.ToTable(nameof(Config_major));

            builder.HasKey(e => e.Mak_id);
            builder.Property(e => e.Major_kind_id).HasColumnType("char()").IsRequired(false).HasMaxLength(2);
            builder.Property(e => e.Major_kind_name).HasColumnType("varchar()").IsRequired(false).HasMaxLength(60);
            builder.Property(e => e.Major_id).HasColumnType("char()").IsRequired(false).HasMaxLength(2);
            builder.Property(e => e.Major_name).HasColumnType("varchar()").IsRequired(false).HasMaxLength(60);
            builder.Property(e => e.Test_amount).HasMaxLength(4);

            builder.HasData(new Config_major()
            {

                Mak_id = 1,
                Major_kind_id = "01",
                Major_kind_name = "销售",
                Major_id = "01",
                Major_name = "人事经理",
                Test_amount = 0,

            });
        }
    }
}
