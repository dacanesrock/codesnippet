using Microsoft.EntityFrameworkCore;

namespace codesnippet.Models
{
  public class MyDbContext : DbContext
  {
    public DbSet<Snippet> Snippets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseSqlite("DataSource=Snippets.db");
    }
  }
}