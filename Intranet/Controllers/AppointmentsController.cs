using Microsoft.AspNetCore.Mvc;
using Intranet.Models;

namespace Intranet.Controllers;

public class AppointmentsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
