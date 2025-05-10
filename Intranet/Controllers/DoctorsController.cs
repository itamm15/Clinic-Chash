using Microsoft.AspNetCore.Mvc;
using Intranet.Models;
using Clinic.Database;
using Microsoft.EntityFrameworkCore;

namespace Intranet.Controllers;

public class DoctorsController : Controller
{
  private readonly AppDbContext _context;
  public DoctorsController(AppDbContext context) { _context = context; }
  public IActionResult Index()
  {
    var doctors = _context.Doctors.Include(x => x.Specialization).ToList();
    var specializations = _context.Specializations.ToList();

    return View(new DoctorIndexViewModel { Doctors = doctors, Specializations = specializations });
  }

  public IActionResult Show(int Id)
  {
    ViewData["Id"] = Id;
    return View();
  }

  [HttpPost]
  public IActionResult Create(Doctor doctor)
  {
    Console.WriteLine(doctor);
    _context.Doctors.Add(doctor);
    _context.SaveChanges();
    return RedirectToAction("Index");
  }

  [HttpPost]
  public IActionResult Delete(int id)
  {
    var doctor = _context.Doctors.Find(id);
    if (doctor == null) return NotFound();

    _context.Doctors.Remove(doctor);
    _context.SaveChanges();
    return RedirectToAction("Index");
  }
}
