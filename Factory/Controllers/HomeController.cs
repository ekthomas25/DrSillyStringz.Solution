using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using Factory.Models;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      dynamic model = new ExpandoObject();
      model.Engineers = _db.Engineers.ToList();
      model.Machines = _db.Machines.ToList();
      
      // ViewBag.MachineId = _db.Machines.ToList();
      // ViewBag.EngineerId = _db.Engineers.ToList();
      return View(model);
    }
  }
}