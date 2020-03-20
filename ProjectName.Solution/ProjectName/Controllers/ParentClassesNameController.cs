using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
  public class ParentClassesNameController : Controller
  {
    private readonly ProjectNameContext _db;

    public ParentClassesNameController(ProjectNameContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<ParentClassName> model = _db.ParentClassesName.ToList();
    //   return View(model);
    // }
  }
}