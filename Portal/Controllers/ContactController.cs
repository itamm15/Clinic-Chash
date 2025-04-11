using Microsoft.AspNetCore.Mvc;
using Portal.Models;
namespace Portal.Controllers;

public class ContactController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
