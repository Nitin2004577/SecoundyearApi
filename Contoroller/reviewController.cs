using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using secondyear.Properties.Context;
using secoundyear.Properties.Models;
// using usingLinq.Context;
// using usingLinq.Models;

namespace usingLinq.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
         private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_context.reviews.ToList());
        }

        [HttpPost]

        public IActionResult Create([FromBody] Review review)
        {
            _context.reviews.Add(review);
            _context.SaveChanges();
            return Ok("Created sucessfully");
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var review = _context.reviews.Find(id);

            if (review == null)
            {
                return NotFound();
            }

            _context.reviews.Remove(review);
            _context.SaveChanges();

            return Ok("Deleted Sucessfully");
        }
    }
}