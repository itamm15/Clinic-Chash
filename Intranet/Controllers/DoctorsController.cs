using Microsoft.AspNetCore.Mvc;
using Intranet.Models;

namespace Intranet.Controllers;

public class DoctorsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Show(int Id)
  {
    ViewData["Id"] = Id;
    return View(Id);
  }
}
