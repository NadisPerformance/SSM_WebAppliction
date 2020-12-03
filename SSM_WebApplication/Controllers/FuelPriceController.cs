using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSM_WebApplication.Models;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class FuelPriceController : Controller
    {
       private readonly IFuelPriceRepository _fuelPriceRepository;
       private readonly IFuelRepository _fuelRepository;

        public FuelPriceController(IFuelPriceRepository fuelPriceRepository, IFuelRepository fuelRepository)
        {
            _fuelPriceRepository = fuelPriceRepository;
            _fuelRepository = fuelRepository;
        }

        public IActionResult List()
        {
            var fuelPrices = _fuelPriceRepository.GetAllFuelPrices();
            return View(fuelPrices);
        }
        public IActionResult Detail(int idFuelPrice)
        {
            var fuelPrice = _fuelPriceRepository.GetFuelPriceById(idFuelPrice);
            if (fuelPrice == null)
                return NotFound();
            return View(fuelPrice);
        }
    }
}
