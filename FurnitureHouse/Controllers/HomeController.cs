using FurnitureHouse.Data;
using FurnitureHouse.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> AllBrands()
        {
            return View(await _context.Brands.ToListAsync());
        }

        public async Task<IActionResult> ViewFurniture(int ? id)
        {
            var data = _context.FurnitureInfos
                .Include(j => j.FurnitureSubCategory)
                .Include(j => j.Brand)
                .Where( j => j.BrandID == id);
            return View(await data.ToListAsync());
        }

        public async Task<IActionResult> ViewSubFurniture(int? id)
        {
            var data = _context.FurnitureInfos
                .Include(j => j.FurnitureSubCategory)
                .Include(j => j.Brand)
                .Where(j => j.FurnitureSubCategoryID == id);
            return View(await data.ToListAsync());
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> AddFavourite(int? id)
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
            string userid = _userManager.GetUserName(this.User);
            Favourite favourite = new Favourite();
            favourite.FurnitureInfoID = furnitureInfo.FurnitureInfoID;
            favourite.UserID = userid;
            _context.Add(favourite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyFavourites));
        }

        [Authorize]
        public async Task<IActionResult> MyFavourites()
        {
            string userid = _userManager.GetUserName(this.User);
            var favourites = _context.Favourites                
                .Where(m => m.UserID == userid);
            if (favourites.Count() > 0)
            {
                foreach (Favourite favourite in favourites)
                {
                    favourite.FurnitureInfo = _context.FurnitureInfos
                        .Include(b => b.Brand)
                        .Include(b => b.FurnitureSubCategory)
                        .FirstOrDefault(m => m.FurnitureInfoID == favourite.FurnitureInfoID);
                }
            }
            return View(await favourites.ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> DeleteFavourite(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favourite = await _context.Favourites.FindAsync(id);
            if (favourite == null)
            {
                return NotFound();
            }           
            _context.Remove(favourite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyFavourites));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
