using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("categories", Schema = "company")]
    public partial class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
    }
}
