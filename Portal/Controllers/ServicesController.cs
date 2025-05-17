using Clinic.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Models;
namespace Portal.Controllers;

public class ServicesController : Controller
{
  private readonly AppDbContext _context;

  public ServicesController(AppDbContext context)
  {
    _context = context;
  }

  public IActionResult Index()
  {
    var services = _context.Examinations
                   .Include(e => e.Doctor)
                   .Select(e => new ServiceViewModel
                   {
                    Name = e.Name,
                    Description = e.Description,
                    DoctorName = e.Doctor.Name + " " + e.Doctor.LastName
                   })
                   .ToList();

    return View(services);
  }
}
