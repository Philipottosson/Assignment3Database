using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Keyless]
    public partial class Type
    {
        public int? Integer { get; set; }
        public double? Float { get; set; }
        public string String { get; set; }
        public DateTime? DateTime { get; set; }
        public int? Bool { get; set; }
    }
}
