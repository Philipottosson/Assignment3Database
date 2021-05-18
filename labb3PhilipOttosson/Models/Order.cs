using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("orders", Schema = "company")]
    public partial class Order
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        [StringLength(10)]
        public string OrderDate { get; set; }
        [StringLength(10)]
        public string RequiredDate { get; set; }
        [StringLength(10)]
        public string ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public double? Freight { get; set; }
        [StringLength(100)]
        public string ShipName { get; set; }
        [StringLength(100)]
        public string ShipAddress { get; set; }
        [StringLength(50)]
        public string ShipCity { get; set; }
        [StringLength(50)]
        public string ShipRegion { get; set; }
        [StringLength(20)]
        public string ShipPostalCode { get; set; }
        [StringLength(50)]
        public string ShipCountry { get; set; }
    }
}
