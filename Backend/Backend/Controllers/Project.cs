using Backend.DTO.ProjectDTO;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class ProjectController : ControllerBase
    {
        private readonly PortfolioContext _context;
        public ProjectController(PortfolioContext context)
        {
            _context = context;
;        }

        [HttpGet]
        public async Task<IActionResult> GetProject(ReadprojectDTO readProjectDTO)
        {
            var project = await _context.Projects.ToListAsync();
            if(project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        [HttpGet("{ id}")]
        public async Task<IActionResult> GetProject(int id, ReadprojectDTO readProjectDTO)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectDTO createProjectDTO)
        {
            var project = new Project
            {
                Title = createProjectDTO.Title,
                Description = createProjectDTO.Description,
                Githublink = createProjectDTO.Githublink,
            };
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return Ok(project);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProject(int id, UpdateProjectDTO updateProjectDTO)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            project.Title = updateProjectDTO.Title;
            project.Description = updateProjectDTO.Description;
            project.Githublink = updateProjectDTO.Githublink;

            await _context.SaveChangesAsync();
            return Ok(project);

        }


        [HttpDelete]
        public async Task<IActionResult> DeleteProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
            return Ok(project);
           
        }
    }
}

