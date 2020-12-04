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
    public class _PumpsController : Controller
    {
        private readonly AppDbContext _context;

        public _PumpsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: _Pumps
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pumps.ToListAsync());
        }

        // GET: _Pumps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pump = await _context.Pumps
                .FirstOrDefaultAsync(m => m.PumpId == id);
            if (pump == null)
            {
                return NotFound();
            }

            return View(pump);
        }

        // GET: _Pumps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: _Pumps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PumpId,PumpName,PumpDescription,AddDate,Status")] Pump pump)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pump);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pump);
        }

        // GET: _Pumps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pump = await _context.Pumps.FindAsync(id);
            if (pump == null)
            {
                return NotFound();
            }
            return View(pump);
        }

        // POST: _Pumps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PumpId,PumpName,PumpDescription,AddDate,Status")] Pump pump)
        {
            if (id != pump.PumpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pump);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PumpExists(pump.PumpId))
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
            return View(pump);
        }

        // GET: _Pumps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pump = await _context.Pumps
                .FirstOrDefaultAsync(m => m.PumpId == id);
            if (pump == null)
            {
                return NotFound();
            }

            return View(pump);
        }

        // POST: _Pumps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pump = await _context.Pumps.FindAsync(id);
            _context.Pumps.Remove(pump);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PumpExists(int id)
        {
            return _context.Pumps.Any(e => e.PumpId == id);
        }
    }
}
