using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TonyApp.Models;

namespace TonyApp.Data
{
    /// <summary>
    /// Main database context for the application.
    /// Inherits from DbContext to provide database operations.
    /// </summary>
    public class MyAppDbContext : DbContext
    {
        /// <summary>
        /// Constructor that accepts DbContextOptions for configuration.
        /// </summary>
        /// <param name="options">Configuration options for the database context.</param>
        public MyAppDbContext (DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }
        /// <summary>
        /// Represents the Product table in the database.
        /// Provides methods for querying and saving Product entities.
        /// </summary>
        public DbSet<Product> Product => Set<Product>();
        /// <summary>
        /// Configures the database model and entity relationships.
        /// Called during context initialization.
        /// </summary>
        /// <param name="modelBuilder">Used to configure the model.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Product entity properties and constraints
            modelBuilder.Entity<Product>(entity =>
            {
                // Define primary key
                entity.HasKey(e => e.Id);

                // Configure Name property
                entity.Property(e => e.Name)
                    .IsRequired()           // Cannot be null
                    .HasMaxLength(100);      // Maximum 100 characters
                // Configure Description property
                entity.Property(e => e.Description)
                    .HasMaxLength(500);       // Maximum 500 characters
                // Configure Category property
                entity.Property(e => e.Category)
                    .HasMaxLength(50);        // Maximum 50 characters
                // Configure Price property with specific decimal type
                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18,2)"); // 18 digits total, 2 after decimal point
                // Configure CreatedDate with default value
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("GETUTCDATE()"); // Default to current UTC time
                // Configure IsActive with default value
                entity.Property(e => e.IsActive)
                    .HasDefaultValue(true);  // Default to active
            });
        }
    }
}
