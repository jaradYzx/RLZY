using Domain.Entity.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configers.User
{
    public class UserConfiger : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable(nameof(Users));

            builder.HasKey(e => e.UId);
            builder.Property(e => e.UName).HasColumnType("varchar()").IsRequired().HasMaxLength(60);
            builder.Property(e => e.UTrueName).HasColumnType("varchar()").IsRequired().HasMaxLength(60);
            builder.Property(e => e.UPassWord).HasColumnType("varchar()").IsRequired().HasMaxLength(60);
        }
    }
}
