using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Keyless]
    [Table("playlist_track", Schema = "music")]
    public partial class PlaylistTrack
    {
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }
    }
}
