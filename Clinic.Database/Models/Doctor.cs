using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Doctor
{
  public int Id { get; set; }

  [Required]
  [StringLength(50)]
  public string Name { get; set; }

  [Required]
  [StringLength(50)]
  public string LastName { get; set; }

  [Required]
  public int SpecializationId { get; set; }
  public Specialization Specialization { get; set; }

  [Required]
  [EmailAddress]
  [StringLength(100)]
  public string Email { get; set; }

  [Required]
  [DataType(DataType.Date)]
  public DateTime DateOfBirth { get; set; }
}
