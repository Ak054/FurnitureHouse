using FurnitureHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureHouse.Services
{
    public interface IMenuAccessService
    {
        Task<List<FurnitureCategory>> GetMenu();
    }
}
