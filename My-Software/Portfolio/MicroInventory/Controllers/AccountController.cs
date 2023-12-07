

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MyInventory.Models;
using MyInventory.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace MyInventory.Controllers
{
  public class AccountController : Controller
  {
    private readonly UsersDbContext _db;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, UsersDbContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }


    public ActionResult Index()
    {
      return View();
    }

    [Authorize]
    public IActionResult Register()
    {
      return View();
    }

    [Authorize]
    [HttpPost]    
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      else
      {
        User user = new User { UserName = model.Email };
        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
          return RedirectToAction("Index");
        }
        else
        {
          foreach (IdentityError error in result.Errors)
          {
            ModelState.AddModelError("", error.Description);
          }
          return View(model);
        }
      }
    }


    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      else
      {
        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
        if (result.Succeeded)
        {
          return RedirectToAction("Index");
        }
        else
        {
          ModelState.AddModelError("", "There is something wrong with your email or username. Please try again.");
          return View(model);
        }
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }





  }
}
