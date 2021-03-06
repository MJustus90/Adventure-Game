﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdventureGame.Data;
using AdventureGame.Models;

namespace AdventureGame.Controllers
{
    public class Game2Controller : Controller
    {
        private readonly AdventureGameContext _context;

        public Game2Controller(AdventureGameContext context)
        {
            _context = context;
        }

        // GET: Game2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Screen.ToListAsync());
        }

        // GET: Game2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screen = await _context.Screen
                .FirstOrDefaultAsync(m => m.ScreenId == id);
            if (screen == null)
            {
                return NotFound();
            }

            return View(screen);
        }

        // GET: Game2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Game2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScreenId,Name,Description")] Screen screen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screen);
        }

        // GET: Game2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screen = await _context.Screen.FindAsync(id);
            if (screen == null)
            {
                return NotFound();
            }
            return View(screen);
        }

        // POST: Game2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScreenId,Name,Description")] Screen screen)
        {
            if (id != screen.ScreenId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(screen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScreenExists(screen.ScreenId))
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
            return View(screen);
        }

        // GET: Game2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screen = await _context.Screen
                .FirstOrDefaultAsync(m => m.ScreenId == id);
            if (screen == null)
            {
                return NotFound();
            }

            return View(screen);
        }

        // POST: Game2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var screen = await _context.Screen.FindAsync(id);
            _context.Screen.Remove(screen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScreenExists(int id)
        {
            return _context.Screen.Any(e => e.ScreenId == id);
        }
    }
}
