using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class DevContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectUsers> ProjectUsers { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<DailyWork> DailyWorks { get; set; }

        public DevContext(DbContextOptions<DevContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProjectUsers>(m =>
            {
                m.HasOne(pu => pu.User).WithMany(u => u.ProjectUsers).HasForeignKey(pu => pu.UserId);
                m.HasOne(pu => pu.Project).WithMany(u => u.ProjectUsers).HasForeignKey(pu => pu.ProjectId);
            });

            modelBuilder.Entity<DailyWork>(m =>
            {
                m.HasIndex(dw => dw.CreatedTime);
            });
            modelBuilder.Entity<Project>(m =>
            {
                m.HasIndex(p => p.Name);
            });
            modelBuilder.Entity<User>(m =>
            {
                m.HasIndex(u => u.Realname);
                m.HasIndex(u => u.Username);
            });
        }
    }
}
