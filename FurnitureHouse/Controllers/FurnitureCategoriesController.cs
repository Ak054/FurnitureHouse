using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FurnitureHouse.Data;
using FurnitureHouse.Models;

namespace FurnitureHouse.Controllers
{
    public class FurnitureCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FurnitureCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FurnitureCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.FurnitureCategories.ToListAsync());
        }

        

        // GET: FurnitureCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FurnitureCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FurnitureCategoryID,FurnitureCategoryName")] FurnitureCategory furnitureCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(furnitureCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(furnitureCategory);
        }

        // GET: FurnitureCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furnitureCategory = await _context.FurnitureCategories.FindAsync(id);
            if (furnitureCategory == null)
            {
                return NotFound();
            }
            return View(furnitureCategory);
        }

        // POST: FurnitureCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FurnitureCategoryID,FurnitureCategoryName")] FurnitureCategory furnitureCategory)
        {
            if (id != furnitureCategory.FurnitureCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(furnitureCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FurnitureCategoryExists(furnitureCategory.FurnitureCategoryID))
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
            return View(furnitureCategory);
        }

        // GET: FurnitureCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furnitureCategory = await _context.FurnitureCategories
                .FirstOrDefaultAsync(m => m.FurnitureCategoryID == id);
            if (furnitureCategory == null)
            {
                return NotFound();
            }

            return View(furnitureCategory);
        }

        // POST: FurnitureCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var furnitureCategory = await _context.FurnitureCategories.FindAsync(id);
            _context.FurnitureCategories.Remove(furnitureCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FurnitureCategoryExists(int id)
        {
            return _context.FurnitureCategories.Any(e => e.FurnitureCategoryID == id);
        }
    }
}
