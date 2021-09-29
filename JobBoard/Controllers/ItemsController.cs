using Microsoft.AspNetCore.Mvc;
using TripList.Models;
using System.Collections.Generic;

namespace TripList.Controllers
{
  public class OpeningsController : Controller
  {
    [HttpGet("/openings")]
    public ActionResult Index()
    {
      List<Opening> allOpenings = Opening.GetAll();
      return View(allOpenings);
    }

    [HttpGet("/openings/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/openings")]
    public ActionResult Create(string title, string description, string contactInfo)
    {
      Item myOpening = new Opening(title, description, contactInfo);
      return RedirectToAction("Index");
    }

    [HttpPost("/openings/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/openings/{id}/edit")]
    public ActionResult Update(int id)
    {
  
      Item editOpening = Opening.UpdateOpening(id);
      return RedirectToAction("Index");
    }

    [HttpGet("/openings/{id}")]
    public ActionResult Show(int id)
    {
      Item foundOpening = Opening.Find(id);
      return View(foundOpening);
    }
  }
}