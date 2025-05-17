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
        var icons = new Dictionary<string, string>
        {
            ["Kardiolog"] = "bi bi-heart-pulse",
            ["Neurolog"] = "bi bi-activity",
            ["Ortopeda"] = "bi bi-person-walking",
            ["Stomatolog"] = "bi bi-emoji-smile",
            ["Diabetolog"] = "bi bi-droplet-half",
            ["Pediatra"] = "bi bi-balloon"
        };

        var texts = new Dictionary<string, string>
        {
            ["Kardiolog"] = "Specjalizacja zajmująca się diagnozowaniem i leczeniem chorób serca i układu krążenia.",
            ["Neurolog"] = "Zajmuje się diagnozowaniem i leczeniem chorób układu nerwowego, takich jak udary, padaczka, czy stwardnienie rozsiane.",
            ["Ortopeda"] = "Specjalizacja zajmująca się diagnozowaniem i leczeniem urazów, zaburzeń i chorób układu kostno-stawowego.",
            ["Stomatolog"] = "Stomatologia to dziedzina medycyny zajmująca się zdrowiem jamy ustnej, zębów i przyzębia.",
            ["Diabetolog"] = "Specjalizacja zajmująca się leczeniem cukrzycy i jej powikłań.",
            ["Pediatra"] = "Koncentruje się na zdrowiu i leczeniu dzieci, od noworodków po młodzież."
        };

        var specs = _context.Specializations.Select(s => new PortalHomeViewModel
        {
            Name = s.Name,
            Description = texts[s.Name],
            Icon = icons[s.Name]
        }).ToList();

        return View(specs);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
