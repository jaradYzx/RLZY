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
    public class Engage_resumeConfiger : IEntityTypeConfiguration<Engage_resume>
    {
        public void Configure(EntityTypeBuilder<Engage_resume> builder)
        {
            builder.ToTable(nameof(Engage_resume));

            builder.HasKey(e => e.Res_id);

            builder.Property(e => e.Human_name).HasMaxLength(60);
            builder.Property(e => e.Engage_type).HasMaxLength(30);
            builder.Property(e => e.Human_address).HasMaxLength(200);
            builder.Property(e => e.Human_postcode).HasMaxLength(10);
            builder.Property(e => e.Human_major_kind_id).HasMaxLength(2);
            builder.Property(e => e.Human_major_kind_name).HasMaxLength(60);
            builder.Property(e => e.Human_major_id).HasMaxLength(2);
            builder.Property(e => e.Human_major_name).HasMaxLength(60);
            builder.Property(e => e.Human_telephone).HasMaxLength(60);
            builder.Property(e => e.Human_homephone).HasMaxLength(60);
            builder.Property(e => e.Human_mobilephone).HasMaxLength(60);
            builder.Property(e => e.Human_email).HasMaxLength(60);
            builder.Property(e => e.Human_hobby).HasMaxLength(200);
            builder.Property(e => e.Human_specility).HasMaxLength(200);
            builder.Property(e => e.Human_sex).HasMaxLength(2);
            builder.Property(e => e.Human_religion).HasMaxLength(60);
            builder.Property(e => e.Human_party).HasMaxLength(60);
            builder.Property(e => e.Human_nationality).HasMaxLength(60);
            builder.Property(e => e.Human_race).HasMaxLength(60);
            builder.Property(e => e.Human_educated_degree).HasMaxLength(60);
            builder.Property(e => e.Human_educated_major).HasMaxLength(60);
            builder.Property(e => e.Human_college).HasMaxLength(60);
            builder.Property(e => e.Human_idcard).HasMaxLength(60);
            builder.Property(e => e.Human_birthplace).HasMaxLength(200);

            builder.Property(e => e.Demand_salary_standard).HasColumnType("numeric(15,2)");

            builder.Property(e => e.Human_picture).HasMaxLength(60);
            builder.Property(e => e.Attachment_name).HasMaxLength(60);
            builder.Property(e => e.Register).HasMaxLength(60);
            builder.Property(e => e.Checker).HasMaxLength(60);
            builder.Property(e => e.Test_checker).HasMaxLength(60);
            builder.Property(e => e.Pass_register).HasMaxLength(60);
            builder.Property(e => e.Pass_checker).HasMaxLength(60);
            builder.Property(e => e.Pass_checkComment).HasMaxLength(60);
            builder.Property(e => e.Pass_passComment).HasMaxLength(60);
        }
    }
}
