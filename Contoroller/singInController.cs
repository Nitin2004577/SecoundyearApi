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
    public class singInController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public singInController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.singIn.ToList());
        }


        [HttpPost]

        public IActionResult Create(SingIn singIn)
        {

            _context.singIn.Add(singIn);
            _context.SaveChanges();
            return Ok("Created Sucessfully");
        }

    }


}
