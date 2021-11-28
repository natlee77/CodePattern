using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOLID.Data;
using SOLID.Models;

namespace SOLID.Controllers
{
    public class ExtraServicesController : Controller
    {
        private readonly DBContext _context;

        public ExtraServicesController(DBContext context)
        {
            _context = context;
        }

        // GET: ExtraServices
        public async Task<IActionResult> Index()
        {
            var dBContext = _context.ExtraService.Include(e => e.Animal).Include(e => e.Invoice);
            return View(await dBContext.ToListAsync());
        }

        // GET: ExtraServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extraService = await _context.ExtraService
                .Include(e => e.Animal)
                .Include(e => e.Invoice)
                .FirstOrDefaultAsync(m => m.ExtraServiceId == id);
            if (extraService == null)
            {
                return NotFound();
            }

            return View(extraService);
        }

        // GET: ExtraServices/Create
        public IActionResult Create()
        {
            ViewData["PetsId"] = new SelectList(_context.Animal, "PetsId", "PetsName");
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId");
            return View();
        }

        // POST: ExtraServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExtraServiceId,Date,Done,ServiceDescription,ServicePrice,PetsId,InvoiceId")] ExtraService extraService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(extraService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PetsId"] = new SelectList(_context.Animal, "PetsId", "PetsName", extraService.PetsId);
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", extraService.InvoiceId);
            return View(extraService);
        }

        // GET: ExtraServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extraService = await _context.ExtraService.FindAsync(id);
            if (extraService == null)
            {
                return NotFound();
            }
            ViewData["PetsId"] = new SelectList(_context.Animal, "PetsId", "PetsName", extraService.PetsId);
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", extraService.InvoiceId);
            return View(extraService);
        }

        // POST: ExtraServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExtraServiceId,Date,Done,ServiceDescription,ServicePrice,PetsId,InvoiceId")] ExtraService extraService)
        {
            if (id != extraService.ExtraServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(extraService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExtraServiceExists(extraService.ExtraServiceId))
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
            ViewData["PetsId"] = new SelectList(_context.Animal, "PetsId", "PetsName", extraService.PetsId);
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", extraService.InvoiceId);
            return View(extraService);
        }

        // GET: ExtraServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extraService = await _context.ExtraService
                .Include(e => e.Animal)
                .Include(e => e.Invoice)
                .FirstOrDefaultAsync(m => m.ExtraServiceId == id);
            if (extraService == null)
            {
                return NotFound();
            }

            return View(extraService);
        }

        // POST: ExtraServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var extraService = await _context.ExtraService.FindAsync(id);
            _context.ExtraService.Remove(extraService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExtraServiceExists(int id)
        {
            return _context.ExtraService.Any(e => e.ExtraServiceId == id);
        }
    }
}
