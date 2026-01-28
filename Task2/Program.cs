using System.Drawing;
using Task2;

Reactangle reactangle = new();
reactangle.Color = "red";
reactangle.Width = 10;
reactangle.Height = 20;
System.Console.WriteLine(reactangle.Area());
System.Console.WriteLine(reactangle.Perimeter());
System.Console.WriteLine(reactangle.ToString());
System.Console.WriteLine("=========================================================");
Circle circle = new();
circle.Color = "red";
circle.Radiuse = 10;
System.Console.WriteLine(circle.Area());
System.Console.WriteLine(circle.Perimeter());
System.Console.WriteLine(circle.ToString());
