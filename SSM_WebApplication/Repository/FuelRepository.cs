using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public class FuelRepository : IFuelRepository
    {
        private readonly AppDbContext _appDbContext;
        public FuelRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Fuel> GetAllFuels()
        {
            return _appDbContext.Fuels;
        }

        public Fuel GetFuelById(int id)
        {
            return _appDbContext.Fuels.FirstOrDefault(f=>f.FuelId==id) ;
        }
    }
}
