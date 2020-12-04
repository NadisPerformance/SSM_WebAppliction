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
    public class _JobTitleController : Controller
    {
        private readonly AppDbContext _context;

        public _JobTitleController(AppDbContext context)
        {
            _context = context;
        }

        // GET: _JobTitle
        public async Task<IActionResult> List()
        {
            return View(await _context.JobTitles.ToListAsync());
        }

        // GET: _JobTitle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitles
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (jobTitle == null)
            {
                return NotFound();
            }

            return View(jobTitle);
        }

        // GET: _JobTitle/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: _JobTitle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobId,JobName,ShortDescription,AddDate,Status")] JobTitle jobTitle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(jobTitle);
        }

        // GET: _JobTitle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitles.FindAsync(id);
            if (jobTitle == null)
            {
                return NotFound();
            }
            return View(jobTitle);
        }

        // POST: _JobTitle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobId,JobName,ShortDescription,AddDate,Status")] JobTitle jobTitle)
        {
            if (id != jobTitle.JobId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobTitleExists(jobTitle.JobId))
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
            return View(jobTitle);
        }

        // GET: _JobTitle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitles
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (jobTitle == null)
            {
                return NotFound();
            }

            return View(jobTitle);
        }

        // POST: _JobTitle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobTitle = await _context.JobTitles.FindAsync(id);
            _context.JobTitles.Remove(jobTitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        private bool JobTitleExists(int id)
        {
            return _context.JobTitles.Any(e => e.JobId == id);
        }
    }
}
