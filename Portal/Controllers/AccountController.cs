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
    var prescriptions = _context.Prescriptions.Include(p => p.Doctor).Include(p => p.Patient).ToList();
    var payments = _context.Payments.ToList();

    var accountModel = new AccountViewModel
    {
      Visits = visits,
      Prescriptions = prescriptions,
      Payments = payments
    };

    return View(accountModel);
  }
}
