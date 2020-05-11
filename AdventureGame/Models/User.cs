using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureGame.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        //public int ScreenId { get; set; }
        //public Screen screen { get; set; }

        public int Level { get; set; }
        public int Exp { get; set; }
        public int HP { get; set; }
    }
}
