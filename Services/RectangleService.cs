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

    public IEnumerable<RectangleDto> FindMatchingRectangles(int x, int y)
    {

        if (_context.Rectangles == null || !_context.Rectangles.Any())
            return Enumerable.Empty<RectangleDto>();

        return _context.Rectangles.Where(r =>
            x >= r.X && x <= (r.X + r.Width) &&
            y >= r.Y && y <= (r.Y + r.Height))
            .Select(rect =>
            new RectangleDto(rect.X, rect.Y, rect.Width, rect.Height));

    }
}

