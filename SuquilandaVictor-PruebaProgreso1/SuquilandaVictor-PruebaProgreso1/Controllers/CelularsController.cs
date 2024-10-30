using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuquilandaVictor_PruebaProgreso1.Data;
using SuquilandaVictor_PruebaProgreso1.Models;

namespace SuquilandaVictor_PruebaProgreso1.Controllers
{
    public class CelularsController : Controller
    {
        private readonly SuquilandaVictor_PruebaProgreso1Context _context;

        public CelularsController(SuquilandaVictor_PruebaProgreso1Context context)
        {
            _context = context;
        }

        // GET: Celulars
        public async Task<IActionResult> Index()
        {
            var suquilandaVictor_PruebaProgreso1Context = _context.Celular.Include(c => c.VSuquilanda);
            return View(await suquilandaVictor_PruebaProgreso1Context.ToListAsync());
        }

        // GET: Celulars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular
                .Include(c => c.VSuquilanda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // GET: Celulars/Create
        public IActionResult Create()
        {
            ViewData["IdVSuquilanda"] = new SelectList(_context.VSuquilanda, "Id", "Name");
            return View();
        }

        // POST: Celulars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Modelo,Fabricando,Anio,Precio,IdVSuquilanda")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(celular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdVSuquilanda"] = new SelectList(_context.VSuquilanda, "Id", "Name", celular.IdVSuquilanda);
            return View(celular);
        }

        // GET: Celulars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular.FindAsync(id);
            if (celular == null)
            {
                return NotFound();
            }
            ViewData["IdVSuquilanda"] = new SelectList(_context.VSuquilanda, "Id", "Name", celular.IdVSuquilanda);
            return View(celular);
        }

        // POST: Celulars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Modelo,Fabricando,Anio,Precio,IdVSuquilanda")] Celular celular)
        {
            if (id != celular.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(celular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CelularExists(celular.Id))
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
            ViewData["IdVSuquilanda"] = new SelectList(_context.VSuquilanda, "Id", "Name", celular.IdVSuquilanda);
            return View(celular);
        }

        // GET: Celulars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular
                .Include(c => c.VSuquilanda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // POST: Celulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var celular = await _context.Celular.FindAsync(id);
            if (celular != null)
            {
                _context.Celular.Remove(celular);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CelularExists(int id)
        {
            return _context.Celular.Any(e => e.Id == id);
        }
    }
}
