using Microsoft.EntityFrameworkCore;
using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public class FuelPriceRepository : IFuelPriceRepository
    {
        private readonly AppDbContext _appDbContext;
        public FuelPriceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<FuelPrice> GetAllFuelPrices()
        {
            return _appDbContext.FuelPrices.Include(f => f.Fuel);
        }

        public FuelPrice GetFuelPriceById(int Id)
        {
            return _appDbContext.FuelPrices.FirstOrDefault(f => f.FuelPriceId == Id);
        }
    }
}
