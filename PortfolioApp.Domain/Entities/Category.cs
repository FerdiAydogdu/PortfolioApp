using PortfolioApp.Domain.Common;

namespace PortfolioApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<ProjectCategory> ProjectCategories { get; set; } = new List<ProjectCategory>();
    }
}
