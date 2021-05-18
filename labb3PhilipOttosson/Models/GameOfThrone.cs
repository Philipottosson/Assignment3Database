using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Keyless]
    public partial class GameOfThrone
    {
        public int Episode { get; set; }
        public int? EpisodeInSeason { get; set; }
        public int? Season { get; set; }
        public string Title { get; set; }
        [Column("Directed by")]
        public string DirectedBy { get; set; }
        [Column("Written by")]
        public string WrittenBy { get; set; }
        [Column("Original air date")]
        public DateTime? OriginalAirDate { get; set; }
        [Column("U.S. viewers(millions)")]
        public double? USViewersMillions { get; set; }
    }
}
