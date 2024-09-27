using Domain.Entity.Human_Resources_File;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configers.Engage
{
    public class Engage_major_releaseConfiger : IEntityTypeConfiguration<Engage_major_release>
    {
        public void Configure(EntityTypeBuilder<Engage_major_release> builder)
        {
            builder.ToTable(nameof(Engage_major_release));

            builder.HasKey(e => e.Mre_id);
            builder.Property(e => e.First_kind_id).HasMaxLength(2);
            builder.Property(e => e.First_kind_name).HasMaxLength(60);
            builder.Property(e => e.Second_kind_id).HasMaxLength(2);
            builder.Property(e => e.Second_kind_name).HasMaxLength(60);
            builder.Property(e => e.Third_kind_id).HasMaxLength(2);
            builder.Property(e => e.Third_kind_name).HasMaxLength(60);
            builder.Property(e => e.Major_kind_id).HasMaxLength(2);
            builder.Property(e => e.Major_kind_name).HasMaxLength(60);
            builder.Property(e => e.Major_id).HasMaxLength(2);
            builder.Property(e => e.Major_name).HasMaxLength(60);

            builder.Property(e => e.Engage_type).HasMaxLength(60);
            builder.Property(e => e.Register).HasMaxLength(60);
            builder.Property(e => e.Changer).HasMaxLength(60);
  
            builder.Property(e => e.deadline).IsRequired(false);
            builder.Property(e => e.RegistTime).IsRequired(false); 
            builder.Property(e => e.ChangeTime).IsRequired(false);
        }
    }
}
