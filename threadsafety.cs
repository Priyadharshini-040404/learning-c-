using System;

public sealed class Singleton
{
    private static Singleton _instance;
    private Singleton()
    {
        Console.WriteLine("Singleton instance created.");
    }
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Singleton s1 = Singleton.GetInstance();
        s1.ShowMessage("Hello from s1");
        Singleton s2 = Singleton.GetInstance();
        s2.ShowMessage("Hello from s2");
        Console.WriteLine(object.ReferenceEquals(s1, s2)); // True
    }
}
