using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("regions", Schema = "company")]
    public partial class Region
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string RegionDescription { get; set; }
    }
}
