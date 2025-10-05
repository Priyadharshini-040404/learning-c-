using System;
using System.Collections.Generic;
public interface IObserver
{
    void Update();
}
public class AlarmClock
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }
    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void Ring()
    {
        Console.WriteLine(" Alarm is ringing! Notifying all observers...");
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
}
public class Buzzer : IObserver
{
    public void Update()
    {
        Console.WriteLine(" Buzzer: Making sound...");
    }
}
public class Light : IObserver
{
    public void Update()
    {
        Console.WriteLine(" Light: Flashing...");
    }
}
public class MobileApp : IObserver
{
    public void Update()
    {
        Console.WriteLine(" Mobile App: Sending notification...");
    }
}
class Program
{
    static void Main()
    {
        AlarmClock alarm = new AlarmClock();
        alarm.Attach(new Buzzer());
        alarm.Attach(new Light());
        alarm.Attach(new MobileApp());
        alarm.Ring();
    }
}
