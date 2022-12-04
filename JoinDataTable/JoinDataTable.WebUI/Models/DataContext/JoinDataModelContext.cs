using JoinDataTable.WebUI.Models.Model;
using Microsoft.EntityFrameworkCore;

namespace JoinDataTable.WebUI.Models.DataContext
{
    public class JoinDataModelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SOFTWARE\SQLEXPRESS;Database=JoinDatabase;Integrated Security=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
