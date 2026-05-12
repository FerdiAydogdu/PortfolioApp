using PortfolioApp.Domain.Common;

namespace PortfolioApp.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ProjectUrl { get; set; }
        public string? GithubUrl { get; set; }
        public string? CoverImageUrl { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Slug { get; set; } = string.Empty;
        public ICollection<ProjectSkill> ProjectSkills { get; set; }
        = new List<ProjectSkill>();
        public ICollection<ProjectCategory> ProjectCategories { get; set; }
            = new List<ProjectCategory>();
    }
}
