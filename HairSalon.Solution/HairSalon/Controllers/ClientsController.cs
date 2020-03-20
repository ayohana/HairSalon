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

    // public ActionResult Create()
    // {
    //   ViewBag.StylistId = new SelectList(_db.ParentClients, "StylistId", "Name");
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Item item)
    // {
    //   _db.Items.Add(item);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  }
}