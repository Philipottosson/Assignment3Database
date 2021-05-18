using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("albums", Schema = "music")]
    public partial class Album
    {
        [Key]
        public int AlbumId { get; set; }
        [Required]
        [StringLength(160)]
        public string Title { get; set; }
        public int ArtistId { get; set; }
    }
}
