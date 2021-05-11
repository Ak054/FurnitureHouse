using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FurnitureHouse.Data;
using FurnitureHouse.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace FurnitureHouse.Controllers
{
    [Authorize(Roles = "power")]
    public class FurnitureInfoesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public FurnitureInfoesController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        // GET: FurnitureInfoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FurnitureInfos.Include(f => f.Brand).Include(f => f.FurnitureSubCategory);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FurnitureInfoes/Create
        public IActionResult Create()
        {
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandName");
            ViewData["FurnitureSubCategoryID"] = new SelectList(_context.FurnitureSubCategories, "FurnitureSubCategoryID", "FurnitureSubCategoryName");
            return View();
        }

        // POST: FurnitureInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FurnitureInfoID,FurnitureName,OfferPrice,Price,File,FurnitureSubCategoryID,BrandID")] FurnitureInfo furnitureInfo)
        {
            using (var memoryStream = new MemoryStream())
            {
                await furnitureInfo.File.FormFile.CopyToAsync(memoryStream);

                string photoname = furnitureInfo.File.FormFile.FileName;
                furnitureInfo.Extension = Path.GetExtension(photoname);
                if (!".jpg.jpeg.png.gif.bmp".Contains(furnitureInfo.Extension.ToLower()))
                {
                    ModelState.AddModelError("File.FormFile", "Only Images Allowed");
                }
                else
                {
                    ModelState.Remove("Extension");
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(furnitureInfo);
                await _context.SaveChangesAsync();
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "furnitures");
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }
                string filename = furnitureInfo.FurnitureInfoID + furnitureInfo.Extension;
                var filePath = Path.Combine(uploadsRootFolder, filename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await furnitureInfo.File.FormFile.CopyToAsync(fileStream).ConfigureAwait(false);
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandName", furnitureInfo.BrandID);
            ViewData["FurnitureSubCategoryID"] = new SelectList(_context.FurnitureSubCategories, "FurnitureSubCategoryID", "FurnitureSubCategoryName", furnitureInfo.FurnitureSubCategoryID);
            return View(furnitureInfo);
        }

        // GET: FurnitureInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furnitureInfo = await _context.FurnitureInfos.FindAsync(id);
            if (furnitureInfo == null)
            {
                return NotFound();
            }
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandName", furnitureInfo.BrandID);
            ViewData["FurnitureSubCategoryID"] = new SelectList(_context.FurnitureSubCategories, "FurnitureSubCategoryID", "FurnitureSubCategoryName", furnitureInfo.FurnitureSubCategoryID);
            return View(furnitureInfo);
        }

        // POST: FurnitureInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FurnitureInfoID,FurnitureName,OfferPrice,Price,Extension,FurnitureSubCategoryID,BrandID")] FurnitureInfo furnitureInfo)
        {
            if (id != furnitureInfo.FurnitureInfoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(furnitureInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FurnitureInfoExists(furnitureInfo.FurnitureInfoID))
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
            ViewData["BrandID"] = new SelectList(_context.Brands, "BrandID", "BrandName", furnitureInfo.BrandID);
            ViewData["FurnitureSubCategoryID"] = new SelectList(_context.FurnitureSubCategories, "FurnitureSubCategoryID", "FurnitureSubCategoryName", furnitureInfo.FurnitureSubCategoryID);
            return View(furnitureInfo);
        }

        // GET: FurnitureInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furnitureInfo = await _context.FurnitureInfos
                .Include(f => f.Brand)
                .Include(f => f.FurnitureSubCategory)
                .FirstOrDefaultAsync(m => m.FurnitureInfoID == id);
            if (furnitureInfo == null)
            {
                return NotFound();
            }

            return View(furnitureInfo);
        }

        // POST: FurnitureInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var furnitureInfo = await _context.FurnitureInfos.FindAsync(id);
            _context.FurnitureInfos.Remove(furnitureInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FurnitureInfoExists(int id)
        {
            return _context.FurnitureInfos.Any(e => e.FurnitureInfoID == id);
        }
    }
}
