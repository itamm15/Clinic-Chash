using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Database
{
  public class Payment
  {
    public int Id { get; set; }

    [Required]
    [Range(0.01, 100000, ErrorMessage = "Kwota musi być większa niż 0")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Data płatności jest wymagana")]
    [DataType(DataType.Date)]
    [Column(TypeName = "date")]
    public DateTime PaymentDate { get; set; }

    [StringLength(200, ErrorMessage = "Opis nie może być dłuższy niż 200 znaków")]
    public string Description { get; set; }

    [Required]
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
  }
}
