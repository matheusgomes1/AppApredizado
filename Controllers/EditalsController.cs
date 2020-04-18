using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApredizadoApp.Data;
using ApredizadoApp.Models;

namespace ApredizadoApp.Controllers
{
    public class EditalsController : Controller
    {
        private readonly AppAprdContext _context;

        public EditalsController(AppAprdContext context)
        {
            _context = context;
        }

        // GET: Editals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Edital.ToListAsync());
        }

        // GET: Editals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edital = await _context.Edital
                .FirstOrDefaultAsync(m => m.ID == id);
            if (edital == null)
            {
                return NotFound();
            }

            return View(edital);
        }

        // GET: Editals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Editals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Numero,Ano,Vigencia,DataPublicacao,DataValidade,Objeto,Status,NumeroEdital,EntidadeId")] Edital edital)
        {
            if (ModelState.IsValid)
            {
                _context.Add(edital);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(edital);
        }

        // GET: Editals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edital = await _context.Edital.FindAsync(id);
            if (edital == null)
            {
                return NotFound();
            }
            return View(edital);
        }

        // POST: Editals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Numero,Ano,Vigencia,DataPublicacao,DataValidade,Objeto,Status,NumeroEdital,EntidadeId")] Edital edital)
        {
            if (id != edital.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(edital);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditalExists(edital.ID))
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
            return View(edital);
        }

        // GET: Editals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edital = await _context.Edital
                .FirstOrDefaultAsync(m => m.ID == id);
            if (edital == null)
            {
                return NotFound();
            }

            return View(edital);
        }

        // POST: Editals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var edital = await _context.Edital.FindAsync(id);
            _context.Edital.Remove(edital);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditalExists(int id)
        {
            return _context.Edital.Any(e => e.ID == id);
        }
    }
}
