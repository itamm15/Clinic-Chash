using Microsoft.AspNetCore.Mvc;
using Intranet.Models;

namespace Intranet.Controllers;

public class DoctorsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
