using System;
public abstract class Shape
{
    public abstract double CalculateArea();
    public Shape()
    {
        Console.WriteLine("Shape constructor called");
    }
}
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
        Console.WriteLine("Area from Rextangle: " + CalculateArea());
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
public class circle : Shape
{
    public double Radius { get; set; }
    public circle(double radius)
    {
        Radius = radius;
        Console.WriteLine("Area from Circle: " + CalculateArea());
    }
    public override double CalculateArea()
    {
        return Math.PI* Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        Shape rect = new Rectangle(4, 6);
        rect.CalculateArea();
        Shape cir = new circle(2);
        cir.CalculateArea();
    }
}
