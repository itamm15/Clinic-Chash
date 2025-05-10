using Microsoft.EntityFrameworkCore;

namespace Clinic.Database
{
  public class AppDbContext : DbContext
  {

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Specialization> Specializations { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
  }
}
