using Clinic.Database;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
namespace Portal.Controllers;

public class AboutUsController : Controller
{
  private readonly AppDbContext _context;

  public AboutUsController(AppDbContext context)
  {
    _context = context;
  }

  public IActionResult Index()
  {
    ViewBag.Layout = GenerateLayout.GenerateLayoutViewModel(_context);
    var text = _context.Texts.ToList();

    return View(text);
  }
}
