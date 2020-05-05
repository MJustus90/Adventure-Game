using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureGame.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int ItemTypeId { get; }
    }

    public class ItemType
    {
        public int ItemTypeId { get; set; }
        public string TypeName { get; set; }
    }
}
