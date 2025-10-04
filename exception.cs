using System;
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}
class Program
{
    static void ValidateAge(int age)
    {
        if (age < 0)
        {
            throw new InvalidAgeException("Age cannot be negative.");
        }
        else if (age < 18)
        {
            throw new Exception("You must be at least 18 years old.");
        }
        Console.WriteLine("Age is valid: " + age);
    }
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            ValidateAge(age);
        }
        catch (InvalidAgeException ex)   
        {
            Console.WriteLine("Custom Exception Caught: " + ex.Message);
        }
        catch (Exception ex)             
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution finished (finally block).");
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}
