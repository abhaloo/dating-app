using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }



        // Endpoint for retrieving all users
        // returns users in a list
        // uses async methods for multi threading to improve scalability 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
        
            return await _context.Users.ToListAsync();

        }


        // Endpoint for retrieving one user
        // specifies {id} parameter in attribute and method signature
        // uses async methods for multi threading to improve scalability  
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return  await _context.Users.FindAsync(id);;

        }


    }
}