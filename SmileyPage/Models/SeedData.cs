using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmileyPage.Data;
using System;
using System.Linq;

namespace SmileyPage.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SmileyPageContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SmileyPageContext>>()))
        {
            // Look for any restaurants
            if (context.Restaurant.Any())
            {
                return; //DB has already been seeded
            }
            context.Restaurant.AddRange(
                new Restaurant
                {
                    Name = "Restaurant A",
                    Address = "Adresse A",
                    Smilies = new List<Smiley>
                    {
                        new Smiley { Type = "/pictures/smiley1.png", IssueDate = new DateTime(2025, 1, 1)},
                        new Smiley { Type = "/pictures/smiley2.png", IssueDate = new DateTime(2025, 2, 2)},
                        new Smiley { Type = "/pictures/smiley3.png", IssueDate = new DateTime(2025, 3, 3)}
                    }
                },
                new Restaurant
                {
                    Name = "Restaurant B",
                    Address = "Adresse B",
                    Smilies = new List<Smiley>
                    {
                        new Smiley { Type = "/pictures/smiley4.png", IssueDate = new DateTime(2025, 4, 4)},
                        new Smiley { Type = "/pictures/smiley1.png", IssueDate = new DateTime(2025, 5, 5)},
                        new Smiley { Type = "/pictures/smiley2.png", IssueDate = new DateTime(2025, 6, 6)}
                    }
                },
                new Restaurant
                {
                    Name = "Restaurant C",
                    Address = "Adresse C",
                    Smilies = new List<Smiley>
                    {
                        new Smiley { Type = "/pictures/smiley3.png", IssueDate = new DateTime(2025, 7, 7)},
                        new Smiley { Type = "/pictures/smiley4.png", IssueDate = new DateTime(2025, 8, 8)},
                        new Smiley { Type = "/pictures/smiley1.png", IssueDate = new DateTime(2025, 9, 9)}
                    }
                }
            );
            context.SaveChanges();
        }
    }
}
