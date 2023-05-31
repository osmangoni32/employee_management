using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployInformationApplication.Models;

namespace EmployInformationApplication.Controllers
{
    public class EmployDatabaseModelsAutoCreateController : Controller
    {
        private readonly EmployDatabase _context;

        public EmployDatabaseModelsAutoCreateController(EmployDatabase context)
        {
            _context = context;
        }

        // GET: EmployDatabaseModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.EmployDatabaseModelInDatabaseAsTable.ToListAsync());
        }

        // GET: EmployDatabaseModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EmployDatabaseModelInDatabaseAsTable == null)
            {
                return NotFound();
            }

            var employDatabaseModel = await _context.EmployDatabaseModelInDatabaseAsTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employDatabaseModel == null)
            {
                return NotFound();
            }

            return View(employDatabaseModel);
        }

        // GET: EmployDatabaseModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployDatabaseModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,District,Departmaent,phonumber")] EmployDatabaseModel employDatabaseModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employDatabaseModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employDatabaseModel);
        }

        // GET: EmployDatabaseModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EmployDatabaseModelInDatabaseAsTable == null)
            {
                return NotFound();
            }

            var employDatabaseModel = await _context.EmployDatabaseModelInDatabaseAsTable.FindAsync(id);
            if (employDatabaseModel == null)
            {
                return NotFound();
            }
            return View(employDatabaseModel);
        }

        // POST: EmployDatabaseModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,District,Departmaent,phonumber")] EmployDatabaseModel employDatabaseModel)
        {
            if (id != employDatabaseModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employDatabaseModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployDatabaseModelExists(employDatabaseModel.Id))
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
            return View(employDatabaseModel);
        }

        // GET: EmployDatabaseModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EmployDatabaseModelInDatabaseAsTable == null)
            {
                return NotFound();
            }

            var employDatabaseModel = await _context.EmployDatabaseModelInDatabaseAsTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employDatabaseModel == null)
            {
                return NotFound();
            }

            return View(employDatabaseModel);
        }

        // POST: EmployDatabaseModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EmployDatabaseModelInDatabaseAsTable == null)
            {
                return Problem("Entity set 'EmployDatabase.EmployDatabaseModelInDatabase'  is null.");
            }
            var employDatabaseModel = await _context.EmployDatabaseModelInDatabaseAsTable.FindAsync(id);
            if (employDatabaseModel != null)
            {
                _context.EmployDatabaseModelInDatabaseAsTable.Remove(employDatabaseModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployDatabaseModelExists(int id)
        {
          return _context.EmployDatabaseModelInDatabaseAsTable.Any(e => e.Id == id);
        }
    }
}
