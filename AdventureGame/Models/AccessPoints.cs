﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureGame.Models
{
    public class AccessPoints
    {
        // May or may not need this in the database
        public int AccessPointsId { get; set; }
        public string Name { get; set; }

        public int ScreenId { get; set; }
        public Screen screen { get; set; }
    }
}
