using System.ComponentModel.DataAnnotations;

public class Specialization
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }
}
