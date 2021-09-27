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
    public class AlumnosController : Controller
    {
        private readonly InscripcionWebContext _context;

        public AlumnosController(InscripcionWebContext context)
        {
            _context = context;
        }
        #region Alumnos
        // GET: Alumnos
        public async Task<IActionResult> Index(int? opcion, string txtBusqueda)
        {
            return View(await _context.Alumnos.ToListAsync());
        }
        public async Task<IActionResult> IndexInscripcion(int? opcion, string txtBusqueda)
        {
            if (opcion == 1)
            {
                ViewData["txtBusqueda"] = txtBusqueda;
                return View(await _context.Alumnos.Where(a => a.Nombre.Contains(txtBusqueda)
                || a.Apellido.Contains(txtBusqueda)).ToListAsync());
            }
            else
                return View(await _context.Alumnos.ToListAsync());
        }
        public async Task<IActionResult> IndexEliminados()
        {
            return View(await _context.Alumnos.IgnoreQueryFilters().Where
                (c => c.Eliminado == true).ToListAsync());
        }
        #endregion
        #region Detalles
        // GET: Alumnos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }
        #endregion
        #region Inscribir
        // GET: Alumnos/Inscribir/5
        public async Task<IActionResult> Inscribir(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos.Include(a => a.DetalleAlumnoCarreras).ThenInclude(d => d.Carrera).Include(a => a.DetalleAlumnoMaterias).ThenInclude(d => d.Materia).FirstOrDefaultAsync(m => m.Id == id);
            //ViewData["CarreraId"] = new SelectList(_context.Carreras.Where(c => c.Id == alumno.DetalleAlumnoCarrera.), "Id", "Nombre");

            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }
        #endregion
        #region Crear
        // GET: Alumnos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Telefono,Dni,Apellido,Nombre")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alumno);
        }
        #endregion
        #region Editar
        // GET: Alumnos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno == null)
            {
                return NotFound();
            }
            return View(alumno);
        }

        // POST: Alumnos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Telefono,Dni,Apellido,Nombre")] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnoExists(alumno.Id))
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
            return View(alumno);
        }
        #endregion
        #region Eliminar
        // GET: Alumnos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);
            //agregamos esta linea que pone el campo eliminado en verdadero
            alumno.Eliminado = true;
            //_context.Alumnos.Remove(alumno);
            _context.Update(alumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
        #region Restaurar
        // GET: Alumnos/Restaurar/5
        public async Task<IActionResult> Restaurar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos.IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // POST: Alumnos/Restaurar/5
        [HttpPost, ActionName("Restaurar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RestauracionConfirmada(int id)
        {
            var alumno = await _context.Alumnos.IgnoreQueryFilters().
                FirstOrDefaultAsync(m => m.Id == id);
            //agregamos esta linea que pone el campo eliminado en verdadero
            alumno.Eliminado = false;
            //_context.Alumnos.Remove(alumno);
            _context.Update(alumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
        #region Eliminación Definitiva
        // GET: Alumnos/EliminacionDefinitiva/5
        public async Task<IActionResult> EliminacionDefinitiva(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos.IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // POST: Alumnos/EliminacionDefinitiva/5
        [HttpPost, ActionName("EliminacionDefinitiva")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminacionDefinitiva(int id)
        {
            var alumno = await _context.Alumnos.IgnoreQueryFilters().
                FirstOrDefaultAsync(m => m.Id == id);
            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexEliminados));
        }
        #endregion
        private bool AlumnoExists(int id)
        {
            return _context.Alumnos.Any(e => e.Id == id);
        }
    }
}
