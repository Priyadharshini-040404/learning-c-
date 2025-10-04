using System;
class AlarmClock
{
    public delegate void RingEventHandler(object sender, EventArgs e);
    public event RingEventHandler Ring;
    public void StartAlarm()
    {
        Console.WriteLine("Alarm set... waiting to ring...");
        System.Threading.Thread.Sleep(3000); 
        OnRing();
    }
    protected virtual void OnRing()
    {
        if (Ring != null) 
            Ring(this, EventArgs.Empty);
    }
}
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void WakeUp(object sender, EventArgs e)
    {
        Console.WriteLine($"{Name} is waking up because alarm rang!");
    }
}
class Program
{
    static void Main()
    {
        AlarmClock alarm = new AlarmClock();
        Person alice = new Person("Alice");
        Person bob = new Person("Bob");
        alarm.Ring += alice.WakeUp;
        alarm.Ring += bob.WakeUp;
        alarm.StartAlarm();
    }
}
