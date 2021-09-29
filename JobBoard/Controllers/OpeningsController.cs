using Microsoft.AspNetCore.Mvc;
using JobList.Models;
using System.Collections.Generic;

namespace JobList.Controllers
{
  public class OpeningsController : Controller
  {
    [HttpGet("/openings")]
    public ActionResult Index()
    {
      List<Opening> allopenings = Opening.GetAll();
      return View(allopenings);
    }

    [HttpGet("/openings/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/openings")]
    public ActionResult Create(string title, string description, string contactInfo)
    {
      Opening myOpening = new Opening(title, description, contactInfo);
      return RedirectToAction("Index");
    }

    [HttpPost("/openings/delete")]
    public ActionResult DeleteAll()
    {
      Opening.ClearAll();
      return View();
    }

    [HttpGet("/openings/{id}")]
    public ActionResult Show(int id)
    {
      Opening foundOpening = Opening.Find(id);
      return View(foundOpening);
    }
  }
}