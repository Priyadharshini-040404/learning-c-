using System;
using System.Threading;
using System.Threading.Tasks;
public sealed class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();
    private Logger()
    {
        Console.WriteLine("Logger instance created.");
    }
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null) 
                {
                    _instance = new Logger();
                }
            }
        }
        return _instance;
    }
    public void Log(string message)
    {
        Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] {message}");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Starting 5 Threads ===");
        for (int i = 1; i <= 5; i++)
        {
            int id = i; 
            Thread t = new Thread(() =>
            {
                Logger logger = Logger.GetInstance();
                logger.Log($"Thread {id} logging.");
            });
            t.Start();
        }
        Thread.Sleep(1000);
        Console.WriteLine("\n=== Starting 5 Tasks ===");
        Task[] tasks = new Task[5];
        for (int i = 1; i <= 5; i++)
        {
            int id = i; 
            tasks[i - 1] = Task.Run(() =>
            {
                Logger logger = Logger.GetInstance();
                logger.Log($"Task {id} logging.");
            });
        }
        Task.WaitAll(tasks);
        Console.WriteLine("\nAll threads and tasks have finished logging.");
    }
}
