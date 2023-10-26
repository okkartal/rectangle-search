using RectangleSearch.Data;
using RectangleSearch.Models;

namespace RectangleSearch.Services;
public class RectangleService : IRectangleService
{
    private readonly AppDbContext _context;
    public RectangleService(AppDbContext context)
    {
        _context = context;
    }

    public List<Rectangle> FindMatchingRectangles(int[] coordinates)
    {
        var matchingRectangles = new List<Rectangle>();

        for (int i = 0; i < coordinates.Length; i++)
        {
            var x = coordinates[0];
            var y = coordinates[1];

            if (_context.Rectangles != null)
            {
                var rectangles = _context.Rectangles.Where(r =>
                    x >= r.X && x <= (r.X + r.Width) &&
                    y >= r.Y && y <= (r.Y + r.Height));

                if (rectangles.Any())
                {
                    matchingRectangles.AddRange(rectangles);
                }
            }
        }

        return matchingRectangles;
    }
}

