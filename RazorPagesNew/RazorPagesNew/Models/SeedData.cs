using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesNew.Data;
using System;
using System.Linq;

namespace RazorPagesNew.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesNewContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesNewContext>>()))
            {
                // Look for any movies.
                if (context.Team.Any())
                {
                    return;   // DB has been seeded
                }

                context.Team.AddRange(
                    new Team
                    {
                        Name = "Washington Nationals",
                        CreationDate = DateTime.Parse("1989-2-12"),
                        Sport = "Baseball",
                        Worth = 7.99M
                    },

                    new Team
                    {
                        Name = "New York Jets",
                        CreationDate = DateTime.Parse("1984-3-13"),
                        Sport = "Footba;;",
                        Worth = 8.99M
                    },

                    new Team
                    {
                        Name = "New York Nets",
                        CreationDate = DateTime.Parse("1986-2-23"),
                        Sport = "Basketball",
                        Worth = 9.99M
                    },

                    new Team
                    {
                        Name = "Houston Astros",
                        CreationDate = DateTime.Parse("1959-4-15"),
                        Sport = "Baseball",
                        Worth = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
