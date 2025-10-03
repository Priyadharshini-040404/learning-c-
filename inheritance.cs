using System;
public class vehicle
{
    public string brand {  get; set; }
    public int speed { get; set; }
    public void start()
    {
        Console.WriteLine($"{brand} is starting at {speed} km/h.");
    }
    public void stop()
    {
        Console.WriteLine($"{brand} has stopped");
    }
}
public class car : vehicle
{
    public int seating { get; set; }
    public void horn()
    {
        Console.WriteLine($"{brand} horn is beep beep");
    }
}
public class bike : vehicle
{
    public int millage { get; set; }
    public void colour()
    {
        Console.WriteLine($"{brand} colour is red");
    }
}
class program
{
    static void Main ( string[] args )
    {
        car car1 = new car();
        car1.brand = "TOYATO";
        car1.speed = 70;
        car1.start();
        car1.horn();
        car1.stop();

        bike bike1=new bike();
        bike1.brand = "HONDA";
        bike1.speed = 80;
        bike1.start();
        bike1.colour();
        bike1.stop();
    }
}