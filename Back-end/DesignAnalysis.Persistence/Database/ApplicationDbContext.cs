using DesignAnalysis.Core.Entities;
using DesignAnalysis.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) :
            base(dbContextOptions)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<EngineerDetail> EngineerDetails { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<BuildingFacility> BuildingFacilities { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Occupant> Occupants { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePage> RolePages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ProjectStage> ProjectStages { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseMsSqlConvention();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }

   
}
