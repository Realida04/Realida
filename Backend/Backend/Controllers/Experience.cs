
using Backend.DTO.ExperienceDTO;
using Backend.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly PortfolioContext _context;

        public ExperienceController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetExperience(ReadExperienceDTO readExperienceDTO)
        {
            var experience = await _context.Experiences.ToListAsync();
            if (experience == null)
            {
                return NotFound();
            }
            return Ok(experience);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExperience(ReadExperienceDTO readExperienceDTO, int id)
        {
            var experience = await _context.Experiences.FindAsync(id);
            if (experience == null)
            {
                return NotFound();
            }
            return Ok(experience);
        }

        [HttpPost]
        public async Task<IActionResult> CreateExperience(CreateExperieceDTO createExperienceDTO)
        {
            var experience = new Experience
            {
                Company = createExperienceDTO.Company,
                Position = createExperienceDTO.Position,
                StartDate = createExperienceDTO.StartDate,
                EndDate = createExperienceDTO.EndDate,

            };
            _context.Experiences.Add(experience);
            await _context.SaveChangesAsync();
            return Ok(experience);
        }

        [HttpPut]
        public async Task<IActionResult>UpdateExperience(int id, UpdateExperienceDTO updateExperienceDTO)
        {
            var experience = await _context.Experiences.FindAsync(id);
            if(experience == null)
            {
                return NotFound();
            }

            experience.Company = updateExperienceDTO.Company;
            experience.Position = updateExperienceDTO.Position;
            experience.StartDate = updateExperienceDTO.StartDate;
            experience.EndDate = updateExperienceDTO.EndDate;

            await _context.SaveChangesAsync();
            return Ok(experience);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteExpereience(int id)
        {
            var experience = await _context.Experiences.FindAsync(id);
              if(experience == null)
            {
                return NotFound();
            }

            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();
            return NoContent();
        }    
    }
}