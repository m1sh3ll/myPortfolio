﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyInventory.Models;
using Microsoft.AspNetCore.Authorization;

namespace MyInventory.Controllers
{
  public class ProductsController : Controller
  {
    private readonly ApplicationDbContext _context;

    public ProductsController(ApplicationDbContext context)
    {
      _context = context;
    }


    public async Task<IActionResult> Index()
    {
      return _context.Products != null ?
                  View(await _context.Products.ToListAsync()) :
                  Problem("Entity set 'ApplicationDbContext.Products'  is null.");
    }

    [Authorize]
    public async Task<IActionResult> Admin()
    {
      return _context.Products != null ?
                  View(await _context.Products.ToListAsync()) :
                  Problem("Entity set 'ApplicationDbContext.Products'  is null.");
    }

    public async Task<IActionResult> Details(int? id)
    {
      if (id == null || _context.Products == null)
      {
        return NotFound();
      }

      var product = await _context.Products
          .FirstOrDefaultAsync(m => m.Id == id);
      if (product == null)
      {
        return NotFound();
      }

      return View(product);
    }


    [Authorize]
    public IActionResult Create()
    {
      return View();
    }
   
    

    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,Price,ImageURL,Description")] Product product)
    {
      if (ModelState.IsValid)
      {
        _context.Add(product);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(product);
    }


    [Authorize]
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null || _context.Products == null)
      {
        return NotFound();
      }

      var product = await _context.Products.FindAsync(id);
      if (product == null)
      {
        return NotFound();
      }
      return View(product);
    }



    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Price,ImageURL,Description")] Product product)
    {
      if (id != product.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(product);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!ProductExists(product.Id))
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
      return View(product);
    }

    [Authorize]
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null || _context.Products == null)
      {
        return NotFound();
      }

      var product = await _context.Products
          .FirstOrDefaultAsync(m => m.Id == id);
      if (product == null)
      {
        return NotFound();
      }

      return View(product);
    }


    [Authorize]
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      if (_context.Products == null)
      {
        return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
      }
      var product = await _context.Products.FindAsync(id);
      if (product != null)
      {
        _context.Products.Remove(product);
      }

      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool ProductExists(int id)
    {
      return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
