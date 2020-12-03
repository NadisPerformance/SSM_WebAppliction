using Microsoft.AspNetCore.Mvc;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult List()
        {
            var employee = _employeeRepository.GetAllEmployees();
            return View(employee);
        }
        public IActionResult Detail(int idEmployee)
        {
            var employee = _employeeRepository.GetEmployeeById(idEmployee);
            if (employee == null)
                return NotFound();
            return View(employee);
        }
    }
}
