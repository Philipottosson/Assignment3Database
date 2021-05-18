﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("media_types", Schema = "music")]
    public partial class MediaType
    {
        [Key]
        public int MediaTypeId { get; set; }
        [StringLength(120)]
        public string Name { get; set; }
    }
}
