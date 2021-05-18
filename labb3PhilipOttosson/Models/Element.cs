using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    public partial class Element
    {
        [Key]
        public int Number { get; set; }
        [StringLength(10)]
        public string Symbol { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? Period { get; set; }
        public int? Group { get; set; }
        public double? Mass { get; set; }
        public int? Radius { get; set; }
        public int? Valenceel { get; set; }
        public int? Stableisotopes { get; set; }
        public double? Meltingpoint { get; set; }
        public double? Boilingpoint { get; set; }
        public double? Density { get; set; }
    }
}
