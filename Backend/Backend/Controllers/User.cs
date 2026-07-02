using Backend.DTO.UserDTO;
using Backend.DTO.UserrDTO;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

        public class UserController : ControllerBase

        {
            private readonly PortfolioContext _context;


            public UserController(PortfolioContext context)
            {
                _context = context;
            }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var user = await _context.Users.ToListAsync();
            return Ok(user);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if(user == null)
            {
                return NotFound();  
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Createuser(CreateUserDTO createUserDTO)
        {
            var user = new User
            { 
                Fullname = createUserDTO.Fullname,
                Phone = createUserDTO.Phone,
                Email = createUserDTO.Email,
                Title = createUserDTO.Title,
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
                return Ok(user);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Updateuser(int id, UpdateUserDTO updateUserDTO)
        {

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Fullname = updateUserDTO.Fullname;
            user.Phone = updateUserDTO.Phone;
            user.Email = updateUserDTO.Email;
            user.Title = updateUserDTO.Title;

            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteuser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            {
                  if(user == null)
                {
                    return NotFound();
                }

                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return NoContent();
            };
        }
    }
}
    