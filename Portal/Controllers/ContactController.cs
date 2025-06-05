using Clinic.Database;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
namespace Portal.Controllers;

public class ContactController : Controller
{
  private readonly AppDbContext _context;

  public ContactController(AppDbContext context)
  {
    _context = context;
  }

  public IActionResult Index()
  {
    var texts = _context.Texts.ToList();
    return View(texts);
  }
}
