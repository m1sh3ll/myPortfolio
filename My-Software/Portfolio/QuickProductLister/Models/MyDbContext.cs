using Microsoft.EntityFrameworkCore;


namespace MyCommerce.Models
{
  public class MyDbContext : DbContext  
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<SkuAsin> SkuToAsin { get; set; }   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=sqlite.db");
    }
  }
}
