using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("employees", Schema = "company")]
    public partial class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(10)]
        public string TitleOfCourtesy { get; set; }
        [StringLength(10)]
        public string BirthDate { get; set; }
        [StringLength(10)]
        public string HireDate { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [StringLength(13)]
        public string Region { get; set; }
        [StringLength(20)]
        public string PostalCode { get; set; }
        [StringLength(10)]
        public string Country { get; set; }
        [StringLength(50)]
        public string HomePhone { get; set; }
        [StringLength(10)]
        public string Extension { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        [StringLength(100)]
        public string PhotoPath { get; set; }
    }
}
