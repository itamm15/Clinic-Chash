using Microsoft.AspNetCore.Mvc;
using Portal.Models;
namespace Portal.Controllers;

public class AccountController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
