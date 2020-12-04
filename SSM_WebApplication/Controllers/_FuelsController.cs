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
    public class _FuelsController : Controller
    {
        private readonly AppDbContext _context;

        public _FuelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: _Fuels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fuels.ToListAsync());
        }

        // GET: _Fuels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fuel = await _context.Fuels
                .FirstOrDefaultAsync(m => m.FuelId == id);
            if (fuel == null)
            {
                return NotFound();
            }

            return View(fuel);
        }

        // GET: _Fuels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: _Fuels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuelId,FuelName,FuelPrice,ShortDescription,AddDate,Status")] Fuel fuel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fuel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fuel);
        }

        // GET: _Fuels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fuel = await _context.Fuels.FindAsync(id);
            if (fuel == null)
            {
                return NotFound();
            }
            return View(fuel);
        }

        // POST: _Fuels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuelId,FuelName,FuelPrice,ShortDescription,AddDate,Status")] Fuel fuel)
        {
            if (id != fuel.FuelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fuel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuelExists(fuel.FuelId))
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
            return View(fuel);
        }

        // GET: _Fuels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fuel = await _context.Fuels
                .FirstOrDefaultAsync(m => m.FuelId == id);
            if (fuel == null)
            {
                return NotFound();
            }

            return View(fuel);
        }

        // POST: _Fuels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fuel = await _context.Fuels.FindAsync(id);
            _context.Fuels.Remove(fuel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuelExists(int id)
        {
            return _context.Fuels.Any(e => e.FuelId == id);
        }
    }
}
