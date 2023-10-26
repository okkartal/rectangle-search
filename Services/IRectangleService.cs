using RectangleSearch.Models;

namespace RectangleSearch.Services;
public interface IRectangleService
{
    List<Rectangle> FindMatchingRectangles(int[] coordinates);
}

