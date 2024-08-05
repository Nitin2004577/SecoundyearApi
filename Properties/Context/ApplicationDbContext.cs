using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using secoundyear.Properties.Models;
using usingLinq.Models;


namespace secondyear.Properties.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<SingUp> SingUps { get; set; }

        public DbSet<SingIn> singIns {get; set; } 

        public DbSet<Review> reviews {get; set; }
        

        public DbSet<TravelPackage> travelPackages { get; set; }
        public DbSet<User>  users { get;  set; }

        public DbSet<Booking> bookings {get; set;}
    }

   
}
