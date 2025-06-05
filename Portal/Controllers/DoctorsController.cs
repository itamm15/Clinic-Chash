using Clinic.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Models;
namespace Portal.Controllers;

public class DoctorsController : Controller
{
  private readonly AppDbContext _context;

  public DoctorsController(AppDbContext context)
  {
    _context = context;
  }

  public IActionResult Index()
  {

    var texts = _context.Texts.ToList();
    var icons = new Dictionary<string, string>
    {
      ["Kardiolog"] = "bi bi-heart-pulse",
      ["Neurolog"] = "bi bi-activity",
      ["Ortopeda"] = "bi bi-person-walking",
      ["Stomatolog"] = "bi bi-emoji-smile",
      ["Diabetolog"] = "bi bi-droplet-half",
      ["Pediatra"] = "bi bi-balloon"
    };

    var doctors = _context.Doctors
        .Include(d => d.Specialization)
        .Select(d => new DoctorViewModel
        {
          Name = d.Name + " " + d.LastName,
          Specialization = d.Specialization.Name,
          Icon = icons.ContainsKey(d.Specialization.Name) ? icons[d.Specialization.Name] : "bi bi-patch-question-fill",
          Email = d.Email
        }).ToList();

    var viewModel = new DoctorHomePageViewModel
    {
        Doctors = doctors,
        Texts = texts
    };

    return View(viewModel);
  }
}
