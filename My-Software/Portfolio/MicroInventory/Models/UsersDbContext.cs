using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyInventory.Models
{
  public class UsersDbContext : IdentityDbContext<User>
  {
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }

  }
}
