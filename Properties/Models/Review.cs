using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using secoundyear.Properties.Models;

namespace usingLinq.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public int? Rating { get; set; }

        public string? ReviewText { get; set; } = String.Empty;

        public int? HotelId { get; set; }
        public Hotel? Hotel { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }

    }
}