using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FurnitureHouse.Data;
using FurnitureHouse.Models;
using Microsoft.AspNetCore.Authorization;

namespace FurnitureHouse.Controllers
{
    [Authorize(Roles="power")]
    public class FurnitureSubCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FurnitureSubCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FurnitureSubCategories
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FurnitureSubCategories.Include(f => f.FurnitureCategory);
            return View(await applicationDbContext.ToListAsync());
        }

        

        // GET: FurnitureSubCategories/Create
        public IActionResult Create()
        {
            ViewData["FurnitureCategoryID"] = new SelectList(_context.FurnitureCategories, "FurnitureCategoryID", "FurnitureCategoryName");
            return View();
        }

        // POST: FurnitureSubCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FurnitureSubCategoryID,FurnitureSubCategoryName,FurnitureCategoryID")] FurnitureSubCategory furnitureSubCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(furnitureSubCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FurnitureCategoryID"] = new SelectList(_context.FurnitureCategories, "FurnitureCategoryID", "FurnitureCategoryName", furnitureSubCategory.FurnitureCategoryID);
            return View(furnitureSubCategory);
        }

        // GET: FurnitureSubCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furnitureSubCategory = await _context.FurnitureSubCategories.FindAsync(id);
            if (furnitureSubCategory == null)
            {
                return NotFound();
            }
            ViewData["FurnitureCategoryID"] = new SelectList(_context.FurnitureCategories, "FurnitureCategoryID", "FurnitureCategoryName", furnitureSubCategory.FurnitureCategoryID);
            return View(furnitureSubCategory);
        }

        // POST: FurnitureSubCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FurnitureSubCategoryID,FurnitureSubCategoryName,FurnitureCategoryID")] FurnitureSubCategory furnitureSubCategory)
        {
            if (id != furnitureSubCategory.FurnitureSubCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(furnitureSubCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FurnitureSubCategoryExists(furnitureSubCategory.FurnitureSubCategoryID))
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
            ViewData["FurnitureCategoryID"] = new SelectList(_context.FurnitureCategories, "FurnitureCategoryID", "FurnitureCategoryName", furnitureSubCategory.FurnitureCategoryID);
            return View(furnitureSubCategory);
        }

        // GET: FurnitureSubCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furnitureSubCategory = await _context.FurnitureSubCategories
                .Include(f => f.FurnitureCategory)
                .FirstOrDefaultAsync(m => m.FurnitureSubCategoryID == id);
            if (furnitureSubCategory == null)
            {
                return NotFound();
            }

            return View(furnitureSubCategory);
        }

        // POST: FurnitureSubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var furnitureSubCategory = await _context.FurnitureSubCategories.FindAsync(id);
            _context.FurnitureSubCategories.Remove(furnitureSubCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FurnitureSubCategoryExists(int id)
        {
            return _context.FurnitureSubCategories.Any(e => e.FurnitureSubCategoryID == id);
        }
    }
}
