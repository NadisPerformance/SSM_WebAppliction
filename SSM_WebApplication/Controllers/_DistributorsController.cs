using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SSM_WebApplication.Models;

namespace SSM_WebApplication.Controllers
{
    public class _DistributorsController : Controller
    {
        private readonly AppDbContext _context;

        public _DistributorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: _Distributors
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Distributors.Include(d => d.Fuel).Include(d => d.Pump);
            return View(await appDbContext.ToListAsync());
        }

        // GET: _Distributors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distributor = await _context.Distributors
                .Include(d => d.Fuel)
                .Include(d => d.Pump)
                .FirstOrDefaultAsync(m => m.DistributorId == id);
            if (distributor == null)
            {
                return NotFound();
            }

            return View(distributor);
        }

        // GET: _Distributors/Create
        public IActionResult Create()
        {
            ViewData["FuelId"] = new SelectList(_context.Fuels, "FuelId", "FuelId");
            ViewData["PumpId"] = new SelectList(_context.Pumps, "PumpId", "PumpId");
            return View();
        }

        // POST: _Distributors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DistributorId,DistributorName,DistributorDescription,AddDate,Status,FuelId,PumpId")] Distributor distributor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(distributor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FuelId"] = new SelectList(_context.Fuels, "FuelId", "FuelId", distributor.FuelId);
            ViewData["PumpId"] = new SelectList(_context.Pumps, "PumpId", "PumpId", distributor.PumpId);
            return View(distributor);
        }

        // GET: _Distributors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distributor = await _context.Distributors.FindAsync(id);
            if (distributor == null)
            {
                return NotFound();
            }
            ViewData["FuelId"] = new SelectList(_context.Fuels, "FuelId", "FuelId", distributor.FuelId);
            ViewData["PumpId"] = new SelectList(_context.Pumps, "PumpId", "PumpId", distributor.PumpId);
            return View(distributor);
        }

        // POST: _Distributors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DistributorId,DistributorName,DistributorDescription,AddDate,Status,FuelId,PumpId")] Distributor distributor)
        {
            if (id != distributor.DistributorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(distributor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistributorExists(distributor.DistributorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FuelId"] = new SelectList(_context.Fuels, "FuelId", "FuelId", distributor.FuelId);
            ViewData["PumpId"] = new SelectList(_context.Pumps, "PumpId", "PumpId", distributor.PumpId);
            return View(distributor);
        }

        // GET: _Distributors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distributor = await _context.Distributors
                .Include(d => d.Fuel)
                .Include(d => d.Pump)
                .FirstOrDefaultAsync(m => m.DistributorId == id);
            if (distributor == null)
            {
                return NotFound();
            }

            return View(distributor);
        }

        // POST: _Distributors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var distributor = await _context.Distributors.FindAsync(id);
            _context.Distributors.Remove(distributor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DistributorExists(int id)
        {
            return _context.Distributors.Any(e => e.DistributorId == id);
        }
    }
}
