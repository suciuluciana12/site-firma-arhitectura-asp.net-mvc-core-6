using Microsoft.EntityFrameworkCore;
using siteCipri1.Models;
using System.Collections.Generic;

namespace siteCipri1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
