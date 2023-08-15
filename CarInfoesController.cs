using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInformation_Assignment3.Data;
using CarInformation_Assignment3.Models;

namespace CarInformation_Assignment3
{
    public class CarInfoesController : Controller
    {
        private readonly CarInformation_Assignment3Context _context;

        public CarInfoesController(CarInformation_Assignment3Context context)
        {
            _context = context;
        }

        // GET: CarInfoes
        public async Task<IActionResult> Index()
        {
              return _context.CarInfo != null ? 
                          View(await _context.CarInfo.ToListAsync()) :
                          Problem("Entity set 'CarInformation_Assignment3Context.CarInfo'  is null.");
        }

        // GET: CarInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarInfo == null)
            {
                return NotFound();
            }

            var carInfo = await _context.CarInfo
                .FirstOrDefaultAsync(m => m.carNumber == id);
            if (carInfo == null)
            {
                return NotFound();
            }

            return View(carInfo);
        }

        // GET: CarInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("carNumber,carModel,carMade,manufacturedYear,fuelType,maxSpeed")] CarInfo carInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carInfo);
        }

        // GET: CarInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CarInfo == null)
            {
                return NotFound();
            }

            var carInfo = await _context.CarInfo.FindAsync(id);
            if (carInfo == null)
            {
                return NotFound();
            }
            return View(carInfo);
        }

        // POST: CarInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("carNumber,carModel,carMade,manufacturedYear,fuelType,maxSpeed")] CarInfo carInfo)
        {
            if (id != carInfo.carNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarInfoExists(carInfo.carNumber))
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
            return View(carInfo);
        }

        // GET: CarInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CarInfo == null)
            {
                return NotFound();
            }

            var carInfo = await _context.CarInfo
                .FirstOrDefaultAsync(m => m.carNumber == id);
            if (carInfo == null)
            {
                return NotFound();
            }

            return View(carInfo);
        }

        // POST: CarInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CarInfo == null)
            {
                return Problem("Entity set 'CarInformation_Assignment3Context.CarInfo'  is null.");
            }
            var carInfo = await _context.CarInfo.FindAsync(id);
            if (carInfo != null)
            {
                _context.CarInfo.Remove(carInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarInfoExists(int id)
        {
          return (_context.CarInfo?.Any(e => e.carNumber == id)).GetValueOrDefault();
        }
    }
}
