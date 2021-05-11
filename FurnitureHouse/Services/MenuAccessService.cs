using FurnitureHouse.Data;
using FurnitureHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace FurnitureHouse.Services
{
    public class MenuAccessService:IMenuAccessService
    {
        private readonly ApplicationDbContext _context;

        public MenuAccessService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<FurnitureCategory>> GetMenu()
        {
            return await _context.FurnitureCategories.Include(m => m.FurnitureSubCategories).ToListAsync();
        }
    }
}
