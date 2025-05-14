
using System;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Database
{
  public class Visit
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime VisitDate { get; set; }

    [Required]
    [StringLength(100)]
    public string VisitReason { get; set; }

    [Required]
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }

    [Required]
    public int DoctorId { get; set; }
    public Doctor? Doctor { get; set; }
  }
}
