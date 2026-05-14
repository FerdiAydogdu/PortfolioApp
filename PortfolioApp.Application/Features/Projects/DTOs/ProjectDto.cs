namespace PortfolioApp.Application.Features.Projects.DTOs
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? GithubUrl { get; set; }
        public string? ProjectUrl { get; set; }
        public string? CoverImageUrl { get; set; }
        public bool IsFeatured { get; set; }
        public string Slug { get; set; } = string.Empty;
    }
}
