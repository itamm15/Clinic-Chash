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

  [HttpPost]
  public IActionResult Delete(int id)
  {
    var specialization = _context.Specializations.Find(id);
    if (specialization == null) return NotFound();

    _context.Specializations.Remove(specialization);
    _context.SaveChanges();
    return RedirectToAction("Index");
  }
}
