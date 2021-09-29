using Microsoft.AspNetCore.Mvc;
using TripList.Models;
using System.Collections.Generic;

namespace TripList.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description, double price, bool packedOrNot, double weight)
    {
      Item myItem = new Item(description, price, packedOrNot, weight);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}/edit")]
    public ActionResult Update(int id)
    {
      // Item.UpdateItem(id);
      // return RedirectToAction("Index");
            Item editItem = Item.UpdateItem(id);
      return RedirectToAction("Index");
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }
  }
}