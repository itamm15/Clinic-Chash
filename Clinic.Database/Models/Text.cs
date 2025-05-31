using System.ComponentModel.DataAnnotations;

namespace Clinic.Database
{
  public class Text
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public int Key { get; set; }

    [Required]
    public string Content { get; set; }
  }
}
