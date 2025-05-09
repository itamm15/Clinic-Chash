using Microsoft.AspNetCore.Mvc;
using Intranet.Models;
using Clinic.Database;

namespace Intranet.Controllers;

public class PatientsController : Controller
{
  private readonly AppDbContext _context;

  public PatientsController(AppDbContext context) { _context = context; }

  public IActionResult Index()
  {
    var patients = _context.Patients.ToList();
    return View(patients);
  }
}
