using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WarehouseDoc.DataBase.Entity;

namespace WarehouseDoc.DataBase
{
    using System;

    public class WarehouseDatabaseContext : DbContext
    {
        public DbSet<Document> Documents{ get; set; }

        public WarehouseDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = $@"server=localhost;user id=dbUser;persistsecurityinfo=True;database=Warehousedb";
            optionsBuilder.UseMySql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Document>().Property(x => x.DocumentId).HasDefaultValue(Guid.NewGuid());
            modelBuilder.Entity<Document>(config =>
            {
                config.HasOne<Client>();
                config.HasMany<Product>();
            });
        }
    }
}
