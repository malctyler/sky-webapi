using Microsoft.AspNetCore.Identity;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Temporarily suppress the pending model changes warning
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
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
        public DbSet<ScheduledInspection> ScheduledInspections { get; set; }
        public DbSet<Ledger> Ledgers { get; set; }
        public DbSet<RevokedToken> RevokedTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Identity Roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR", ConcurrencyStamp = "00000000-0000-0000-0000-000000000001" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER", ConcurrencyStamp = "00000000-0000-0000-0000-000000000002" },
                new IdentityRole { Id = "3", Name = "Staff", NormalizedName = "STAFF", ConcurrencyStamp = "00000000-0000-0000-0000-000000000003" }
            );

            // Create admin user with hashed password (Password123!)
            var hasher = new PasswordHasher<ApplicationUser>();
            var adminUser = new ApplicationUser
            {
                Id = "1",
                UserName = "admin@skyapp.com",
                NormalizedUserName = "ADMIN@SKYAPP.COM",
                Email = "admin@skyapp.com",
                NormalizedEmail = "ADMIN@SKYAPP.COM",
                EmailConfirmed = true,
                SecurityStamp = "00000000-0000-0000-0000-000000000001",
                ConcurrencyStamp = "00000000-0000-0000-0000-000000000001"
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Password123!");

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            // Assign Admin and Staff Roles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "1", RoleId = "3" }
            );

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
            sky_webapi.Data.DatabaseSeeder.SeedData(modelBuilder);

            modelBuilder.Entity<ScheduledInspection>()
                .HasOne(si => si.PlantHolding)
                .WithMany()
                .HasForeignKey(si => si.HoldingID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ScheduledInspection>()
                .HasOne(si => si.Inspector)
                .WithMany()
                .HasForeignKey(si => si.InspectorID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Ledger entity
            modelBuilder.Entity<Ledger>()
                .Property(l => l.SubTotal)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Ledger>()
                .Property(l => l.VAT)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Ledger>()
                .Property(l => l.Total)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Ledger>()
                .Property(l => l.InvoiceRef)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Ledger>()
                .Property(l => l.CustomerName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Ledger>()
                .Property(l => l.ReferenceWithoutInitials)
                .HasComputedColumnSql("CAST(SUBSTRING(InvoiceRef, CHARINDEX('/', InvoiceRef), LEN(InvoiceRef) - CHARINDEX('/', InvoiceRef) + 1) AS nvarchar(100))", stored: true);

            modelBuilder.Entity<Ledger>()
                .HasIndex(l => l.ReferenceWithoutInitials)
                .IsUnique()
                .HasFilter(null);

            // Configure RevokedToken entity
            modelBuilder.Entity<RevokedToken>()
                .HasIndex(rt => rt.TokenId)
                .IsUnique();
                
            modelBuilder.Entity<RevokedToken>()
                .HasIndex(rt => rt.UserId);
                
            modelBuilder.Entity<RevokedToken>()
                .HasIndex(rt => rt.ExpiresAt);
        }
    }
}
