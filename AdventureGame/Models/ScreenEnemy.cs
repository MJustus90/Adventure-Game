using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureGame.Models
{
    public class ScreenEnemy
    {
        public int ScreenEnemyId { get; set; }
        public int ScreenId { get; set; }
        public int EnemyId { get; set; }
        public string Action { get; set; }
    }
}
