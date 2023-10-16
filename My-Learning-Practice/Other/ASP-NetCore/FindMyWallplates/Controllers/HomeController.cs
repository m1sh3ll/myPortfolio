using FindMyWallplates.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FindMyWallplates.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
      //return Content("Home Page");
    }
    public IActionResult Welcome(string sku)
    {
      //return Content("Wallplate SKU: " + sku);
      ViewData["Message"] = "Wallplate";
      ViewData["Sku"] = sku;
      return View();
    }
    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}