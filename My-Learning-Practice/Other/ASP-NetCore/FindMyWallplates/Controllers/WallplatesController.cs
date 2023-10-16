using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FindMyWallplates.Data;
using FindMyWallplates.Models;

namespace FindMyWallplates.Controllers
{
    public class WallplatesController : Controller
    {
        private readonly FindMyWallplatesContext _context;

        public WallplatesController(FindMyWallplatesContext context)
        {
            _context = context;
        }

        // GET: Wallplates
        public async Task<IActionResult> Index()
        {
              return _context.Wallplates != null ? 
                          View(await _context.Wallplates.ToListAsync()) :
                          Problem("Entity set 'FindMyWallplatesContext.Wallplates'  is null.");
        }

        // GET: Wallplates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Wallplates == null)
            {
                return NotFound();
            }

            var wallplates = await _context.Wallplates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wallplates == null)
            {
                return NotFound();
            }

            return View(wallplates);
        }

        // GET: Wallplates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wallplates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SKU,Title,Price,Quantity")] Wallplates wallplates)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wallplates);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wallplates);
        }

        // GET: Wallplates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Wallplates == null)
            {
                return NotFound();
            }

            var wallplates = await _context.Wallplates.FindAsync(id);
            if (wallplates == null)
            {
                return NotFound();
            }
            return View(wallplates);
        }

        // POST: Wallplates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SKU,Title,Price,Quantity")] Wallplates wallplates)
        {
            if (id != wallplates.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wallplates);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WallplatesExists(wallplates.Id))
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
            return View(wallplates);
        }

        // GET: Wallplates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Wallplates == null)
            {
                return NotFound();
            }

            var wallplates = await _context.Wallplates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wallplates == null)
            {
                return NotFound();
            }

            return View(wallplates);
        }

        // POST: Wallplates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Wallplates == null)
            {
                return Problem("Entity set 'FindMyWallplatesContext.Wallplates'  is null.");
            }
            var wallplates = await _context.Wallplates.FindAsync(id);
            if (wallplates != null)
            {
                _context.Wallplates.Remove(wallplates);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WallplatesExists(int id)
        {
          return (_context.Wallplates?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
