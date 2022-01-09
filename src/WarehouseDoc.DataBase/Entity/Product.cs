using System;

namespace WarehouseDoc.DataBase.Entity
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal NetPrice { get; set; }
    }
}