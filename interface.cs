using System;
public interface IShape
{
    double CalculateArea();  
    void Display();         
}
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    public void Display()
    {
        Console.WriteLine($"This is a Circle");
    }
}
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double CalculateArea()
    {
        return Width * Height;
    }
    public void Display()
    {
        Console.WriteLine($"This is a Rectangle");
    }
}
class Program
{
    static void Main()
    {
        IShape circle = new Circle(5);
        circle.Display();
        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        IShape rectangle = new Rectangle(4, 6);
        rectangle.Display();
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
    }
}
