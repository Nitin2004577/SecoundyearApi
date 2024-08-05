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
    public class travelPackageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public travelPackageController( ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.travelPackage.ToList());
        }

        [HttpPost]
        public IActionResult Create(TravelPackage travelPackage)
        {
            _context.travelPackage.Add(travelPackage);
            _context.SaveChanges();
            return Ok("Created SucessFully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var findTravelPackage = _context.travelPackage.Find(id);
            if (findTravelPackage != null)  {
                return NotFound();
            }

            findTravelPackage.IsDelete = true;
            _context.SaveChanges();
            return Ok("Deleted SucessFully");
        }

        [HttpGet("search")]
        public IActionResult SearchByName([FromQuery] string name)
        {
            var travelPackages = _context.Hotels
            .Where(TP => TP.Name.Contains(name))
            .ToList();

            if(!travelPackages.Any())
            {
                return NotFound();
            }
            return Ok(travelPackages);


        }
    }
}