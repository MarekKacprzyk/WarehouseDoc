namespace WarehouseDoc.Forms.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Document
    {
        public string Header { get; set; }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal NetPrice { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal NetPrice { get; set; }
    }
}
