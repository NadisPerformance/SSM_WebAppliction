using Microsoft.EntityFrameworkCore;
using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public class DistributorRepository:IDistributorRepository
    {
        private readonly AppDbContext _appDbContext;
        public DistributorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Distributor> GetAllDistributors()
        {
            return _appDbContext.Distributors.Include(f => f.Fuel); 
        }

        public Distributor GetDistributorById(int id)
        {
            return _appDbContext.Distributors.FirstOrDefault(d => d.DistributorId == id);
        }
    }
}
