using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RectangleSearch.Models;
public class Rectangle
{
    [Key, JsonIgnore]
    public int Id { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}

