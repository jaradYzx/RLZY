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
    public class Config_file_first_kindConfiger : IEntityTypeConfiguration<Config_file_first_kind>
    {
        public void Configure(EntityTypeBuilder<Config_file_first_kind> builder)
        {
            builder.ToTable(nameof(Config_file_first_kind));

            builder.HasKey(e => e.Ffk_id);
            builder.Property(e => e.First_kind_id).HasColumnType("char()").HasMaxLength(2);
            builder.Property(e => e.First_kind_name).HasColumnType("varchar()").HasMaxLength(60);
            builder.Property(e => e.First_kind_salary_id).HasColumnType("text");
            builder.Property(e => e.First_kind_sale_id).HasColumnType("text");

            builder.HasData(new Config_file_first_kind()
            {

                Ffk_id = 1,
                First_kind_id = "01",
                First_kind_name = "集团",
                First_kind_sale_id = "1",
                First_kind_salary_id = "1",
            });
        }
    }
}
