using Domain.Entity.Engage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configers.Engage
{
    public class Engage_interviewConfiger : IEntityTypeConfiguration<Engage_interview>
    {
        public void Configure(EntityTypeBuilder<Engage_interview> builder)
        {
            builder.ToTable(nameof(Engage_interview));

            builder.HasKey(e => e.Ein_id);

            builder.Property(e => e.Human_name).HasMaxLength(60);
            builder.Property(e => e.Human_major_kind_id).HasMaxLength(2);
            builder.Property(e => e.Human_major_kind_name).HasMaxLength(30);
            builder.Property(e => e.Human_major_id).HasMaxLength(2);
            builder.Property(e => e.Human_major_name).HasMaxLength(30);
            builder.Property(e => e.Image_degree).HasMaxLength(20);
            builder.Property(e => e.Native_language_degree).HasMaxLength(20);
            builder.Property(e => e.Foreign_language_degree).HasMaxLength(20);
            builder.Property(e => e.Response_speed_degree).HasMaxLength(20);
            builder.Property(e => e.EQ_degree).HasMaxLength(20);
            builder.Property(e => e.IQ_degree).HasMaxLength(20);
            builder.Property(e => e.Multi_quality_degree).HasMaxLength(20);
            builder.Property(e => e.Register).HasMaxLength(60);
            builder.Property(e => e.Checker).HasMaxLength(60);
            builder.Property(e => e.Result).HasMaxLength(60);
        }
    }
}
