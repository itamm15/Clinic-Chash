using Microsoft.AspNetCore.Mvc;
using Portal.Models;
namespace Portal.Controllers;

public class AboutUsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
