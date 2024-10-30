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
    public class VSuquilandasController : Controller
    {
        private readonly SuquilandaVictor_PruebaProgreso1Context _context;

        public VSuquilandasController(SuquilandaVictor_PruebaProgreso1Context context)
        {
            _context = context;
        }

        // GET: VSuquilandas
        public async Task<IActionResult> Index()
        {
            return View(await _context.VSuquilanda.ToListAsync());
        }

        // GET: VSuquilandas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vSuquilanda = await _context.VSuquilanda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vSuquilanda == null)
            {
                return NotFound();
            }

            return View(vSuquilanda);
        }

        // GET: VSuquilandas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VSuquilandas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Edad,Fondos,Correo,ComproCelular,FechaNacimiento,TotalCelulares")] VSuquilanda vSuquilanda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vSuquilanda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vSuquilanda);
        }

        // GET: VSuquilandas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vSuquilanda = await _context.VSuquilanda.FindAsync(id);
            if (vSuquilanda == null)
            {
                return NotFound();
            }
            return View(vSuquilanda);
        }

        // POST: VSuquilandas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Edad,Fondos,Correo,ComproCelular,FechaNacimiento,TotalCelulares")] VSuquilanda vSuquilanda)
        {
            if (id != vSuquilanda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vSuquilanda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VSuquilandaExists(vSuquilanda.Id))
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
            return View(vSuquilanda);
        }

        // GET: VSuquilandas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vSuquilanda = await _context.VSuquilanda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vSuquilanda == null)
            {
                return NotFound();
            }

            return View(vSuquilanda);
        }

        // POST: VSuquilandas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vSuquilanda = await _context.VSuquilanda.FindAsync(id);
            if (vSuquilanda != null)
            {
                _context.VSuquilanda.Remove(vSuquilanda);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VSuquilandaExists(int id)
        {
            return _context.VSuquilanda.Any(e => e.Id == id);
        }
    }
}
