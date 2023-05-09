using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{   
    
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            //the purpose of this is to get a list of all the users with one line 
            //instead of writing sql queries every single time for every single user 

            return await _context.Users.ToListAsync(); 
        }

        [HttpGet("{id}")] //syntax used to be able to get a specific user w their ID 
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
            
        }

    }
}