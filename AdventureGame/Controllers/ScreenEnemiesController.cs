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
    public class ScreenEnemiesController : Controller
    {
        private readonly AdventureGameContext _context;

        public ScreenEnemiesController(AdventureGameContext context)
        {
            _context = context;
        }

        // GET: ScreenEnemies
        public async Task<IActionResult> Index()
        {
            return View(await _context.ScreenEnemy.ToListAsync());
        }

        // GET: ScreenEnemies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenEnemy = await _context.ScreenEnemy
                .FirstOrDefaultAsync(m => m.ScreenEnemyId == id);
            if (screenEnemy == null)
            {
                return NotFound();
            }

            return View(screenEnemy);
        }

        // GET: ScreenEnemies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScreenEnemies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScreenEnemyId,ScreenId,EnemyId,Action")] ScreenEnemy screenEnemy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screenEnemy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screenEnemy);
        }

        // GET: ScreenEnemies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenEnemy = await _context.ScreenEnemy.FindAsync(id);
            if (screenEnemy == null)
            {
                return NotFound();
            }
            return View(screenEnemy);
        }

        // POST: ScreenEnemies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScreenEnemyId,ScreenId,EnemyId,Action")] ScreenEnemy screenEnemy)
        {
            if (id != screenEnemy.ScreenEnemyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(screenEnemy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScreenEnemyExists(screenEnemy.ScreenEnemyId))
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
            return View(screenEnemy);
        }

        // GET: ScreenEnemies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenEnemy = await _context.ScreenEnemy
                .FirstOrDefaultAsync(m => m.ScreenEnemyId == id);
            if (screenEnemy == null)
            {
                return NotFound();
            }

            return View(screenEnemy);
        }

        // POST: ScreenEnemies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var screenEnemy = await _context.ScreenEnemy.FindAsync(id);
            _context.ScreenEnemy.Remove(screenEnemy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScreenEnemyExists(int id)
        {
            return _context.ScreenEnemy.Any(e => e.ScreenEnemyId == id);
        }
    }
}
