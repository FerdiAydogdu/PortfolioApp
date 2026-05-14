using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Application.Features.Projects.DTOs
{
    public class CreateProjectDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Url]
        public string? GithubUrl { get; set; }

        [Url]
        public string? ProjectUrl { get; set; }

        [Url]
        public string? CoverImageUrl { get; set; }

        public bool IsFeatured { get; set; }
    }
}
