using Microsoft.AspNetCore.Mvc;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IActionResult List()
        {
            var customer = _customerRepository.GetAllCustomers();
            return View(customer);
        }
        public IActionResult Detail(int idCustomer)
        {
            var customer = _customerRepository.GetCustomerById(idCustomer);
            if (customer == null)
                return NotFound();
            return View(customer);
        }
    }
}
