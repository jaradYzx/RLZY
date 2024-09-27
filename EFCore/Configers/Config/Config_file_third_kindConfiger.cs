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
    public class Config_file_third_kindConfiger : IEntityTypeConfiguration<Config_file_third_kind>
    {

        public void Configure(EntityTypeBuilder<Config_file_third_kind> builder)
        {
            builder.ToTable(nameof(Config_file_third_kind));

            builder.HasKey(e => e.Ftk_id);
            builder.Property(e => e.First_kind_id).HasColumnType("char()").HasMaxLength(2);
            builder.Property(e => e.First_kind_name).HasColumnType("varchar()").HasMaxLength(60);
            builder.Property(e => e.Second_kind_id).HasColumnType("char()").HasMaxLength(2);
            builder.Property(e => e.Second_kind_name).HasColumnType("varchar()").HasMaxLength(60);
            builder.Property(e => e.Third_kind_id).HasColumnType("char()").HasMaxLength(2);
            builder.Property(e => e.Third_kind_name).HasColumnType("varchar()").HasMaxLength(60);
            builder.Property(e => e.Third_kind_sale_id).HasColumnType("text");
            builder.Property(e => e.Third_kind_is_retail).HasColumnType("char()").HasMaxLength(2);

            builder.HasData(new Config_file_third_kind()
            {
                Ftk_id = 1,
                First_kind_id = "01",
                First_kind_name = "集团",
                Second_kind_id = "01",
                Second_kind_name = "软件公司",
                Third_kind_id = "02",
                Third_kind_name = "外包组",
                Third_kind_sale_id = "1",
                Third_kind_is_retail = "否"

            });
        }
    }
}
