using PortfolioApp.Domain.Common;

namespace PortfolioApp.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? IconUrl { get; set; }
        public int ProficiencyLevel { get; set; }

        public ICollection<ProjectSkill> ProjectSkills { get; set; }
        = new List<ProjectSkill>();
    }
}
