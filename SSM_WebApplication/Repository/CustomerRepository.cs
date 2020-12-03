using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;
        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _appDbContext.Customers;
        }

        public Customer GetCustomerById(int id)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == id);
        }
    }
}
