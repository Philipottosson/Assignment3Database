using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("TallyTable")]
    public partial class TallyTable
    {
        [Key]
        [Column("n")]
        public long N { get; set; }
    }
}
