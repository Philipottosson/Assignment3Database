using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    public partial class User
    {
        [Key]
        [Column("ID")]
        [StringLength(12)]
        public string Id { get; set; }
        [StringLength(6)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
    }
}
