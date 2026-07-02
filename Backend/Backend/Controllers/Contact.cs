using Backend.DTO.ContactDTO;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Backend.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]  
        public class ContactController : ControllerBase  
        { 
        
        private readonly PortfolioContext _context;
            public ContactController(PortfolioContext context)
            {
                _context = context;
            }

        

            [HttpPost]
         public async Task<IActionResult> CreateContact(CreateContactDTO createContactDTO)
            {
                var contact = new Contact
                { 
                    Name = createContactDTO.Name,
                    Subject = createContactDTO.Subject,
                    Msg = createContactDTO.Msg,
                    UserId = createContactDTO.UserId,
                };
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return Ok(contact);

            }


        [HttpGet]
        public async Task<IActionResult> GetContact()
        {
            var contact = await _context.Contacts.ToListAsync();
            return Ok(contact);

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if(contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContact(int id, UpdateContactDTO updateContactDTO)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null) 
            {
                return NotFound();
            }

            contact.Name = updateContactDTO.Name;
            contact.Subject = updateContactDTO.Subject;
            contact.Msg= updateContactDTO.Msg;

            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return Ok(contact);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
                {
                if(contact == null)
                {
                    return NotFound();
                }

                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();
                return Ok(contact);


            }
        }

    }
}
