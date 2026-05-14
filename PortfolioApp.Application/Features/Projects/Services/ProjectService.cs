using PortfolioApp.Application.Features.Projects.DTOs;
using PortfolioApp.Application.Features.Projects.Interfaces;
using PortfolioApp.Application.Interfaces;
using PortfolioApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Application.Features.Projects.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IGenericRepository<Project> _projectRepository;

        public ProjectService(
            IGenericRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<ProjectDto>> GetAllAsync()
        {
            var projects = await _projectRepository.GetAllAsync();

            return projects.Select(x => new ProjectDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                GithubUrl = x.GithubUrl,
                ProjectUrl = x.ProjectUrl,
                CoverImageUrl = x.CoverImageUrl,
                IsFeatured = x.IsFeatured,
                Slug = x.Slug
            }).ToList();
        }

        public async Task<ProjectDto?> GetByIdAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);

            if (project is null)
                return null;

            return new ProjectDto
            {
                Id = project.Id,
                Title = project.Title,
                Description = project.Description,
                GithubUrl = project.GithubUrl,
                ProjectUrl = project.ProjectUrl,
                CoverImageUrl = project.CoverImageUrl,
                IsFeatured = project.IsFeatured,
                Slug = project.Slug
            };
        }

        public async Task CreateAsync(CreateProjectDto dto)
        {
            var slugExists = await _projectRepository.AnyAsync(x => x.Slug == GenerateSlug(dto.Title));

            if (slugExists)
                throw new Exception("Project slug already exists.");

            var project = new Project
            {
                Title = dto.Title,
                Description = dto.Description,
                GithubUrl = dto.GithubUrl,
                ProjectUrl = dto.ProjectUrl,
                CoverImageUrl = dto.CoverImageUrl,
                IsFeatured = dto.IsFeatured,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Slug = GenerateSlug(dto.Title)
            };

            await _projectRepository.AddAsync(project);

            await _projectRepository.SaveChangesAsync();
        }

        private string GenerateSlug(string title)
        {
            return title.ToLower().Replace(" ", "-");
        }
    }
}
