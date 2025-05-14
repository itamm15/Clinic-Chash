
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Database
{
  public class Visit
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "timestamp without time zone")]
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
