using Microsoft.EntityFrameworkCore;

namespace WarehouseDoc.DataBase.Repository
{
    public abstract class BaseRespository<Entity> where Entity : class
    {
        protected readonly WarehouseDatabaseContext DbContext;
        protected abstract DbSet<Entity> dbSet { get; }

        protected BaseRespository(WarehouseDatabaseContext dbContext)
        {
            DbContext = dbContext;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}