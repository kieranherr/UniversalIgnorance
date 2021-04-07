using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalIgnorance.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public double ProductPrice { get; set; }
        [ForeignKey("Inventory")]
        public int InventoryId { get; set; }
        public Inventory inventory { get; set; }
    }
}
