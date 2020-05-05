using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdventureGame.Models;

namespace AdventureGame.Data
{
    
        public class AdventureGameContext : DbContext
        {
            public AdventureGameContext(DbContextOptions<AdventureGameContext> options)
                : base(options)
            {
            }

            public DbSet<Item> Item { get; set; }
            public DbSet<ItemType> ItemType { get; set; }
        }
    
}
