using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WarehouseDoc.DataBase.Entity;

namespace WarehouseDoc.DataBase.Repository
{
    public class DocumentRepository : BaseRespository<Document>
    {
        protected override DbSet<Document> dbSet => DbContext.Documents;

        public DocumentRepository(WarehouseDatabaseContext dbContext) :base(dbContext)
        {
        }

        public IQueryable<Document> GetAllDocuments()
        {
            return dbSet;
        }

        public void Update(Document document)
        {
            var foundDocument = dbSet.FirstOrDefault(d => d.DocumentId == document.DocumentId);

            if (foundDocument != null)
            {
                foundDocument.Client = document.Client;
                foundDocument.GrossPrice = document.GrossPrice;
                foundDocument.NetPrice = document.NetPrice;
                foundDocument.Products.Clear();
                foundDocument.Products.AddRange(document.Products);

                SaveChanges();
                return;
            }

            dbSet.Add(document);
            SaveChanges();
        }

        public bool Deleted(Document document)
        {
            var foundDocument = dbSet.FirstOrDefault(d => d.DocumentId == document.DocumentId);

            if (foundDocument == null)
            {
                return false;
            }

            dbSet.Remove(foundDocument);
            SaveChanges();
            return true;
        }
    }
}
