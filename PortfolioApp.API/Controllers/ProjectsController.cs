using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Application.Features.Projects.DTOs;
using PortfolioApp.Application.Features.Projects.Interfaces;

namespace PortfolioApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects = await _projectService.GetAllAsync();

            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _projectService.GetByIdAsync(id);

            if (project is null)
                return NotFound();

            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            CreateProjectDto dto)
        {
            await _projectService.CreateAsync(dto);

            return Ok();
        }
    }
}
