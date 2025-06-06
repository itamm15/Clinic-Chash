using Microsoft.EntityFrameworkCore;

namespace Clinic.Database
{
  public class AppDbContext : DbContext
  {

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Specialization> Specializations { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Examination> Examinations { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Text> Texts { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
  }
}
