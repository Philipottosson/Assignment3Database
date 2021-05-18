using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("customers", Schema = "company")]
    public partial class Customer
    {
        [Key]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [StringLength(50)]
        public string ContactName { get; set; }
        [StringLength(50)]
        public string ContactTitle { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string Region { get; set; }
        [StringLength(20)]
        public string PostalCode { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
    }
}
