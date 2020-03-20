using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
  public class ClassesNameController : Controller
  {
    private readonly ProjectNameContext _db;

    public ClassesNameController(ProjectNameContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<Item> model = _db.ClassesName.Include(classes => classes.ParentClassName).ToList();
    //   return View(model);
    // }

    // public ActionResult Create()
    // {
    //   ViewBag.ParentClassNameId = new SelectList(_db.ParentClassesName, "ParentClassNameId", "Name");
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