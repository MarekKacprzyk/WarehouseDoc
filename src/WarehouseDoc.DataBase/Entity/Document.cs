using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseDoc.DataBase.Entity
{
    using System.Collections.Generic;

    public class Document
    {
        [Required]
        public string Header { get; set; }

        [Key]
        public Guid DocumentId { get; set; }

        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal NetPrice { get; set; }

        [NotMapped]
        public virtual List<Product> Products { get; set; }
    }
}
