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
    public class singUpController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public singUpController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.SingUps.ToList());
        }


        [HttpPost]

        public IActionResult Create(SingUp singUp)
        {

            _context.SingUps.Add(singUp);
            _context.SaveChanges();
            return Ok("Created Sucessfully");
        }

    }


}
