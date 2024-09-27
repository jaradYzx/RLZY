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
    public class Config_primary_keyConfiger : IEntityTypeConfiguration<Config_primary_key>
    {
        public void Configure(EntityTypeBuilder<Config_primary_key> builder)
        {
            builder.ToTable(nameof(Config_primary_key));

            builder.HasKey(e => e.Prk_id);
            builder.Property(e => e.Primary_key_table).HasColumnType("varchar()").IsRequired(false).HasMaxLength(60);
            builder.Property(e => e.Primary_key).HasColumnType("varchar()").IsRequired(false).HasMaxLength(60);
            builder.Property(e => e.Key_name).HasColumnType("varchar()").IsRequired(false).HasMaxLength(60);
            builder.Property(e => e.Primary_key_status).HasMaxLength(1);

            builder.HasData(new Config_primary_key()
            {
                Prk_id = 1,
                Primary_key_table = "HumanFile",
                Primary_key = "firstKindName",
                Key_name = "I级机构名称",
                Primary_key_status = 1,

            });
        }
    }
}
