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
    public class PersonPHD184sController : Controller
    {
        private readonly ApplicationContext _context;

        public PersonPHD184sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PersonPHD184s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonPHD184.ToListAsync());
        }

        // GET: PersonPHD184s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPHD184 = await _context.PersonPHD184
                .FirstOrDefaultAsync(m => m.Personld == id);
            if (personPHD184 == null)
            {
                return NotFound();
            }

            return View(personPHD184);
        }

        // GET: PersonPHD184s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonPHD184s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Personld,PersonName")] PersonPHD184 personPHD184)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personPHD184);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personPHD184);
        }

        // GET: PersonPHD184s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPHD184 = await _context.PersonPHD184.FindAsync(id);
            if (personPHD184 == null)
            {
                return NotFound();
            }
            return View(personPHD184);
        }

        // POST: PersonPHD184s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Personld,PersonName")] PersonPHD184 personPHD184)
        {
            if (id != personPHD184.Personld)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personPHD184);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonPHD184Exists(personPHD184.Personld))
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
            return View(personPHD184);
        }

        // GET: PersonPHD184s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPHD184 = await _context.PersonPHD184
                .FirstOrDefaultAsync(m => m.Personld == id);
            if (personPHD184 == null)
            {
                return NotFound();
            }

            return View(personPHD184);
        }

        // POST: PersonPHD184s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personPHD184 = await _context.PersonPHD184.FindAsync(id);
            _context.PersonPHD184.Remove(personPHD184);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonPHD184Exists(int id)
        {
            return _context.PersonPHD184.Any(e => e.Personld == id);
        }
    }
}
