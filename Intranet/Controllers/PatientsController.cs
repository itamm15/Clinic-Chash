using Microsoft.AspNetCore.Mvc;
using Intranet.Models;
using Clinic.Database;

namespace Intranet.Controllers;

public class PatientsController : Controller
{
    private readonly AppDbContext _context;

    public PatientsController(AppDbContext context) { _context = context; }

    public IActionResult Index()
    {
        var patients = _context.Patients.ToList();
        return View(patients);
    }

    [HttpPost]
    public IActionResult Create(Patient patient)
    {
        Console.WriteLine(patient);
        _context.Patients.Add(patient);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var patient = _context.Patients.Find(id);
        if (patient == null) return NotFound();

        _context.Patients.Remove(patient);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var patient = _context.Patients.Find(id);
        if (patient == null) return NotFound();

        return View(patient);
    }

    [HttpPost]
    public IActionResult Update(Patient patient)
    {
        _context.Patients.Update(patient);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Details(int? id)
    {
        if (id == null) return NotFound();

        var patient = _context.Patients.Find(id);
        if (patient == null) return NotFound();

        return View(patient);
    }
}
