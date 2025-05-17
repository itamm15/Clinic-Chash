using Clinic.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Models;
namespace Portal.Controllers;

public class AccountController : Controller
{
  public readonly AppDbContext _context;

  public AccountController(AppDbContext context)
  {
    _context = context;
  }

  public IActionResult Index()
  {
    var visits = _context.Visits.Include(v => v.Doctor).Include(v => v.Patient).ToList();

    var accountModel = new AccountViewModel
    {
      Visits = visits
    };

    return View(accountModel);
  }
}
