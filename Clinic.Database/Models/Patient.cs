using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Patient
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Imię jest wymagane")]
    [StringLength(50, ErrorMessage = "Imię nie może być dłuższe niż 50 znaków")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Nazwisko jest wymagane")]
    [StringLength(50, ErrorMessage = "Nazwisko nie może być dłuższe niż 50 znaków")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Adres e-mail jest wymagany")]
    [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail")]
    [StringLength(100)]
    public string Email { get; set; }

    [Required(ErrorMessage = "Numer telefonu jest wymagany")]
    [Phone(ErrorMessage = "Nieprawidłowy numer telefonu")]
    [StringLength(20)]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Data urodzenia jest wymagana")]
    [Column(TypeName = "date")]
    public DateTime DateOfBirth { get; set; }

    [StringLength(200, ErrorMessage = "Adres nie może być dłuższy niż 200 znaków")]
    public string Address { get; set; }
}
