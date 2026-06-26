using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.DTO.EducationDTO;
using Microsoft.AspNetCore.Http.HttpResults;
namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EducationController : ControllerBase
    {
        private readonly PortfolioContext _context;
          public EducationController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEducation(ReadEducationDTO readEducatoinDTO)
        {
            var education = await _context.Educations.ToListAsync();
            if (education == null)
            {
                return NotFound();
            }

            return Ok(education);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEducation(int id)
        {
            var education = await _context.Educations.FindAsync(id);
            if(education == null)
            {
                return NotFound();
            }
            return Ok(education);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEducation(CreateEducationDTO createEducationDTO)
        {
           var education = new Education
           {
               Institution = createEducationDTO.Institution,
               Degree = createEducationDTO.Degree,
               Field = createEducationDTO.Field,
               StartYear = createEducationDTO.StartYear,
           };
            _context.Educations.Add(education);
            await _context.SaveChangesAsync();
            return Ok(education);


        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEducation(int id, UpdateEducationDTO updateEducationDTO)
        {
            var education = await _context.Educations.FindAsync(id);
            {
                if (education == null)
                {
                    return NotFound();
                }

                education.Institution = updateEducationDTO.Institution;
                education.Degree = updateEducationDTO.Degree;
                education.Field = updateEducationDTO.Field;
                education.StartYear = updateEducationDTO.StartYear;
            }
            await _context.SaveChangesAsync();
            return Ok(education);
            
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducation(int id)
        {
            var education = await _context.Educations.FindAsync(id);
                {
                if(education == null)
                {
                    return NotFound();
                }
            }
            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
