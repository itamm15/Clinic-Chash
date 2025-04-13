using Microsoft.AspNetCore.Mvc;
using Portal.Models;
namespace Portal.Controllers;

public class ServicesController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
