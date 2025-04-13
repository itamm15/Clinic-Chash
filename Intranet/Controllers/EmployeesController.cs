using Microsoft.AspNetCore.Mvc;
using Intranet.Models;

namespace Intranet.Controllers;

public class EmployeesController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
