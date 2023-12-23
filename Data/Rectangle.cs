using System.ComponentModel.DataAnnotations;

namespace RectangleSearch.Data;
public class Rectangle
{
    [Key]
    public int Id { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}

