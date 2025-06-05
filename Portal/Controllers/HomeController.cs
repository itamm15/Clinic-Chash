using System.Diagnostics;
using Clinic.Database;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

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
        var texts = _context.Texts.ToList();

        var icons = new Dictionary<string, string>
        {
            ["Kardiolog"] = "bi bi-heart-pulse",
            ["Neurolog"] = "bi bi-activity",
            ["Ortopeda"] = "bi bi-person-walking",
            ["Stomatolog"] = "bi bi-emoji-smile",
            ["Diabetolog"] = "bi bi-droplet-half",
            ["Pediatra"] = "bi bi-balloon"
        };

        var specs = _context.Specializations.Select(s => new PortalHomeSpecsViewModel
        {
            Name = s.Name,
            Icon = icons.ContainsKey(s.Name) ? icons[s.Name] : "bi bi-patch-question-fill"
        }).ToList();

        var viewModel = new PortalHomeViewModel
        {
            Texts = texts,
            Specializations = specs
        };

        return View(viewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
