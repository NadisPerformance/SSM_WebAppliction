using Microsoft.AspNetCore.Mvc;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class PumpController : Controller
    {
        private readonly IPumpRepository _pumpRespository;

        public PumpController(IPumpRepository pumpRepository)
        {
            _pumpRespository = pumpRepository;
        }

        public IActionResult List()
        {
            var pumps = _pumpRespository.GetAllPumps();
            return View(pumps);
        }
        public IActionResult Detail(int idPump)
        {
            var pump = _pumpRespository.GetPumpById(idPump);
            if (pump == null)
                return NotFound();
            return View(pump);
        }
    }
}
