using Microsoft.EntityFrameworkCore;

namespace WarehouseDoc.DataBase
{
    using System;

    public class WarehouseDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = $@"server=localhost;user id=dbUser;persistsecurityinfo=True;database=Warehousedb";
            optionsBuilder.UseMySql(connectionString);
        }
    }
}
