namespace Task2;

public class Circle : Shape
{
   public double Radiuse;
    public override double Area()
    {
        double s = Math.PI * Radiuse * Radiuse;
        return s;
    }
    public override double Perimeter()
    {
        double s = 2 * Math.PI * Radiuse;
        return s;
    }
    public override string ToString()
    {
        return $"The Circle {Color}";
    }


}
