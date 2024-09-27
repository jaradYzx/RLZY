using Domain.Entity.Config;
using Domain.Entity.Engage;
using Domain.Entity.Human_Resources_File;
using Domain.Entity.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = @"Data Source=.;Initial Catalog=HR;Integrated Security=True;Encrypt=False";
            optionsBuilder.UseSqlServer(connStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Config_file_first_kind> config_file_first_kind { get; set; }
        public DbSet<Config_file_second_kind> config_file_second_kind { get; set; }
        public DbSet<Config_file_third_kind> config_file_third_kind { get; set; }
        public DbSet<Config_public_char> config_public_char { get; set; }   
        public DbSet<Config_primary_key> config_primary_key { get; set; }
        public DbSet<Config_major_kind> config_major_kind { get; set; }
        public DbSet<Config_major> config_major { get; set; }
        public DbSet<Engage_interview> engage_Interviews { get; set; }
        public DbSet<Engage_major_release> engage_Major_Releases { get; set; }
        public DbSet<Engage_resume> engage_Resumes { get; set; }
    }
}
