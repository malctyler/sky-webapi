using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sky_webapi.Data.Entities;

namespace sky_webapi.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Summary> Summaries { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<NoteEntity> Notes { get; set; }
        public DbSet<PlantCategoryEntity> PlantCategories { get; set; }
        public DbSet<AllPlantEntity> Allplant { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<PlantHolding> PlantHoldings { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectorEntity> Inspectors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure entity relationships
            modelBuilder.Entity<AllPlantEntity>()
                .HasIndex(p => p.PlantDescription)
                .IsUnique();

            modelBuilder.Entity<AllPlantEntity>()
                .HasOne(p => p.Category)
                .WithMany(c => c.plant)
                .HasForeignKey(p => p.PlantCategory)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlantHolding>()
                .HasOne(p => p.Customer)
                .WithMany()
                .HasForeignKey(p => p.CustID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlantHolding>()
                .HasOne(p => p.Plant)
                .WithMany()
                .HasForeignKey(p => p.PlantNameID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlantHolding>()
                .HasOne(p => p.Status)
                .WithMany(s => s.PlantHoldings)
                .HasForeignKey(p => p.StatusID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Inspection>()
                .HasOne(i => i.PlantHolding)
                .WithMany()
                .HasForeignKey(i => i.HoldingID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Inspection>()
                .HasOne(i => i.Inspector)
                .WithMany(inspector => inspector.Inspections)
                .HasForeignKey(i => i.InspectorID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NoteEntity>()
                .HasOne(n => n.Customer)
                .WithMany(c => c.Notes)
                .HasForeignKey(n => n.CustID)
                .OnDelete(DeleteBehavior.Cascade);

            // Call the DatabaseSeeder to seed all data
            DatabaseSeeder.SeedData(modelBuilder);

            modelBuilder.Entity<AllPlantEntity>()
                .HasOne(p => p.Category)
                .WithMany(c => c.plant)
                .HasForeignKey(p => p.PlantCategory)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlantHolding>()
                .HasOne(p => p.Customer)
                .WithMany()
                .HasForeignKey(p => p.CustID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlantHolding>()
                .HasOne(p => p.Plant)
                .WithMany()
                .HasForeignKey(p => p.PlantNameID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlantHolding>()
                .HasOne(p => p.Status)
                .WithMany(s => s.PlantHoldings)
                .HasForeignKey(p => p.StatusID)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure Inspection relationship
            modelBuilder.Entity<Inspection>()
                .HasOne(i => i.PlantHolding)
                .WithMany()
                .HasForeignKey(i => i.HoldingID)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure Inspection relationship with InspectedByEntity
            modelBuilder.Entity<Inspection>()
                .HasOne(i => i.Inspector)
                .WithMany(inspector => inspector.Inspections)
                .HasForeignKey(i => i.InspectorID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure cascade delete for Notes when Customer is deleted
            modelBuilder.Entity<NoteEntity>()
                .HasOne(n => n.Customer)
                .WithMany(c => c.Notes)
                .HasForeignKey(n => n.CustID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
