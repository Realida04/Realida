using Backend.DTO.SkillDTO;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SkillController : ControllerBase
    {
        private readonly PortfolioContext _context;

        public SkillController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetSkill()
        {
            var skill = await _context.Skills.ToListAsync();
            if(skill == null) 
            { 
                return NotFound();
            }

            return Ok(skill);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkill(int id)
        {
            var skill = await _context.Skills.FindAsync(id);
            if(skill == null)
            {
                return NotFound();
            }
            return Ok(skill);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSkill(CreateSkillDTO createSkillDTO)
        {
            var skill = new Skill
            { 
                UserId = createSkillDTO.UserId,
                Name = createSkillDTO.Name
            };

            _context.Skills.Add(skill);
            await _context.SaveChangesAsync();
            return Ok(skill);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSkill(int id, UpdateSkillDTO updateSkillDTO)
        {
            var skill = await _context.Skills.FindAsync(id);
                {
                skill.Name = updateSkillDTO.Name;
                }

            await _context.SaveChangesAsync();
            return Ok(skill);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            var skill = await _context.Skills.FindAsync(id);
            if(skill == null)
            {
                return NotFound();
            }
            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();
            return Ok(skill);

        }
    }
}
