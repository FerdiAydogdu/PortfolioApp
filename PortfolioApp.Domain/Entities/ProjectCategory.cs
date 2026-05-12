namespace PortfolioApp.Domain.Entities
{
    public class ProjectCategory
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
