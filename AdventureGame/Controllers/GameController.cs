using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdventureGame.Controllers
{
    public class GameController : Controller
    {
        public IActionResult ScreenOne()
        {
            return View();
        }
        public IActionResult Chest()
        {
            return View();
        }
    }
}