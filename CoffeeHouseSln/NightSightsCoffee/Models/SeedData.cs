using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace NightSightsCoffee.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Single Orgin Brazil",
                    Description = "Our true dark roast - simply intense. Intentionally pushed to the brink of bittersweet, it is the essential dark roast.",
                    TastingNotes = "Tasting Notes: Dark Chocolate, Molasses, Creamy.",
                    Category = "Dark Roast",
                    Price = 16.99m
                },
                new Product
                {
                    Name = "Single Origin Ethiopia",
                    Description = "Refreshing mix of berries and citrus to liven your morning. Just the right amount of sweet. Robost and Full Bodied exactly what the doctor ordered.",
                    TastingNotes = "Tasting Notes: Fresh Blueberries, Lime Zest, Floral.",
                    Category = "Medium Roast",
                    Price = 16.99m
                },
                new Product
                {
                    Name = "Single Origin Colombia",
                    Description = "The coffee lovers roast for all occasions. This is the roast you choose for the daily grind, best brewed as a pour over or as a French Press.",
                    TastingNotes = "Tasting Notes: Rich, Sweet Cherry, Chocolate Candy Bar.",
                    Category = "Light Roast",
                    Price = 16.99m
                },
                new Product
                {
                    Name = "Single Origin Vietnam",
                    Description = "The intense bitter flavor associated with all single orgin beans from Vietnam. Notes of dried fruit and baked goods.",
                    TastingNotes = "Tasting Notes: Cinniamon Sugar, Fig, Bitter Bite.",
                    Category = "Dark Roast",
                    Price = 15.99m
                },
                new Product
                {
                    Name = "Single Origin Kona",
                    Description = "A single orgin that tastes like soaking in the rays on the beach in kona. A perfect vacation day at home when you wish you were far away at the beach.",
                    TastingNotes = "Tasting Notes: Honey, Brown Sugar, Sweet.",
                    Category = "Medium Roast",
                    Price = 19.99m
                },
                new Product
                {
                    Name = "Colombia Blend",
                    Description = "A sweet tooth's dream blend. A rich, sweet blend on a mission to convert the masses to the perfect blend of brown sugar goodness with a smooth finish.",
                    TastingNotes = "Tasting Notes: Milk Chocolate, Sugar Cookie, Creamy.",
                    Category = "Light Roast",
                    Price = 12.99m
                },
                new Product
                {
                    Name = "Ethiopia Blend",
                    Description = "A Dazzling cup full of tropical fruit flavors. This is the roast flavor mainly comes from the laayyoo indigenious tree in ethipoia which grows thorughout the area in Uraga.",
                    TastingNotes = "Tasting Notes: Guava, Blood Orange, Sparkling.",
                    Category = "Medium Roast",
                    Price = 12.99m
                },
                new Product
                {
                    Name = "Guatemala Blend",
                    Description = "The early stages of dark and roasty, but just shy of a truly dark roast. This roast sits just shy of bittersweet and has the perfect balance of sweet and smokey flavors.",
                    TastingNotes = "Tasting Notes: Dried Cherry, Caramel, Smooth.",
                    Category = "Medium Roast",
                    Price = 12.99m
                }
                );
                context.SaveChanges();
            }
        }
    }
}
