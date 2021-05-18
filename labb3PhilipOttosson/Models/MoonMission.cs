using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Keyless]
    public partial class MoonMission
    {
        [Required]
        [StringLength(100)]
        public string Spacecraft { get; set; }
        [Column("Launch date")]
        public DateTime? LaunchDate { get; set; }
        [Column("Carrier rocket")]
        public string CarrierRocket { get; set; }
        public string Operator { get; set; }
        [Column("Mission type")]
        public string MissionType { get; set; }
        public string Outcome { get; set; }
        public string Comment { get; set; }
    }
}
