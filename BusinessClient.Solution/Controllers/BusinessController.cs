using Microsoft.AspNetCore.Mvc;
using BusinessClient.Models;

namespace BusinessClient.Controllers
{
  public class BusinessController : Controller
  {
    public IActionResult Index()
    {
      var allBusiness = Business.GetBusinesses();
      return View(allBusiness);
    }

    [HttpPost]
    public IActionResult Index(Business business)
    {
      Business.Post(business);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var business = Business.GetDetails(id);
      return View(business);
    }

    public IActionResult Edit(int id)
    {
      var business = Business.GetDetails(id);
      return View(business);
    }

    [HttpPost]
    public IActionResult Details(int id, Business business)
    {
      business.Id = id;
      Business.Put(business);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Business.Delete(id);
      return RedirectToAction("Index");
    }
  }
}