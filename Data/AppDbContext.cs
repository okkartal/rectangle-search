using Microsoft.EntityFrameworkCore;
using RectangleSearch.Models;

namespace RectangleSearch.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Rectangle>? Rectangles { get; set; }
     

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rectangle>().HasKey(x => x.Id);

        for (int i = 1; i <= 200; i++)
        {
            
            modelBuilder.Entity<Rectangle>().HasData(
            
                new Rectangle { Id = i, Width = i * 2, Height = i * 2, X = i * 3, Y = i * 4 }
            );
        }
    }
}

