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
    var texts = _context.Texts.ToList();
    var visits = _context.Visits.Include(v => v.Doctor).ToList();
    var prescriptions = _context.Prescriptions.Include(p => p.Doctor).ToList();
    var payments = _context.Payments.ToList();

    var accountModel = new AccountViewModel
    {
      Visits = visits,
      Prescriptions = prescriptions,
      Payments = payments,
      Texts = texts
    };

    return View(accountModel);
  }
}
