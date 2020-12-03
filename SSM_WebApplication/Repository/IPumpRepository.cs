using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public interface IPumpRepository
    {
        IEnumerable<Pump> GetAllPumps();
        Pump GetPumpById(int id);
    }
}
