using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    public partial class Color
    {
        [Key]
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(7)]
        public string Code { get; set; }
        public int? Red { get; set; }
        public int? Green { get; set; }
        public int? Blue { get; set; }
    }
}
