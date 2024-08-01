using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using secondyear.Properties.Context;
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

    }


}
