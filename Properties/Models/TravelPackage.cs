using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secoundyear.Properties.Models
{
    public class TravelPackage
    {
        [Key]
        public int Id { get; set; }

        public string? TravelPackageDate { get; set; } = string.Empty;

        public string? Review { get; set; } = string.Empty;

        public bool? IsDelete {get; set;}
    }
}