using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamHuuDuy184.Models;

namespace PhamHuuDuy184.Controllers
{
    public class PHD0184sController : Controller
    {
        private readonly ApplicationContext _context;

        public PHD0184sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PHD0184s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PHD0184.ToListAsync());
        }

        // GET: PHD0184s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pHD0184 = await _context.PHD0184
                .FirstOrDefaultAsync(m => m.PHDId == id);
            if (pHD0184 == null)
            {
                return NotFound();
            }

            return View(pHD0184);
        }

        // GET: PHD0184s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PHD0184s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PHDId,PHDName,PHDGender")] PHD0184 pHD0184)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pHD0184);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pHD0184);
        }

        // GET: PHD0184s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pHD0184 = await _context.PHD0184.FindAsync(id);
            if (pHD0184 == null)
            {
                return NotFound();
            }
            return View(pHD0184);
        }

        // POST: PHD0184s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PHDId,PHDName,PHDGender")] PHD0184 pHD0184)
        {
            if (id != pHD0184.PHDId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pHD0184);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PHD0184Exists(pHD0184.PHDId))
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
            return View(pHD0184);
        }

        // GET: PHD0184s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pHD0184 = await _context.PHD0184
                .FirstOrDefaultAsync(m => m.PHDId == id);
            if (pHD0184 == null)
            {
                return NotFound();
            }

            return View(pHD0184);
        }

        // POST: PHD0184s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pHD0184 = await _context.PHD0184.FindAsync(id);
            _context.PHD0184.Remove(pHD0184);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PHD0184Exists(int id)
        {
            return _context.PHD0184.Any(e => e.PHDId == id);
        }
    }
}
