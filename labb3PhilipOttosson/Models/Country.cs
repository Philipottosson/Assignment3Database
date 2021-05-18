using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    public partial class Country
    {
        [Key]
        [Column("Country")]
        [StringLength(100)]
        public string Country1 { get; set; }
        [StringLength(50)]
        public string Region { get; set; }
        public int? Population { get; set; }
        [Column("Area (sq# mi#)")]
        public int? AreaSqMi { get; set; }
        [Column("Pop# Density (per sq# mi#)")]
        [StringLength(20)]
        public string PopDensityPerSqMi { get; set; }
        [Column("Coastline (coast/area ratio)")]
        [StringLength(20)]
        public string CoastlineCoastAreaRatio { get; set; }
        [Column("Net migration")]
        [StringLength(20)]
        public string NetMigration { get; set; }
        [Column("Infant mortality (per 1000 births)")]
        [StringLength(20)]
        public string InfantMortalityPer1000Births { get; set; }
        [Column("GDP ($ per capita)")]
        public int? GdpPerCapita { get; set; }
        [Column("Literacy (%)")]
        [StringLength(10)]
        public string Literacy { get; set; }
        [Column("Phones (per 1000)")]
        [StringLength(20)]
        public string PhonesPer1000 { get; set; }
        [Column("Arable (%)")]
        [StringLength(10)]
        public string Arable { get; set; }
        [Column("Crops (%)")]
        [StringLength(10)]
        public string Crops { get; set; }
        [Column("Other (%)")]
        [StringLength(10)]
        public string Other { get; set; }
        public int? Climate { get; set; }
        [StringLength(10)]
        public string Birthrate { get; set; }
        [StringLength(10)]
        public string Deathrate { get; set; }
        [StringLength(10)]
        public string Agriculture { get; set; }
        [StringLength(10)]
        public string Industry { get; set; }
        [StringLength(10)]
        public string Service { get; set; }
    }
}
