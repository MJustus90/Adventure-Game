using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureGame.Models
{
    public class ScreenItem
    {
        public int ScreenItemId { get; set; }
        public int ScreensId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public string TakenDescription { get; set; }
        public string Action { get; set; }

    }
}