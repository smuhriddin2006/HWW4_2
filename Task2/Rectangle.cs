using System.Drawing;

namespace Task2;

public class Reactangle : Shape
{   
    public double Width {get; set;}
    public double Height {get; set;}
    public override double Area()
    {
        return Width * Height;
    }
    public override double Perimeter()
    {
        return 2 + (Width + Height);
    }
    public override string ToString()
    {
        return $"The rectangle {Color}";
    }


}
