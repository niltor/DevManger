using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Entity;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectUsers> ProjectUsers { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<DailyWork> DailyWorks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProjectUsers>(m =>
            {
                m.HasOne(pu => pu.User).WithMany(u => u.ProjectUsers);
                m.HasOne(pu => pu.Project).WithMany(u => u.ProjectUsers);
            });

            modelBuilder.Entity<DailyWork>(m =>
            {
                m.HasIndex(dw => dw.CreatedTime);
            });
            modelBuilder.Entity<Project>(m =>
            {
                m.HasIndex(p => p.Name);
            });
        }
    }
}
