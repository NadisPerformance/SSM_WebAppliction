using Microsoft.AspNetCore.Mvc;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class PaymentTypeController : Controller
    {
        private readonly IPaymentTypeRepository _paymentTypeRepository;
        public PaymentTypeController(IPaymentTypeRepository paymentTypeRepository)
        {
            _paymentTypeRepository = paymentTypeRepository;
        }
        public IActionResult List()
        {
            var paymentType = _paymentTypeRepository.GetAllPaymentTypes();
            return View(paymentType);
        }
        public IActionResult Detail(int idPaymentType)
        {
            var paymentType = _paymentTypeRepository.GetPaymentTypeById(idPaymentType);
            if (paymentType == null)
                return NotFound();
            return View(paymentType);
        }
    }
}
