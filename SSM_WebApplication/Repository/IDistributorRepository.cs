using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public interface IDistributorRepository
    {
        IEnumerable<Distributor> GetAllDistributors();
        Distributor GetDistributorById(int id);
    }
}
