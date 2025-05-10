using Clinic.Database;
using Microsoft.AspNetCore.Mvc;

public class SpecsController : Controller
{
  private readonly AppDbContext _context;
  public SpecsController(AppDbContext context) { _context = context; }

  public IActionResult Index()
  {
    var specs = _context.Specializations.ToList();
    return View(specs);
  }

  [HttpPost]
  public IActionResult Create(Specialization specialization)
  {
    Console.Write(specialization);
    _context.Specializations.Add(specialization);
    _context.SaveChanges();
    return RedirectToAction("Index");
  }
}
