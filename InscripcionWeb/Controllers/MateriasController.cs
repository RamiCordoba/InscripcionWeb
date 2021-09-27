using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InscripcionWeb.Data;
using InscripcionWeb.Models;

namespace InscripcionWeb.Controllers
{
    public class MateriasController : Controller
    {
        private readonly InscripcionWebContext _context;

        public MateriasController(InscripcionWebContext context)
        {
            _context = context;
        }
        #region Materias
        // GET: Materias
        public async Task<IActionResult> Index()
        {
            var inscripcionWebContext = _context.Materias.Include(m => m.AñoCursado);
            return View(await inscripcionWebContext.ToListAsync());
        }
        public async Task<IActionResult> IndexEliminadas()
        {
            return View(await _context.Materias.IgnoreQueryFilters().Where(c => c.Eliminado == true).ToListAsync());
        }
        #endregion
        #region Detalles
        // GET: Materias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materia = await _context.Materias
                .Include(m => m.AñoCursado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materia == null)
            {
                return NotFound();
            }

            return View(materia);
        }
        #endregion
        #region Crear
        // GET: Materias/Create
        public IActionResult Create()
        {
            //ViewData["AñoCursadoId"] = new SelectList(_context.Set<AñoCursado>(), "Id", "Nombre");
            //return View();
            _context.AñoCursados.Include(m => m.Carrera);
            ViewData["AñoCursadoId"] = new SelectList(from años in _context.AñoCursados.Include(c => c.Carrera).ToList() select new {Id=años.Id, Nombre = años.Nombre+" - "+años.Carrera.Nombre }, "Id", "Nombre");             
            return View();
        }

        // POST: Materias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,AñoCursadoId")] Materia materia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["AñoCursadoId"] = new SelectList(_context.Set<AñoCursado>(), "Id", "Nombre", materia.AñoCursadoId);
            ViewData["AñoCursadoId"] = new SelectList(from años in _context.AñoCursados.Include(c => c.Carrera).ToList() select new { Id = años.Id, Nombre = años.Nombre + " - " + años.Carrera.Nombre }, "Id", "Nombre", materia.AñoCursadoId);
            return View(materia);
        }
        #endregion
        #region Editar
        // GET: Materias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materia = await _context.Materias.FindAsync(id);
            if (materia == null)
            {
                return NotFound();
            }
            //ViewData["AñoCursadoId"] = new SelectList(_context.Set<AñoCursado>(), "Id", "Nombre", materia.AñoCursadoId);
            ViewData["AñoCursadoId"] = new SelectList(from años in _context.AñoCursados.Include(c => c.Carrera).ToList() select new { Id = años.Id, Nombre = años.Nombre + " - " + años.Carrera.Nombre }, "Id", "Nombre", materia.AñoCursadoId);
            return View(materia);
        }

        // POST: Materias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,AñoCursadoId")] Materia materia)
        {
            if (id != materia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MateriaExists(materia.Id))
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
            ViewData["AñoCursadoId"] = new SelectList(_context.Set<AñoCursado>(), "Id", "Nombre", materia.AñoCursadoId);
            return View(materia);
        }
        #endregion
        #region Eliminar
        // GET: Materias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materia = await _context.Materias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materia == null)
            {
                return NotFound();
            }

            return View(materia);
        }

        // POST: Materias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            //agregamos esta linea que pone el campo eliminado en verdadero
            materia.Eliminado = true;
            //_context.Materias.Remove(materia);
            _context.Update(materia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
        #region Restaurar
        // GET: Materias/Restaurar/5
        public async Task<IActionResult> Restaurar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materia = await _context.Materias.IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materia == null)
            {
                return NotFound();
            }

            return View(materia);
        }

        // POST: Materias/Restaurar/5
        [HttpPost, ActionName("Restaurar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RestauracionConfirmada(int id)
        {
            var materia = await _context.Materias.IgnoreQueryFilters().
                FirstOrDefaultAsync(m => m.Id == id);
            //agregamos esta linea que pone el campo eliminado en verdadero
            materia.Eliminado = false;
            //_context.Materias.Remove(materia);
            _context.Update(materia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
        #region Eliminación Definitiva
        // GET: Materias/EliminacionDefinitiva/5
        public async Task<IActionResult> EliminacionDefinitiva(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materia = await _context.Materias.IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materia == null)
            {
                return NotFound();
            }

            return View(materia);
        }

        // POST: Materias/EliminacionDefinitiva/5
        [HttpPost, ActionName("EliminacionDefinitiva")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminacionDefinitiva(int id)
        {
            var materia = await _context.Materias.IgnoreQueryFilters().
                FirstOrDefaultAsync(m => m.Id == id);
            _context.Materias.Remove(materia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexEliminadas));
        }
        #endregion
        private bool MateriaExists(int id)
        {
            return _context.Materias.Any(e => e.Id == id);
        }
    }
}
