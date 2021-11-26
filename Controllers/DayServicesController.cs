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
    public class DayServicesController : Controller
    {
        private readonly DBContext _context;

        public DayServicesController(DBContext context)
        {
            _context = context;
        }

        // GET: DayServices
        public async Task<IActionResult> Index()
        {
            var dBContext = _context.DayService.Include(d => d.Animal).Include(d => d.Invoice);
            return View(await dBContext.ToListAsync());
        }

        // GET: DayServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayService = await _context.DayService
                .Include(d => d.Animal)
                .Include(d => d.Invoice)
                .FirstOrDefaultAsync(m => m.ScheduleID == id);
            if (dayService == null)
            {
                return NotFound();
            }

            return View(dayService);
        }

        // GET: DayServices/Create
        public IActionResult Create()
        {
            ViewData["PetsId"] = new SelectList(_context.Animal, "PetsId", "PetsName");
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId");
            return View();
        }

        // POST: DayServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScheduleID,DateGetIn ,DateGetOut,PricePerDag,PetsId,InvoiceId")] DayService dayService)

        {
            
            if (ModelState.IsValid)
            {
                _context.Add(dayService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PetsId"] = new SelectList(_context.Animal, "PetsId", "PetsName", dayService.PetsId);
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", dayService.InvoiceId);
            return View(dayService);
        }

        // GET: DayServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayService = await _context.DayService.FindAsync(id);
            if (dayService == null)
            {
                return NotFound();
            }
            ViewData["PetsId"] = new SelectList(_context.Animal, "PetsId", "PetsName", dayService.PetsId);
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", dayService.InvoiceId);
            return View(dayService);
        }

        // POST: DayServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScheduleID,DateGetIn,DateGetOut,PricePerDag,PetsId,InvoiceId")] DayService dayService)
        {
            if (id != dayService.ScheduleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dayService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DayServiceExists(dayService.ScheduleID))
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
            ViewData["PetsId"] = new SelectList(_context.Animal, "PetsId", "PetsName", dayService.PetsId);
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", dayService.InvoiceId);
            return View(dayService);
        }

        // GET: DayServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayService = await _context.DayService
                .Include(d => d.Animal)
                .Include(d => d.Invoice)
                .FirstOrDefaultAsync(m => m.ScheduleID == id);
            if (dayService == null)
            {
                return NotFound();
            }

            return View(dayService);
        }

        // POST: DayServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dayService = await _context.DayService.FindAsync(id);
            _context.DayService.Remove(dayService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DayServiceExists(int id)
        {
            return _context.DayService.Any(e => e.ScheduleID == id);
        }
    }
}
