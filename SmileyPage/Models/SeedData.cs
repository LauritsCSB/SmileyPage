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
            // Look for any restaurants, remove them and re-seed
            if (context.Restaurant.Any())
            {
                context.Restaurant.RemoveRange(context.Restaurant);
                context.SaveChanges();
            }
            context.Restaurant.AddRange(
                new Restaurant
                {
                    Name = "Restaurant A",
                    Address = "Adresse A",
                    CurrrentSmiley = "~/pictures/smiley1.png",
                    SecondSmiley = "~/pictures/smiley2.png",
                    ThirdSmiley = "~/pictures/smiley3.png"
                },
                new Restaurant
                {
                    Name = "Restaurant B",
                    Address = "Adresse B",
                    CurrrentSmiley = "~/pictures/smiley4.png",
                    SecondSmiley = "~/pictures/smiley1.png",
                    ThirdSmiley = "~/pictures/smiley2.png"
                },
                new Restaurant
                {
                    Name = "Restaurant C",
                    Address = "Adresse C",
                    CurrrentSmiley = "~/pictures/smiley3.png",
                    SecondSmiley = "~/pictures/smiley4.png",
                    ThirdSmiley = "~/pictures/smiley1.png"
                }
            );
            context.SaveChanges();
        }
    }
}
