using System;
using System.Threading;
using System.Threading.Tasks;
class Program
{
    static void LogMessage(string name)
    {
        Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] {name} is running.");
        Thread.Sleep(500); 
    }
    static void Main()
    {
        Console.WriteLine("=== Demonstrating Threads ===");
        Thread[] threads = new Thread[5];

        for (int i = 0; i < 5; i++)
        {
            int id = i + 1; 
            threads[i] = new Thread(() => LogMessage($"Thread {id}"));
            threads[i].Start();
        }
        foreach (Thread t in threads)
        {
            t.Join();
        }
        Console.WriteLine("\n=== Demonstrating Tasks (TPL) ===");
        Task[] tasks = new Task[5];

        for (int i = 0; i < 5; i++)
        {
            int id = i + 1; 
            tasks[i] = Task.Run(() => LogMessage($"Task {id}"));
        }
        Task.WaitAll(tasks);

        Console.WriteLine("\nAll threads and tasks completed.");
    }
}
