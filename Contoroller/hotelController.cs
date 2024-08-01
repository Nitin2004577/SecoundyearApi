using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using secondyear.Properties.Context;
using secoundyear.Migrations;
using secoundyear.Properties.Models;

namespace secoundyear.Contoroller
{
    [ApiController]
    [Route("api/[controller]")]
    public class hotelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public hotelController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Hotels.ToList());
        }


        [HttpPost]

        public IActionResult Create(Hotel hotel)
        {

            _context.Hotels.Add(hotel);
            _context.SaveChanges();
            return Ok("Created Sucessfully");
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var hotels = _context.Hotels.Find(Id);
            if (hotels == null)
            {
                return NotFound();
            }
            return Ok(hotels);
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Hotel requestHotel)
        {
            var hotel = _context.Hotels.Find(Id);


            hotel.Name = requestHotel.Name;

            _context.SaveChanges();
            return Ok("Updated Sucessfully");

        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var hotel = _context.Hotels.Find(Id);

            _context.Hotels.Remove(hotel);
            _context.SaveChanges();
            return Ok("Deleted sucessfully");
        }

        [HttpGet("search")]
        public IActionResult SearchByName([FromQuery] string name)
        {
            var hotel = _context.Hotels
            .Where(h => h.Name.Contains(name))
            .ToList();
            return Ok(hotel);

        }




    }
}





