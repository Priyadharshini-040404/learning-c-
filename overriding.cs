using System;

public class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle starting");
    }
}
public class Car : Vehicle
{
    public sealed override void Start()
    {
        Console.WriteLine("Car starting with key");
    }
}
public class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike starting with kick");
    }
}
class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Start(); 
        Bike bike = new Bike();
        bike.Start(); 
    }
}
