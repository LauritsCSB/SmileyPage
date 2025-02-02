using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmileyPage.Models;

namespace SmileyPage.Data
{
    public class SmileyPageContext : DbContext
    {
        public SmileyPageContext (DbContextOptions<SmileyPageContext> options)
            : base(options)
        {
        }

        public DbSet<SmileyPage.Models.Restaurant> Restaurant { get; set; } = default!;
    }
}
