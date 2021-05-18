﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("playlists", Schema = "music")]
    public partial class Playlist
    {
        [Key]
        public int PlaylistId { get; set; }
        [StringLength(120)]
        public string Name { get; set; }
    }
}
