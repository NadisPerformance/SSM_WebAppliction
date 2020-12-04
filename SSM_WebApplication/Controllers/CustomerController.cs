using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSM_WebApplication.Models;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository, AppDbContext context)
        {
            _customerRepository = customerRepository;
            _context = context;
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

        // GET: _Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,Company,ICE,Adresse1,Adresse2,City,Tel1,Tel2,Email,ContactName,Status,AddDate")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(customer);
        }

        // GET: _Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FirstName,LastName,Company,ICE,Adresse1,Adresse2,City,Tel1,Tel2,Email,ContactName,Status,AddDate")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(customer);
        }

        // GET: _Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: _Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}