using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace labb3PhilipOttosson.Models
{
    [Table("employee_territory", Schema = "company")]
    public partial class EmployeeTerritory
    {
        [Key]
        [StringLength(7)]
        public string Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? TerritoryId { get; set; }
    }
}
