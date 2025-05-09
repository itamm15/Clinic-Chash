using Microsoft.EntityFrameworkCore;

namespace Clinic.Database
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
  }
}
