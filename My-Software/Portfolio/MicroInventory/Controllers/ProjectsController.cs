using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyInventory.Models;
using Microsoft.AspNetCore.Authorization;

namespace MyInventory.Controllers
{
  public class ProjectsController : Controller
  {
    private readonly ApplicationDbContext _context;

    public ProjectsController(ApplicationDbContext context)
    {
      _context = context;
    }


    public async Task<IActionResult> Index()
    {
      return _context.Projects != null ?
                  View(await _context.Projects.ToListAsync()) :
                  Problem("Entity set 'ApplicationDbContext.Projects'  is null.");
    }


    [Authorize]
    public async Task<IActionResult> Admin()
    {
      return _context.Projects != null ?
                  View(await _context.Projects.ToListAsync()) :
                  Problem("Entity set 'ApplicationDbContext.Projects'  is null.");
    }

    public async Task<IActionResult> Details(int? id)
    {
      if (id == null || _context.Projects == null)
      {
        return NotFound();
      }

      var Project = await _context.Projects
          .FirstOrDefaultAsync(m => m.Id == id);
      if (Project == null)
      {
        return NotFound();
      }

      return View(Project);
    }


    [Authorize]
    public IActionResult Create()
    {
      return View();
    }


    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,ImageURL,Description,Link")] Project Project)
    {
      if (ModelState.IsValid)
      {
        _context.Add(Project);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(Project);
    }


    [Authorize]
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null || _context.Projects == null)
      {
        return NotFound();
      }

      var Project = await _context.Projects.FindAsync(id);
      if (Project == null)
      {
        return NotFound();
      }
      return View(Project);
    }



    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ImageURL,Description,Link")] Project Project)
    {
      if (id != Project.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(Project);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!ProjectExists(Project.Id))
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
      return View(Project);
    }

    [Authorize]
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null || _context.Projects == null)
      {
        return NotFound();
      }

      var Project = await _context.Projects
          .FirstOrDefaultAsync(m => m.Id == id);
      if (Project == null)
      {
        return NotFound();
      }

      return View(Project);
    }


    [Authorize]
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      if (_context.Projects == null)
      {
        return Problem("Entity set 'ApplicationDbContext.Projects'  is null.");
      }
      var Project = await _context.Projects.FindAsync(id);
      if (Project != null)
      {
        _context.Projects.Remove(Project);
      }

      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool ProjectExists(int id)
    {
      return (_context.Projects?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
