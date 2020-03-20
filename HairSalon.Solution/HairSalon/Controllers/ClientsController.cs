using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<Item> model = _db.Clients.Include(classes => classes.Stylist).ToList();
    //   return View(model);
    // }

    public ActionResult Create()
    {
      ViewBag.StylistID = new SelectList(_db.Stylists, "StylistID", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Details", "Stylists", new { id = client.StylistID });
    }

  }
}