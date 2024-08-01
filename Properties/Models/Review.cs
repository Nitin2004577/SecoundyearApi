using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secoundyear.Properties.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public string rating { get; set; } = string.Empty;

        public string Comment { get; set; } = string.Empty;      // id rating comment hotelId

        public string hotelId { get; set; } = string.Empty;

    }
}

// userName email password comform password