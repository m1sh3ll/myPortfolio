using Microsoft.AspNetCore.Mvc;

namespace MyInventory.Controllers
{
  public class ResumeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    public IActionResult Resume()
    {
      return View("Index");
    }

  }
}
