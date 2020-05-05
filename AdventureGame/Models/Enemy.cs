using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureGame.Models
{
    public class Enemy
    {
        public int EnemyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public int Multiplier { get; set; }
        public int Die { get; set; }
        public int Modifier { get; set; }
        public int Exp { get; set; }
    }
}
