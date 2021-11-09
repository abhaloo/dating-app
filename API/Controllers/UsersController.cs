using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

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


        //Endpoint for retrieving all users
        //returns users in a list
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;

        }


        //Endpoint for retrieving one user
        //specifies parameters in attribute and method signature 
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return  _context.Users.Find(id);;

        }


    }
}