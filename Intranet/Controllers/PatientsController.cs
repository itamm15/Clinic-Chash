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

  [HttpPost]
  public IActionResult Create(Patient patient)
  {
    Console.WriteLine(patient);
    _context.Patients.Add(patient);
    _context.SaveChanges();
    return RedirectToAction("Index");
  }
}
