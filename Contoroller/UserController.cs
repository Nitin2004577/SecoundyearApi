using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using secondyear.Properties.Context;
using usingLinq.Dtos;
using usingLinq.Models;

namespace usingLinq.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Get() 
        {
            var users = _context.users.ToList();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UserDto model)
        {
            var user = new User
            {
                Name = model.Name,
                Role = model.Role,
                Username = model.Username,
                Password = model.Password,
            };
            _context.users.Add(user);
            _context.SaveChanges();

            return Ok("User created successfully");

        }
    }
}