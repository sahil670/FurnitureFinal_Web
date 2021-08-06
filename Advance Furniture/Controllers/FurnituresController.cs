﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Advance_Furniture.Data;
using Advance_Furniture.Models;

namespace Advance_Furniture.Controllers
{
    public class FurnituresController : Controller
    {
        private readonly Advance_FurnitureContext _context;

        public FurnituresController(Advance_FurnitureContext context)
        {
            _context = context;
        }

        // GET: Furnitures
        public async Task<IActionResult> Index()
        {
            return View(await _context.Furniture.ToListAsync());
        }
        public async Task<IActionResult> viewFurniture()
        {
            return View(await _context.Furniture.ToListAsync());
        }

        // GET: Furnitures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.id == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        // GET: Furnitures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Furnitures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name,Price,description")] Furniture furniture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(furniture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(furniture);
        }

        // GET: Furnitures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture.FindAsync(id);
            if (furniture == null)
            {
                return NotFound();
            }
            return View(furniture);
        }

        // POST: Furnitures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Price,description")] Furniture furniture)
        {
            if (id != furniture.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(furniture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FurnitureExists(furniture.id))
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
            return View(furniture);
        }

        // GET: Furnitures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.id == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        // POST: Furnitures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var furniture = await _context.Furniture.FindAsync(id);
            _context.Furniture.Remove(furniture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FurnitureExists(int id)
        {
            return _context.Furniture.Any(e => e.id == id);
        }
    }
}
