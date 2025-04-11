using Microsoft.AspNetCore.Mvc;
using Intranet.Models;

namespace Intranet.Controllers;

public class PatientsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
