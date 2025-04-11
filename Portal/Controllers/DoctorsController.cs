using Microsoft.AspNetCore.Mvc;
using Portal.Models;
namespace Portal.Controllers;

public class DoctorsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
