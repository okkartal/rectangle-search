using RectangleSearch.Models;

namespace RectangleSearch.Services;
public interface IRectangleService
{
    IEnumerable<RectangleDto> FindMatchingRectangles(int x, int y);
}

