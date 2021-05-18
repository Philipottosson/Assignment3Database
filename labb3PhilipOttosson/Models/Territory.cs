using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("territories", Schema = "company")]
    public partial class Territory
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string TerritoryDescription { get; set; }
        public int? RegionId { get; set; }
    }
}
