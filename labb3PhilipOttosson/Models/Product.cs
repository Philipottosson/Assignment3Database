using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("products", Schema = "company")]
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        [StringLength(50)]
        public string QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public int? Discontinued { get; set; }
    }
}
