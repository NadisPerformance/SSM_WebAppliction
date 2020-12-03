using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public class PumpRepository : IPumpRepository
    {
        private readonly AppDbContext _appDbContext;
        public PumpRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Pump> GetAllPumps()
        {
            return _appDbContext.Pumps;
        }

        public Pump GetPumpById(int id)
        {
            return _appDbContext.Pumps.FirstOrDefault(p => p.PumpId == id);
        }
    }
}
