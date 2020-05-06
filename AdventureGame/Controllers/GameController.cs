using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureGame.Models;
using AdventureGame.Data;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace AdventureGame.Controllers
{
    public class GameController : Controller
    {
        private readonly AdventureGameContext _context;
        public IActionResult ScreenOne()
        {
            return View();
        }
        public IActionResult Chest()
        {
            return View();
        }
        
        public async Task<IActionResult> TestScreen(int? id)
        {
            var screen = await _context.Screen.FindAsync(id);
            return View(screen);
        }
        public async Task<IActionResult> AllScreens()
        {
            return View();
        }
    }
}