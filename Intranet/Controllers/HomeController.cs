using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Intranet.Models;
using Clinic.Database;

namespace Intranet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var currentYear = DateTime.Now.Year;

        var visitsSummary = _context
                            .Visits
                            .Where(v => v.VisitDate.Year == currentYear)
                            .GroupBy(v => v.VisitDate.Month)
                            .Select(v => new
                            {
                                Month = v.Key,
                                NumberOfVisist = v.Count()
                            })
                            .OrderBy(v => v.Month)
                            .ToList();

        visitsSummary = Enumerable.Range(1, 12)
                        .Select(index => new
                        {
                            Month = index,
                            NumberOfVisist = visitsSummary.FirstOrDefault(v => v.Month == index)?.NumberOfVisist ?? 0
                        })
                        .ToList();

        var indexModel = new HomeIndexViewModel
        {
            Patients = _context.Patients.ToList(),
            Doctors = _context.Doctors.ToList(),
            Visits = new VisitsSummary { Label = visitsSummary.Select(v => v.Month).ToList(), Data = visitsSummary.Select(v => v.NumberOfVisist).ToList() }
        };

        return View(indexModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
