using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    public partial class Airport
    {
        [Key]
        [Column("IATA")]
        [StringLength(10)]
        public string Iata { get; set; }
        [Column("ICAO")]
        [StringLength(10)]
        public string Icao { get; set; }
        [Column("Airport name")]
        [StringLength(200)]
        public string AirportName { get; set; }
        [Column("Location served")]
        [StringLength(200)]
        public string LocationServed { get; set; }
        [StringLength(20)]
        public string Time { get; set; }
        [Column("DST")]
        [StringLength(20)]
        public string Dst { get; set; }
    }
}
