using System;
using System.Diagnostics;
using System.Threading.Tasks;
class Program
{
    static async Task WashClothesAsync()
    {
        Console.WriteLine("Washing clothes started...");
        await Task.Delay(3000); // 3 seconds delay
        Console.WriteLine("Washing clothes completed!");
    }
    static async Task CleanHouseAsync()
    {
        Console.WriteLine("Cleaning house started...");
        await Task.Delay(2000); // 2 seconds delay
        Console.WriteLine("Cleaning house completed!");
    }
    static async Task CookFoodAsync()
    {
        Console.WriteLine("Cooking food started...");
        await Task.Delay(5000); // 5 seconds delay
        Console.WriteLine("Cooking food completed!");
    }
    static async Task Main(string[] args)
    {
        Console.WriteLine("Daily chores started...");
        Stopwatch stopwatch = Stopwatch.StartNew();
        Task task1 = WashClothesAsync();
        Task task2 = CleanHouseAsync();
        Task task3 = CookFoodAsync();
        await Task.WhenAll(task1, task2, task3);
        stopwatch.Stop();
        Console.WriteLine($"All chores completed! Total time: {stopwatch.Elapsed.TotalSeconds} seconds.");
    }
}
