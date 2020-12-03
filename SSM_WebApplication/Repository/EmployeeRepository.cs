using Microsoft.EntityFrameworkCore;
using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _appDbContext.Employees.Include(e => e.JobTitle);
        }

        public Employee GetEmployeeById(int id)
        {
            return _appDbContext.Employees.FirstOrDefault(d => d.EmployeeId == id);
        }
    }
}
