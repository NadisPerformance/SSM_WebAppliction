using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class DistributorController : Controller
    {
        private readonly IDistributorRepository _distributorRespository;
        private readonly IFuelRepository _fuelRepository;
        private readonly IPumpRepository _pumpRepository;

        public DistributorController(IDistributorRepository distributorRepository, IFuelRepository fuelRepository, IPumpRepository pumpRepository)
        {
            _distributorRespository = distributorRepository;
            _fuelRepository = fuelRepository;
            _pumpRepository = pumpRepository;
        }
        
        public IActionResult List()
        {
            var distributors = _distributorRespository.GetAllDistributors();
            return View(distributors);
        }
        public IActionResult Detail(int idDistributor)
        {
            var distributor = _distributorRespository.GetDistributorById(idDistributor);
            if (distributor == null)
                return NotFound();
            return View(distributor);
        }
    }
}
