using Microsoft.AspNetCore.Mvc;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class FuelController : Controller
    {
        private readonly IFuelRepository _fuelRepository;

        public FuelController(IFuelRepository fuelRepository)
        {
            _fuelRepository = fuelRepository;
        }
        public IActionResult List()
        {
            var fuels = _fuelRepository.GetAllFuels();
            return View(fuels);
        }
        public IActionResult Detail(int idFuel)
        {
            var fuel = _fuelRepository.GetFuelById(idFuel);
            if (fuel == null)
                return NotFound();
            return View(fuel);
        }
    }
}
