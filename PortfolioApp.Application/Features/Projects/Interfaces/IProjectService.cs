using PortfolioApp.Application.Features.Projects.DTOs;

namespace PortfolioApp.Application.Features.Projects.Interfaces
{
    public interface IProjectService
    {
        Task<List<ProjectDto>> GetAllAsync();
        Task<ProjectDto?> GetByIdAsync(int id);
        Task CreateAsync(CreateProjectDto dto);
    }
}
