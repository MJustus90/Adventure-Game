using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureGame.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks.Dataflow;

namespace AdventureGame.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AdventureGameContext(serviceProvider.GetRequiredService<DbContextOptions<AdventureGameContext>>()))
            {
                if (context.Screen.Any())
                {
                    return;
                }

                context.Screen.AddRange(
                    new Screen
                    {
                        Name = "Dead End",
                        Description = "You stand at the end of a wide road which continues to the west.The barren wilderness from whence you came lies to the east and south.To the north you see a broad field surrounded by a tall fence and accessible only through a gate.A small chest sits on the ground by the fence."
                    },
                    new Screen
                    {
                        Name = "Broad Field",
                        Description = "You stand in a broad field, freshly tilled but devoid of crops. The only exit lies south and leads to the end of a wide road."
                    },
                    new Screen
                    {
                        Name = "Main Road",
                        Description = "You stand on a wide road which continues as far as you can see to the west. The road ends a short way east.",
                    },
                    new Screen
                    {
                        Name = "Main Road2",
                        Description = "A road to the west of the Main Road filled with holes.",
                    },
                    new Screen
                    {
                        Name = "Chest",
                        Description = "You open the chest and look in.",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
