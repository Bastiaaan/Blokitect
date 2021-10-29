using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blokitect.Data.Models;

namespace Blokitect.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerSupplier>().HasKey(sc => new { sc.CustomerId, sc.SupplierId });
            builder.Entity<ProjectSupplier>().HasKey(sc => new { sc.ProjectId, sc.SupplierId });//.OnDelete(DeleteBehavior.Restrict);
            builder.Entity<ProjectSector>().HasKey(ps => new { ps.ProjectId, ps.SectorId });
            builder.Entity<CustomerSector>().HasKey(cs => new { cs.CustomerId, cs.SectorId });
            
            // NOTE: By applying ef-core commands, you have to insert EntityFrameworkCore\<CommandName> to make it work
            // Configuring M2M-relationships in the database
            
            builder.Entity<ProjectSupplier>()
                .HasOne(i => i.Supplier)
                .WithMany(i => i.ProjectSuppliers)
                .HasForeignKey(i => i.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProjectSupplier>()
                .HasOne(i => i.Project)
                .WithMany(i => i.ProjectSuppliers)
                .HasForeignKey(i => i.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CustomerSupplier>()
                .HasOne(i => i.Customer)
                .WithMany(i => i.CustomerSuppliers)
                .HasForeignKey(i => i.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CustomerSupplier>()
                .HasOne(i => i.Supplier)
                .WithMany(i => i.CustomerSuppliers)
                .HasForeignKey(i => i.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.Entity<ProjectSector>()
                .HasOne(i => i.Project)
                .WithMany(i => i.ProjectSectors)
                .HasForeignKey(i => i.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProjectSector>()
                .HasOne(i => i.Sector)
                .WithMany(i => i.ProjectSectors)
                .HasForeignKey(i => i.SectorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CustomerSector>()
                .HasOne(i => i.Customer)
                .WithMany(i => i.CustomerSectors)
                .HasForeignKey(i => i.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CustomerSector>()
                .HasOne(i => i.Sector)
                .WithMany(i => i.CustomerSectors)
                .HasForeignKey(i => i.SectorId)
                .OnDelete(DeleteBehavior.Cascade);

            // End of session
            // Configuring O2M-relationships in the database

            builder.Entity<Supplier>()
                .HasMany<Review>()
                .WithOne(i => i.Supplier)
                .HasForeignKey(i => i.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Customer>()
                .HasMany<Review>()
                .WithOne(i => i.Customer)
                .HasForeignKey(i => i.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Review>()
                .HasOne(i => i.Supplier)
                .WithMany(i => i.Reviews)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<Customer>()
                .HasMany(i => i.Projects)
                .WithOne(i => i.Customer)
                .HasForeignKey(i => i.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            // End of session

            // Configuration of O2O relationships in the Database

            builder.Entity<ContactPerson>()
                .HasOne(i => i.Project)
                .WithMany(i => i.ContactPeople)
                .HasForeignKey(i => i.ProjectId);

            // End of session

            base.OnModelCreating(builder);
        }

        public DbSet<Component> Components { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerSupplier> CustomerSuppliers { get; set; }

        public DbSet<ProjectSupplier> ProjectSuppliers { get; set; }

        public DbSet<Function> Functions { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Sector> Sectors { get; set; }

        public DbSet<ProjectSector> ProjectSectors { get; set; }

        public DbSet<CustomerSector> CustomerSectors { get; set; }

        public DbSet<Private> Privates { get; set; }

        public DbSet<ContactPerson> ContactPeople { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}
