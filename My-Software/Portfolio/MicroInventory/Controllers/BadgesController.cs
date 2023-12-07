using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyInventory.Models;
using Microsoft.AspNetCore.Authorization;

namespace MyInventory.Controllers
{
  public class BadgesController : Controller
  {
    private readonly ApplicationDbContext _context;

    public BadgesController(ApplicationDbContext context)
    {
      _context = context;
    }


    public async Task<IActionResult> Index()
    {
      return _context.Badges != null ?
                  View(await _context.Badges.ToListAsync()) :
                  Problem("Entity set 'ApplicationDbContext.Badges'  is null.");
    }


    [Authorize]
    public async Task<IActionResult> Admin()
    {
      return _context.Badges != null ?
                  View(await _context.Badges.ToListAsync()) :
                  Problem("Entity set 'ApplicationDbContext.Badges'  is null.");
    }

    public async Task<IActionResult> Details(int? id)
    {
      if (id == null || _context.Badges == null)
      {
        return NotFound();
      }

      var Badge = await _context.Badges
          .FirstOrDefaultAsync(m => m.Id == id);
      if (Badge == null)
      {
        return NotFound();
      }

      return View(Badge);
    }


    [Authorize]
    public IActionResult Create()
    {
      return View();
    }


    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,ImageURL,Description,Link,DateIssued")] Badge Badge)
    {
      if (ModelState.IsValid)
      {
        _context.Add(Badge);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(Badge);
    }


    [Authorize]
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null || _context.Badges == null)
      {
        return NotFound();
      }

      var Badge = await _context.Badges.FindAsync(id);
      if (Badge == null)
      {
        return NotFound();
      }
      return View(Badge);
    }



    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ImageURL,Description,Link,DateIssued")] Badge Badge)
    {
      if (id != Badge.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(Badge);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!BadgeExists(Badge.Id))
          {
            return NotFound();
          }
          else
          {
            throw;
          }
        }
        return RedirectToAction(nameof(Index));
      }
      return View(Badge);
    }

    [Authorize]
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null || _context.Badges == null)
      {
        return NotFound();
      }

      var Badge = await _context.Badges
          .FirstOrDefaultAsync(m => m.Id == id);
      if (Badge == null)
      {
        return NotFound();
      }

      return View(Badge);
    }


    [Authorize]
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      if (_context.Badges == null)
      {
        return Problem("Entity set 'ApplicationDbContext.Badges'  is null.");
      }
      var Badge = await _context.Badges.FindAsync(id);
      if (Badge != null)
      {
        _context.Badges.Remove(Badge);
      }

      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool BadgeExists(int id)
    {
      return (_context.Badges?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
